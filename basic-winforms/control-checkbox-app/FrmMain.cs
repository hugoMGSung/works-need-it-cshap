using System;
using System.Windows.Forms;

namespace control_checkbox_app
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void ChkMonitoringBed_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMonitoringBed.CheckState == CheckState.Checked)
            {
                ChkSubBedTemp.Checked = ChkSubBedHumid.Checked = true;
            } 
            else if (ChkMonitoringBed.CheckState == CheckState.Unchecked)
            {
                ChkSubBedTemp.Checked = ChkSubBedHumid.Checked = false;
            }           
        }

        private void ChangeSubStates()
        {
            if (ChkSubBedTemp.Checked && ChkSubBedHumid.Checked)
            {
                ChkMonitoringBed.CheckState = CheckState.Checked;
            }
            else if (ChkSubBedTemp.Checked == false && ChkSubBedHumid.Checked == false)
            {
                ChkMonitoringBed.CheckState = CheckState.Unchecked;
            }
            else
            {
                ChkMonitoringBed.CheckState = CheckState.Indeterminate;
            }
        }

        private void ChkSubBedTemp_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSubStates();
        }
        

        private void ChkSubBedHumid_CheckedChanged(object sender, EventArgs e)
        {
            ChangeSubStates();
        }
    }
}
