using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleanCode
{
    public partial class Form1 : Form
    {
        private GameEngine gameEngine;
        public Form1()
        {
            InitializeComponent();

            gameEngine = new GameEngine(10);
            UpdateDisplay();
        }

        public void UpdateDisplay()
        {
            label1.Text = gameEngine.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //attacking ------------------------------------------------------------
        private void btnAtkUp_Click(object sender, EventArgs e)
        {
            TriggerAttack();
            UpdateDisplay();
        }

        private void btnAtkRight_Click(object sender, EventArgs e)
        {
            TriggerAttack();
            UpdateDisplay();
        }

        private void btnAtkDown_Click(object sender, EventArgs e)
        {
            TriggerAttack();
            UpdateDisplay();
        }

        private void btnAtkLeft_Click(object sender, EventArgs e)
        {
            TriggerAttack();
            UpdateDisplay();
        }

        //movement ------------------------------------------------------------
        private void btnUp_Click(object sender, EventArgs e)
        {
            TriggerMovement();
            UpdateDisplay();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            TriggerMovement();
            UpdateDisplay();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            TriggerMovement();
            UpdateDisplay();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            TriggerMovement();
            UpdateDisplay();
        }

        private void lblHeroStats_Click(object sender, EventArgs e)
        {

        }
    }
}
