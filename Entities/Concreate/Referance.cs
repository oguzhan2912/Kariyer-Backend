
namespace Entities.Concreate
{
    public class Referance : BaseCard
    {
        
        public string ReferanceName { get; set; }
        public string ReferanceFoundation { get; set; }
        public string ReferanceEmail { get; set; }
        public int ReferancePhoneNumber { get; set; }
        public int ReferancePhoneNumber2 { get; set; }

        /*Connections*/
        public int? CVId { get; set; }
        public virtual CV CVInfo { get; set; }
        

       

    }
}
