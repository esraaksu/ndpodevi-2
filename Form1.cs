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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Girilen bilgilerin kaydet butonuyla listbox'a aktarılmasını sağlar
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + ", " + textBox4.Text + ", " + dateTimePicker1.Value);
        }

        // Kayıt yaptıktan sonra yeni kayıt için gerekli kutucukların boşalmasını sağlar
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;         
        }

        // Yalnızca seçili olan öğeyi listeden çıkarmayı sağlar
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        // Öğelerin hepsini çıkararak listbox'ın boşalmasını sağlar
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        // DVD Ekleme formundaki bilgileri DVD Koleksiyon formuna aktarılması için dizi tanımladım
        public static int liste;

        public static string[] elemanlar = new string[100];

        // veriaktar() metodu ile listboxdaki verileri diziye aktardım
        private void veriaktar()  
        {
            liste = listBox1.Items.Count;
            for (int i = 0; i < liste; i++)
            {
                elemanlar[i] = Convert.ToString(listBox1.Items[i]);
            }
        }

        // Koleksiyona Git butonuyla çalışmaya başlayan buton verilerin ikinci forma aktarılmasını sağlar
        private void button5_Click(object sender, EventArgs e)
        {
            veriaktar();
            Form2 yeni = new Form2();
            yeni.Show();
            this.Hide(); 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
