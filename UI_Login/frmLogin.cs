using MySql.Data.MySqlClient;
using SISTEMA_1._0.DAL;
using SISTEMA_1._0.UI_Principal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_1._0
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string senha = txtSenha.Text.Trim();

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (MySqlConnection connMySQL = DAL_Conn.GetConnectionMySQL())
            {
                try
                {
                    connMySQL.Open();
                    // Exemplo de consulta para autenticar o usuário
                    string query = "SELECT COUNT(*) FROM usuarios WHERE nome=@nome AND senha=@senha";
                    MySqlCommand cmd = new MySqlCommand(query, connMySQL);
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Login realizado com sucesso!");
                        // Aqui você pode abrir o próimo formulário ou realizar outras operações após o login
                        frmTi form = new frmTi();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Nome de usuário ou senha incorretos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
