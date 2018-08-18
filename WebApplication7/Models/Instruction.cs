using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebApplication7.Models;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class Instruction
    {
        [Key]
        public int InstUserId { get; set; }

        public string Insturctionname { get; set; }

        public string Description { get; set; }

        public virtual ICollection<User> GetUsers{ get; set; }
    }
}
