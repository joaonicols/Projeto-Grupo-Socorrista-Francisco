using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        //Criando variáveis para controle do menu
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            //executando o método desabilitar campos
            desabilitarCampos();
        }

        public frmGerenciarUsuarios(string nome)
        {
            InitializeComponent();
            //executando o método desabilitar campos
            desabilitarCampos();
            txtUsuario.Text = nome;
        }

        //desabilitar campos
        public void desabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        //habilitar campos
        public void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }

        public void desabilitarCamposCadastrar()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnNovo.Enabled = true;
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();
        }

        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();
            txtUsuario.Focus();
            btnErro.Visible = false;
            btnChecked.Visible = false;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
           habilitarCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals("") || txtValidaSenha.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1
                    );
            }
            else
            {
                if(txtSenha.Text.Length < 12 || txtValidaSenha.Text.Length <12)
                {
                    MessageBox.Show("A senha tem que ser igual a 12 caracteres",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                }
                if (txtSenha.Text.Equals(txtValidaSenha.Text))
                {
                    if(cadastrarUsuarios(txtUsuario.Text, txtSenha.Text) == 1)
                    {
                        MessageBox.Show("Cadastrado com sucesso.",
                         "Mensagem do Sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1
                        );
                        desabilitarCamposCadastrar();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar.",
                            "Mensagem do sistema",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1
                            );
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não são iguais.",
                        "Mensagem do sistema",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1
                        );
                    txtSenha.Clear();
                    txtValidaSenha.Clear();
                    txtSenha.Focus();
                }
            }
        }

        private void txtValidaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtValidaSenha.Text))
            {
                btnChecked.Visible = true;
                btnChecked.Enabled = true;
                btnErro.Enabled = false;
                btnErro.Visible = false;
            }
            else
            {
                if(txtValidaSenha.Text.Length == 12)
                {
                    btnErro.Enabled = true;
                    btnChecked.Visible = false;
                    btnErro.Visible = true;
                    btnChecked.Enabled = false;
                }
                else
                {
                    btnErro.Enabled = false;
                    btnChecked.Visible = false;
                    btnErro.Visible = false;
                    btnChecked.Enabled = false;
                }
            }
        }
        
        //criar o crud da janela usuários

        //
        public int cadastrarUsuarios(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome, senha)values(@nome, @senha);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        //buscar usuários cadastrados
        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select nome from tbUsuarios order by nome asc;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            

            cbbUsuariosCadastrados.Items.Clear();

            while (DR.Read())
            {
                cbbUsuariosCadastrados.Items.Add(DR.GetString(0));
            }

            Conexao.fecharConexao();

        }

        //método alterar usuário
        public void alterarUsuarios()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome = @nome, senha = @senha' where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            //comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = ;

            comm.Connection = Conexao.obterConexao();

            Conexao.fecharConexao();
        }

        //busca usuário por código
        public void buscaUsuarioCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codusu = 1;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            txtCodigo.Text = DR.GetString(0);
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);
            Conexao.fecharConexao();
        }

        private void cbbUsuariosCadastrados_Click(object sender, EventArgs e)
        {
            buscarUsuariosCadastrados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuario abrir = new frmPesquisarUsuario();
            abrir.Show();
            this.Hide();
        }
    }
}
