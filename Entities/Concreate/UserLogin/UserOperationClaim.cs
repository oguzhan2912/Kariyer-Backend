using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concreate.UserLogin
{
    public class UserOperationClaim:BaseCard
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public int CVId { get; set; }
    }
}
