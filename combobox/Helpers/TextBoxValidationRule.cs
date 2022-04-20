using System.Globalization;
using System.Windows.Controls;

namespace combobox.Helpers
{
    public class TextBoxValidationRule : ValidationRule
    {
        public TextBoxValidationRule()
        {
            ValidatesOnTargetUpdated = true;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string username = (string)value;

            if (username.Length < Length)
            {
                return new ValidationResult(false, "Username must be length >= 5");
            }
            else
            {
                return new ValidationResult(true, null);
            }
        }

        public int Length { get; set; } = 5;
    }
}
