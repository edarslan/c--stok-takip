using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakip
{
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-JBK4KL2;Initial Catalog=stoktakip;Integrated Security=True");
        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combokategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void combokategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            combomarka.Items.Clear();
            combomarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='"+combokategori.SelectedItem+"'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combomarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnyeniekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,alisfiyati,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@alisfiyati,@satisfiyati,@tarih)", baglanti);
            komut.Parameters.AddWithValue("@barkodno",txtbarkodno.Text);
            komut.Parameters.AddWithValue("@kategori",combokategori.Text);
            komut.Parameters.AddWithValue("@marka", combomarka.Text);
            komut.Parameters.AddWithValue("@urunadi", txtürünadı.Text);
            komut.Parameters.AddWithValue("@miktari",int.Parse(txtmiktarı.Text));
            komut.Parameters.AddWithValue("@alisfiyati",double.Parse(txtalış.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtsatış.Text));
            komut.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün eklendi");
            combomarka.Items.Clear();
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void barkodnotxt_TextChanged(object sender, EventArgs e)
        {
            if (barkodnotxt.Text=="")
            {
                lblmiktar.Text = "";
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '"+barkodnotxt.Text+"'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                kategoritxt.Text = read["kategori"].ToString();
                markatxt.Text = read["marka"].ToString();
                ürünadıtxt.Text = read["urunadi"].ToString();
                lblmiktar.Text = read["miktari"].ToString();
                alıştxt.Text = read["alisfiyati"].ToString();
                satıştxt.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void btnvarolanekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(miktartxt.Text)+"'where barkodno='"+barkodnotxt.Text+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var olan ürüne ekleme yapıldı");
        }
    }
}
