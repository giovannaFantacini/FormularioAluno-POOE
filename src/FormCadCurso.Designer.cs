namespace Aula4
{
    partial class FormCadCurso
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadCurso));
            TabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            cadastro = new TabPage();
            cbTipo = new ReaLTaiizor.Controls.MaterialComboBox();
            cbAnoCriacao = new ReaLTaiizor.Controls.MaterialComboBox();
            id = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            nome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            consulta = new TabPage();
            dataGridView = new DataGridView();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            TabControl1.SuspendLayout();
            cadastro.SuspendLayout();
            consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(cadastro);
            TabControl1.Controls.Add(consulta);
            TabControl1.Depth = 0;
            TabControl1.Dock = DockStyle.Fill;
            TabControl1.ImageList = imageList1;
            TabControl1.Location = new Point(3, 64);
            TabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControl1.Multiline = true;
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(800, 683);
            TabControl1.SizeMode = TabSizeMode.FillToRight;
            TabControl1.TabIndex = 0;
            // 
            // cadastro
            // 
            cadastro.Controls.Add(cbTipo);
            cadastro.Controls.Add(cbAnoCriacao);
            cadastro.Controls.Add(id);
            cadastro.Controls.Add(btnCancelar);
            cadastro.Controls.Add(btnSalvar);
            cadastro.Controls.Add(nome);
            cadastro.ImageKey = "form.png";
            cadastro.ImeMode = ImeMode.Off;
            cadastro.Location = new Point(4, 31);
            cadastro.Name = "cadastro";
            cadastro.Padding = new Padding(3);
            cadastro.Size = new Size(792, 648);
            cadastro.TabIndex = 0;
            cadastro.Text = "Cadastro";
            cadastro.UseVisualStyleBackColor = true;
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
            cbTipo.Hint = "Tipo";
            cbTipo.IntegralHeight = false;
            cbTipo.ItemHeight = 43;
            cbTipo.Items.AddRange(new object[] { "Tecnico", "Bacharelado", "Tecnologo", "Licenciatura" });
            cbTipo.Location = new Point(40, 51);
            cbTipo.MaxDropDownItems = 4;
            cbTipo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(515, 49);
            cbTipo.StartIndex = 0;
            cbTipo.TabIndex = 16;
            // 
            // cbAnoCriacao
            // 
            cbAnoCriacao.AutoResize = false;
            cbAnoCriacao.BackColor = Color.FromArgb(255, 255, 255);
            cbAnoCriacao.Depth = 0;
            cbAnoCriacao.DrawMode = DrawMode.OwnerDrawVariable;
            cbAnoCriacao.DropDownHeight = 174;
            cbAnoCriacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAnoCriacao.DropDownWidth = 121;
            cbAnoCriacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbAnoCriacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbAnoCriacao.FormattingEnabled = true;
            cbAnoCriacao.Hint = "Ano Criação";
            cbAnoCriacao.IntegralHeight = false;
            cbAnoCriacao.ItemHeight = 43;
            cbAnoCriacao.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023" });
            cbAnoCriacao.Location = new Point(40, 207);
            cbAnoCriacao.MaxDropDownItems = 4;
            cbAnoCriacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbAnoCriacao.Name = "cbAnoCriacao";
            cbAnoCriacao.Size = new Size(252, 49);
            cbAnoCriacao.StartIndex = 0;
            cbAnoCriacao.TabIndex = 15;
            // 
            // id
            // 
            id.AnimateReadOnly = false;
            id.AutoCompleteMode = AutoCompleteMode.None;
            id.AutoCompleteSource = AutoCompleteSource.None;
            id.BackgroundImageLayout = ImageLayout.None;
            id.CharacterCasing = CharacterCasing.Normal;
            id.Depth = 0;
            id.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            id.HideSelection = true;
            id.Hint = "Id";
            id.LeadingIcon = null;
            id.Location = new Point(604, 52);
            id.MaxLength = 32767;
            id.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            id.Name = "id";
            id.PasswordChar = '\0';
            id.PrefixSuffixText = null;
            id.ReadOnly = true;
            id.RightToLeft = RightToLeft.No;
            id.SelectedText = "";
            id.SelectionLength = 0;
            id.SelectionStart = 0;
            id.ShortcutsEnabled = true;
            id.Size = new Size(76, 48);
            id.TabIndex = 13;
            id.TabStop = false;
            id.TextAlign = HorizontalAlignment.Left;
            id.TrailingIcon = null;
            id.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(429, 361);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(562, 361);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // nome
            // 
            nome.AnimateReadOnly = false;
            nome.AutoCompleteMode = AutoCompleteMode.None;
            nome.AutoCompleteSource = AutoCompleteSource.None;
            nome.BackgroundImageLayout = ImageLayout.None;
            nome.CharacterCasing = CharacterCasing.Normal;
            nome.Depth = 0;
            nome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            nome.HideSelection = true;
            nome.Hint = "Nome";
            nome.LeadingIcon = null;
            nome.Location = new Point(40, 129);
            nome.MaxLength = 32767;
            nome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            nome.Name = "nome";
            nome.PasswordChar = '\0';
            nome.PrefixSuffixText = null;
            nome.ReadOnly = false;
            nome.RightToLeft = RightToLeft.No;
            nome.SelectedText = "";
            nome.SelectionLength = 0;
            nome.SelectionStart = 0;
            nome.ShortcutsEnabled = true;
            nome.Size = new Size(640, 48);
            nome.TabIndex = 0;
            nome.TabStop = false;
            nome.TextAlign = HorizontalAlignment.Left;
            nome.TrailingIcon = null;
            nome.UseSystemPasswordChar = false;
            // 
            // consulta
            // 
            consulta.Controls.Add(dataGridView);
            consulta.Controls.Add(btnNovo);
            consulta.Controls.Add(btnExcluir);
            consulta.Controls.Add(btnEditar);
            consulta.ImageKey = "search.png";
            consulta.ImeMode = ImeMode.Disable;
            consulta.Location = new Point(4, 31);
            consulta.Name = "consulta";
            consulta.Padding = new Padding(3);
            consulta.Size = new Size(792, 648);
            consulta.TabIndex = 1;
            consulta.Text = "Consulta";
            consulta.UseVisualStyleBackColor = true;
            consulta.Enter += consulta_Enter;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.ControlLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.Dock = DockStyle.Top;
            dataGridView.GridColor = SystemColors.ControlLightLight;
            dataGridView.Location = new Point(3, 3);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(786, 594);
            dataGridView.TabIndex = 4;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(412, 603);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(612, 603);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(509, 603);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "form.png");
            imageList1.Images.SetKeyName(1, "search.png");
            // 
            // FormCadCurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 750);
            Controls.Add(TabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControl1;
            Name = "FormCadCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Curso";
            TabControl1.ResumeLayout(false);
            cadastro.ResumeLayout(false);
            cadastro.PerformLayout();
            consulta.ResumeLayout(false);
            consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControl1;
        private TabPage cadastro;
        private TabPage consulta;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit cidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit bairro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit endereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit nome;
        private ReaLTaiizor.Controls.MaterialComboBox cbEstado;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox dtNascimento;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private DataGridView dataGridView;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit id;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit areaFormacao;
        private ReaLTaiizor.Controls.MaterialComboBox cbAnoCriacao;
        private ReaLTaiizor.Controls.MaterialComboBox cbTipo;
    }
}