using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concreate
{
    public class BaseCard:IEntity
    {

        [Key]
        public int Id { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } 
        public string CreatedUser { get; set; }
        public string ModifiedUser { get; set; }
        public int IsDeleted { get; set; } = 1;
        

    }
}
