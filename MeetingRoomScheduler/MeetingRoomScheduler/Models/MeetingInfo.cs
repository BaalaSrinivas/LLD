using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingRoomScheduler.Models
{
    public class MeetingInfo
    {
        public MeetingInfo()
        {
            Participants = new List<Participant>();
        }

        public string MeetingId { get; set; }

        public MeetingRoom MeetingRoom { get; set; }

        public List<Participant> Participants { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
