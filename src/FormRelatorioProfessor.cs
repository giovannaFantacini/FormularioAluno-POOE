using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.General.Find;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System.Data;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Aula4
{
    public partial class FormRelatorioProfessor : MaterialForm
    {
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";
        public FormRelatorioProfessor()
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
            var sql = "SELECT * FROM professor WHERE 1 = 1";
            if (cbEstado.Text != "")
            {
                sql += " AND ESTADO = @estado";
            }
            if (txtCidade.Text != "")
            {
                sql += " AND CIDADE = @cidade";
            }

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            if (cbEstado.Text != "")
            {
                sqlAd.SelectCommand.Parameters.AddWithValue("@estado", cbEstado.Text);
            }
            if (txtCidade.Text != "")
            {
                sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", txtCidade.Text);
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

            page.Canvas.DrawString("Relatorio de Professores", font1, brush1,
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

            doc.SaveToFile("RelatorioProfessores.pdf");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (verifica_impressora())
            {
                MontaRelatorio();

                string selectedPrinter = cbImpressora.Text;

                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.LoadFromFile("RelatorioProfessores.pdf");

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
            p.StartInfo = new ProcessStartInfo(@"RelatorioProfessores.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
