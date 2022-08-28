using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class OtherInfo
    {
        [Key]
        public int OtherId { get; set; }
        public string Interests { get; set; }
        public string MemberGNO { get; set; }
        public bool TravelContinents { get; set; }
        public bool Cigaratte { get; set; }
        public string MilitaryStatus { get; set; }
        public DateTime DefermentDate { get; set; }
        public DateTime CompletionDate { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }

    }
}
