using GenomeBuilderAppR2.Models;
using GenomeBuilderAppR2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenomeBuilderAppR2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = GenomeBuilderService.Instance;
            GenomeModel genome = service.BuildGenome();
            foreach (var geneOfList in genome.Genes)
            {
                Console.WriteLine($"Gene: {geneOfList.Name}, Symbol: {geneOfList.Symbol}, Sequence: {geneOfList.Sequence}");
            }
            Console.WriteLine("Press any key to exit..."); 
            //----
            //var gene = new GeneModel("SickleCell", "HBB", "ATG...");
            //var therapyService = new GeneTherapyService();
            //therapyService.ModifyGene(gene, "ATG... новая последовательность ...");
            //Console.WriteLine($"Modified Gene: {gene.Name}, Sequence: {gene.Sequence}");
            //----

            var gene = new GeneModel("Dystrophin", "DMD", "ATG... mutant sequence ...");
            var therapyService = new GeneTherapyService();
            string targetSequence = "mutant sequence";
            string healthySequence = "correct sequence";
            therapyService.CorrectMutation(gene, targetSequence, healthySequence);
            Console.WriteLine($"Modified Gene: {gene.Name}, Sequence: {gene.Sequence}");
            Console.ReadKey();
        }
    }
}
