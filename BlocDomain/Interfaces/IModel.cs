using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDomain.Interfaces
{
   public interface IModel<T>
    {
        void Create(T t);
        void Delete(T t);

    }
}
