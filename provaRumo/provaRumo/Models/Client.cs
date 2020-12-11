using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public float Cash { get; set; }

        public Client()
        {

        }

        public Client(int ClientId, string Name, float Cash)
        {
            this.ClientId = ClientId;
            this.Name = Name;
            this.Cash = Cash;
        }
    }
}