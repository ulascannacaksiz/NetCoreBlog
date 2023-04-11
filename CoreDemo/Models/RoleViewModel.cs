using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class RoleViewModel
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Name { get; set; }
    }
}
