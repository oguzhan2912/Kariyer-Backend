using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concreate
{
    public class ApplicationUser : IEntity
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Lastname { get; set; }

       
    }
}
 