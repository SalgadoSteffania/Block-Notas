using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bloc_de_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TreeNode DirectorioArch(DirectoryInfo directoryInfo)
        {
            TreeNode treeNode = new TreeNode(directoryInfo.Name);

            foreach(var item in directoryInfo.GetDirectories())
            { 
                treeNode.Nodes.Add(DirectorioArch(item));
            }

            foreach(var item  in directoryInfo.GetFiles())
            {
                treeNode.Nodes.Add(new TreeNode(item.Name));
            }

            return treeNode;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArch = new OpenFileDialog();
            StreamReader miTexto = null;

         
            abrirArch.Filter="Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            abrirArch.Title = "Abrir archivo ";
            abrirArch.ShowDialog();
            abrirArch.OpenFile();
            string rutaArchivo = abrirArch.FileName;
            miTexto = File.OpenText(rutaArchivo);
            rtbTexto.Text = miTexto.ReadToEnd();


        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarText = new SaveFileDialog();
            StreamWriter miEscritura = null;

            guardarText.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            guardarText.Title = "Guardar como . . . ";
            guardarText.ShowDialog();
            string ruta = guardarText.FileName;
            miEscritura = File.AppendText(ruta);
            miEscritura.Write(rtbTexto.Text);
            miEscritura.Flush();

            rtbTexto.Clear();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Redo();
           
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbTexto.Clear();
        }

        private void estiloDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog estiloLetra = new FontDialog();
            estiloLetra.Font = rtbTexto.Font;
            if (estiloLetra.ShowDialog() == DialogResult.OK)
                rtbTexto.Font = estiloLetra.Font;

        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorLetra = new ColorDialog();
            if (colorLetra.ShowDialog() == DialogResult.OK)
                rtbTexto.ForeColor = colorLetra.Color;
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog FondoColor = new ColorDialog();
            if (FondoColor.ShowDialog() == DialogResult.OK) ;
            rtbTexto.BackColor = FondoColor.Color;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autores Abdiel robado de youtube ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Directorio = @"C:\\Users\\User\\Downloads";

            tvwArchivos.Nodes.Clear();

            DirectoryInfo directoryInfo = new DirectoryInfo(Directorio);
            
            tvwArchivos.Nodes.Add(DirectorioArch(directoryInfo));
        }

        private void tvwArchivos_DoubleClick(object sender, EventArgs e)
        {

            string OpenArch = "C:\\Users\\User\\Downloads" + tvwArchivos.SelectedNode.FullPath;
            OpenFileDialog abrirArch = new OpenFileDialog();
            StreamReader miTexto = null;


            abrirArch.Filter = "Archivos de texto (.txt)|*.txt|Todos los archivos (*.*)|*.*";
            abrirArch.Title = "Abrir archivo ";
            abrirArch.ShowDialog();
            abrirArch.OpenFile();
            string rutaArchivo = abrirArch.FileName;
            miTexto = File.OpenText(rutaArchivo);
            rtbTexto.Text = miTexto.ReadToEnd();

        }
    }
}
