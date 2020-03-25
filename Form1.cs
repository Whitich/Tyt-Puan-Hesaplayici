/****************************************************************************
**                                     SAKARYA ÜNİVERSİTESİ
**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                            BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                               NESNEYE DAYALI PROGRAMLAMA DERSİ
**                                   2019-2020 BAHAR DÖNEMİ
**
**                                 ÖĞRENCİ ADI: Mert HARMANKAŞI
**                                 ÖĞRENCİ NUMARASI: B191200047
** 
****************************************************************************/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            
            
            float dogrutü = Convert.ToInt32(txtDogrut.Text);
            float yanlıstü = Convert.ToInt32(txtYanlıst.Text);

          //yukarıda türkçenin doğru ve yanlışlarını çevirdim  

            if (dogrutü <= 40 && dogrutü>-1 && yanlıstü>-1 && yanlıstü<41 && (yanlıstü+dogrutü)<41)
            
                //yukarıda doğrunun ve yanlışın 40 dan fazla olamayacağını ve doğru yanlış toplamlarınında 40 dan büyük olamayacağını yazdım olursa geçerli bir değer giriniz yazıyor
            {
                
                float nett = dogrutü - (yanlıstü / 4);
                label4.Text = "Net :" + nett;

                //yukarıda net hesabı yaptırdım
            }
            else
            {
                label4.Text = "Geçerli değer giriniz";
            }
            float dogruma = Convert.ToInt32(txtDogruM.Text);
            float yanlısma = Convert.ToInt32(txtYanlısM.Text);

            //yukarıda matematiğin doğru ve yanlışlarını çevirdim

            if (dogruma<=40 && dogruma > -1 && yanlısma > -1 && yanlısma < 41 && (yanlısma + dogruma) < 41)

            //yukarıda doğrunun ve yanlışın 40 dan fazla olamayacağını ve doğru yanlış toplamlarınında 40 dan büyük olamayacağını yazdım olursa geçerli bir değer giriniz yazıyor
            {
                float netm = dogruma - (yanlısma / 4);
                label6.Text = "Net :" + netm;

                //yukarıda net hesabı yaptırdım
            }
            else
            {
                label6.Text = "Geçerli değer giriniz";
            }

            float dogruso = Convert.ToInt32(txtDogruS.Text);
            float yanlısso = Convert.ToInt32(txtYanlısS.Text);

            //yukarıda sosyalin doğru ve yanlışlarını çevirdim

            if (dogruso <=20 && yanlısso>-1 && dogruso>-1 && yanlısso<21 && (yanlısso+dogruso)<21)

                //yukarıda doğrunun ve yanlışın 20 den fazla olamayacağını ve doğru yanlış toplamlarınında 20 den büyük olamayacağını yazdım olursa geçerli bir değer giriniz yazıyor
            {
                float nets = dogruso - (yanlısso / 4);
                label8.Text = "Net :" + nets;

                //yukarıda net hesabı yaptırdım
            }
            else
            {
                label8.Text = "Geçerli değer giriniz";
            }
            float dogrufe = Convert.ToInt32(txtDogruF.Text);
            float yanlısfe = Convert.ToInt32(txtYanlısF.Text);

            //yukarıda fenin doğru ve yanlışlarını çevirdim

            if (dogrufe<=20 && dogrufe>-1 && yanlısfe>-1 && yanlısfe<21 && (yanlısfe+dogrufe)<21)

            //yukarıda doğrunun ve yanlışın 20 den fazla olamayacağını ve doğru yanlış toplamlarınında 20 den büyük olamayacağını yazdım olursa geçerli bir değer giriniz yazıyor
            {
                float netf = dogrufe - (yanlısfe / 4);
                label10.Text = "Net :" + netf;

                //yukarıda net hesabı yaptırdım
            }
            else
            {
                label10.Text = "Geçerli değer giriniz";
            }

            float neddd = dogrutü - (yanlıstü /4) + dogruma - (yanlısma /4) + dogrufe - (yanlısfe /4) + dogruso - (yanlısso / 4);
            label11.Text = "Toplam net :"+neddd;

            //yukarıda toplam neti hesaplayıp yazdırdım

            float puantm = (33 * (dogrutü - (yanlıstü / 4) + dogruma - (yanlısma / 4)))/10;
            float puanfs = (34 * (dogruso - (yanlısso / 4) + dogrufe - (yanlısfe / 4)))/10;

            float totp = puantm + puanfs + 100;
            label12.Text = "TYT puanı :" + totp;
 
            //yukarıda netleri tekrar hesaplayıp katsayılarıyla çarpıp 100 puan ekleyip tyt puanını yazdırdım
        }
        
        // aşağıdakiler textboxlara sadece sayı girilmesini sağlıyor harf veya sembol girilmesini engelliyor

        private void txtDogrut_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtYanlıst_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtDogruM_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtYanlısM_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtDogruS_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtYanlısS_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtDogruF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void txtYanlısF_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }
    }
}
