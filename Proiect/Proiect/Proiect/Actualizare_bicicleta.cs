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
    public partial class Actualizare_bicicleta : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ANDREEA-PC;Initial Catalog=PROIECT_BD;Integrated Security=True");
        private Centru_inchirieri_biciclete form1;
        public Actualizare_bicicleta(Centru_inchirieri_biciclete form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Bicicleta set Pret='" + textBox2.Text + "' where Model='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            form1.display_data();
            MessageBox.Show("Pretul bicicletei a fost actualizat.");
        }
    }
}
