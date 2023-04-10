using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Employee1.Modal
{
    public class Employeeclass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Firstname is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name should accept only alphabets")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Name should accept only alphabets")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
