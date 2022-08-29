using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Dto
{
   public class PostWorkDto
    {
        public int PostWorkId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPosition { get; set; }
        public string CompanyDepartment { get; set; }
        public string CompanyMission { get; set; }
        public decimal CompanySalary { get; set; }
        public DateTime CompanyStartingDate { get; set; }
        public bool CompanyStillWorking { get; set; }
        public DateTime CompanyLeavingDate { get; set; }
        public string CompanyLeavingReason { get; set; }
    }
}
