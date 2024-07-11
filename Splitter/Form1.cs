using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtPdf.Text = @"D:\temp\tmp\listado.pdf";
            txtSalida.Text = @"D:\temp\tmp";
            txtArchivoNombres.Text = @"D:\temp\tmp\listas_archivos.xlsx";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Cargar el documento PDF original
            string originalPdfPath = txtPdf.Text;
            string archivo_nombres = txtArchivoNombres.Text;
            PdfDocument inputDocument = PdfReader.Open(originalPdfPath, PdfDocumentOpenMode.Import);
            SLDocument sl = new SLDocument(archivo_nombres);
            // Crear los nuevos documentos PDF                       
         
            int splitPage = inputDocument.PageCount;
            string col = txtCol.Text;
            int pRow = chCabecera.Checked ? 2 : 1;
            for (int i = 0; i < splitPage; i++)
            {
                PdfDocument outputDocument1 = new PdfDocument();
                //string nombre_archivo = sl.GetCellValueAsString(i+1, 1);
                string nombre_archivo = sl.GetCellValueAsString(col+ (pRow+i));
                if (nombre_archivo.Equals("")) nombre_archivo = i + "";
                string outputPath1 = txtSalida.Text+"\\" + nombre_archivo + ".pdf";
                outputDocument1.AddPage(inputDocument.Pages[i]);
                outputDocument1.Save(outputPath1);

            }
            MessageBox.Show("División completada exitosamente");
            Console.WriteLine("PDF dividido exitosamente.");
         }
    }
}
