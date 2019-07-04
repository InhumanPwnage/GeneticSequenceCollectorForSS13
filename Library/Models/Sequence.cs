using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Library.Domain;

namespace Library.Models
{
    public class Sequence
    {
        //public Pair[] Combinations { get; set; }
        public string[] Combinations { get; set; }
        public int Id { get; set; }
        public bool IsSolved { get; set; }

        //public Sequence(int numberOfPairs)
        //{
        //    Combinations = new Pair[numberOfPairs];
        //}

        //public bool CheckPairsAreSolved()
        //{
        //    foreach (var pair in Combinations)
        //    {
        //        if (pair.Prefix.Equals(Enums.Code.X) || pair.Suffix.Equals(Enums.Code.X))
        //        {
        //            IsSolved = false;
        //            return false;
        //        }
        //    }

        //    IsSolved = true;
        //    return true;
        //}

        public bool CheckPairsAreSolved()
        {
            foreach (var combination in Combinations)
            {
                if (combination.Contains('X'))
                {
                    IsSolved = false;
                    return false;
                }
            }

            IsSolved = true;
            return true;
        }
    }
}
