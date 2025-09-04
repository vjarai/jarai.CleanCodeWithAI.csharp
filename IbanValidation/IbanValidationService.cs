using System.Numerics;

namespace IbanValidation
{
    public class IbanValidationService
    {
        /// <summary>
        /// Validates an IBAN number according to the official IBAN validation algorithm.
        /// </summary>
        /// <param name="iban">The IBAN string to validate.</param>
        /// <returns>True if valid, false otherwise.</returns>
        public bool Validate(string iban)
        {
            if (string.IsNullOrWhiteSpace(iban))
                return false;

            iban = iban.Replace(" ", string.Empty).ToUpperInvariant();
            if (iban.Length < 15 || iban.Length > 34)
                return false;

            // Move the four initial characters to the end of the string
            string rearranged = iban.Substring(4) + iban.Substring(0, 4);

            // Replace each letter in the string with two digits
            string numericIban = "";
            foreach (char c in rearranged)
            {
                if (char.IsLetter(c))
                {
                    int value = c - 'A' + 10;
                    numericIban += value.ToString();
                }
                else if (char.IsDigit(c))
                {
                    numericIban += c;
                }
                else
                {
                    return false; // Invalid character
                }
            }

            // Perform mod-97 operation
            BigInteger ibanInt;
            if (!BigInteger.TryParse(numericIban, out ibanInt))
                return false;

            return ibanInt % 97 == 1;
        }
    }
}
