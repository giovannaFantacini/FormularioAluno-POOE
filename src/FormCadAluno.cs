using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace Aula4
{
    public partial class FormCadAluno : MaterialForm
    {
        bool isAlteracao = false;
        int indexSelecionado = 0;
        string cs = @"server=localhost;" +
                    "uid=root;" +
                    "pwd=;" +
                    "database=academico";

        public FormCadAluno()
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
                sql = "INSERT INTO aluno" +
                          "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
                          "VALUES" +
                          "(@matricula, @dt_nascimento, @nome,  @endereco, @bairro, @cidade, @estado, @senha)";
            }
            else
            {
                sql = "UPDATE aluno set matricula = @matricula, " +
                          "dt_nascimento = @dt_nascimento, " +
                          "nome = @nome, " + "endereco = @endereco, " +
                          "bairro = @bairro, " + "cidade = @cidade, " +
                          "estado = @estado, " + "senha = @senha " +
                          " WHERE id = @id";

            }
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", matricula.Text);
            DateTime.TryParse(dtNascimento.Text, out var dataNascimento);
            cmd.Parameters.AddWithValue("@dt_nascimento", dataNascimento);
            cmd.Parameters.AddWithValue("@nome", nome.Text);
            cmd.Parameters.AddWithValue("@endereco", endereco.Text);
            cmd.Parameters.AddWithValue("@bairro", bairro.Text);
            cmd.Parameters.AddWithValue("@cidade", cidade.Text);
            cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
            cmd.Parameters.AddWithValue("@senha", senha.Text);
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
            if (string.IsNullOrEmpty(matricula.Text))
            {
                MessageBox.Show("Matricula é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                matricula.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(nome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                nome.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(endereco.Text))
            {
                MessageBox.Show("Endereço é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                endereco.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cidade.Text))
            {
                MessageBox.Show("Cidade é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                cidade.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(senha.Text))
            {
                MessageBox.Show("Senha é obrigatória", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                senha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(bairro.Text))
            {
                MessageBox.Show("Bairro é obrigatório", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                bairro.Focus();
                return false;
            }

            if (!DateTime.TryParse(dtNascimento.Text, out DateTime _))
            {
                MessageBox.Show("Data de nascimento inválida", "IFSP",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtNascimento.Focus();
                return false;
            }

            return true;
            throw new NotImplementedException();
        }

        private void carrega_Grid()
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "SELECT * FROM aluno";
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

        private void lVAlunos_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            if ((e.ItemIndex % 2) == 1)
            {
                e.Item.BackColor = Color.FromArgb(230, 230, 255);
                e.Item.UseItemStyleForSubItems = true;
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
            matricula.Focus();
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
                matricula.Text = linha.Cells["matricula"].Value.ToString();
                dtNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                nome.Text = linha.Cells["nome"].Value.ToString();
                endereco.Text = linha.Cells["endereco"].Value.ToString();
                bairro.Text = linha.Cells["bairro"].Value.ToString();
                cidade.Text = linha.Cells["cidade"].Value.ToString();
                cbEstado.Text = linha.Cells["estado"].Value.ToString();
                senha.Text = linha.Cells["senha"].Value.ToString();
                TabControl1.SelectedIndex = 0;
                matricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecionar algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar(int id)
        {
            var con = new MySqlConnection(cs);
            con.Open();
            var sql = "DELETE FROM ALUNO WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id.ToString());
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
