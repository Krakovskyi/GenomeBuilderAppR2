using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Models
{
    public class GeneModel
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Sequence { get; set; }
        public GeneModel(string name, string symbol, string sequence)
        {
            Name = name;
            Symbol = symbol;
            Sequence = sequence;
        }

        public void ModifySequence(string newSequence)
        {
            Sequence = newSequence; 
        } 

    }
}
