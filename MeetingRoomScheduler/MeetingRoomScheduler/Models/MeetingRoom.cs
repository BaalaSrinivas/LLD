using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingRoomScheduler.Models
{
    public class MeetingRoom
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public Calender Calender { get; set; }
    }
}
