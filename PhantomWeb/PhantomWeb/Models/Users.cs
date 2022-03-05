using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhantomWeb.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
