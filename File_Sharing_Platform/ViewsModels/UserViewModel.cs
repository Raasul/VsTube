﻿using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
