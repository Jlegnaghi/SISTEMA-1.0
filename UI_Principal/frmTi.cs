using SISTEMA_1._0.UI_Funcionario;
using SISTEMA_1._0.UI_Professor;
using SISTEMA_1._0.UI_Usuario;
using SISTEMA_1._0.UI_Gestao_TI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_1._0.UI_Principal
{
    public partial class frmTi : Form
    {
        public frmTi()
        {
            InitializeComponent();
        }

        private void menuFuncionarioNovo_Click(object sender, EventArgs e)
        {
            frmAddFuncionario form = new frmAddFuncionario();
            form.Show();
        }

        private void menuFuncionarioAlterar_Click(object sender, EventArgs e)
        {
            frmAddFuncionario form = new frmAddFuncionario();
            form.Show();
        }

        private void menuFuncionarioExcluir_Click(object sender, EventArgs e)
        {
            frmDelFuncionario form = new frmDelFuncionario();
            form.Show();
        }

        private void menuProfessorNovo_Click(object sender, EventArgs e)
        {
            frmAddProfessor form = new frmAddProfessor();
            form.Show();
        }

        private void menuProfessorAlterar_Click(object sender, EventArgs e)
        {
            frmAltProfessor form = new frmAltProfessor();
            form.Show();
        }

        private void menuProfessorExcluir_Click(object sender, EventArgs e)
        {
            frmDelProfessor form = new frmDelProfessor();
            form.Show();
        }

        private void menuUsuarioNovo_Click(object sender, EventArgs e)
        {
            frmAddUsuario form = new frmAddUsuario();
            form.Show();
        }

        private void menuUsuarioAlterar_Click(object sender, EventArgs e)
        {
            frmAltUsuario form = new frmAltUsuario();
            form.Show();
        }

        private void menuUsuarioExcluir_Click(object sender, EventArgs e)
        {
            frmDelUsuario form = new frmDelUsuario();
            form.Show();
        }

        private void gestaoTIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestao form = new frmGestao();
            form.Show();
        }
    }
}
