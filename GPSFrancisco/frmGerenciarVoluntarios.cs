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

        public int cadastrarAtribuicoes(string nome, string email, string telCel, string endereco, string numero, string cep, string bairro, string cidade, string estado, int codAtr, DateTime data,  DateTime hora,  int status)
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
            comm.Parameters.Add("@nome", MySqlDbType.Int32).Value = codAtr;
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
    }
}
