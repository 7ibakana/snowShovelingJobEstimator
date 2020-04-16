using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snowShovelingJobEstimator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configure earliest and latest dates possible in DateTimePicker
            //Earliest is today, latest in seven days time
            dteAppointmentDate.MinDate = DateTime.Today;
            dteAppointmentDate.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnSpecialRequests_Click(object sender, EventArgs e)
        {
            frmSpecialRequests frmSpecialRequests = new frmSpecialRequests();
            //Set the tag to be the current text in txtSpecialRequests
            frmSpecialRequests.Tag = txtSpecialRequests.Text;
            DialogResult res = frmSpecialRequests.ShowDialog();
        }
    }
}
