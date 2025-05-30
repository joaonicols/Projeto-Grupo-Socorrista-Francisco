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

        public int cadastrarAtribuicoes(string nome, string email, string telCel, string endereco, string numero, string cep, string bairro, string cidade, string estado, DateTime data,  DateTime hora,  int status)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome, email, telCel, endereco, numero, cep, bairro, cidade, estado, codAtr, data, hora, status) values (@nome, @email, @telCel, @endereco, @numero, @cep, @bairro, @cidade, @estado, @codAtr, @data, @hora, @status);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@nome", MySqlDbType.Int32).Value = codigoAtribuicao;
            comm.Parameters.Add("@nome", MySqlDbType.Date, 100).Value = data;
            comm.Parameters.Add("@nome", MySqlDbType.Time, 100).Value = hora;
            comm.Parameters.Add("@nome", MySqlDbType.Bit, 100).Value = status;

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
            int codigoAtribuicao = buscaCodigoAtribuicoes(cbbAtribuicoes.SelectedItem.ToString());
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
            mtbTelefone.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHoras.Enabled = true;
            ckbAtivo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
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

        }
    }
}
