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
        }




        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W) buttonW.Image = Properties.Resources.WAction;
            if (e.KeyCode == Keys.S) buttonS.Image = Properties.Resources.SAction;
            if (e.KeyCode == Keys.A) buttonA.Image = Properties.Resources.AAction;
            if (e.KeyCode == Keys.D) buttonD.Image = Properties.Resources.DAction;

            if (e.KeyCode == Keys.Up) buttonUp.Image = Properties.Resources.ArrowUpAction;
            if (e.KeyCode == Keys.Down) buttonDown.Image = Properties.Resources.ArrowDownAction;
            if (e.KeyCode == Keys.Left) buttonLeft.Image = Properties.Resources.ArrowLeftAction;
            if (e.KeyCode == Keys.Right) buttonRight.Image = Properties.Resources.ArrowRightAction;


            if(e.KeyCode == Keys.Space) using(var game = new SnakeGame())
                {
                    game.Run();
                }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)  buttonW.Image = Properties.Resources.WState;
            if (e.KeyCode == Keys.S) buttonS.Image = Properties.Resources.SState;
            if (e.KeyCode == Keys.A) buttonA.Image = Properties.Resources.AState;
            if(e.KeyCode == Keys.D) buttonD.Image = Properties.Resources.DState;

            if(e.KeyCode == Keys.Up) buttonUp.Image = Properties.Resources.ArrowUpState;
            if(e.KeyCode == Keys.Down) buttonDown.Image = Properties.Resources.ArrowDownState;
            if (e.KeyCode == Keys.Left) buttonLeft.Image = Properties.Resources.ArrowLeftState;
            if(e.KeyCode == Keys.Right) buttonRight.Image = Properties.Resources.ArrowRightState;
        }


    }
}

