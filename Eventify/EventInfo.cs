using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify
{
    internal class EventInfo
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string EventLocation { get; set; }
        public string EventBudget { get; set; }
        public string EventDescription { get; set; }

    }
}
