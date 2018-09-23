using System;
using System.Collections.Generic;

namespace RestauantAPP.Model
{
    public class SessionData
    {
        public static IEnumerable<Session> Get()
        {
            return new List<Session>()
            {
                new Session() {SessionTitle  = "big data", SessionSpeaker = "speaker1", IsTechnical = "Yes", SessionDescription = "speaker is a K"},
                new Session() {SessionTitle  = "company mangerment", SessionSpeaker = "speaker2", IsTechnical = "No", SessionDescription = "speaker is a L"},
                new Session() {SessionTitle  = "it skills", SessionSpeaker = "speaker3", IsTechnical = "Yes", SessionDescription = "speaker is a M"},
                new Session() {SessionTitle  = "history", SessionSpeaker = "speaker4", IsTechnical = "No", SessionDescription = "speaker is a N"},
                new Session() {SessionTitle  = "software programming", SessionSpeaker = "speaker5", IsTechnical = "Yes", SessionDescription = "speaker is a O"},
                new Session() {SessionTitle  = "presentaion skill", SessionSpeaker = "speaker6", IsTechnical = "No", SessionDescription = "speaker is a P"},
                new Session() {SessionTitle  = "research method", SessionSpeaker = "speaker7", IsTechnical = "Yes", SessionDescription = "speaker is a Q"},
                new Session() {SessionTitle  = "art", SessionSpeaker = "speaker8", IsTechnical = "No", SessionDescription = "time management"}
            };
        }
    }
}
