using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itsenäinenteht
{
    public partial class Form1 : Form
    {
        dice noppa1 = new dice();
        dice noppa2 = new dice();
        int kierrokset = 0;
        int p2Wins;
        int p1Wins;

        public Form1()
        {
            InitializeComponent();
        }
    
            
        private void button1_Click(object sender, EventArgs e)
        {
            noppa1.roll();

            label1.Text = noppa1.Luku.ToString();

            if (label2.Text == "" == false)
            {
                if (noppa2.Luku > noppa1.Luku)
                {
                    label3.Text = "Pelaaja 2 voitti";
                    kierrokset = +1;
                    p2Wins += 1;
                    label7.Text = p2Wins.ToString();
                }
                if (noppa2.Luku < noppa1.Luku)
                {
                    label3.Text = "Pelaaja 1 voitti";
                    kierrokset = +1;
                    p1Wins = +1;
                    label6.Text = p1Wins.ToString();

                }
                if (noppa2.Luku == noppa1.Luku)
                {
                    label3.Text = "Tasapeli";
                    kierrokset = +1;
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            noppa2.roll();

            label2.Text = noppa2.Luku.ToString();

            if (label1.Text == "" == false)
            {
                if (noppa2.Luku > noppa1.Luku)
                {
                    label3.Text = "Pelaaja 2 voitti";
                    kierrokset = +1;
                    p2Wins += 1;
                    label7.Text = p2Wins.ToString();
                }
                if (noppa2.Luku < noppa1.Luku)
                {
                    label3.Text = "Pelaaja 1 voitti";
                    kierrokset = +1;
                    p1Wins += 1;
                    label6.Text = p1Wins.ToString();
                }
                if (noppa2.Luku == noppa1.Luku)
                {
                    label3.Text = "Tasapeli";
                    kierrokset = +1;
                }
            }



        }
    }
        



    
   
}
