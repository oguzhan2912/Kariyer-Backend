using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class Other : BaseCard
    {
        
        public string Interests { get; set; }
        public string MemberGNO { get; set; }
        public bool TravelContinents { get; set; }
        public bool Cigaratte { get; set; }
        public string MilitaryStatus { get; set; }
        public DateTime DefermentDate { get; set; }
        public DateTime CompletionDate { get; set; }

        /*Connections*/

     
    }
}
