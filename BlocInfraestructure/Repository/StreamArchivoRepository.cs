using BlocDomain.Entities;
using BlocDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocInfraestructure.Repository
{
    public class StreamArchivoRepository: IArchivoModel
    {
        string Directorio = Directory.GetCurrentDirectory() + @"\+Archivo de texto";

        public void Create (ArchivosTXT t)
        {
            string Archivo = @"\" + t.Nombre + ".txt";
            File.Create(Directorio + Archivo);
        }

        public void Delete (ArchivosTXT t)
        {
            string Archivo = @"\" + t.Nombre + ".txt";
            File.Delete(Directorio + Archivo);

        }

        public void  EditText (ArchivosTXT t, string n )
        {
            string NuevoArch = @"\" + n + ".txt";
            string Archivo = @"\" + t.Nombre + ".txt";
            File.Move(Directorio + Archivo, Directorio + NuevoArch);
        }

        public void ReadText (ArchivosTXT t)
        { 
            string Archivo = @"\" + t.Nombre + ".txt";
            File.AppendAllText(Directorio + Archivo, t.Texto);
        }
    }
}
