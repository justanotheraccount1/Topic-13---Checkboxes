using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_13___Checkboxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chkStarTrek.Checked && chkStarWars.Checked)
            {
                lblResults.Text = "Results: You are truly a person of culture";
                btnSubmit.ForeColor = Color.Red;
                btnSubmit.BackColor = Color.White;
                this.BackColor = Color.Black;
                lblResults.ForeColor = Color.White;
                chkStarTrek.ForeColor = Color.White;
                chkStarWars.ForeColor = Color.White;
            }
            if (chkStarTrek.Checked && !chkStarWars.Checked)
            {
                lblResults.Text = "Results: You only like Star Trek!?! Weird...";
                btnSubmit.ForeColor = Color.White;
                btnSubmit.BackColor = Color.Black;
                this.BackColor = Color.Red;
                lblResults.ForeColor = Color.White;
                chkStarTrek.ForeColor = Color.White;
                chkStarWars.ForeColor = Color.White;
            }
            if (!chkStarTrek.Checked && chkStarWars.Checked)
            {
                lblResults.Text = "Results: You only like Star Wars. Understandable.";
                btnSubmit.ForeColor = Color.White;
                btnSubmit.BackColor = Color.Red;
                this.BackColor = Color.White;
                lblResults.ForeColor = Color.Black;
                chkStarTrek.ForeColor = Color.Black;
                chkStarWars.ForeColor = Color.Black;
            }
            if (!chkStarTrek.Checked && !chkStarWars.Checked)
            {
                lblResults.Text = "Results: You are wrong.";
                btnSubmit.ForeColor = Color.Black;
                btnSubmit.BackColor = Color.Red;
                this.BackColor = Color.Black;
                lblResults.ForeColor = Color.White;
                chkStarTrek.ForeColor = Color.White;
                chkStarWars.ForeColor = Color.White;
            }
        }
    }
}
