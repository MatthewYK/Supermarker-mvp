using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        void Add(PaymodeModel paymodeModel);
        void Edit(PaymodeModel paymodeModel);
        void Delete(int id);
        IEnumerable<PaymodeModel> GetAll();
        IEnumerable<PaymodeModel> GetByValue(String value);
    }
}
