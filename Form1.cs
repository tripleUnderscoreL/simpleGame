using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleGame
{
    public partial class Form1 : Form
    {
        bool dirLeft, dirRight, jump;
        int fallingSpeed;
        int force;
        int movingSpeed = 4;

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) dirRight = true;
            if (e.KeyCode == Keys.A) dirLeft = true;
            if (e.KeyCode == Keys.Space && jump == false) jump = true;
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) dirRight = false;
            if (e.KeyCode == Keys.A) dirLeft = false;
            if (jump == true) jump = false;
        }
    }
}
