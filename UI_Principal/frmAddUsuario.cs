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
    public partial class frmAddUsuario : Form
    {
        public frmAddUsuario()
        {
            InitializeComponent();
        }

        private void niveis_acessoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.niveis_acessoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuariosDataSet);

        }

        private void frmAddUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'usuariosDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.usuariosDataSet.usuarios);
            // TODO: esta linha de código carrega dados na tabela 'usuariosDataSet.usuarios'. Você pode movê-la ou removê-la conforme necessário.
            this.usuariosTableAdapter.Fill(this.usuariosDataSet.usuarios);
            // TODO: esta linha de código carrega dados na tabela 'usuariosDataSet.niveis_acesso'. Você pode movê-la ou removê-la conforme necessário.
            this.niveis_acessoTableAdapter.Fill(this.usuariosDataSet.niveis_acesso);

        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.usuariosDataSet);

        }
    }
}
