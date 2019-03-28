using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCKontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sonuc = 0;
        private void btnKontrol_Click(object sender, EventArgs e)
        {

            int x = 1;
            int y = 0;
            int z = 0;
            string tc = txtTC.Text;
            tc = tc.Trim();
            int[] sayilar = new int[11];
            for (int i = 0; i < tc.Length; i++)
            {
                sayilar[i] = Int32.Parse(tc[i].ToString());
            }
            foreach (var item in sayilar)
            {
                
                if(x < 11)
                {
                    sonuc = sonuc + item;
                }
                else
                {
                    z = item;
                }
                x++;
            }
            y = sonuc % 10;

            if(y == z)
            {
                MessageBox.Show("Doğru");
            }
            else
            {
                MessageBox.Show("Yanlış");
            }
            
            
            x = 0;
            y = 0;
            z = 0;
            sonuc = 0;
        }
       
       
    }
}
