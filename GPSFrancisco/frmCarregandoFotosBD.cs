using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmCarregandoFotosBD : Form
    {
        public frmCarregandoFotosBD()
        {
            InitializeComponent();
            Desabilitarcampos();
        }

        private void btnInserirFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                txtBuscaFotos.Text = foto;
                pctFotos.ImageLocation = foto;
            }
            habilitarCampos();
        }

        private void btnSalvarFotos_Click(object sender, EventArgs e)
        {
            if (pctFotos.Image != null)
            {
                byte[] imagem_byte = null;

                FileStream fs = new FileStream(this.txtBuscaFotos.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader(fs);

                imagem_byte = br.ReadBytes((int)fs.Length);

                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbfotos(nome, campo_imagem)values(@nome, @campo_imagem);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();
                comm.Parameters.Add("@campo_imagem", MySqlDbType.LongBlob).Value = imagem_byte;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;

                comm.Connection = Conexao.obterConexao();

                int resp = comm.ExecuteNonQuery();

                MessageBox.Show("Foto salva no banco de dados!!!" + resp);
                Desabilitarcampos();
                
                Conexao.fecharConexao();
            }
            else
            {
                MessageBox.Show("Favor inserir um texto ou uma imagem",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        public void Desabilitarcampos()
        {
            txtNome.Enabled = false;
            txtBuscaFotos.Enabled = false;
            pctFotos.Enabled = false;
            btnLimpar.Enabled = false;
            btnSalvarFotos.Enabled = false;
            btnPesquisar.Enabled = false;
            btnInserirFotos.Focus();

        }

        public void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtBuscaFotos.Enabled = true;
            pctFotos.Enabled = true;
            btnLimpar.Enabled = true;
            btnSalvarFotos.Enabled = true;
            btnPesquisar.Enabled = true;
            btnInserirFotos.Focus();
        }



    }
}
