using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;


namespace Entities.Concreate.UserLogin
{
    public class User : BaseCard
    {
        
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }        
        

    }
}
