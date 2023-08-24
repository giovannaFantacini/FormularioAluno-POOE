namespace Aula3
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeProfessoresToolStripMenuItem = new ToolStripMenuItem();
            cadastroDeCursosToolStripMenuItem = new ToolStripMenuItem();
            relatoriosToolStripMenuItem = new ToolStripMenuItem();
            relatorioDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem, relatoriosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 72);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastroDeAlunosToolStripMenuItem, cadastroDeProfessoresToolStripMenuItem, cadastroDeCursosToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(73, 24);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // cadastroDeAlunosToolStripMenuItem
            // 
            cadastroDeAlunosToolStripMenuItem.Name = "cadastroDeAlunosToolStripMenuItem";
            cadastroDeAlunosToolStripMenuItem.Size = new Size(251, 26);
            cadastroDeAlunosToolStripMenuItem.Text = "Cadastro de Alunos";
            cadastroDeAlunosToolStripMenuItem.Click += cadastroDeAlunosToolStripMenuItem_Click;
            // 
            // cadastroDeProfessoresToolStripMenuItem
            // 
            cadastroDeProfessoresToolStripMenuItem.Name = "cadastroDeProfessoresToolStripMenuItem";
            cadastroDeProfessoresToolStripMenuItem.Size = new Size(251, 26);
            cadastroDeProfessoresToolStripMenuItem.Text = "Cadastro de Professores";
            // 
            // cadastroDeCursosToolStripMenuItem
            // 
            cadastroDeCursosToolStripMenuItem.Name = "cadastroDeCursosToolStripMenuItem";
            cadastroDeCursosToolStripMenuItem.Size = new Size(251, 26);
            cadastroDeCursosToolStripMenuItem.Text = "Cadastro de Cursos";
            // 
            // relatoriosToolStripMenuItem
            // 
            relatoriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { relatorioDeAlunosToolStripMenuItem });
            relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            relatoriosToolStripMenuItem.Size = new Size(90, 24);
            relatoriosToolStripMenuItem.Text = "Relatorios";
            // 
            // relatorioDeAlunosToolStripMenuItem
            // 
            relatorioDeAlunosToolStripMenuItem.Name = "relatorioDeAlunosToolStripMenuItem";
            relatorioDeAlunosToolStripMenuItem.Size = new Size(223, 26);
            relatorioDeAlunosToolStripMenuItem.Text = "Relatorio de Alunos";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            ForeColor = Color.Transparent;
            FormStyle = ReaLTaiizor.Enum.Material.FormStyles.ActionBar_48;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Padding = new Padding(3, 72, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFSP - Sistema de Gerenciamento Acadêmico";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem cadastroDeAlunosToolStripMenuItem;
        private ToolStripMenuItem cadastroDeProfessoresToolStripMenuItem;
        private ToolStripMenuItem cadastroDeCursosToolStripMenuItem;
        private ToolStripMenuItem relatoriosToolStripMenuItem;
        private ToolStripMenuItem relatorioDeAlunosToolStripMenuItem;
    }
}