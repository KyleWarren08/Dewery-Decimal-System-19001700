using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewery_Decimal_System_19001700
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReplacingBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Replaceing_Books repBookForm = new Replaceing_Books();
            repBookForm.ShowDialog();
            this.Close();
        }

        private void btnIdentifyingAreas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identifying_Areas IdenAreaForm = new Identifying_Areas();
            IdenAreaForm.ShowDialog();
            this.Close();
        }

        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Finding_Call_Numbers FindNumForm = new Finding_Call_Numbers();
            FindNumForm.ShowDialog();
            this.Close();
        }
    }
}
