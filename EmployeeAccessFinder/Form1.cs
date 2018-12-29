using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel=Microsoft.Office.Interop.Excel;

namespace EmployeeAccessFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Find_Click(object sender, EventArgs e)
        {
            int PositionCode = Convert.ToInt32(Input_PositionID.Text);
            int deptNum = PositionCode / 1000;

            int sheetNum;

            switch (deptNum)
            {

                case 105:
                    sheetNum = 9;
                    MessageBox.Show("Executive");
                    break;

                case 185:
                case 190:
                case 195:
                    sheetNum = 10;
                    MessageBox.Show("Facilities");
                    break;

                case 120:
                case 123:
                case 510:
                case 520:
                    sheetNum = 11;
                    MessageBox.Show("Finance");
                    break;

                case 440:
                case 445:
                    sheetNum = 12;
                    MessageBox.Show("Food & Beverage");
                    break;

                case 210:
                case 220:
                    sheetNum = 13;
                    MessageBox.Show("Gaming");
                    break;

                case 150:
                case 155:
                    sheetNum = 14;
                    MessageBox.Show("GEHR");
                    break;

                case 115:
                case 116:
                    sheetNum = 15;
                    MessageBox.Show("IT");
                    break;

                case 110:
                case 125:
                    sheetNum = 16;
                    MessageBox.Show("Legal");
                    break;

                case 620:
                case 630:
                case 650:
                case 660:
                case 665:
                case 730:
                    sheetNum = 17;
                    MessageBox.Show("Marketing");
                    break;

                case 170:
                case 175:
                case 178:
                    sheetNum = 18;
                    MessageBox.Show("Procurement");
                    break;

                case 240:
                    sheetNum = 19;
                    MessageBox.Show("Security");
                    break;

                case 230:
                    sheetNum = 20;
                    MessageBox.Show(deptNum + "Surveillance");
                    break;

                default:
                    MessageBox.Show("Department code " + deptNum + " does not exist. Please enter a valid position code");
                    sheetNum = 0;
                    break;
            }

            OpenFile(sheetNum);
        }

        private void Input_PositionID_TextChanged(object sender, EventArgs e)
        {

        }

        public void OpenFile(int sheet)
        {
            Excel excel = new Excel("C:\\Users\\320051\\Desktop\\Copy_EAM_WIP_v7.xlsx", sheet);
            MessageBox.Show(excel.ReadCell(1, 0), excel.LastRow().ToString());

        }
    }
}
