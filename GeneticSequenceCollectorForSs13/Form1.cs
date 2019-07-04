using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Domain;

namespace GeneticSequenceCollectorForSs13
{
    public partial class Form1 : Form
    {
        public static Dictionary<int, Sequence> DictionaryofSequences;

        public Form1()
        {
            InitializeComponent();

            DictionaryofSequences = new Dictionary<int, Sequence>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            var lines = rchInputSequences.Lines.Where(x => !string.IsNullOrEmpty(x)).Distinct().ToArray();

            foreach (var line in lines)
            {
                Sequence currentSequence = new Sequence
                {
                    Id = ExtractMutationNumber(line)
                };

                if (!DictionaryofSequences.ContainsKey(currentSequence.Id))
                {
                    currentSequence.Combinations = ProcessLine(line);

                    DictionaryofSequences.Add(currentSequence.Id, currentSequence);
                }
                else
                {
                    //key exists, check if not solved
                    if (!DictionaryofSequences[currentSequence.Id].IsSolved)
                    {
                        currentSequence.Combinations = ProcessLine(line);

                        UpdateSequence(currentSequence.Id, currentSequence);

                        currentSequence.CheckPairsAreSolved();
                    }
                }


            }//foreach

            rchCurrentCatalogue.Text = string.Join(", ", DictionaryofSequences.Keys.ToList().OrderBy(x=>x));
        }


        public int ExtractMutationNumber(string line)
        {
            var pFrom = line.IndexOf(Constants.MutationText) + Constants.MutationText.Length;
            var pTo = line.LastIndexOf(Constants.ArrowText);

            int.TryParse(line.Substring(pFrom, pTo - pFrom), out int mutationId);

            return mutationId;
        }

        public string[] ProcessLine(string line)
        {
            var pTo = line.LastIndexOf(Constants.ArrowText);

            //var rowsAsString = line.Substring(pFrom).Replace("-", string.Empty);

            //int iterationCount = 0;

            //for (int i = 0; i < rowsAsString.Length; i += 2)
            //{
            //    Pair pairToAssign = new Pair
            //    {
            //        Prefix = (Enums.Code)Enum.Parse(typeof(Enums.Code), rowsAsString[i].ToString()),
            //        Suffix = (Enums.Code)Enum.Parse(typeof(Enums.Code), rowsAsString[i + 1].ToString())
            //    };

            //    sequenceToReturn.Combinations[iterationCount] = pairToAssign;
            //    iterationCount++;
            //}

            return line.Substring(pTo + Constants.ArrowText.Length).Split('-');
        }

        public void UpdateSequence(int mutationId, Sequence sequenceForReference)
        {
            var sequenceToUpdate = DictionaryofSequences[mutationId];

            for (int i = 0; i < sequenceToUpdate.Combinations.Length; i++)
            {
                var combinationReference = sequenceForReference.Combinations[i];
                StringBuilder combination = new StringBuilder(sequenceToUpdate.Combinations[i]);

                //check if the combinations differ, and only process if they do
                if (!combination.Equals(combinationReference))
                {
                    for (int j = 0; j < sequenceToUpdate.Combinations[i].Length; j++)
                    {
                        if (combination[j].Equals('X') && !combinationReference[j].Equals('X'))
                        {
                            combination[j] = combinationReference[j];

                            var leftToProcess = combination.ToString().Substring(j);
                            var leftToProcessReference = combinationReference.Substring(j);

                            //minor benefit, check if any changes left in string so we avoid needlessly iterating over unchanged genes
                            if (j + 1 != sequenceToUpdate.Combinations[i].Length &&
                                leftToProcess.Equals(leftToProcessReference))
                                break;
                        }
                    }
                }

                sequenceToUpdate.Combinations[i] = combination.ToString();
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            var mutationId = Convert.ToInt32(numSequence.Value);

            lblSearchInput.Text = mutationId.ToString();

            var combinations = new string[0];

            if (DictionaryofSequences.ContainsKey(mutationId))
            {
                combinations = DictionaryofSequences[mutationId].Combinations;
            }

            txtSequence.Text = string.Join("  ", combinations);
        }
    }
}
