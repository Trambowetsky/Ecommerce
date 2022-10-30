using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public Sex UserSex { get; set; }
        public DateTime BirthDate { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
