using MeetingRoomScheduler.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetingRoomScheduler
{
    public class MeetingSchedulerAPI
    {
        MeetingScheduler _scheduler;

        private const int LastNCount = 20;

        public MeetingSchedulerAPI()
        {
            _scheduler = new MeetingScheduler();
        }

        public bool ScheduleMeeting(int meetingRoomId, IEnumerable<string> participantsMailId, DateTime startTime, DateTime endTime)
        {
            return _scheduler.ScheduleMeeting(meetingRoomId, participantsMailId, startTime, endTime);
        }

        public IEnumerable<MeetingInfo> GetMeetingInfo(DateTime startTime, DateTime endTime)
        {
            return _scheduler.GetMeetings(startTime, endTime);
        }

        public IEnumerable<MeetingInfo> GetLastNMeetingInfo()
        {
            return _scheduler.GetLastNMeetingInfo(LastNCount);
        }
    }
}
