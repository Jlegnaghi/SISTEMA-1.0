using MySql.Data.MySqlClient;
using SISTEMA_1._0.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_1._0.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            // Conectar ao banco de dados e validar o login
            using (MySqlConnection conn = Data_Layer.DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha); // Lembre-se que a senha deve ser criptografada no banco de dados

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login bem-sucedido
                        MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Aqui você pode abrir outra janela ou continuar para o próximo passo
                        frmPrincipal mainForm = new frmPrincipal();
                        mainForm.Show();

                        // Fechar o formulário de login (opcional)
                        this.Hide();  // Ou this.Close();
                    }
                    else
                    {
                        // Falha no login
                        MessageBox.Show("Login ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Fecha a aplicação
            Application.Exit();
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é a tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Impede o som de beep padrão do Enter
                e.SuppressKeyPress = true;

                // Chama o método para realizar o login
                btnEntrar_Click(sender, e);
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada é a tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Impede o som de beep padrão do Enter
                e.SuppressKeyPress = true;

                // Chama o método para realizar o login
                btnEntrar_Click(sender, e);
            }
        }
    }
}