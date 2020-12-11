using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace provaRumo.Interfaces
{
    public interface IBasicModel
    {
        IBasicModel Upsert();
        List<IBasicModel> ListItems();
        IBasicModel GetById(int Id);
        IBasicModel Delete();
    }
}
