using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace IdentitySample.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "RoleName")]
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false)]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        // Add the Address Info:
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<SelectListItem> RolesList { get; set; }
        public string security1 { get; set; } 
        public string security2 { get; set; } 
        public string securityq1 { get; set; } 
        public string securityq2 { get; set; } 
    }
}