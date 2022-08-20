using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lmitp
{
    public partial class Rehema_Ogana : Form
    {
        public Rehema_Ogana()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeform e1 = new employeeform();
            e1.Show();
            this.Hide();
        }
    }
}
