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

            // Calculate mod-97 incrementally to avoid very large integer parsing.
            int remainder = 0;

            foreach (char c in rearranged)
            {
                if (char.IsLetter(c))
                {
                    int value = c - 'A' + 10;
                    remainder = AppendNumberAndMod97(remainder, value);
                }
                else if (char.IsDigit(c))
                {
                    remainder = (remainder * 10 + (c - '0')) % 97;
                }
                else
                {
                    return false; // Invalid character
                }
            }

            return remainder == 1;
        }

        private static int AppendNumberAndMod97(int currentRemainder, int value)
        {
            if (value >= 10)
            {
                currentRemainder = (currentRemainder * 10 + (value / 10)) % 97;
                currentRemainder = (currentRemainder * 10 + (value % 10)) % 97;
                return currentRemainder;
            }

            return (currentRemainder * 10 + value) % 97;
        }
    }
}
