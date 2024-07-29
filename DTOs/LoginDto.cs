using System.ComponentModel.DataAnnotations;
using System.Linq; // Adicione esta linha
using System.Text.RegularExpressions;

namespace EcommerceApi.Models
{
public class LoginDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }
}

}
