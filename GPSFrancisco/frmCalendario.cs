using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void cldCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Data Selecionada: Start = " + e.Start.ToShortDateString() + " : Final = " + e.End.ToShortDateString();
        }

        private void cldCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Data Selecionada: Start = " + e.Start.ToShortDateString() + " : Final = " + e.End.ToShortDateString();
        }

        private void btnCarregarData_Click(object sender, EventArgs e)
        {
            //DateTime dt = new DateTime();
            DateTime dtNow = new DateTime(2025, 06, 09, 09, 47, 06);
            DateTime dtUtcNow = new DateTime(2025, 06, 09);

            MessageBox.Show("Hora atual:" + dtNow + " Hora local:" + dtUtcNow);
        }
    }
}
