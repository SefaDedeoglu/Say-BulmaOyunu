using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayıBulmaOyunu
{
    public partial class Form1 : Form
    {
        double sonuc = 0;
        public Form1()
        {
            InitializeComponent();
            lblSayilar.Text = " SAYILAR = ";
            lblSonuc.Text = "";
            RandomAta();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            kullanici = txtKullanici.Text;
            string[] islemler = new string[10];
            int[] sayilar = new int[10];
            int sayac = 0, sayac2 = 0;
            for (int i = 0; i < kullanici.Length; i++)
            {

                if (kullanici[i].Equals('+') || kullanici[i].Equals('*') || kullanici[i].Equals('-') || kullanici[i].Equals('/'))
                {
                    islemler[sayac] = kullanici[i].ToString();
                    sayac++;
                }
                else
                {
                    if (kullanici[i].Equals('0'))
                    {

                        sayilar[sayac2 - 1] = sayilar[sayac2 - 1] * 10;
                    }
                    else
                    {
                        sayilar[sayac2] = Convert.ToInt32(kullanici[i].ToString());
                        sayac2++;
                    }
                }
            }
            for (int i = 0; i < sayac2; i++)
            {
                Boolean kontrol = false;
                for (int j = 0; j < 6; j++)
                {
                    if (sayilar1[j] == sayilar[i])
                    {
                        kontrol = true;
                        break;
                    }
                }
                if (kontrol == false)
                {
                    MessageBox.Show("Lütfen Random sayıları kullanınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                for ( i = 0; i < sayac2; i++)
                {
                    Boolean kontrol2 = true;
                    for (int j = 0; j < sayac2; j++)
                    {
                        if (sayilar[i]==sayilar[j]&&i!=j)
                        {
                            kontrol2 =false;
                        }
                    }
                    if (kontrol2==false)
                    {
                        MessageBox.Show("Lütfen her sayıyı bir defa kullanınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        goto a;
                    }
                }
            }
            a:;
            sonuc = sayilar[0];
            int k = 0;
            for (int i = 1; i < sayac2; i++)
            {
                for (; k <sayac ;)
                {
                    if (islemler[k].Equals("+"))
                    {
                        sonuc += sayilar[i];
                        k++;
                        break;
                    }
                    else if (islemler[k].Equals("*"))
                    {
                        sonuc *= sayilar[i];
                        k++;
                        break;
                    }
                    else if (islemler[k].Equals("-"))
                    {
                        sonuc -= sayilar[i];
                        k++;
                        break;
                    }
                    else if (islemler[k].Equals("/"))
                    {
                        sonuc /= sayilar[i];
                        k++;
                        break;
                    }
                }
            }
            if (sonuc.ToString() == lblSonuc.Text)
            {
                MessageBox.Show("SONUCUNUZ = " + sonuc + "  DOĞRU BİLDİNİZ TEBRİKLER ! ", "FENAKEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
        { 
                MessageBox.Show( sonuc.ToString(), "YANLIŞŞŞŞŞŞŞŞŞŞŞŞŞŞŞ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        int[] sayilar1 = new int[6];
        private void RandomAta()
        {
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                sayilar1[i] = rnd.Next(1, 10);
                for (int j = 0; j <i; j++)
                {
                    if(sayilar1[i]==sayilar1[j]&&i!=5)
                    {
                        i--;
                        break;
                    }
                }
                if (i == 5)
                {
                    sayilar1[i] *= 10;
                }
            }
                for(int i =0; i < 6; i++)
            {
                lblSayilar.Text += sayilar1[i] + "|";
            }
            lblSonuc.Text = rnd.Next(100, 1000).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
