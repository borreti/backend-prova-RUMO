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
        public int TableId { get; set; }
        public virtual Client ClientId { get; set; }
        public bool Free { get; set; }

        public Table()
        {

        }
        
        public Table(int TableId, Client ClientId, bool Free)
        {
            this.TableId = TableId;
            this.ClientId = ClientId;
            this.Free = Free;
        }
    }
}