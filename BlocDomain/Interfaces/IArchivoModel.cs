using BlocDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDomain.Interfaces
{
    public interface IArchivoModel : IModel<ArchivosTXT>
    {

        void ReadText(ArchivosTXT t);

        void EditText(ArchivosTXT t , string n);
    }
}
