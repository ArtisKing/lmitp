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
    public partial class employeeform : Form
    {
        public employeeform()
        {
            InitializeComponent();
        }

        private void btndashbaord_Click(object sender, EventArgs e)
        {
            Salma_Marie s1 = new Salma_Marie();
            s1.Show();
            this.Hide();
        }
  
        private void rehemaOgana_Click(object sender, EventArgs e)
        {
            Rehema_Ogana r1 =new Rehema_Ogana();
            r1.Show();
            this.Hide();
        }

        private void arthurGichuki_Click(object sender, EventArgs e)
        {
            Arthur_Gichuki a1 = new Arthur_Gichuki();
            a1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
