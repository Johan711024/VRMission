using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRMission
{
#nullable disable
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Email { get; set; }


        // Navigation properties
        public Avatar Avatar { get; set; }

        public ICollection<Mission> Missions { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
