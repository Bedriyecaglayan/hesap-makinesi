using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        int sayac;   /*  girilen değerleri ve islem yapmak için islem değerini(operatörleri kontrol edecegiz) tanımladık */
        
        public Form1()
        {
            InitializeComponent();
        }

        private void RakamOlay(object sender, EventArgs e) 
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button20_Click(object sender, EventArgs e) /* butonlara tıklanınca (0'dan 9'a kadar) sıfır silinecek ve basılan değeri yazan işlem */
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "";
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button19_Click(object sender, EventArgs e) 
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text += "6";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button23_Click(object sender, EventArgs e) /* butonlara tıklanınca sıfır silinecek ve basılan değeri yazan işlem  sonu */
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text += "";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button25_Click(object sender, EventArgs e)  /*  C işlemi yazdığımız rakamları tek tek silen kod */ 
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                if (textBox1.Text.Length==0)  /* silme işleminde fazla tıklamada hata aldım tekrar hata vermemesi textbox1'e 0 atadım. */ 
                {
                    textBox1.Text = "0";
                }

            }
        }

      
        private void button22_Click(object sender, EventArgs e) /* matematiksel işlemleri = işlemine tıklanınca yapmasını sağlayan kod */
        {
            y = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                textBox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                textBox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "*")
            {
                textBox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                textBox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem== "mod")
            {
                textBox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }

        }

        private void button17_Click(object sender, EventArgs e)  /* 4 işlem operartörlerini tanıttım eşittir işleminde if komutu ile işlem yaptırmak için*/
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "+";
            label1.Text = textBox1.Text + "+";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e) /* 4 işlem operartörlerini tanıttım eşittir işleminde if komutu ile işlem yaptırmak için*/
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "-";
            label1.Text = textBox1.Text + "-";
            textBox1.Text = "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "*";
            label1.Text = textBox1.Text + "*";
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "/";
            label1.Text = textBox1.Text + "/";
            textBox1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e) /* Kare alma işlemini gerçekleştirdik */ 
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = Math.Pow(kare, 2);
            textBox1.Text = Convert.ToString(kare);
        }

        private void button3_Click(object sender, EventArgs e) /* küp alma işlemini gerçekleştirdik */
        {
            double kup = Convert.ToDouble(textBox1.Text);
            kup = Math.Pow(kup, 3);
            textBox1.Text = Convert.ToString(kup);
        }

        private void button26_Click(object sender, EventArgs e) /* kök alma işlemi yaptık */ 
        {
            double karekok = Convert.ToDouble(textBox1.Text);
            karekok = Math.Sqrt(karekok);
            textBox1.Text = Convert.ToString(karekok);
        }

        private void button28_Click(object sender, EventArgs e) /* mod alma işlemini tanımladık */
        {
            x = Convert.ToDouble(textBox1.Text);
            islem = "mod";
            label1.Text = textBox1.Text + "(mod)";
            textBox1.Text = "0";
 
        }

        private void button27_Click(object sender, EventArgs e) /* 1/x  işlemini gerçekleştridik */
        {
            double bolumx = Convert.ToDouble(textBox1.Text);
            bolumx = 1 / (bolumx) ;
            textBox1.Text = Convert.ToString(bolumx);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text.Length !=0 )
            {
                double l;
                l = Math.Log10(Convert.ToDouble(textBox1.Text));
                textBox1.Text = Convert.ToString(l);

            }

        }

        private void button8_Click(object sender, EventArgs e) /* sinüs alma işlemi gerçekleştirildi */
        {
            double sinus = Convert.ToDouble(textBox1.Text);
            sinus = Math.Sin(Math.PI * sinus / 180);
            textBox1.Text = Convert.ToString(sinus);
            
            

        }

        private void button7_Click(object sender, EventArgs e) /* cosinüs alma işlemi gerçekleştirildi */
        {
            double Cosx = Convert.ToDouble(textBox1.Text);
            Cosx = Math.Cos(Math.PI * Cosx / 180);
            
        }

        private void button6_Click(object sender, EventArgs e) /* tanjant alma işlemi gerçekleştirildi */
        {
            double tanx = Convert.ToDouble(textBox1.Text);
            tanx = Math.Tan(Math.PI * tanx / 180);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sayac++;
            this.Text = "Ekran " + sayac + " Salisedir çalışıyor !!";
            if (sayac >= 12000)
            {
                timer1.Enabled = false;
            }
                
        }

     

        private void button4_Click(object sender, EventArgs e) /*  AC işlemi tüm işlemi silen işlem */ 
        {
            textBox1.Text = "0";
            label1.Text = "";
        }
    }
}
