using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cressem
{
    public partial class FormIO : Form
    {
        public bool isWorking = false;

        public FormIO()
        {
            InitializeComponent();
        }

        private void checkBoxModify_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModify.Checked)
                isWorking = true;
            else
                isWorking = false;
        }
    }
}
