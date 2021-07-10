
using System.ComponentModel.DataAnnotations;

namespace User_Detials_API.Models
{
    public class User
    {

        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public int age { get; set; }

    }
}
