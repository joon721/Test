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
    public partial class FormUseSkip : Form
    {
        public bool isWorking = false;
        public FormUseSkip()
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
