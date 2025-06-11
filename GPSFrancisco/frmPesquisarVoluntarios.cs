using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
            Desabilitarcampos();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisar.SelectedItem.ToString();

            frmGerenciarVoluntarios abrir = new frmGerenciarVoluntarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == false && rdbNome.Checked == false)
            {
                MessageBox.Show("Favor selecionar um item.",
                    "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else if (txtDescricao.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um valor",
                "Mensagem do Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtDescricao.Focus();
            }
            else
            {
                if(rdbCodigo.Checked)
                {
                    buscaVoluntarioPorCodigo(Convert.ToInt32(txtDescricao.Text));
                }
                if (rdbNome.Checked)
                {
                    buscaVoluntarioPorNome(txtDescricao.Text);
                }
            }       
        }

        //busca voluntários por código
        public void buscaVoluntarioPorCodigo(int codVol)
        { 
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbvoluntarios where codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisar.Items.Clear();
            ltbPesquisar.Items.Add(DR.GetInt32(0));

            Conexao.fecharConexao();
        }

        //busca voluntários por nome
        public void buscaVoluntarioPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbvoluntarios where nome like '%" + nome + "%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            
            ltbPesquisar.Items.Clear();
            while (DR.Read())
            {
                ltbPesquisar.Items.Add(DR.GetString(1));
            }
         
            Conexao.fecharConexao();
        }

        public void Limparcampos()
        {
            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
        }

        public void Desabilitarcampos()
        {
            txtDescricao.Enabled = false;
            ltbPesquisar.Enabled = false;
            btnLimpar.Enabled = false;
            btnPesquisar.Enabled = false;
        }

        public void Habilitarcampos()
        {
            txtDescricao.Enabled = true;
            ltbPesquisar.Enabled = true;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;

        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked == true)
            {
                Habilitarcampos();
            }
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true)
            {
                Habilitarcampos();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limparcampos();
        }
    }
}