/**********************************************************
**                SAKARYA ÜNİVERSİTESİ
**         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**           BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**             NESNEYE DAYALI PROGRAMLAMA DERSİ
**                  2019-2020 BAHAR DÖNEMİ
**             
**             ÖDEV NUMARASI......: Ödev 1
**             ÖĞRENCİ ADI........: Esra AKSU
**             ÖĞRENCİ NUMARASI...: B191200370
**         DERSİN ALINDIĞI GRUP...: A
**********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dvd_koleksiyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // DVD Ekleme formunda kaydedilen bilgilerin aktarılmasını sağlayan buton
        private void button4_Click(object sender, EventArgs e)
        {
            dvd_koleksiyonu oto = new dvd_koleksiyonu();

            oto.adi = "star wars";
            oto.yönetmeni = "george lucas";
            oto.süresi = "135 dakika";
            oto.konusu = "yıldız savaşları";
            oto.türü = "macera, bilim kurgu";
            oto.ülke = "yabancı";
            oto.tarih = "1977";

            string adi = oto.adigetir();

            label9.Text = oto.adi.ToString();
            label10.Text = oto.yönetmeni.ToString();
            label11.Text = oto.süresi.ToString();
            label12.Text = oto.konusu.ToString();
            label13.Text = oto.türü.ToString();
            label14.Text = oto.ülke.ToString();
            label15.Text = oto.tarih.ToString();

        }

        /* İstenilen bilgiye daha kolay erişilebilmesini sağlayan ara butonu
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox1.Text.ToLower()))
                {
                    listBox1.SetSelected(i, true);
                }
            }

        }

        // Listbox'a düşen verilerin alfabetik olarak sıralanmasını ssaağlayan buton
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        // Yalnızca seçili olan öğeyi listeden çıkarmayı sağlar
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // Bütün öğeleri listeden çıkarmayı sağlar
        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
        */

        // Yeni kayıt yapılmak istendiğinde DVD Ekleme formuna geri dönülmesini sağlayan buton
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 yeni = new Form1();
            yeni.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            yılın_filmi oto = new yılın_filmi();

            oto.adi = "Parasite";
            oto.yönetmeni = "Bong Joonho";
            oto.süresi = "130 dakika";
            oto.konusu = "vahşi ve zorlayıcı bir üstünlük mücadelesi";
            oto.türü = "gerilim, komedi";
            oto.ülke = "yabancı";
            oto.tarih = "2019";

            string adi = oto.adigetir();

            label22.Text = oto.adi.ToString();
            label21.Text = oto.yönetmeni.ToString();
            label20.Text = oto.süresi.ToString();
            label19.Text = oto.konusu.ToString();
            label18.Text = oto.türü.ToString();
            label17.Text = oto.ülke.ToString();
            label16.Text = oto.tarih.ToString();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
