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

namespace ClientTSP
{
    public partial class Przycisk : Form
    {
        public Przycisk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Polaczenie_Click(object sender, EventArgs e)
        {
            string host = Adress.Text;
            int port = System.Convert.ToInt32(port_p.Value);

            try
            {
                TcpClient klient = new TcpClient(host, port);

                listBox1.Items.Add("Nawiazano polaczenie z" + host + "na porcie:" + port);
                klient.Close();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Blad:Nie udało się nawiazac polaczenia!");
                MessageBox.Show(ex.ToString(), "Blad");
            }
        }
    }
}
