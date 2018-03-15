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
    public partial class Centru_inchirieri_biciclete : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ANDREEA-PC;Initial Catalog=PROIECT_BD;Integrated Security=True");
        public Centru_inchirieri_biciclete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adaugare_bicicleta f2 = new Adaugare_bicicleta(this);
            f2.ShowDialog();
        }
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID_B, ID_S, Model, ID_P, ID_Sed, Pret from Bicicleta";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        public void display_data_ang()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select CNP, Nume, Prenume, Salariu from Angajat";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
        public void display_data_cl()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID_C, CNP, Nume, Prenume, Adresa, Varsta from Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        public void display_data_in()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Data_I, Data_S, Pret from Inchiriere";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            connection.Close();
        }
        public void display_data_promo()//de modificat
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Promotie";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            connection.Close();
        }
        public void display_data_sed()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID_Sed, Adresa, Nr_tel from Sediu";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            connection.Close();
        }
        public void display_data_serv()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select ID_S, Adresa, Nr_tel from Service";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView7.DataSource = dt;
            connection.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Adaugare_angajat f2 = new Adaugare_angajat(this);
            f2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet1.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter1.Fill(this.pROIECT_BDDataSet1.Client);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet1.Bicicleta' table. You can move, or remove it, as needed.
            this.bicicletaTableAdapter1.Fill(this.pROIECT_BDDataSet1.Bicicleta);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet1.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter1.Fill(this.pROIECT_BDDataSet1.Service);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet1.Sediu' table. You can move, or remove it, as needed.
            this.sediuTableAdapter1.Fill(this.pROIECT_BDDataSet1.Sediu);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Promotie' table. You can move, or remove it, as needed.
            this.promotieTableAdapter.Fill(this.pROIECT_BDDataSet.Promotie);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.pROIECT_BDDataSet.Client);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.pROIECT_BDDataSet.Service);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Sediu' table. You can move, or remove it, as needed.
            this.sediuTableAdapter.Fill(this.pROIECT_BDDataSet.Sediu);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Inchiriere' table. You can move, or remove it, as needed.
            this.inchiriereTableAdapter.Fill(this.pROIECT_BDDataSet.Inchiriere);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Angajat' table. You can move, or remove it, as needed.
            this.angajatTableAdapter.Fill(this.pROIECT_BDDataSet.Angajat);
            // TODO: This line of code loads data into the 'pROIECT_BDDataSet.Bicicleta' table. You can move, or remove it, as needed.
            this.bicicletaTableAdapter.Fill(this.pROIECT_BDDataSet.Bicicleta);
            display_data_ang();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Actualizare_angajat f2 = new Actualizare_angajat(this);
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 f2 = new Form5(this);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Actualizare_bicicleta f2 = new Actualizare_bicicleta(this);
            f2.ShowDialog();
        }

     

        private void button8_Click(object sender, EventArgs e)
        {
            display_data_cl();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Client values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_cl();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            MessageBox.Show("Clientul a fost adaugat.");
        }

     

        private void button10_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Client values('" + textBox10.Text + "','" + textBox9.Text + "','" + textBox8.Text + "','" + textBox7.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_in();
            textBox10.Text = "";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox7.Text = "";
            textBox6.Text = "";
            MessageBox.Show("Inchirierea a fost adaugata.");

        }

        private void button11_Click(object sender, EventArgs e)
        {
            display_data_in();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            display_data_promo();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Promotie values('" + textBox11.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_promo();
            textBox11.Text = "";
            MessageBox.Show("Promotia a fost adaugata.");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            display_data_sed();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Sediu values('" + textBox14.Text + "','" + textBox13.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_sed();
            textBox14.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Sediul a fost adaugat.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Sediu where ID_Sed='" + textBox18.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_sed();
            textBox18.Text = "";
            MessageBox.Show("Sediul a fost sters.");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            display_data_serv();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Service values('" + textBox19.Text + "','" + textBox17.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data_serv();
            textBox19.Text = "";
            textBox17.Text = "";
            MessageBox.Show("Service-ul a fost adaugat.");
        }

        

        private void button20_Click(object sender, EventArgs e)
        {
            display_data_ang();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Actualizare_sediu f2 = new Actualizare_sediu(this);
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizare_service f2 = new Actualizare_service(this);
            f2.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Promotie.ID_P, Promotie.Reducere FROM Promotie INNER JOIN Bicicleta ON Promotie.ID_P = Bicicleta.ID_P WHERE Bicicleta.Model='" + comboBox5.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            connection.Close();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Angajat.Nume, Angajat.Prenume FROM Angajat INNER JOIN Sediu ON Angajat.ID_Sed = Sediu.ID_Sed WHERE Sediu.Adresa = '"+comboBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Angajat.Salariu FROM Angajat INNER JOIN Sediu ON Angajat.ID_Sed = Sediu.ID_Sed WHERE Sediu.Adresa='"+comboBox2.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Bicicleta.Model FROM Bicicleta INNER JOIN Inchiriere ON Bicicleta.ID_B = Inchiriere.ID_B WHERE Inchiriere.Pret > '"+textBox15.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Client.Nume,Client.Prenume FROM Client INNER JOIN Inchiriere ON Client.ID_C = Inchiriere.ID_C WHERE Inchiriere.Pret > '"+textBox20.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Bicicleta.ID_B,Bicicleta.Model FROM Bicicleta INNER JOIN Service ON Bicicleta.ID_S = Service.ID_S WHERE Service.Adresa ='" + comboBox3.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Model,Pret FROM Bicicleta  WHERE Bicicleta.Pret = (SELECT MAX(Bicicleta.Pret) FROM Bicicleta)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Model,Pret FROM Bicicleta  WHERE Bicicleta.Pret = (SELECT MIN(Bicicleta.Pret) FROM Bicicleta)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Client.Nume,Client.Prenume ,Client.Varsta FROM Client WHERE Client.Varsta = (SELECT MIN(Client.Varsta) FROM Client)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Client.Nume,Client.Prenume ,Client.Varsta FROM Client WHERE Client.Varsta = (SELECT MAX(Client.Varsta) FROM Client)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Angajat.Nume,Angajat.Prenume,Angajat.Salariu FROM Angajat WHERE Angajat.Salariu = (SELECT MAX(Angajat.Salariu) FROM Angajat)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Angajat.Nume,Angajat.Prenume,Angajat.Salariu FROM Angajat WHERE Angajat.Salariu = (SELECT MIN(Angajat.Salariu) FROM Angajat)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Sediu.Adresa, Sediu.Nr_tel FROM Sediu INNER JOIN BICICLETA ON Sediu.ID_Sed=Bicicleta.ID_Sed WHERE Bicicleta.Model='"+comboBox4.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView6.DataSource = dt;
            connection.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Inchiriere WHERE Pret = (SELECT Max(Pret) FROM Inchiriere)";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            connection.Close();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Service.Adresa,Service.Nr_tel FROM Service INNER JOIN Bicicleta ON Service.ID_S=Bicicleta.ID_S WHERE Bicicleta.Model='"+comboBox6.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView7.DataSource = dt;
            connection.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT Client.Nume,Client.Prenume,Client.Adresa FROM Client  INNER JOIN  Inchiriere  ON Client.ID_C IN(SELECT Inchiriere.ID_C FROM Inchiriere INNER JOIN Bicicleta ON Inchiriere.ID_B=Bicicleta.ID_B WHERE Bicicleta.Model='"+comboBox7.Text+"')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT Inchiriere.Data_I, Inchiriere.Data_S, Inchiriere.Pret FROM Inchiriere JOIN Bicicleta ON Inchiriere.ID_B in(select Bicicleta.ID_B FROM Bicicleta JOIN Promotie ON Bicicleta.ID_P=Promotie.ID_P WHERE Promotie.Reducere>'" + textBox12.Text+"')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            connection.Close();
        }
    }
}
