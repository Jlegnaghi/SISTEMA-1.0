namespace SISTEMA_1._0.UI_Gestao_TI
{
    partial class frmGestao
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblGabinete = new System.Windows.Forms.Label();
            this.picBoxGabinete = new System.Windows.Forms.PictureBox();
            this.txtGabinete = new System.Windows.Forms.TextBox();
            this.txtPlacaMae = new System.Windows.Forms.TextBox();
            this.lblPlacaMae = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.lblCPU = new System.Windows.Forms.Label();
            this.txtFonte = new System.Windows.Forms.TextBox();
            this.lblFonte = new System.Windows.Forms.Label();
            this.lblDicoRigido = new System.Windows.Forms.Label();
            this.chkHDD = new System.Windows.Forms.CheckBox();
            this.chkSSD = new System.Windows.Forms.CheckBox();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.txtGPU = new System.Windows.Forms.TextBox();
            this.lblGPU = new System.Windows.Forms.Label();
            this.txtTeclado = new System.Windows.Forms.TextBox();
            this.lblTeclado = new System.Windows.Forms.Label();
            this.txtMouse = new System.Windows.Forms.TextBox();
            this.lblMouse = new System.Windows.Forms.Label();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.chk16Gb = new System.Windows.Forms.CheckBox();
            this.chk8Gb = new System.Windows.Forms.CheckBox();
            this.lblMemoria = new System.Windows.Forms.Label();
            this.chk4Gb = new System.Windows.Forms.CheckBox();
            this.chk2Gb = new System.Windows.Forms.CheckBox();
            this.cBoxTipoMemoria = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.cBoxTamanhoDisco = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCarregarImagem = new System.Windows.Forms.Button();
            this.btnImprimirCodigoBarras = new System.Windows.Forms.Button();
            this.picBoxCodigoBarras = new System.Windows.Forms.PictureBox();
            this.btnCodBarras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGabinete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCodigoBarras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(152, 329);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(233, 329);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(314, 329);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(395, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGabinete
            // 
           this.lblGabinete.AutoSize = true;
           this.lblGabinete.Location = new System.Drawing.Point(15, 57);
           this.lblGabinete.Name = "lblGabinete";
           this.lblGabinete.Size = new System.Drawing.Size(50, 13);
           this.lblGabinete.TabIndex = 4;
           this.lblGabinete.Text = "Gabinete";
           // 
            // picBoxGabinete
            // 
            this.picBoxGabinete.Location = new System.Drawing.Point(556, 25);
            this.picBoxGabinete.Name = "picBoxGabinete";
            this.picBoxGabinete.Size = new System.Drawing.Size(195, 221);
            this.picBoxGabinete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGabinete.TabIndex = 5;
            this.picBoxGabinete.TabStop = false;
            this.picBoxGabinete.Click += new System.EventHandler(this.picBoxGabinete_Click);
            // 
            // txtGabinete
            // 
            this.txtGabinete.Location = new System.Drawing.Point(36, 73);
            this.txtGabinete.Name = "txtGabinete";
            this.txtGabinete.Size = new System.Drawing.Size(206, 20);
            this.txtGabinete.TabIndex = 6;
            this.txtGabinete.TextChanged += new System.EventHandler(this.txtGabinete_TextChanged);
            // 
            // txtPlacaMae
            // 
            this.txtPlacaMae.Location = new System.Drawing.Point(36, 121);
            this.txtPlacaMae.Name = "txtPlacaMae";
            this.txtPlacaMae.Size = new System.Drawing.Size(206, 20);
            this.txtPlacaMae.TabIndex = 8;
            this.txtPlacaMae.TextChanged += new System.EventHandler(this.txtPlacaMae_TextChanged);
            // 
            // lblPlacaMae
            // 
            this.lblPlacaMae.AutoSize = true;
            this.lblPlacaMae.Location = new System.Drawing.Point(15, 105);
            this.lblPlacaMae.Name = "lblPlacaMae";
            this.lblPlacaMae.Size = new System.Drawing.Size(58, 13);
            this.lblPlacaMae.TabIndex = 7;
            this.lblPlacaMae.Text = "Placa Mae";
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(36, 171);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(206, 20);
            this.txtCPU.TabIndex = 10;
            this.txtCPU.TextChanged += new System.EventHandler(this.txtCPU_TextChanged);
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(15, 155);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(29, 13);
            this.lblCPU.TabIndex = 9;
            this.lblCPU.Text = "CPU";
            // 
            // txtFonte
            // 
            this.txtFonte.Location = new System.Drawing.Point(36, 220);
            this.txtFonte.Name = "txtFonte";
            this.txtFonte.Size = new System.Drawing.Size(206, 20);
            this.txtFonte.TabIndex = 14;
            this.txtFonte.TextChanged += new System.EventHandler(this.txtFonte_TextChanged);
            // 
            // lblFonte
            // 
            this.lblFonte.AutoSize = true;
            this.lblFonte.Location = new System.Drawing.Point(15, 204);
            this.lblFonte.Name = "lblFonte";
            this.lblFonte.Size = new System.Drawing.Size(34, 13);
            this.lblFonte.TabIndex = 13;
            this.lblFonte.Text = "Fonte";
            // 
            // lblDicoRigido
            // 
            this.lblDicoRigido.AutoSize = true;
            this.lblDicoRigido.Location = new System.Drawing.Point(15, 263);
            this.lblDicoRigido.Name = "lblDicoRigido";
            this.lblDicoRigido.Size = new System.Drawing.Size(67, 13);
            this.lblDicoRigido.TabIndex = 15;
            this.lblDicoRigido.Text = "Disco Rigido";
            // 
            // chkHDD
            // 
            this.chkHDD.AutoSize = true;
            this.chkHDD.Location = new System.Drawing.Point(81, 279);
            this.chkHDD.Name = "chkHDD";
            this.chkHDD.Size = new System.Drawing.Size(50, 17);
            this.chkHDD.TabIndex = 16;
            this.chkHDD.Text = "HDD";
            this.chkHDD.UseVisualStyleBackColor = true;
            this.chkHDD.CheckedChanged += new System.EventHandler(this.chkHDD_CheckedChanged);
            // 
            // chkSSD
            // 
            this.chkSSD.AutoSize = true;
            this.chkSSD.Location = new System.Drawing.Point(152, 279);
            this.chkSSD.Name = "chkSSD";
            this.chkSSD.Size = new System.Drawing.Size(48, 17);
            this.chkSSD.TabIndex = 17;
            this.chkSSD.Text = "SSD";
            this.chkSSD.UseVisualStyleBackColor = true;
            this.chkSSD.CheckedChanged += new System.EventHandler(this.chkSSD_CheckedChanged);
            // 
            // txtSetor
            // 
            this.txtSetor.Location = new System.Drawing.Point(284, 226);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(206, 20);
            this.txtSetor.TabIndex = 28;
            this.txtSetor.TextChanged += new System.EventHandler(this.txtSetor_TextChanged);
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Location = new System.Drawing.Point(263, 210);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(32, 13);
            this.lblSetor.TabIndex = 27;
            this.lblSetor.Text = "Setor";
            // 
            // txtGPU
            // 
            this.txtGPU.Location = new System.Drawing.Point(284, 172);
            this.txtGPU.Name = "txtGPU";
            this.txtGPU.Size = new System.Drawing.Size(206, 20);
            this.txtGPU.TabIndex = 26;
            this.txtGPU.TextChanged += new System.EventHandler(this.txtGPU_TextChanged);
            // 
            // lblGPU
            // 
            this.lblGPU.AutoSize = true;
            this.lblGPU.Location = new System.Drawing.Point(263, 156);
            this.lblGPU.Name = "lblGPU";
            this.lblGPU.Size = new System.Drawing.Size(30, 13);
            this.lblGPU.TabIndex = 25;
            this.lblGPU.Text = "GPU";
            // 
            // txtTeclado
            // 
            this.txtTeclado.Location = new System.Drawing.Point(284, 123);
            this.txtTeclado.Name = "txtTeclado";
            this.txtTeclado.Size = new System.Drawing.Size(206, 20);
            this.txtTeclado.TabIndex = 24;
            this.txtTeclado.TextChanged += new System.EventHandler(this.txtTeclado_TextChanged);
            // 
            // lblTeclado
            // 
            this.lblTeclado.AutoSize = true;
            this.lblTeclado.Location = new System.Drawing.Point(263, 107);
            this.lblTeclado.Name = "lblTeclado";
            this.lblTeclado.Size = new System.Drawing.Size(46, 13);
            this.lblTeclado.TabIndex = 23;
            this.lblTeclado.Text = "Teclado";
            // 
            // txtMouse
            // 
            this.txtMouse.Location = new System.Drawing.Point(284, 73);
            this.txtMouse.Name = "txtMouse";
            this.txtMouse.Size = new System.Drawing.Size(206, 20);
            this.txtMouse.TabIndex = 22;
            this.txtMouse.TextChanged += new System.EventHandler(this.txtMouse_TextChanged);
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(263, 57);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(39, 13);
            this.lblMouse.TabIndex = 21;
            this.lblMouse.Text = "Mouse";
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(284, 25);
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(206, 20);
            this.txtMonitor.TabIndex = 20;
            this.txtMonitor.TextChanged += new System.EventHandler(this.txtMonitor_TextChanged);
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Location = new System.Drawing.Point(263, 9);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(42, 13);
            this.lblMonitor.TabIndex = 19;
            this.lblMonitor.Text = "Monitor";
            // 
            // chk16Gb
            // 
            this.chk16Gb.AutoSize = true;
            this.chk16Gb.Location = new System.Drawing.Point(444, 279);
            this.chk16Gb.Name = "chk16Gb";
            this.chk16Gb.Size = new System.Drawing.Size(52, 17);
            this.chk16Gb.TabIndex = 31;
            this.chk16Gb.Text = "16Gb";
            this.chk16Gb.UseVisualStyleBackColor = true;
            this.chk16Gb.CheckedChanged += new System.EventHandler(this.chk16Gb_CheckedChanged);
            // 
            // chk8Gb
            // 
            this.chk8Gb.AutoSize = true;
            this.chk8Gb.Location = new System.Drawing.Point(392, 279);
            this.chk8Gb.Name = "chk8Gb";
            this.chk8Gb.Size = new System.Drawing.Size(46, 17);
            this.chk8Gb.TabIndex = 30;
            this.chk8Gb.Text = "8Gb";
            this.chk8Gb.UseVisualStyleBackColor = true;
            this.chk8Gb.CheckedChanged += new System.EventHandler(this.chk8Gb_CheckedChanged);
            // 
            // lblMemoria
            // 
            this.lblMemoria.AutoSize = true;
            this.lblMemoria.Location = new System.Drawing.Point(263, 263);
            this.lblMemoria.Name = "lblMemoria";
            this.lblMemoria.Size = new System.Drawing.Size(47, 13);
            this.lblMemoria.TabIndex = 29;
            this.lblMemoria.Text = "Memoria";
            // 
            // chk4Gb
            // 
            this.chk4Gb.AutoSize = true;
            this.chk4Gb.Location = new System.Drawing.Point(340, 279);
            this.chk4Gb.Name = "chk4Gb";
            this.chk4Gb.Size = new System.Drawing.Size(46, 17);
            this.chk4Gb.TabIndex = 34;
            this.chk4Gb.Text = "4Gb";
            this.chk4Gb.UseVisualStyleBackColor = true;
            this.chk4Gb.CheckedChanged += new System.EventHandler(this.chk4Gb_CheckedChanged);
            // 
            // chk2Gb
            // 
            this.chk2Gb.AutoSize = true;
            this.chk2Gb.Location = new System.Drawing.Point(288, 279);
            this.chk2Gb.Name = "chk2Gb";
            this.chk2Gb.Size = new System.Drawing.Size(46, 17);
            this.chk2Gb.TabIndex = 33;
            this.chk2Gb.Text = "2Gb";
            this.chk2Gb.UseVisualStyleBackColor = true;
            this.chk2Gb.CheckedChanged += new System.EventHandler(this.chk2Gb_CheckedChanged);
            // 
            // cBoxTipoMemoria
            // 
            this.cBoxTipoMemoria.FormattingEnabled = true;
            this.cBoxTipoMemoria.Items.AddRange(new object[] {
            "DDR2",
            "DDR3",
            "DDR4"});
            this.cBoxTipoMemoria.Location = new System.Drawing.Point(288, 302);
            this.cBoxTipoMemoria.Name = "cBoxTipoMemoria";
            this.cBoxTipoMemoria.Size = new System.Drawing.Size(202, 21);
            this.cBoxTipoMemoria.TabIndex = 35;
            this.cBoxTipoMemoria.Text = "TIPO";
            this.cBoxTipoMemoria.SelectedIndexChanged += new System.EventHandler(this.cBoxTipoMemoria_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(33, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(98, 20);
            this.txtID.TabIndex = 37;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(76, 13);
            this.lblID.TabIndex = 36;
            this.lblID.Text = "ID / Cód Barra";
            // 
            // cBoxTamanhoDisco
            // 
            this.cBoxTamanhoDisco.FormattingEnabled = true;
            this.cBoxTamanhoDisco.Items.AddRange(new object[] {
            "80GB",
            "120GB",
            "128GB",
            "160GB",
            "240GB",
            "250GB",
            "256GB",
            "320GB",
            "480GB",
            "512GB",
            "750GB",
            "1TB"});
            this.cBoxTamanhoDisco.Location = new System.Drawing.Point(40, 302);
            this.cBoxTamanhoDisco.Name = "cBoxTamanhoDisco";
            this.cBoxTamanhoDisco.Size = new System.Drawing.Size(202, 21);
            this.cBoxTamanhoDisco.TabIndex = 38;
            this.cBoxTamanhoDisco.Text = "Tamanho";
            this.cBoxTamanhoDisco.SelectedIndexChanged += new System.EventHandler(this.cBoxTamanhoDisco_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(152, 23);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 39;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCarregarImagem
            // 
            this.btnCarregarImagem.Location = new System.Drawing.Point(556, 252);
            this.btnCarregarImagem.Name = "btnCarregarImagem";
            this.btnCarregarImagem.Size = new System.Drawing.Size(75, 23);
            this.btnCarregarImagem.TabIndex = 40;
            this.btnCarregarImagem.Text = "Importar";
            this.btnCarregarImagem.UseVisualStyleBackColor = true;
            this.btnCarregarImagem.Click += new System.EventHandler(this.btnCarregarImagem_Click);
            // 
            // btnImprimirCodigoBarras
            // 
            this.btnImprimirCodigoBarras.Location = new System.Drawing.Point(676, 337);
            this.btnImprimirCodigoBarras.Name = "btnImprimirCodigoBarras";
            this.btnImprimirCodigoBarras.Size = new System.Drawing.Size(75, 23);
            this.btnImprimirCodigoBarras.TabIndex = 41;
            this.btnImprimirCodigoBarras.Text = "Impimir";
            this.btnImprimirCodigoBarras.UseVisualStyleBackColor = true;
            this.btnImprimirCodigoBarras.Click += new System.EventHandler(this.btnImprimirCodigoBarras_Click);
            // 
            // picBoxCodigoBarras
            // 
            this.picBoxCodigoBarras.Location = new System.Drawing.Point(556, 281);
            this.picBoxCodigoBarras.Name = "picBoxCodigoBarras";
            this.picBoxCodigoBarras.Size = new System.Drawing.Size(195, 50);
            this.picBoxCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCodigoBarras.TabIndex = 42;
            this.picBoxCodigoBarras.TabStop = false;
            this.picBoxCodigoBarras.Click += new System.EventHandler(this.picBoxCodigoBarras_Click);
            // 
            // btnCodBarras
            // 
            this.btnCodBarras.Location = new System.Drawing.Point(556, 337);
            this.btnCodBarras.Name = "btnCodBarras";
            this.btnCodBarras.Size = new System.Drawing.Size(75, 23);
            this.btnCodBarras.TabIndex = 43;
            this.btnCodBarras.Text = "Vizualizar";
            this.btnCodBarras.UseVisualStyleBackColor = true;
            this.btnCodBarras.Click += new System.EventHandler(this.btnCodBarras_Click);
            // 
            // frmGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnCodBarras);
            this.Controls.Add(this.picBoxCodigoBarras);
            this.Controls.Add(this.btnImprimirCodigoBarras);
            this.Controls.Add(this.btnCarregarImagem);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cBoxTamanhoDisco);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cBoxTipoMemoria);
            this.Controls.Add(this.chk4Gb);
            this.Controls.Add(this.chk2Gb);
            this.Controls.Add(this.chk16Gb);
            this.Controls.Add(this.chk8Gb);
            this.Controls.Add(this.lblMemoria);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lblSetor);
            this.Controls.Add(this.txtGPU);
            this.Controls.Add(this.lblGPU);
            this.Controls.Add(this.txtTeclado);
            this.Controls.Add(this.lblTeclado);
            this.Controls.Add(this.txtMouse);
            this.Controls.Add(this.lblMouse);
            this.Controls.Add(this.txtMonitor);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.chkSSD);
            this.Controls.Add(this.chkHDD);
            this.Controls.Add(this.lblDicoRigido);
            this.Controls.Add(this.txtFonte);
            this.Controls.Add(this.lblFonte);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.txtPlacaMae);
            this.Controls.Add(this.lblPlacaMae);
            this.Controls.Add(this.txtGabinete);
            this.Controls.Add(this.picBoxGabinete);
            this.Controls.Add(this.lblGabinete);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCriar);
            this.Name = "frmGestao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGabinete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCodigoBarras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblGabinete;
        private System.Windows.Forms.PictureBox picBoxGabinete;
        private System.Windows.Forms.TextBox txtGabinete;
        private System.Windows.Forms.TextBox txtPlacaMae;
        private System.Windows.Forms.Label lblPlacaMae;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.TextBox txtFonte;
        private System.Windows.Forms.Label lblFonte;
        private System.Windows.Forms.Label lblDicoRigido;
        private System.Windows.Forms.CheckBox chkHDD;
        private System.Windows.Forms.CheckBox chkSSD;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.TextBox txtGPU;
        private System.Windows.Forms.Label lblGPU;
        private System.Windows.Forms.TextBox txtTeclado;
        private System.Windows.Forms.Label lblTeclado;
        private System.Windows.Forms.TextBox txtMouse;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.CheckBox chk16Gb;
        private System.Windows.Forms.CheckBox chk8Gb;
        private System.Windows.Forms.Label lblMemoria;
        private System.Windows.Forms.CheckBox chk4Gb;
        private System.Windows.Forms.CheckBox chk2Gb;
        private System.Windows.Forms.ComboBox cBoxTipoMemoria;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.ComboBox cBoxTamanhoDisco;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCarregarImagem;
        private System.Windows.Forms.Button btnImprimirCodigoBarras;
        private System.Windows.Forms.PictureBox picBoxCodigoBarras;
        private System.Windows.Forms.Button btnCodBarras;
    }
}