/*
 * Created by: Nicholas  Ellul
 * Created on: 03-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 4-04
 * This program converts a mark to percentage ex; 4+ to 95%
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404GradeAverageProgram
{
    public partial class MarkToAverageForm : Form
    {
        public MarkToAverageForm()
        {
            InitializeComponent();
        }

        public int markToInt(string mark)
        {
            int markAsPercent;

            switch (mark)
            {
                case "4+":
                    markAsPercent = 95;
                    break;

                case "4":
                    markAsPercent = 90;
                    break;

                case "4-":
                    markAsPercent = 85;
                    break;

                case "3+":
                    markAsPercent = 77;
                    break;

                case "3":
                    markAsPercent = 75;
                    break;

                case "3-":
                    markAsPercent = 72;
                    break;

                case "2+":
                    markAsPercent = 67;
                    break;

                case "2":
                    markAsPercent = 65;
                    break;

                case "2-":
                    markAsPercent = 62;
                    break;

                case "1+":
                    markAsPercent = 57;
                    break;

                case "1":
                    markAsPercent = 55;
                    break;

                case "1-":
                    markAsPercent = 52;
                    break;

                case "R":
                    markAsPercent = 30;
                    break;

                case "r":
                    markAsPercent = 30;
                    break;

                case "NE":
                    markAsPercent = 0;
                    break;

                case "ne":
                    markAsPercent = 0;
                    break;

                default:
                    markAsPercent = -1;
                    break;
            }

            return markAsPercent;
        }
        private void btnCaluclate_Click(object sender, EventArgs e)
        {
            string markInput = this.txtInput.Text;
            int markAsInterger;

            markAsInterger = markToInt(markInput);
            MessageBox.Show("Your mark is " + markAsInterger + "%", "Conversion");          
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
