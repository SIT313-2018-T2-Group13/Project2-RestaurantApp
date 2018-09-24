using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using RestauantAPP_API.Models;

namespace RestauantAPP_API.Controllers
{
    public class ConferenceSessionsController : ApiController
    {
        List<Notice> sessions = new List<Notice>(
            new Notice[]
        {
            new Notice{SessionTitle = "Microsoft", SessionDescription="24hours open today"},
            new Notice{SessionTitle = "Bamboo House", SessionDescription="Close today"},
            new Notice{SessionTitle = "Universal Restaurant", SessionDescription="50% off"},
            new Notice{SessionTitle = "IBM", SessionDescription="Watson"}
        }
        );
        public List<Notice> GetAllClass()
        {
            return sessions;
        }
        public Notice GetSession(string id)
        {
            var session = sessions.FirstOrDefault((p) => p.SessionTitle == id);
            return session;
        }
    }
}
