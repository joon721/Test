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
    public partial class FormEditTenkeyName : Form
    {
        public static string oldTextBox = "";
        public FormEditTenkeyName()
        {
            InitializeComponent();
            textBoxNewDescription.Text = oldTextBox;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            FormList.PageManual.newDescription = textBoxNewDescription.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            FormList.PageManual.newDescription = oldTextBox;
            this.Close();
        }
    }
}
