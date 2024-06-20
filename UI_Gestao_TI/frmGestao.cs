using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SISTEMA_1._0.DAL;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using ZXing.Rendering;

namespace SISTEMA_1._0.UI_Gestao_TI
{
    public partial class frmGestao : Form
    {
        public frmGestao()
        {
            InitializeComponent();
        }


        private void chkHDD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSSD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTamanhoDisco_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chk2Gb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk4Gb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk8Gb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk16Gb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBoxTipoMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DAL_Conn.GetConnectionMySQL())
                {
                    conn.Open();

                    string query = @"INSERT INTO computadores 
                            (Gabinete, PlacaMae, CPU, Fonte, Monitor, Mouse, Teclado, GPU, Setor, TipoDisco, TamanhoDisco, TipoMemoria, TamanhoMemoria, ImagemGabinete, CodigoBarras)
                            VALUES (@Gabinete, @PlacaMae, @CPU, @Fonte, @Monitor, @Mouse, @Teclado, @GPU, @Setor, @TipoDisco, @TamanhoDisco, @TipoMemoria, @TamanhoMemoria, @ImagemGabinete, @CodigoBarras);
                            SELECT LAST_INSERT_ID();";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Gabinete", txtGabinete.Text);
                    cmd.Parameters.AddWithValue("@PlacaMae", txtPlacaMae.Text);
                    cmd.Parameters.AddWithValue("@CPU", txtCPU.Text);
                    cmd.Parameters.AddWithValue("@Fonte", txtFonte.Text);
                    cmd.Parameters.AddWithValue("@Monitor", txtMonitor.Text);
                    cmd.Parameters.AddWithValue("@Mouse", txtMouse.Text);
                    cmd.Parameters.AddWithValue("@Teclado", txtTeclado.Text);
                    cmd.Parameters.AddWithValue("@GPU", txtGPU.Text);
                    cmd.Parameters.AddWithValue("@Setor", txtSetor.Text);

                    string tipoDisco = chkHDD.Checked ? "HDD" : (chkSSD.Checked ? "SSD" : "");
                    cmd.Parameters.AddWithValue("@TipoDisco", tipoDisco);

                    string tamanhoDisco = cBoxTamanhoDisco.SelectedItem?.ToString();
                    cmd.Parameters.AddWithValue("@TamanhoDisco", tamanhoDisco);

                    string tipoMemoria = cBoxTipoMemoria.SelectedItem?.ToString();
                    cmd.Parameters.AddWithValue("@TipoMemoria", tipoMemoria);

                    string tamanhoMemoria = GetSelectedMemory();
                    cmd.Parameters.AddWithValue("@TamanhoMemoria", tamanhoMemoria);

