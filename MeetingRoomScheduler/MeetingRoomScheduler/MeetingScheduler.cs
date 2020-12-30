using MeetingRoomScheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeetingRoomScheduler
{
    public class MeetingScheduler
    {
        IStorageRepository _storageRepository;

        public MeetingScheduler()
        {
            _storageRepository = new StorageRepository();
        }

        public bool ScheduleMeeting(int meetingRoomId, IEnumerable<string> participantsMailId, DateTime startTime, DateTime endTime)
        {
            //Create MeetingInfo object
            MeetingInfo meetingInfo = new MeetingInfo();

            meetingInfo.MeetingRoom = GetMeetingRoomInfo(meetingRoomId);
            foreach(string mailId in participantsMailId)
            {
                meetingInfo.Participants.Add(GetParticipantInfo(mailId));                
            }

            IEnumerable<string> availabilityList = GetAvailability(meetingInfo, startTime, endTime);

            return availabilityList.Count() == 0;
        }

        private bool GetInvividualAvailability(Calender calender, DateTime startTime, DateTime endTime)
        {
            foreach(MeetingInfo info in calender.Meetings)
            {
                if(info.StartTime >= startTime || info.EndTime <= endTime)
                {
                    return false;
                }
            }
            return true;
        }

        private IEnumerable<string> GetAvailability(MeetingInfo meetingInfo, DateTime startTime, DateTime endTime)
        {
            List<string> busyEntityList = new List<string>();

            if(!GetInvividualAvailability(meetingInfo.MeetingRoom.Calender, startTime, endTime))
            {
                busyEntityList.Add(meetingInfo.MeetingRoom.Name);
            }

            foreach(Participant participant in meetingInfo.Participants)
            {
                if (!GetInvividualAvailability(participant.Calender, startTime, endTime))
                {
                    busyEntityList.Add(participant.Name);
                }
            }

            return busyEntityList;
        }

        public IEnumerable<MeetingInfo> GetMeetings(DateTime startTime, DateTime endTime)
        {
            return _storageRepository.GetMeetings(startTime, endTime);
        }

        public IEnumerable<MeetingInfo> GetLastNMeetingInfo(int count)
        {
            return _storageRepository.GetLastNMeetings(count);
        }

        private MeetingRoom GetMeetingRoomInfo(int meetingRoomId)
        {
            return _storageRepository.GetMeetingRoomInfo(meetingRoomId);
        }

        private Participant GetParticipantInfo(string participantMailId)
        {
            return _storageRepository.GetParticipantInfo(participantMailId);
        }
    }
}
