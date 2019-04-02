using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace трикутник
{
    

    public partial class Form1 : Form
       
    {
        public Form1()
        {
            InitializeComponent();
        }
        static void Move(ref int x, ref int y, int newX, int newY)
        {
            x = (newX + x) / 2;
            y = (newY + y) / 2;
        }
        Bitmap My = new Bitmap(1000, 1000);

        private void button1_Click(object sender, EventArgs e)
        {
          
            int x = 1;
            int y = 1;
            var random = new Random();
            for (int i = 0; i < 3000; i++)
            {
              
                var r = random.Next(1, 30);
                if (r < 10)
                {
                    Move(ref x, ref y, 100, 500);
                    My.SetPixel(x, y, Color.Red);
                }
                else if (r > 20)
                {
                    Move(ref x, ref y, 600, 500);
                    My.SetPixel(x, y, Color.Green);
                }
                else
                {
                    Move(ref x, ref y, 350, 100);
                    My.SetPixel(x, y, Color.Black);
                }
            }
            pictureBox1.Image = My;
        }
    }
}
