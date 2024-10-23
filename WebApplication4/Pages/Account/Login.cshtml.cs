using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginCredential Credential { get; set; } = new LoginCredential();

        public void OnGet()
        {
        }

        public void OnPost()
        {

        }

        public class LoginCredential
        {
            [Required]
            public string UserName { get; set; }
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}
