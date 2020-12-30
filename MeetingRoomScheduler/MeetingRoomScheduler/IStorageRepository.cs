using MeetingRoomScheduler.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingRoomScheduler
{
    interface IStorageRepository
    {
        bool SaveMeeting(MeetingInfo meetingInfo);

        IEnumerable<MeetingInfo> GetMeetings(DateTime startTime, DateTime endTime);

        IEnumerable<MeetingInfo> GetLastNMeetings(int count);

        MeetingRoom GetMeetingRoomInfo(int id);

        Participant GetParticipantInfo(string mailId);
    }
}
