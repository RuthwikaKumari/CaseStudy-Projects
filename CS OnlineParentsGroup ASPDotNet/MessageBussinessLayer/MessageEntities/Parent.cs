using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEntities
{
    public class Parent
    {
        public string ParentName { get; set; }
        public string Password { get; set; }
    }
    public class Message
    {
        public int Id { get; set; }
        public string ParentName { get; set; }
        public string Subject { get; set; }
        public string message { get; set; }
    }
}
