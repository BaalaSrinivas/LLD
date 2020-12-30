using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingRoomScheduler.Models
{
    public class Participant
    {
        public string Name { get; set; }

        public string MailId {get; set;}

        public Calender Calender { get; set; }
    }
}
