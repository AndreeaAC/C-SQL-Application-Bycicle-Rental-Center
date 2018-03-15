using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class Actualizare_service : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ANDREEA-PC;Initial Catalog=PROIECT_BD;Integrated Security=True");
        private Centru_inchirieri_biciclete form1;
        public Actualizare_service(Centru_inchirieri_biciclete form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Service set Adresa='" + textBox14.Text + "', Nr_tel='" + textBox13.Text + "' where ID_S='" + textBox15.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            form1.display_data_serv();
            textBox15.Text = "";
            textBox14.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Service-ul a fost actualizat.");
        }
    }
}
