using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocAppCore.IServices
{
    public interface IServices<T>
    {
        void Create(T t);
        void Delete(T t);
    }
}
