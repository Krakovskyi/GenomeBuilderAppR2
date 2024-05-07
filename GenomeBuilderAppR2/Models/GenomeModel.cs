using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Models
{
    public class GenomeModel
    {
        public List<GeneModel> Genes { get; set; } = new List<GeneModel>();
        public void AddGene(GeneModel gene)
        {
            Genes.Add(gene);        
        }
    }
}
