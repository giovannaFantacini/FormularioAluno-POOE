using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace Aula4
{
    public partial class FormCadCurso : MaterialForm
    {
        bool isAlteracao = false;
        int indexSelecionado = 0;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";

        public FormCadCurso()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                Salvar();
                TabControl1.SelectedIndex = 1;
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "";

            if (!isAlteracao)
            {
                sql = "INSERT INTO curso" +
                          "(tipo, nome, ano_criacao)" +
                          "VALUES" +
                          "(@tipo, @nome, @ano_criacao)";
            }
            else
            {
                sql = "UPDATE curso set tipo = @tipo, " +
                          "ano_criacao = @ano_criacao, " +
                          "nome = @nome " +
                          "WHERE id = @id";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@tipo", cbTipo.Text);
            cmd.Parameters.AddWithValue("@nome", nome.Text);
            cmd.Parameters.AddWithValue("@ano_criacao", cbAnoCriacao.Text);
            if (isAlteracao)
            {
                cmd.Parameters.AddWithValue("@id", id.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            LimparCampos();

        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrEmpty(cbTipo.Text))
            {
                MessageBox.Show("Tipo é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbTipo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbAnoCriacao.Text))
            {
                MessageBox.Show("Ano Criação é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAnoCriacao.Focus();
                return false;
            }
            return true;
            throw new NotImplementedException();
        }

        private void carrega_Grid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void consulta_Enter(object sender, EventArgs e)
        {
            carrega_Grid();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente cancelar?", "IFSP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimparCampos();
                TabControl1.SelectedIndex = 1;
            }


        }

        private void LimparCampos()
        {
            isAlteracao = false;
            foreach (var control in cadastro.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TabControl1.SelectedIndex = 0;
            cbTipo.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {

            if (dataGridView.SelectedRows.Count > 0)
            {
                isAlteracao = true;
                var linha = dataGridView.SelectedRows[0];
                id.Text = linha.Cells["id"].Value.ToString();
                cbTipo.Text = linha.Cells["tipo"].Value.ToString();
                nome.Text = linha.Cells["nome"].Value.ToString();
                cbAnoCriacao.Text = linha.Cells["ano_criacao"].Value.ToString();
                TabControl1.SelectedIndex = 0;
                cbTipo.Focus();
            }
            else
            {
                MessageBox.Show("Selecionar algum Curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar? ", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridView.SelectedRows[0].Cells[0].Value;
                    Deletar(id);
                    carrega_Grid();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum Curso!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id.ToString());
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }


    }
}
