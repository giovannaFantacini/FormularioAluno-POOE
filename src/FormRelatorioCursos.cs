using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aula4
{
    public partial class FormRelatorioCursos : MaterialForm
    {
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
        public FormRelatorioCursos()
        {
            InitializeComponent();
            CarregaImpressora();
        }

        private void CarregaImpressora()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbImpressora.Items.Add(printer);
            }
        }

        private void MontaRelatorio()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso WHERE 1 = 1";
            if (cbTipo.Text != "")
            {
                sql += " AND tipo = @tipo";
            }

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            if (cbTipo.Text != "")
            {
                sqlAd.SelectCommand.Parameters.AddWithValue("@tipo", cbTipo.Text);
            }
            var dt = new DataTable();
            sqlAd.Fill(dt);
            con.Close();

            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            int y = 20;
            PdfBrush brush1 = PdfBrushes.Black;
            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatorio de Cursos", font1, brush1,
                page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding = 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat = new PdfStringFormat(
                PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.CadetBlue;
            table.Style.ShowHeader = true;
            table.DataSource = dt;
            foreach (PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(
                    PdfTextAlignment.Center, PdfVerticalAlignment.Middle);

            }
            table.Draw(page, new Point(0, y + 30));

            doc.SaveToFile("RelatorioCursos.pdf");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (verifica_impressora())
            {
                MontaRelatorio();

                string selectedPrinter = cbImpressora.Text;

                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.LoadFromFile("RelatorioCursos.pdf");

                pdfDocument.PrintSettings.PrinterName = selectedPrinter;

                pdfDocument.Print();
            }
        }

        private bool verifica_impressora()
        {
            if (cbImpressora.Text == "")
            {
                MessageBox.Show("Selecione uma Impressora", "IFSP",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbImpressora.Focus();
                return false;
            }
            return true;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioCursos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
