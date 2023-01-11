using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRMission
{
#nullable disable
    public class Message
    {
        public int Id { get; set; }

        //Foreign keys
        public int TaskId { get; set; }
        public int PersonId { get; set; }

        //Payload
        public string MessageText { get; set; }

        //Nav props
        public Mission Mission { get; set; }
        public Person Person { get; set; }


    }
}
