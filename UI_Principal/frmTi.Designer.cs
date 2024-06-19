namespace SISTEMA_1._0.UI_Principal
{
    partial class frmTi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarioAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarioExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarioNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessorNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessorAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProfessorExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarioExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestaoTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArquivo,
            this.opçõesToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuMain";
            // 
            // menuArquivo
            // 
            this.menuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionario,
            this.menuProfessor,
            this.menuUsuario});
            this.menuArquivo.Name = "menuArquivo";
            this.menuArquivo.Size = new System.Drawing.Size(61, 20);
            this.menuArquivo.Text = "Arquivo";
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFuncionarioAlterar,
            this.menuFuncionarioExcluir,
            this.menuFuncionarioNovo});
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(137, 22);
            this.menuFuncionario.Text = "Funcionario";
            // 
            // menuFuncionarioAlterar
            // 
            this.menuFuncionarioAlterar.Name = "menuFuncionarioAlterar";
            this.menuFuncionarioAlterar.Size = new System.Drawing.Size(109, 22);
            this.menuFuncionarioAlterar.Text = "Alterar";
            this.menuFuncionarioAlterar.Click += new System.EventHandler(this.menuFuncionarioAlterar_Click);
            // 
            // menuFuncionarioExcluir
            // 
            this.menuFuncionarioExcluir.Name = "menuFuncionarioExcluir";
            this.menuFuncionarioExcluir.Size = new System.Drawing.Size(109, 22);
            this.menuFuncionarioExcluir.Text = "Excluir";
            this.menuFuncionarioExcluir.Click += new System.EventHandler(this.menuFuncionarioExcluir_Click);
            // 
            // menuFuncionarioNovo
            // 
            this.menuFuncionarioNovo.Name = "menuFuncionarioNovo";
            this.menuFuncionarioNovo.Size = new System.Drawing.Size(109, 22);
            this.menuFuncionarioNovo.Text = "Novo";
            this.menuFuncionarioNovo.Click += new System.EventHandler(this.menuFuncionarioNovo_Click);
            // 
            // menuProfessor
            // 
            this.menuProfessor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProfessorNovo,
            this.menuProfessorAlterar,
            this.menuProfessorExcluir});
            this.menuProfessor.Name = "menuProfessor";
            this.menuProfessor.Size = new System.Drawing.Size(137, 22);
            this.menuProfessor.Text = "Professor";
            // 
            // menuProfessorNovo
            // 
            this.menuProfessorNovo.Name = "menuProfessorNovo";
            this.menuProfessorNovo.Size = new System.Drawing.Size(109, 22);
            this.menuProfessorNovo.Text = "Novo";
            this.menuProfessorNovo.Click += new System.EventHandler(this.menuProfessorNovo_Click);
            // 
            // menuProfessorAlterar
            // 
            this.menuProfessorAlterar.Name = "menuProfessorAlterar";
            this.menuProfessorAlterar.Size = new System.Drawing.Size(109, 22);
            this.menuProfessorAlterar.Text = "Alterar";
            this.menuProfessorAlterar.Click += new System.EventHandler(this.menuProfessorAlterar_Click);
            // 
            // menuProfessorExcluir
            // 
            this.menuProfessorExcluir.Name = "menuProfessorExcluir";
            this.menuProfessorExcluir.Size = new System.Drawing.Size(109, 22);
            this.menuProfessorExcluir.Text = "Excluir";
            this.menuProfessorExcluir.Click += new System.EventHandler(this.menuProfessorExcluir_Click);
            // 
            // menuUsuario
            // 
            this.menuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarioNovo,
            this.menuUsuarioAlterar,
            this.menuUsuarioExcluir});
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(137, 22);
            this.menuUsuario.Text = "Usuario";
            // 
            // menuUsuarioNovo
            // 
            this.menuUsuarioNovo.Name = "menuUsuarioNovo";
            this.menuUsuarioNovo.Size = new System.Drawing.Size(109, 22);
            this.menuUsuarioNovo.Text = "Novo";
            this.menuUsuarioNovo.Click += new System.EventHandler(this.menuUsuarioNovo_Click);
            // 
            // menuUsuarioAlterar
            // 
            this.menuUsuarioAlterar.Name = "menuUsuarioAlterar";
            this.menuUsuarioAlterar.Size = new System.Drawing.Size(109, 22);
            this.menuUsuarioAlterar.Text = "Alterar";
            this.menuUsuarioAlterar.Click += new System.EventHandler(this.menuUsuarioAlterar_Click);
            // 
            // menuUsuarioExcluir
            // 
            this.menuUsuarioExcluir.Name = "menuUsuarioExcluir";
            this.menuUsuarioExcluir.Size = new System.Drawing.Size(109, 22);
            this.menuUsuarioExcluir.Text = "Excluir";
            this.menuUsuarioExcluir.Click += new System.EventHandler(this.menuUsuarioExcluir_Click);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestaoTIToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // gestaoTIToolStripMenuItem
            // 
            this.gestaoTIToolStripMenuItem.Name = "gestaoTIToolStripMenuItem";
            this.gestaoTIToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.gestaoTIToolStripMenuItem.Text = "Gestao TI";
            this.gestaoTIToolStripMenuItem.Click += new System.EventHandler(this.gestaoTIToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // frmTi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArquivo;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuProfessor;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarioAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarioExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuProfessorNovo;
        private System.Windows.Forms.ToolStripMenuItem menuProfessorAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuProfessorExcluir;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioNovo;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioAlterar;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarioExcluir;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarioNovo;
        private System.Windows.Forms.ToolStripMenuItem gestaoTIToolStripMenuItem;
    }
}