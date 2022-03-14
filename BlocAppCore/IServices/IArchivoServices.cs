using BlocDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocAppCore.IServices
{
   public interface IArchivoServices: IServices<ArchivosTXT>
    {

        void ReadText(ArchivosTXT t);

        void EditText(ArchivosTXT t, string n);
    }
}
