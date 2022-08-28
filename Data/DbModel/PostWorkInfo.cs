using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.DbModel
{
    public class PostWorkInfo
    {
        [Key]
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

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CVInfo CVInfo { get; set; }
    }
}
