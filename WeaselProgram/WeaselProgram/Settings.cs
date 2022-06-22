using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaselProgram
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            probs.Text = "Probability of a character mutation: "+MainForm.PROBABILITY_OF_MUTATING.ToString()+"%";
            trackBar.Value = MainForm.PROBABILITY_OF_MUTATING;
            numberMuts.Text = "Number of mutations per cycle: " + MainForm.NUMBER_OF_MUTATIONS.ToString();
            mutsSelect.Value = MainForm.NUMBER_OF_MUTATIONS;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            MainForm.PROBABILITY_OF_MUTATING = trackBar.Value;
            probs.Text = "Character mutation probability: " + MainForm.PROBABILITY_OF_MUTATING.ToString() + "%";
        }

        private void numberMuts_Click(object sender, EventArgs e)
        {

        }

        private void mutsSelect_Scroll(object sender, EventArgs e)
        {
            MainForm.NUMBER_OF_MUTATIONS = mutsSelect.Value;
            numberMuts.Text = "Number of mutations per cycle: " + MainForm.NUMBER_OF_MUTATIONS.ToString();
        }
    }
}
