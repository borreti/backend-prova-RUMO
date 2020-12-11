using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace provaRumo.Models
{
    public class Table
    {
        [Key()]
        public int Id { get; set; }
        public bool Free { get; set; }
    }
}