using System;
using System.Collections.Generic;
using Com.Moonlay.Models;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.Models
{
    public class FamilyData : StandardEntity
    {
        public int id { get; set; }
        public string FullNameOfFamily { get; set; }
        public string Relationship { get; set; }
        public DateTimeOffset? DOBFamily { get; set; }
        public string Religion { get; set; }
        public string Gender { get; set; }
        public string KTPNumber { get; set; }

        //Emergency Contact
        public int no { get; set; }
        public string NameOfContact { get; set; }
        public string PhoneNumber { get; set; }
    }
}
