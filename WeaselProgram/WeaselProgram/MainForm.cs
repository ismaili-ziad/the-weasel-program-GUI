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
    public partial class MainForm : Form
    {
        public static int PROBABILITY_OF_MUTATING = 15;
        public static int NUMBER_OF_MUTATIONS = 10;
        private int STEPS, FAILED;

        public Char ToUpper(Char character)
        {
            return ((char)('A'+character-'a'));
        }

        public String Compute(String goal)
        {
            string poolOfChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            int goalSize = goal.Length, counter = 0;
            string start = "", result;
            Random rnd = new Random();
            for (int i = 0;  i< goalSize; i++)
            {
                start += poolOfChar[rnd.Next(0, poolOfChar.Length)];
            }
            result = start;
            FAILED = 0;
            while (start != goal)
            {
                counter++;
                string bestMutation = start;
                int maxMatchingLetters = 0;
                for (int it = 0; it < NUMBER_OF_MUTATIONS; it++)
                {
                    string currentMutation = "";
                    for (int i = 0; i < goalSize; i++)
                    {
                        if (start[i] != goal[i])
                        {
                            int odd = rnd.Next(0, 100);
                            if (odd <= PROBABILITY_OF_MUTATING)
                            {
                                currentMutation += poolOfChar[rnd.Next(0, poolOfChar.Length)];
                            }
                            else
                            {
                                currentMutation += start[i];
                            }
                        }
                        else
                        {
                            currentMutation += start[i];
                        }
                    }
                    int matchingLetters = 0;
                    for (int i = 0; i < goalSize; i++)
                    {
                        if (goal[i] == currentMutation[i])
                        {
                            matchingLetters++;
                        }
                    }
                    if (maxMatchingLetters < matchingLetters)
                    {
                        maxMatchingLetters = matchingLetters;
                        bestMutation = currentMutation;
                    }
                }
                if (start == bestMutation) FAILED++;
                start = bestMutation;
                result += ("\n" + bestMutation);
            }
            STEPS = counter;
            return result;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult closePrompt = MessageBox.Show("Are you sure you want to close the program?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(closePrompt == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void actualText_TextChanged(object sender, EventArgs e)
        {

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            String input = "";
            for(int i = 0; i < actualText.Text.Length; i++)
            {
                if(actualText.Text[i] >= 'a' && actualText.Text[i] <= 'z')
                {
                    input += ToUpper(actualText.Text[i]);
                }
                else if((actualText.Text[i] >= 'A' && actualText.Text[i] <= 'Z') || actualText.Text[i] == ' ')
                {
                    input += actualText.Text[i];
                }
            }
            actualText.Text = input;
            actualText.ReadOnly = true;
            processButton.Enabled = false;
            resultBox.Text = Compute(input);
            MessageBox.Show("Done.\nNumber of steps: "+STEPS.ToString()+".\nFailures: "+FAILED.ToString()+".", "Process finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Weasel Program, version 1.0.0.\nDeveloped by Ziad Ismaili Alaoui.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualText.Text = "";
            resultBox.Text = "";
            processButton.Enabled = true;
            actualText.ReadOnly = false;
        }
    }
}
