namespace Aula4
{
    partial class FormCadProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadProfessor));
            TabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            cadastro = new TabPage();
            cbtitulacao = new ReaLTaiizor.Controls.MaterialComboBox();
            areaFormacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            id = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            dtNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cbEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            cidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            endereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            nome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            matricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            cadastro.Controls.Add(cbtitulacao);
            cadastro.Controls.Add(areaFormacao);
            cadastro.Controls.Add(id);
            cadastro.Controls.Add(btnCancelar);
            cadastro.Controls.Add(btnSalvar);
            cadastro.Controls.Add(dtNascimento);
            cadastro.Controls.Add(cbEstado);
            cadastro.Controls.Add(cidade);
            cadastro.Controls.Add(bairro);
            cadastro.Controls.Add(endereco);
            cadastro.Controls.Add(nome);
            cadastro.Controls.Add(matricula);
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
            // cbtitulacao
            // 
            cbtitulacao.AutoResize = false;
            cbtitulacao.BackColor = Color.FromArgb(255, 255, 255);
            cbtitulacao.Depth = 0;
            cbtitulacao.DrawMode = DrawMode.OwnerDrawVariable;
            cbtitulacao.DropDownHeight = 174;
            cbtitulacao.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtitulacao.DropDownWidth = 121;
            cbtitulacao.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbtitulacao.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbtitulacao.FormattingEnabled = true;
            cbtitulacao.Hint = "Titulação";
            cbtitulacao.IntegralHeight = false;
            cbtitulacao.ItemHeight = 43;
            cbtitulacao.Items.AddRange(new object[] { "Graduação", "Especialização", "Mestrado", "Doutorado" });
            cbtitulacao.Location = new Point(428, 205);
            cbtitulacao.MaxDropDownItems = 4;
            cbtitulacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbtitulacao.Name = "cbtitulacao";
            cbtitulacao.Size = new Size(252, 49);
            cbtitulacao.StartIndex = 0;
            cbtitulacao.TabIndex = 15;
            // 
            // areaFormacao
            // 
            areaFormacao.AnimateReadOnly = false;
            areaFormacao.AutoCompleteMode = AutoCompleteMode.None;
            areaFormacao.AutoCompleteSource = AutoCompleteSource.None;
            areaFormacao.BackgroundImageLayout = ImageLayout.None;
            areaFormacao.CharacterCasing = CharacterCasing.Normal;
            areaFormacao.Depth = 0;
            areaFormacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            areaFormacao.HideSelection = true;
            areaFormacao.Hint = "Área Formação";
            areaFormacao.LeadingIcon = null;
            areaFormacao.Location = new Point(40, 205);
            areaFormacao.MaxLength = 32767;
            areaFormacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            areaFormacao.Name = "areaFormacao";
            areaFormacao.PasswordChar = '\0';
            areaFormacao.PrefixSuffixText = null;
            areaFormacao.ReadOnly = false;
            areaFormacao.RightToLeft = RightToLeft.No;
            areaFormacao.SelectedText = "";
            areaFormacao.SelectionLength = 0;
            areaFormacao.SelectionStart = 0;
            areaFormacao.ShortcutsEnabled = true;
            areaFormacao.Size = new Size(355, 48);
            areaFormacao.TabIndex = 14;
            areaFormacao.TabStop = false;
            areaFormacao.TextAlign = HorizontalAlignment.Left;
            areaFormacao.TrailingIcon = null;
            areaFormacao.UseSystemPasswordChar = false;
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
            btnCancelar.Location = new Point(462, 572);
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
            btnSalvar.Location = new Point(595, 572);
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
            // dtNascimento
            // 
            dtNascimento.AllowPromptAsInput = true;
            dtNascimento.AnimateReadOnly = false;
            dtNascimento.AsciiOnly = false;
            dtNascimento.BackgroundImageLayout = ImageLayout.None;
            dtNascimento.BeepOnError = false;
            dtNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            dtNascimento.Depth = 0;
            dtNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtNascimento.HidePromptOnLeave = false;
            dtNascimento.HideSelection = true;
            dtNascimento.Hint = "Data de Nascimento";
            dtNascimento.InsertKeyMode = InsertKeyMode.Default;
            dtNascimento.LeadingIcon = null;
            dtNascimento.Location = new Point(368, 52);
            dtNascimento.Mask = "99/99/9999";
            dtNascimento.MaxLength = 32767;
            dtNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            dtNascimento.Name = "dtNascimento";
            dtNascimento.PasswordChar = '\0';
            dtNascimento.PrefixSuffixText = null;
            dtNascimento.PromptChar = '_';
            dtNascimento.ReadOnly = false;
            dtNascimento.RejectInputOnFirstFailure = false;
            dtNascimento.ResetOnPrompt = true;
            dtNascimento.ResetOnSpace = true;
            dtNascimento.RightToLeft = RightToLeft.No;
            dtNascimento.SelectedText = "";
            dtNascimento.SelectionLength = 0;
            dtNascimento.SelectionStart = 0;
            dtNascimento.ShortcutsEnabled = true;
            dtNascimento.Size = new Size(199, 48);
            dtNascimento.SkipLiterals = true;
            dtNascimento.TabIndex = 1;
            dtNascimento.TabStop = false;
            dtNascimento.Text = "  /  /";
            dtNascimento.TextAlign = HorizontalAlignment.Left;
            dtNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            dtNascimento.TrailingIcon = null;
            dtNascimento.UseSystemPasswordChar = false;
            dtNascimento.ValidatingType = null;
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
            cbEstado.Hint = "UF";
            cbEstado.IntegralHeight = false;
            cbEstado.ItemHeight = 43;
            cbEstado.Items.AddRange(new object[] { "AC", "AL", "AM", "AP", "BA", "CE", "DF", "ES", "GO", "MA", "MG", "MS", "MT", "PA", "PB", "PE", "PI", "PR", "RJ", "RN", "RO", "RR", "RS", "SC", "SE", "SP", "TO" });
            cbEstado.Location = new Point(529, 454);
            cbEstado.MaxDropDownItems = 4;
            cbEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(151, 49);
            cbEstado.StartIndex = 0;
            cbEstado.TabIndex = 7;
            // 
            // cidade
            // 
            cidade.AnimateReadOnly = false;
            cidade.AutoCompleteMode = AutoCompleteMode.None;
            cidade.AutoCompleteSource = AutoCompleteSource.None;
            cidade.BackgroundImageLayout = ImageLayout.None;
            cidade.CharacterCasing = CharacterCasing.Normal;
            cidade.Depth = 0;
            cidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            cidade.HideSelection = true;
            cidade.Hint = "Cidade";
            cidade.LeadingIcon = null;
            cidade.Location = new Point(40, 455);
            cidade.MaxLength = 32767;
            cidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cidade.Name = "cidade";
            cidade.PasswordChar = '\0';
            cidade.PrefixSuffixText = null;
            cidade.ReadOnly = false;
            cidade.RightToLeft = RightToLeft.No;
            cidade.SelectedText = "";
            cidade.SelectionLength = 0;
            cidade.SelectionStart = 0;
            cidade.ShortcutsEnabled = true;
            cidade.Size = new Size(434, 48);
            cidade.TabIndex = 5;
            cidade.TabStop = false;
            cidade.TextAlign = HorizontalAlignment.Left;
            cidade.TrailingIcon = null;
            cidade.UseSystemPasswordChar = false;
            // 
            // bairro
            // 
            bairro.AnimateReadOnly = false;
            bairro.AutoCompleteMode = AutoCompleteMode.None;
            bairro.AutoCompleteSource = AutoCompleteSource.None;
            bairro.BackgroundImageLayout = ImageLayout.None;
            bairro.CharacterCasing = CharacterCasing.Normal;
            bairro.Depth = 0;
            bairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            bairro.HideSelection = true;
            bairro.Hint = "Bairro";
            bairro.LeadingIcon = null;
            bairro.Location = new Point(40, 371);
            bairro.MaxLength = 32767;
            bairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            bairro.Name = "bairro";
            bairro.PasswordChar = '\0';
            bairro.PrefixSuffixText = null;
            bairro.ReadOnly = false;
            bairro.RightToLeft = RightToLeft.No;
            bairro.SelectedText = "";
            bairro.SelectionLength = 0;
            bairro.SelectionStart = 0;
            bairro.ShortcutsEnabled = true;
            bairro.Size = new Size(640, 48);
            bairro.TabIndex = 4;
            bairro.TabStop = false;
            bairro.TextAlign = HorizontalAlignment.Left;
            bairro.TrailingIcon = null;
            bairro.UseSystemPasswordChar = false;
            // 
            // endereco
            // 
            endereco.AnimateReadOnly = false;
            endereco.AutoCompleteMode = AutoCompleteMode.None;
            endereco.AutoCompleteSource = AutoCompleteSource.None;
            endereco.BackgroundImageLayout = ImageLayout.None;
            endereco.CharacterCasing = CharacterCasing.Normal;
            endereco.Depth = 0;
            endereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            endereco.HideSelection = true;
            endereco.Hint = "Endereço";
            endereco.LeadingIcon = null;
            endereco.Location = new Point(40, 289);
            endereco.MaxLength = 32767;
            endereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            endereco.Name = "endereco";
            endereco.PasswordChar = '\0';
            endereco.PrefixSuffixText = null;
            endereco.ReadOnly = false;
            endereco.RightToLeft = RightToLeft.No;
            endereco.SelectedText = "";
            endereco.SelectionLength = 0;
            endereco.SelectionStart = 0;
            endereco.ShortcutsEnabled = true;
            endereco.Size = new Size(640, 48);
            endereco.TabIndex = 3;
            endereco.TabStop = false;
            endereco.TextAlign = HorizontalAlignment.Left;
            endereco.TrailingIcon = null;
            endereco.UseSystemPasswordChar = false;
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
            // matricula
            // 
            matricula.AnimateReadOnly = false;
            matricula.AutoCompleteMode = AutoCompleteMode.None;
            matricula.AutoCompleteSource = AutoCompleteSource.None;
            matricula.BackgroundImageLayout = ImageLayout.None;
            matricula.CharacterCasing = CharacterCasing.Normal;
            matricula.Depth = 0;
            matricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            matricula.HideSelection = true;
            matricula.Hint = "Matricula";
            matricula.LeadingIcon = null;
            matricula.Location = new Point(40, 52);
            matricula.MaxLength = 32767;
            matricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            matricula.Name = "matricula";
            matricula.PasswordChar = '\0';
            matricula.PrefixSuffixText = null;
            matricula.ReadOnly = false;
            matricula.RightToLeft = RightToLeft.No;
            matricula.SelectedText = "";
            matricula.SelectionLength = 0;
            matricula.SelectionStart = 0;
            matricula.ShortcutsEnabled = true;
            matricula.Size = new Size(296, 48);
            matricula.TabIndex = 1;
            matricula.TabStop = false;
            matricula.TextAlign = HorizontalAlignment.Left;
            matricula.TrailingIcon = null;
            matricula.UseSystemPasswordChar = false;
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
            // FormCadProfessor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 750);
            Controls.Add(TabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = TabControl1;
            Name = "FormCadProfessor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Professor";
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
        private ReaLTaiizor.Controls.MaterialTextBoxEdit matricula;
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
        private ReaLTaiizor.Controls.MaterialComboBox cbtitulacao;
    }
}