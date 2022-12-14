using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Entities.Concreate.UserLogin
{
    public class User :BaseCard
    {

        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }


    }
}
