using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void start_Click(object sender, EventArgs e)
        {
            start.Visible = false; 
            three.Visible = true;
            await Task.Delay(1000);
            three.Visible = false;
            two.Visible = true;
            await Task.Delay(1000);
            two.Visible = false;
            one.Visible = true;
            await Task.Delay(1000);

            using (var game = new SnakeGame())
            {
                game.Run();
            }

        }

    }
}
