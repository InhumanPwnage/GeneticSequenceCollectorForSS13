using Library.Domain;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Processing
{
    public class SequenceProcessor
    {
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

            return line.Substring(pTo).Split('-');
        }

        public void UpdateSequence(int mutationId, Sequence sequenceForReference, Sequence sequenceToUpdate)
        {
            //var sequenceToUpdate = DictionaryofSequences[mutationId];

            for (int i = 0; i < sequenceToUpdate.Combinations.Length; i++)
            {
                var combinationReference = sequenceForReference.Combinations[i];
                StringBuilder combination = new StringBuilder(sequenceToUpdate.Combinations[i]);

                for (int j = 0; j < sequenceToUpdate.Combinations[i].Length; j++)
                {
                    if (combination[i].Equals('X') && !combinationReference[i].Equals('X'))
                    {
                        combination[j] = combinationReference[j];
                    }
                }

                sequenceToUpdate.Combinations[i] = combination.ToString();
            }

        }
    }
}
