namespace Aula4
{
    partial class FormRelatorioProfessor
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
            cbEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            groupBox1.Controls.Add(cbEstado);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Location = new Point(16, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 83);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // cbEstado
            // 
            cbEstado.AutoResize = false;
            cbEstado.BackColor = Color.FromArgb(255, 255, 255);
            cbEstado.Depth = 0;
            cbEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cbEstado.DropDownHeight = 174;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstado.DropDownWidth = 121;
            cbEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEstado.FormattingEnabled = true;
            cbEstado.Hint = "Estado";
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "", "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cbEstado.Location = new Point(340, 25);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 1;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(6, 26);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(312, 48);
            txtCidade.TabIndex = 2;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // agrupamento
            // 
            agrupamento.Controls.Add(cbAgrupamento);
            agrupamento.Location = new Point(16, 187);
            agrupamento.Name = "agrupamento";
            agrupamento.Size = new Size(539, 91);
            agrupamento.TabIndex = 3;
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
            groupBox2.Location = new Point(16, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 80);
            groupBox2.TabIndex = 4;
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
            btnImprimir.Location = new Point(309, 402);
            btnImprimir.Margin = new Padding(4, 6, 4, 6);
            btnImprimir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnImprimir.Name = "btnImprimir";
            btnImprimir.NoAccentTextColor = Color.Empty;
            btnImprimir.Size = new Size(87, 36);
            btnImprimir.TabIndex = 5;
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
            btnVisualizar.Location = new Point(428, 402);
            btnVisualizar.Margin = new Padding(4, 6, 4, 6);
            btnVisualizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.NoAccentTextColor = Color.Empty;
            btnVisualizar.Size = new Size(103, 36);
            btnVisualizar.TabIndex = 6;
            btnVisualizar.Text = "Visualizar";
            btnVisualizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVisualizar.UseAccentColor = false;
            btnVisualizar.UseVisualStyleBackColor = true;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // FormRelatorioProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 462);
            Controls.Add(btnVisualizar);
            Controls.Add(btnImprimir);
            Controls.Add(groupBox2);
            Controls.Add(agrupamento);
            Controls.Add(groupBox1);
            Name = "FormRelatorioProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Realatorio Professor";
            groupBox1.ResumeLayout(false);
            agrupamento.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstado;
        private GroupBox agrupamento;
        private ReaLTaiizor.Controls.MaterialComboBox cbAgrupamento;
        private GroupBox groupBox2;
        private ReaLTaiizor.Controls.MaterialComboBox cbImpressora;
        private ReaLTaiizor.Controls.MaterialButton btnImprimir;
        private ReaLTaiizor.Controls.MaterialButton btnVisualizar;
    }
}