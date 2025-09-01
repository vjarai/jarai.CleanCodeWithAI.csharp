using Xunit;
using OpenClosed.Original;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed.Original.Tests
{
    public class AlexaTests
    {
        [Theory]
        [InlineData("Radio", "Ich spiele Radio.")]
        [InlineData("Bitte spiele das Radio", "Ich spiele Radio.")]
        [InlineData("Licht", "Ich schalte das Licht ein.")]
        [InlineData("Kannst du das Licht einschalten?", "Ich schalte das Licht ein.")]
        [InlineData("Wetter", "Das Wetter ist sonnig.")]
        [InlineData("Wie ist das Wetter heute?", "Das Wetter ist sonnig.")]
        [InlineData("Unbekannter Befehl", "Entschuldigung, 'unbekannter befehl' habe ich leider nicht verstanden (Fehlt ein Skill?).")]
        public void HandleRequest_PrintsExpectedOutput(string request, string expectedOutput)
        {
            // Arrange
            var alexa = new Alexa();
            using var sw = new StringWriter();
            Console.SetOut(sw);

            // Act
            alexa.HandleRequest(request);

            // Assert
            var output = sw.ToString().Trim();
            Assert.Equal(expectedOutput, output);
        }
    }
}