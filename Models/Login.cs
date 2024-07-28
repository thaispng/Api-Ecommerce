using System.ComponentModel.DataAnnotations;
using System.Linq; // Adicione esta linha
using System.Text.RegularExpressions;

namespace EcommerceApi.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "O e-mail deve ter um domínio válido.")]
        public string Email { get; set; }

        [Required]
        [StringLength(32, MinimumLength = 8, ErrorMessage = "A senha deve ter entre 8 e 32 caracteres.")]
        [CustomValidation(typeof(Login), nameof(ValidatePassword))]
        public string Password { get; set; }

        public static ValidationResult ValidatePassword(string password, ValidationContext context)
        {
            if (string.IsNullOrEmpty(password))
            {
                return new ValidationResult("A senha é obrigatória.");
            }

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.IndexOfAny(new char[] { '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', '=' }) >= 0;

            if (!hasUpperCase)
            {
                return new ValidationResult("A senha deve conter pelo menos uma letra maiúscula.");
            }

            if (!hasLowerCase)
            {
                return new ValidationResult("A senha deve conter pelo menos uma letra minúscula.");
            }

            if (!hasDigit)
            {
                return new ValidationResult("A senha deve conter pelo menos um número.");
            }

            if (!hasSpecialChar)
            {
                return new ValidationResult("A senha deve conter pelo menos um caractere especial (@, #, $, etc.).");
            }

            return ValidationResult.Success;
        }
    }
}
