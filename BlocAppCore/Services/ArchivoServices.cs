using BlocAppCore.IServices;
using BlocDomain.Entities;
using BlocDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocAppCore.Services
{
    public class ArchivoServices : BaseServices<ArchivosTXT>, IArchivoServices
    {
        IArchivoModel archivoModel;

        public ArchivoServices(IArchivoModel model) : base(model)
        {
            this.archivoModel = model;
        }

        public void EditText(ArchivosTXT t, string n)
        {
            archivoModel.EditText(t, n);
        }

        public void  ReadText (ArchivosTXT t)
        {
            archivoModel.ReadText(t);
        }
    }
}
