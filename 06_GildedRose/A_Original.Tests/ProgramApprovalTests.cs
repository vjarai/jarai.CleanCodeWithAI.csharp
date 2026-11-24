using System;
using System.IO;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;

namespace GildedRoseKata.Original.Tests
{
    [CollectionDefinition("Console output", DisableParallelization = true)]
    public class ConsoleOutputCollection
    {
    }

    [Collection("Console output")]
    public class ProgramApprovalTests
    {
        [Fact]
        public Task GivenProgram_WhenMainRuns_ThenConsoleOutputMatchesApprovedOutput()
        {
            var originalOutput = Console.Out;
            using var output = new StringWriter();
            try
            {
                Console.SetOut(output);
                Program.Main(Array.Empty<string>());
            }
            finally
            {
                Console.SetOut(originalOutput);
            }

            return Verifier.Verify(output.ToString());
        }
    }
}
