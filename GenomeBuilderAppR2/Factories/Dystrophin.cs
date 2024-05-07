using GenomeBuilderAppR2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2.Factories
{
    public class Dystrophin : IGeneFactory
    { 
        public GeneModel CreateGene() => new GeneModel("Dystrophin", "DMD", "ATG... mutant sequence ...");
    }
}
