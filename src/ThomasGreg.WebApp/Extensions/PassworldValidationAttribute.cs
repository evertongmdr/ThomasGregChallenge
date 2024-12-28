using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ThomasGreg.WebApp.Extensions
{
    public class PasswordValidationAttribute : ValidationAttribute
    {
        private const int MinimumLength = 8;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var password = value as string;

            if (!IsValidPassword(password))
            {
                return new ValidationResult("A senha deve ter pelo menos 8 caracteres, uma letra " +
                    "maiúscula, uma letra minúscula, um número e um caractere especial.");
            }

            return ValidationResult.Success;
        }

        private bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return false;

            if (password.Length < 8) return false;

            if (!Regex.IsMatch(password, "[A-Z]")) return false;

            if (!Regex.IsMatch(password, "[a-z]")) return false;

            if (!Regex.IsMatch(password, "[0-9]")) return false;

            if (!Regex.IsMatch(password, @"[\W_]")) return false;

            return true;
        }
    }
}
