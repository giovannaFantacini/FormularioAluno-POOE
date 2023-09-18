namespace Aula4
{
    partial class FormRelatorioCursos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cbTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            agrupamento = new GroupBox();
            cbAgrupamento = new ReaLTaiizor.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            cbImpressora = new ReaLTaiizor.Controls.MaterialComboBox();
            btnImprimir = new ReaLTaiizor.Controls.MaterialButton();
            btnVisualizar = new ReaLTaiizor.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            agrupamento.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipo);
            groupBox1.Location = new Point(15, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 94);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cbTipo
            // 
            cbTipo.AutoResize = false;
            cbTipo.BackColor = Color.FromArgb(255, 255, 255);
            cbTipo.Depth = 0;
            cbTipo.DrawMode = DrawMode.OwnerDrawVariable;
            cbTipo.DropDownHeight = 174;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.DropDownWidth = 121;
            cbTipo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbTipo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbTipo.FormattingEnabled = true;
            cbTipo.Hint = "Tipo de Curso";
            cbTipo.IntegralHeight = false;
            cbTipo.ItemHeight = 43;
            cbTipo.Items.AddRange(new object[] { "", "Tecnico", "Bacharelado", "Tecnologo", "Licenciatura" });
            cbTipo.Location = new Point(6, 26);
            cbTipo.MaxDropDownItems = 4;
            cbTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(508, 49);
            cbTipo.StartIndex = 0;
            cbTipo.TabIndex = 1;
            // 
            // agrupamento
            // 
            agrupamento.Controls.Add(cbAgrupamento);
            agrupamento.Location = new Point(14, 199);
            agrupamento.Name = "agrupamento";
            agrupamento.Size = new Size(524, 91);
            agrupamento.TabIndex = 4;
            agrupamento.TabStop = false;
            agrupamento.Text = "Agrupamento";
            // 
            // cbAgrupamento
            // 
            cbAgrupamento.AutoResize = false;
            cbAgrupamento.BackColor = Color.FromArgb(255, 255, 255);
            cbAgrupamento.Depth = 0;
            cbAgrupamento.DrawMode = DrawMode.OwnerDrawVariable;
            cbAgrupamento.DropDownHeight = 174;
            cbAgrupamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAgrupamento.DropDownWidth = 121;
            cbAgrupamento.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAgrupamento.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAgrupamento.FormattingEnabled = true;
            cbAgrupamento.Hint = "Agrupamento";
            cbAgrupamento.IntegralHeight = false;
            cbAgrupamento.ItemHeight = 43;
            cbAgrupamento.Location = new Point(6, 26);
            cbAgrupamento.MaxDropDownItems = 4;
            cbAgrupamento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAgrupamento.Name = "cbAgrupamento";
            cbAgrupamento.Size = new Size(509, 49);
            cbAgrupamento.StartIndex = 0;
            cbAgrupamento.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbImpressora);
            groupBox2.Location = new Point(14, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 80);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Impressora";
            // 
            // cbImpressora
            // 
            cbImpressora.AutoResize = false;
            cbImpressora.BackColor = Color.FromArgb(255, 255, 255);
            cbImpressora.Depth = 0;
            cbImpressora.DrawMode = DrawMode.OwnerDrawVariable;
            cbImpressora.DropDownHeight = 174;
            cbImpressora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImpressora.DropDownWidth = 121;
            cbImpressora.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbImpressora.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbImpressora.FormattingEnabled = true;
            cbImpressora.Hint = "Impressora";
            cbImpressora.IntegralHeight = false;
            cbImpressora.ItemHeight = 43;
            cbImpressora.Location = new Point(6, 25);
            cbImpressora.MaxDropDownItems = 4;
            cbImpressora.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbImpressora.Name = "cbImpressora";
            cbImpressora.Size = new Size(509, 49);
            cbImpressora.StartIndex = 0;
            cbImpressora.TabIndex = 1;
            // 
            // btnImprimir
            // 
            btnImprimir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnImprimir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnImprimir.Depth = 0;
            btnImprimir.HighEmphasis = true;
            btnImprimir.Icon = null;
            btnImprimir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnImprimir.Location = new Point(308, 416);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 6;
            btnImprimir.Text = "Imprimir";
            btnImprimir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnImprimir.UseAccentColor = false;
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnVisualizar
            // 
            btnVisualizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVisualizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVisualizar.Depth = 0;
            btnVisualizar.HighEmphasis = true;
            btnVisualizar.Icon = null;
            btnVisualizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnVisualizar.Location = new Point(435, 416);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(103, 36);
            btnVisualizar.TabIndex = 7;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // FormRelatorioCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 483);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox2);
            Controls.Add(agrupamento);
            Controls.Add(groupBox1);
            Name = "FormRelatorioCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio Cursos";
            groupBox1.ResumeLayout(false);
            agrupamento.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialComboBox cbTipo;
        private GroupBox agrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cbAgrupamento;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox cbImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
    }
}