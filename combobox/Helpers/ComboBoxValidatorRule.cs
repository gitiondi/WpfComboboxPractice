using System.Globalization;
using System.Windows.Controls;

namespace combobox.Helpers
{
    public class ComboBoxValidatorRule : ValidationRule
    {
        public ComboBoxValidatorRule()
        {
            ValidatesOnTargetUpdated = true;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if ((int)value >= 2)
            {
                return new ValidationResult(false, "Always false");
            }
            return new ValidationResult(true, "Cool");
        }
    }
}
