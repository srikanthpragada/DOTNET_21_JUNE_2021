using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webdemo.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [BindProperty]
        [StringLength(10,MinimumLength = 6, ErrorMessage ="Invalid Password!")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [BindProperty]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "Invalid Password!")]
        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }
        public void OnPost()
        {
            if (ModelState.IsValid)
                Message = "Succesfully Registered!";
            else
                Message = "Sorry! Validation failed!";
        }
    }
}
