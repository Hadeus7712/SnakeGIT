using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX.DirectInput;

namespace SnakeGIT
{
    public partial class Form1 : Form
    {
        public Keyboard keyboard;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            var directInput = new DirectInput();
            keyboard = new Keyboard(directInput);
            keyboard.Acquire();
        }

        private async void start_Click(object sender, EventArgs e)
        {
            await Task.Delay(500);



            using (var game = new SnakeGame())
            {
                game.Run();
            }

        }

    }
}

