using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryTesting;
using InventoryModels;

namespace InventorySimulation
{
    public partial class Form1 : Form
    {
        SimulationSystem sys;
        string file_path;
        string test_message;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sys = new SimulationSystem();

            if (comboBox1.SelectedIndex == 0)
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase1;
                test_message = Constants.FileNames.TestCase1;
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase2;
                test_message = Constants.FileNames.TestCase2;
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase3;
                test_message = Constants.FileNames.TestCase3;
            }

            else
            {
                file_path = @"..\..\TestCases\" + Constants.FileNames.TestCase4;
                test_message = Constants.FileNames.TestCase4;
            }


            sys.ReadInput(file_path);

            lbl_NumberOfDays.Text = sys.NumberOfDays.ToString();
            lbl_OrderUpTo.Text = sys.OrderUpTo.ToString();
            lbl_ReviewPeriod.Text = sys.ReviewPeriod.ToString();
            lbl_StartInventoryQuantity.Text = sys.StartInventoryQuantity.ToString();
            lbl_StartLeadDays.Text = sys.StartLeadDays.ToString();
            lbl_StartOrderQuantity.Text = sys.StartOrderQuantity.ToString();


            GrdView_Demand.DataSource = sys.DemandDistribution;
            GrdView_LeadTime.DataSource = sys.LeadDaysDistribution;

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            sys.start_simulation();
            lbl_endingInventoryavg.Text = sys.PerformanceMeasures.EndingInventoryAverage.ToString();
            lbl_shortageQuantityAvg.Text = sys.PerformanceMeasures.ShortageQuantityAverage.ToString();
            grad_output.DataSource = sys.SimulationTable;
            MessageBox.Show(TestingManager.Test(sys, test_message));
        }
    }
}
