using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_karakterDogrulama_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //KOD İTE butonuna basıldığında
        {
            string[] sembol1 = { "j", "ı", "u", "h", "o", "n", "a" };//sembol1 adında bir dizi oluşturduk, küçük harfleri buraya tanımlıyoruz
            string[] sembol2 = { "+","/","-","#","*"}; //sembol2 diye bir dizi oluşturduk ve buraya , karakterleri tanımlıyoruz

            Random r = new Random(); //Random sınıfından "r" nesnesi oluşturuyoruz

            int s1, s2, s3; //3 tane sayı tanımlıyoruz
            s1 = r.Next(0, sembol1.Length); //s1'e r nesnesinden 0 ile sembol1 uzunluğu kadar random sayı istiyoruz
            s2=r.Next(0, sembol2.Length );// buradada 0 ile s2 uzunluğu kadar sayı istiyoruz
            s3 = r.Next(0, 10);// ve s3 içinde 0 ile 10 arasında bir sayı istiyoruz

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString()+ s3.ToString();
            // label1 de hepsi tanımlayacağımız için + ile bir birine ekleyerek yazdık
            //sembol1[s1] yazmamızın sebebi= sembol1 dizisinin s1 inci elamanını çağırıyoruz 
            // s1 zaten bize 7 tane sayı random atacak, atacağı bu sayıları "sembol1[s1]" sembol1 in içine tanımladığımız değerlerden atasın
           
        }

        private void button2_Click(object sender, EventArgs e) //DOĞRULA butonuna bastığımızda
        {
            if (label1.Text == textBox1.Text )//eğer label1 in değeri textBox1 e eşit ise 
            {
                textBox1.BackColor = Color.Green; //textBox ın arka plan rengini yeşil yap
            }
            else
            {
                textBox1.BackColor = Color.Red; //değil ise arka plan rengini kırmızı yap 
            }
        }
        // ☺


    }
}
