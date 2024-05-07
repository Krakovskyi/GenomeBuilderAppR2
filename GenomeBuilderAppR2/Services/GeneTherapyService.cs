using GenomeBuilderAppR2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Services
{
    public class GeneTherapyService
    {
        //public void ModifyGene(GeneModel gene, string newSequence)
        //{ 
        //    gene.ModifySequence(newSequence); 
        //}

        public void CorrectMutation(GeneModel gene, string targetSequence, string healthySequence)
        {
            if (gene.Sequence.Contains(targetSequence))
            { 
                gene.Sequence = gene.Sequence.Replace(targetSequence, healthySequence);
            
            }
        }
    }
}
