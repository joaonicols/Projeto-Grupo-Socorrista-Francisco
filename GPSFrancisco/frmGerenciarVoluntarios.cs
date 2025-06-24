using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MosaicoSolutions.ViaCep;
using System.IO;

namespace GPSFrancisco
{
    public partial class frmGerenciarVoluntarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarVoluntarios()
        {
            InitializeComponent();
            carregaAtribuicoes();
            desabilitarCamposNovo();
        }

        //criando método construtor com parâmetros
        public frmGerenciarVoluntarios(string nome)
        {
            InitializeComponent();
            carregaAtribuicoes();
            desabilitarCamposNovo();
            txtNome.Text = nome;
            carregaVoluntariosPorNome(txtNome.Text);
        }

        private void frmGerenciarVoluntarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        public int cadastrarVoluntarios(string nome, string email, string telCel, string endereco, string numero, string cep, string complemento, string bairro, string cidade, string estado, int codAtr, DateTime data,  DateTime hora,  int status, long foto)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome, email, telCel, endereco, numero, cep, complemento, bairro, cidade, estado, codAtr, data, hora, status, fotos) values (@nome, @email, @telCel, @endereco, @numero, @cep, @complemento, @bairro, @cidade, @estado, @codAtr, @data, @hora, @status, @fotos);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@complemento", MySqlDbType.VarChar, 100).Value = complemento;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codigoAtribuicao;
            comm.Parameters.Add("@data", MySqlDbType.DateTime, 100).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.DateTime, 100).Value = hora;
            comm.Parameters.Add("@status", MySqlDbType.Bit, 100).Value = status;
            comm.Parameters.Add("@fotos", MySqlDbType.LongBlob).Value = foto;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        //buscando atribuições para carregar na ComboBox
        public void carregaAtribuicoes()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbAtribuicoes order by nome;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read())
            {
                cbbAtribuicoes.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();
        }

        //buscando código da atribuição carregada na combo
        public int buscaCodigoAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codAtr from tbAtribuicoes where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            int codAtr = DR.GetInt32(0);
            Conexao.fecharConexao();

            return codAtr;
        }

        int codigoAtribuicao;
        private void cbbAtribuicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoAtribuicao = buscaCodigoAtribuicoes(cbbAtribuicoes.SelectedItem.ToString());
        }

        //desabilitar campos
        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            mtbCEP.Enabled = false;
            txtComplemento.Enabled = false;
            mtbTelefone.Enabled = false;
            cbbAtribuicoes.Enabled = false;
            cbbEstado.Enabled = false;
            dtpData.Enabled = false;
            dtpHoras.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            ckbAtivo.Enabled = false;
        }

        //habilitar campos
        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            mtbCEP.Enabled = true;
            txtComplemento.Enabled = true;
            mtbTelefone.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHoras.Enabled = true;
            ckbAtivo.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }

        //habilitar campos ALTERAR
        public void habilitarCamposAlterar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            mtbCEP.Enabled = true;
            txtComplemento.Enabled = true;
            mtbTelefone.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHoras.Enabled = true;
            ckbAtivo.Enabled = false;
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            txtNome.Focus();
        }

        //desabilitar campos
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            mtbCEP.Clear();
            txtComplemento.Clear();
            mtbTelefone.Clear();
            cbbAtribuicoes.Text = "";
            cbbEstado.Text = "";
            dtpData.Value = DateTime.Now;
            dtpHoras.Value = DateTime.Now;
            ckbAtivo.Checked = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
            desabilitarCamposNovo();            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //verificando se os campos foram preenchidos
            if(txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mtbTelefone.Text.Equals("(  )      -") || txtEndereco.Text.Equals("") || txtNumero.Text.Equals("")  || mtbCEP.Text.Equals("     -") || txtComplemento.Text.Equals ("") || txtBairro.Text.Equals("") || txtCidade.Text.Equals("") || cbbEstado.Text.Equals("") || cbbAtribuicoes.Text.Equals("") || ckbAtivo.Checked == false)
            {
                MessageBox.Show("Favor preencher os campos",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                txtNome.Focus();
            }
            else
            {
                int status = 0;
                if(ckbAtivo.Checked)
                {
                    status = 1;
                }
                else
                {
                    status = 0;
                }
                if (cadastrarVoluntarios(txtNome.Text, txtEmail.Text, mtbTelefone.Text, txtEndereco.Text, txtNumero.Text, mtbCEP.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, cbbEstado.Text, codigoAtribuicao, Convert.ToDateTime(dtpData.Text), Convert.ToDateTime(dtpHoras.Text), status, salvarFotos().LongLength) == 1)
                {
                    MessageBox.Show("Cadastrado com sucesso.",
                        "Mensagem do sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCamposNovo();
                }


            }
        }

        //criando o método busca cep
        public void buscaCEP(string cep)
        {
            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(cep);

                txtEndereco.Text = endereco.Logradouro.ToString();
                txtCidade.Text = endereco.Localidade.ToString();
                txtBairro.Text = endereco.Bairro.ToString();
                cbbEstado.Text = endereco.UF.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("CEP não encontrado.",
                     "Mensagem do sistema",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error,
                     MessageBoxDefaultButton.Button1);
                mtbCEP.Text = "";
                mtbCEP.Focus();
            }
        }

        //buscar voluntarios alterar/deletar
        public void carregaVoluntariosPorNome(string nome)
        {
            bool status = false;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntarios as vol inner join tbAtribuicoes as atr on vol.codAtr = atr.codAtr where vol.nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            if (DR.GetInt32(14) == 1)
            {
                status = true; 
            }
            if (DR.GetInt32(14) == 0)
            {
                status = false;
            }

            byte[] imageData = (byte[])DR.GetValue(16);
            MemoryStream ms = new MemoryStream(imageData);

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mtbTelefone.Text = DR.GetString(3);
            txtEndereco.Text = DR.GetString(4);
            txtNumero.Text = DR.GetString(5);
            mtbCEP.Text = DR.GetString(6);
            txtComplemento.Text = DR.GetString(7);
            txtBairro.Text = DR.GetString(8);
            txtCidade.Text = DR.GetString(9);
            cbbEstado.Text = DR.GetString(10);
            codigoAtribuicao = DR.GetInt32(14);
            dtpData.Value = DR.GetDateTime(12);
            dtpHoras.Value = DR.GetDateTime(13);
            ckbAtivo.Checked = status;
            cbbAtribuicoes.Text = DR.GetString(17);

            Conexao.fecharConexao();

            habilitarCamposAlterar();
        }

        //alterar voluntários
        public int alterarVoluntarios(string nome) 
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("", MySqlDbType.Int32).Value = nome;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        //excluir voluntários
        public int excluirVoluntarios(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbVoluntarios where codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;
            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }


        private void mtbCEP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mtbCEP.Text);
                txtNumero.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios abrir = new frmPesquisarVoluntarios();
            abrir.Show();
            this.Hide();
        }

        public byte[] salvarFotos()
        {
            byte[] imagem_byte = null;

            FileStream fs = new FileStream(enderecoFoto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);
            return imagem_byte;
        }


        string enderecoFoto;
        private void btnInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                enderecoFoto = foto;
                pcbFotoVoluntario.ImageLocation = foto;
                txtNome.Focus();
                

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int resp = alterarVoluntarios(txtNome.Text);
            if(resp == 1)
            {
                MessageBox.Show("Alterado com sucesso!!!",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("Erro ao alterar.",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
              DialogResult result = MessageBox.Show("Deseja excluir?",
                "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                int resp = excluirVoluntarios(Convert.ToInt32(txtCodigo.Text));

                if (resp == 1)
                {
                    MessageBox.Show("Excluído com sucesso!!!",
                        "Mensagem do Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1);
                    limparCampos();
                    desabilitarCamposNovo();
                }

                else
                {
                    MessageBox.Show("Erro ao excluir",
                        "Mensagem do sistema",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error,
                         MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                limparCampos();
                desabilitarCamposNovo();
                btnNovo.Enabled = true;
            }
        }
    }
}
