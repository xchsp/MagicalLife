using Microsoft.VisualStudio.TestTools.UnitTesting;
using MLAPI.Genetic;
using MLAPI.Genetic.Algorithms;
using MLAPI.Genetic.Crossovers;
using MLAPI.Genetic.Reinsertions;
using MLAPI.Genetic.Selections;
using MLAPI.Genetic.Terminations;
using System;
using System.Collections.Generic;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MLAPITest.Genetic.Algorithms
{
    public class GenericGeneticAlgorithmTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void Start_StateUnderTest_ExpectedBehavior(IFitness fitness, ICrossover crossover, ISelection selection, ITermination termination,
            IMutation mutation, IReinsertion reinsertion, int populationSize,
            Chromosome chromosome, IGeneFactory geneFactory)
        {
            // Arrange
            GenericGeneticAlgorithm algorithm =
                new GenericGeneticAlgorithm(fitness, crossover, selection, termination, mutation, reinsertion, populationSize,
                    chromosome, geneFactory);

            // Act
            algorithm.Start();

            // Assert
            Assert.IsNotNull(fitness);
            Assert.IsNotNull(crossover);
            Assert.IsNotNull(selection);
            Assert.IsNotNull(mutation);
            Assert.IsNotNull(reinsertion);
            Assert.IsNotNull(chromosome);
            Assert.IsNotNull(geneFactory);
            Assert.IsNotNull(termination);
            Assert.IsNotNull(algorithm);

            Assert.IsNotNull(algorithm.BestChromosome);
            GeneticTestUtil.ValidateChromosomes(new List<Chromosome> { algorithm.BestChromosome });
        }

        public static IEnumerable<object[]> GetData
        {
            get
            {
                IGeneFactory factory = new TestGeneFactory();

                yield return new object[] {new TestFitness(), new KPointCrossover(1, 10), new PercentSelection(.1F), new GenerationCountTermination(10), new TestMutation(),
                    new ReplaceThenGenerate(factory), 100, new Chromosome(factory.GenerateGenes(10)), factory };

                yield return new object[] { new TestFitness(), new KPointCrossover(2, 10), new PercentSelection(.2F), new GenerationCountTermination(10), new TestMutation(),
                    new ReplaceThenGenerate(factory), 50, new Chromosome(factory.GenerateGenes(10)), factory};

                yield return new object[] { new TestFitness(), new KPointCrossover(3, 10), new PercentSelection(.2F), new GenerationCountTermination(10), new TestMutation(),
                    new ReplaceThenGenerate(factory), 200, new Chromosome(factory.GenerateGenes(10)), factory };
            }
        }
    }
}