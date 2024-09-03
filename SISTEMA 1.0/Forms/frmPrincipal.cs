using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_1._0.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            //ThemeManager.ApplyTheme(this);
        }

        /*private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this); // Atualiza o tema caso o usuário altere o tema do Windows enquanto o formulário está aberto
        }*/

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Fechar toda a aplicação
            Application.Exit();
        }
    }
}
