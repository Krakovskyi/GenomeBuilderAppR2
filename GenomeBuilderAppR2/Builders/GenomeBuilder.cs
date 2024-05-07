using GenomeBuilderAppR2.Factories;
using GenomeBuilderAppR2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Builders
{
    public class GenomeBuilder
    {
        private GenomeModel genome = new GenomeModel();
        public GenomeBuilder AddGene(IGeneFactory geneFactory)
        {
            genome.AddGene(geneFactory.CreateGene());
            return this;
        }

        public GenomeModel Build()
        {
            return genome;
        }



    }
}