                    byte[] imagemGabinete = null;
                    if (picBoxGabinete.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picBoxGabinete.Image.Save(ms, picBoxGabinete.Image.RawFormat);
                            imagemGabinete = ms.ToArray();
                        }
                    }
                    cmd.Parameters.AddWithValue("@ImagemGabinete", imagemGabinete);

                    cmd.Parameters.AddWithValue("@CodigoBarras", DBNull.Value);

                    int lastInsertedId = Convert.ToInt32(cmd.ExecuteScalar());

                    string codigoBarras = "CB" + lastInsertedId.ToString("D6");

                    string updateQuery = @"UPDATE computadores SET CodigoBarras = @CodigoBarras WHERE ID = @ID";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@CodigoBarras", codigoBarras);
                    updateCmd.Parameters.AddWithValue("@ID", lastInsertedId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Computador registrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar computador: " + ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DAL_Conn.GetConnectionMySQL())
                {
                    conn.Open();

                    string query = @"UPDATE computadores 
                             SET Gabinete = @Gabinete, PlacaMae = @PlacaMae, CPU = @CPU, Fonte = @Fonte, Monitor = @Monitor, 
                                 Mouse = @Mouse, Teclado = @Teclado, GPU = @GPU, Setor = @Setor, TipoDisco = @TipoDisco, TamanhoDisco = @TamanhoDisco,
                                 TipoMemoria = @TipoMemoria, TamanhoMemoria = @TamanhoMemoria, ImagemGabinete = @ImagemGabinete
                             WHERE CodigoBarras = @CodigoBarras";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Gabinete", txtGabinete.Text);
                    cmd.Parameters.AddWithValue("@PlacaMae", txtPlacaMae.Text);
                    cmd.Parameters.AddWithValue("@CPU", txtCPU.Text);
                    cmd.Parameters.AddWithValue("@Fonte", txtFonte.Text);
                    cmd.Parameters.AddWithValue("@Monitor", txtMonitor.Text);
                    cmd.Parameters.AddWithValue("@Mouse", txtMouse.Text);
                    cmd.Parameters.AddWithValue("@Teclado", txtTeclado.Text);
                    cmd.Parameters.AddWithValue("@GPU", txtGPU.Text);
                    cmd.Parameters.AddWithValue("@Setor", txtSetor.Text);

                    string tipoDisco = chkHDD.Checked ? "HDD" : (chkSSD.Checked ? "SSD" : "");
                    cmd.Parameters.AddWithValue("@TipoDisco", tipoDisco);

                    string tamanhoDisco = cBoxTamanhoDisco.SelectedItem?.ToString();
                    cmd.Parameters.AddWithValue("@TamanhoDisco", tamanhoDisco);

                    string tipoMemoria = cBoxTipoMemoria.SelectedItem?.ToString();
                    cmd.Parameters.AddWithValue("@TipoMemoria", tipoMemoria);

                    string tamanhoMemoria = GetSelectedMemory();
                    cmd.Parameters.AddWithValue("@TamanhoMemoria", tamanhoMemoria);

                    byte[] imagemGabinete = null;
                    if (picBoxGabinete.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picBoxGabinete.Image.Save(ms, picBoxGabinete.Image.RawFormat);
                            imagemGabinete = ms.ToArray();
                        }
                    }
                    cmd.Parameters.AddWithValue("@ImagemGabinete", imagemGabinete);

                    cmd.Parameters.AddWithValue("@CodigoBarras", txtID.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Computador atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar computador: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = DAL_Conn.GetConnectionMySQL())
                {
                    conn.Open();

                    string query = @"DELETE FROM computadores WHERE CodigoBarras = @CodigoBarras";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CodigoBarras", txtID.Text.Trim());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Computador excluído com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir computador: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtGabinete.Text = string.Empty;
            txtPlacaMae.Text = string.Empty;
            txtCPU.Text = string.Empty;
            txtFonte.Text = string.Empty;
            txtMonitor.Text = string.Empty;
            txtMouse.Text = string.Empty;
            txtTeclado.Text = string.Empty;
            txtGPU.Text = string.Empty;
            txtSetor.Text = string.Empty;

            chkHDD.Checked = false;
            chkSSD.Checked = false;
            cBoxTamanhoDisco.SelectedIndex = -1;
            chk2Gb.Checked = false;
            chk4Gb.Checked = false;
            chk8Gb.Checked = false;
            chk16Gb.Checked = false;
            cBoxTipoMemoria.SelectedIndex = -1;

            picBoxGabinete.Image = null;

            MessageBox.Show("Campos cancelados e limpos.");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string codigoBarras = txtID.Text.Trim();

            if (string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Por favor, digite um código de barras para pesquisar.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DAL_Conn.GetConnectionMySQL())
                {
                    conn.Open();

                    string query = @"SELECT * FROM computadores WHERE CodigoBarras = @CodigoBarras";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CodigoBarras", codigoBarras);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtGabinete.Text = reader["Gabinete"].ToString();
                        txtPlacaMae.Text = reader["PlacaMae"].ToString();
                        txtCPU.Text = reader["CPU"].ToString();
                        txtFonte.Text = reader["Fonte"].ToString();
                        txtMonitor.Text = reader["Monitor"].ToString();
                        txtMouse.Text = reader["Mouse"].ToString();
                        txtTeclado.Text = reader["Teclado"].ToString();
                        txtGPU.Text = reader["GPU"].ToString();
                        txtSetor.Text = reader["Setor"].ToString();

                        string tipoDisco = reader["TipoDisco"].ToString();
                        chkHDD.Checked = (tipoDisco == "HDD");
                        chkSSD.Checked = (tipoDisco == "SSD");

                        cBoxTamanhoDisco.SelectedItem = reader["TamanhoDisco"].ToString();

                        string tipoMemoria = reader["TipoMemoria"].ToString();
                        cBoxTipoMemoria.SelectedItem = tipoMemoria;

                        string tamanhoMemoria = reader["TamanhoMemoria"].ToString();
                        switch (tamanhoMemoria)
                        {
                            case "2GB":
                                chk2Gb.Checked = true;
                                break;
                            case "4GB":
                                chk4Gb.Checked = true;
                                break;
                            case "8GB":
                                chk8Gb.Checked = true;
                                break;
                            case "16GB":
                                chk16Gb.Checked = true;
                                break;
                        }

                        if (reader["ImagemGabinete"] != DBNull.Value)
                        {
                            byte[] imagemGabinete = (byte[])reader["ImagemGabinete"];
                            using (MemoryStream ms = new MemoryStream(imagemGabinete))
                            {
                                picBoxGabinete.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            picBoxGabinete.Image = null;
                        }

                        MessageBox.Show("Computador encontrado!");
                    }
                    else
                    {
                        MessageBox.Show("Computador com o código de barras especificado não foi encontrado.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar computador: " + ex.Message);
            }
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Arquivos de Imagem (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
                dialog.Title = "Selecione uma imagem do gabinete";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = dialog.FileName;
                    picBoxGabinete.Image = Image.FromFile(imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
        }

        private void btnImprimirCodigoBarras_Click(object sender, EventArgs e)
        {
            string codigoBarras = txtID.Text.Trim();

            if (string.IsNullOrEmpty(codigoBarras))
            {
                MessageBox.Show("Por favor, pesquise um computador para imprimir o código de barras.");
                return;
            }

            try
            {
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.CODE_128,
                    Options = new ZXing.Common.EncodingOptions
                    {
                        Width = 300,
                        Height = 100
                    }
                };

                using (Bitmap bitmap = writer.Write(codigoBarras))
                {
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += (s, ev) =>
                    {
                        ev.Graphics.DrawImage(bitmap, new Point(0, 0));
                    };
                    PrintDialog printDialog = new PrintDialog
                    {
                        Document = printDoc
                    };

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDoc.Print();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao imprimir código de barras: " + ex.Message);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Salva a imagem em formato JPEG para evitar problemas com GDI+
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private string GetSelectedMemory()
        {
            if (chk2Gb.Checked) return "2GB";
            if (chk4Gb.Checked) return "4GB";
            if (chk8Gb.Checked) return "8GB";
            if (chk16Gb.Checked) return "16GB";
            return string.Empty;
        }

        private string GenerateUniqueBarcode()
        {
            // Aqui você pode implementar lógica para gerar um código de barras único, por exemplo, usando um GUID
            return Guid.NewGuid().ToString().Substring(0, 12); // Exemplo simples usando parte de um GUID
        }

        private bool ComputerExists(MySqlConnection conn, int id)
        {
            string query = "SELECT COUNT(*) FROM computadores WHERE ID = @ID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", id);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

        private void LimparCampos()
        {
            // Implemente a lógica para limpar todos os campos do formulário
            txtID.Text = "";
            txtGabinete.Text = "";
            txtPlacaMae.Text = "";
            txtCPU.Text = "";
            txtFonte.Text = "";
            txtMonitor.Text = "";
            txtMouse.Text = "";
            txtTeclado.Text = "";
            txtGPU.Text = "";
            txtSetor.Text = "";
            chkHDD.Checked = false;
            chkSSD.Checked = false;
            chk2Gb.Checked = false;
            chk4Gb.Checked = false;
            chk8Gb.Checked = false;
            chk16Gb.Checked = false;
            cBoxTamanhoDisco.SelectedIndex = -1;
            picBoxGabinete.Image = null;
        }

        private void picBoxCodigoBarras_Click(object sender, EventArgs e)
        {

        }

        private void btnCodBarras_Click(object sender, EventArgs e)
        {
            
        }
    }
}