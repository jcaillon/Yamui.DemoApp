using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yamui.Framework.Forms;

namespace Yamui.DemoApp
{
    public partial class Form2 : YamuiFormBaseShadow
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Maximized;
        }
    }
}
