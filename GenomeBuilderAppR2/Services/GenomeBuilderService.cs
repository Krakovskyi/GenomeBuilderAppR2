using GenomeBuilderAppR2.Builders;
using GenomeBuilderAppR2.Factories;
using GenomeBuilderAppR2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Services
{
    public class GenomeBuilderService
    {
        public static GenomeBuilderService instance;
        public static readonly object padlock = new object();
        public static GenomeBuilderService Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new GenomeBuilderService();
                    }
                    return instance;
                }
            }
        }


        public GenomeModel BuildGenome()
        {
            var builder = new GenomeBuilder();
            builder.AddGene(new HemoglobinGeneFactory());
            builder.AddGene(new InsulinGeneFactory());
            builder.AddGene(new Collagen());
            builder.AddGene(new Keratin());
            builder.AddGene(new Myoglobin()); 
            builder.AddGene(new Dystrophin());
            return builder.Build();
        }
    }

}