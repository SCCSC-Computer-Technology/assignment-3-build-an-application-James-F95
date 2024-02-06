using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace James_Fowler_CPT206_Lab_2
{
    public partial class dataform : Form
    {
        private StateData stateData;

        public dataform(StateData stateData)
        {
            InitializeComponent();

            this.stateData = stateData;

            if (stateData != null)
            {
                txtAbbreviation.Text = stateData.Abbreviation;
                txtCapital.Text = stateData.Capitol;
                txtFlagDescription.Text = stateData.FlagDescription;
                txtLargestCity.Text = stateData.LargestCity;
                txtMedianIncome.Text = stateData.MedianIncome.ToString("C");
                txtPercentageJobs.Text = stateData.PercentageOfProgrammingJobs.ToString("P");
                txtPopulation.Text = stateData.Population.ToString();
                txtSecondCity.Text = stateData.SecondLargestCity;
                txtStateBird.Text = stateData.StateBird;
                txtStateFlower.Text = stateData.StateFlower;
                txtStateNickname.Text = stateData.StateNickname;
                txtThirdCity.Text = stateData.ThirdLargestCity;
                txtTotalJobs.Text = stateData.TotalEmployment.ToString();
                txtProgrammingJobs.Text = stateData.ProgrammingJobs.ToString();

                this.Text = stateData.State;
            }
            else
            {
                MessageBox.Show("State information is null.");
                this.Close();
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
