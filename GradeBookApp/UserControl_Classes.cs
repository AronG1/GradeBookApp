using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBookApp
{
    public partial class UserControl_Classes : UserControl
    {
        public UserControl_Classes()
        {
            InitializeComponent();
        }

        private void btn_BackToStartingForm_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            this.Visible = false;
        }
    }
}
