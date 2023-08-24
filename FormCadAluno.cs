using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Data;

namespace Aula3
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

            if (!isAlteracao)
            {
                var sql = "INSERT INTO aluno" +
                          "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha)" +
                          "VALUES" +
                          "(@matricula, @dt_nascimento, @nome,  @endereco, @bairro, @cidade, @estado, @senha)";
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
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            else
            {

            }
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
            /*
            if (lVAlunos.SelectedItems.Count > 0)
            {
                indexSelecionado = lVAlunos.SelectedItems[0].Index;
                isAlteracao = true;
                var item = lVAlunos.SelectedItems[0];
                matricula.Text = item.SubItems[0].Text;
                dtNascimento.Text = item.SubItems[1].Text;
                nome.Text = item.SubItems[2].Text;
                endereco.Text = item.SubItems[3].Text;
                bairro.Text = item.SubItems[4].Text;
                cidade.Text = item.SubItems[5].Text;
                cbEstado.Text = item.SubItems[6].Text;
                senha.Text = item.SubItems[7].Text;
                TabControl1.SelectedIndex = 0;
                matricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecionar algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            /*
            if (lVAlunos.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente deletar? ", "IFSP", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = lVAlunos.SelectedItems[0].Index;
                    Deletar();
                    carrega_listView();
                }
            }
            else
            {
                MessageBox.Show("Selecione algum aluno!", "IFSP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void Deletar()
        {   /*
            var file = File.ReadAllLines(alunosFileName).ToList();
            file.RemoveAt(indexSelecionado);
            File.WriteAllLines(alunosFileName, file);
            */
        }

        private void lVAlunos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void lVAlunos_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
