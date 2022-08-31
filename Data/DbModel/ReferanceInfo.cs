using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class ReferanceInfo
    {
        [Key]
        public int ReferanceId { get; set; }
        public string ReferanceName { get; set; }
        public string ReferanceFoundation { get; set; }
        public string ReferanceEmail { get; set; }
        public int ReferancePhoneNumber { get; set; }
        public int ReferancePhoneNumber2 { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }
        public int? BaseId { get; set; }

        public virtual BaseCard Base { get; set; }

    }
}
