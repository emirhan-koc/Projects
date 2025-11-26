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

namespace kayıtEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection bag = new SqlConnection("server = localhost\\SQLEXPRESS; database = DB_1; Integrated Security = true");

        void listele()
        {
            SqlCommand komut = new SqlCommand("SELECT * FROM KAYIT", bag);
            SqlDataAdapter adp = new SqlDataAdapter(komut);
            DataTable table = new DataTable();
            bag.Open();
            adp.Fill(table);
            bag.Close();
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO KAYIT (NUMARA, AD, ADRES, BÖLÜM, MAAŞ) VALUES (@num, @ad, @adr, @bol, @m)", bag);
            komut.Parameters.AddWithValue("@num", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@adr", textBox5.Text);
            komut.Parameters.AddWithValue("@bol", textBox3.Text);
            komut.Parameters.AddWithValue("@m", textBox4.Text);
            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE FROM KAYIT WHERE NUMARA = @num", bag);
            komut.Parameters.AddWithValue("@num", textBox1.Text);

            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE KAYIT SET AD = @ad, ADRES = @adr, BÖLÜM = @bol, MAAŞ = @m WHERE NUMARA = @num", bag);

            komut.Parameters.AddWithValue("@num", textBox1.Text);
            komut.Parameters.AddWithValue("@ad", textBox2.Text);
            komut.Parameters.AddWithValue("@adr", textBox5.Text);
            komut.Parameters.AddWithValue("@bol", textBox3.Text);
            komut.Parameters.AddWithValue("@m", textBox4.Text);

            bag.Open();
            komut.ExecuteNonQuery();
            bag.Close();
            listele();

        }

        
    }
}
