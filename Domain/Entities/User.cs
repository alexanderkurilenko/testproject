using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public enum Role
    {
        Admin,User
    }
    class User
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public Role Type { get; set; }
        public string PassWord { get; set; }

    }
}
