using Xunit;

namespace IbanValidationService.Tests
{
    public class IbanValidationServiceTests
    {
        private readonly IbanValidationService _service = new IbanValidationService();

        [Theory]
        [InlineData("DE89370400440532013000")] // Germany
        [InlineData("GB82WEST12345698765432")] // UK
        [InlineData("FR1420041010050500013M02606")] // France
        [InlineData("GR1601101250000000012300695")] // Greece
        public void Validate_ValidIbans_ReturnsTrue(string iban)
        {
            Assert.True(_service.Validate(iban));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("INVALIDIBAN123")]
        [InlineData("DE89370400440532013001")]
        [InlineData("GB82WEST12345698765431")]
        [InlineData("FR1420041010050500013M02607")]
        [InlineData("GR1601101250000000012300696")]
        public void Validate_InvalidIbans_ReturnsFalse(string iban)
        {
            Assert.False(_service.Validate(iban));
        }

        [Fact]
        public void Validate_IbanWithSpaces_IsValid()
        {
            string iban = "DE89 3704 0044 0532 0130 00";
            Assert.True(_service.Validate(iban));
        }

        [Fact]
        public void Validate_IbanWithLowerCase_IsValid()
        {
            string iban = "de89370400440532013000";
            Assert.True(_service.Validate(iban));
        }

        [Fact]
        public void Validate_IbanWithSpecialCharacters_ReturnsFalse()
        {
            string iban = "DE89-3704-0044-0532-0130-00";
            Assert.False(_service.Validate(iban));
        }
    }
}
