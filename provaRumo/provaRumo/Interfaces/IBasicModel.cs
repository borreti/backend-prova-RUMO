using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace provaRumo.Interfaces
{
    interface IBasicModel
    {
        int Id { get; set; }

        IBasicModel save();
        IBasicModel add();
        IBasicModel get();
        IBasicModel list();
        IBasicModel remove();
    }
}
