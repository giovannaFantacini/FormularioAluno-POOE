using ReaLTaiizor.Forms;

namespace Aula4
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadAluno formCadAluno = new FormCadAluno();
            formCadAluno.MdiParent = this;
            formCadAluno.Show();

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void cadastroDeProfessoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadProfessor formCadProfessor = new FormCadProfessor();
            formCadProfessor.MdiParent = this;
            formCadProfessor.Show();

        }

        private void cadastroDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadCurso formCadCurso = new FormCadCurso();
            formCadCurso.MdiParent = this;
            formCadCurso.Show();
        }
    }
}