using System;

namespace VRMission
{
#nullable disable
    public class Mission
    {
        public int Id { get; set; }
        public string Title { get; set; }

        // Navigation properties
        public ICollection<Person> Persons { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}