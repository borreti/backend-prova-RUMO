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

        // C
        IBasicModel Create();
        // R
        IBasicModel Get();
        // R
        IBasicModel List();
        // U
        IBasicModel Update();
        // D
        IBasicModel Delete();
    }
}
