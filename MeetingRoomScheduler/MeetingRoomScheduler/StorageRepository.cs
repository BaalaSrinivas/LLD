using System;
using System.Collections.Generic;
using System.Text;
using MeetingRoomScheduler.Models;

namespace MeetingRoomScheduler
{
    class StorageRepository : IStorageRepository
    {
        public IEnumerable<MeetingInfo> GetLastNMeetings(int count)
        {
            return new List<MeetingInfo>();
        }

        public MeetingRoom GetMeetingRoomInfo(int id)
        {
            return new MeetingRoom();
        }

        public IEnumerable<MeetingInfo> GetMeetings(DateTime startTime, DateTime endTime)
        {
            return new List<MeetingInfo>();
        }

        public Participant GetParticipantInfo(string mailId)
        {
            return new Participant();
        }

        public bool SaveMeeting(MeetingInfo meetingInfo)
        {
            return true;
        }
    }
}
