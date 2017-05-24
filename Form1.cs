using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace TCPklient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void polacz_Click(object sender, EventArgs e)
        {
            string host = Adres.Text;
            int port = Convert.ToInt16(my_port.Value);
            //lapiemy wyjatki w try to co chcemy wykonac, a program bedzie 

            try
            {
                TcpClient klient = new TcpClient();
                info_o_polaczeniu.Items.Add("Nawiązano połączenie z " + host + " na porcie " + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                info_o_polaczeniu.Items.Add("Błąd: " + "Nie udalo sie nawiazac polaczenia");
                MessageBox.Show(ex.ToString(), "Błąd");
            }
        }
    }
}
