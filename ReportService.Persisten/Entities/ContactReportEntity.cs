using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportService.Persistent.Entities
{
    public class ContactReportEntity
    {
        public Guid Uuid { get; set; }
        public int Location { get; set; }

        public int NumberOfPeopleAtLocation { get; set; }

        public int NumberOfPhoneNumberAtLocation { get; set; }
    }
}
