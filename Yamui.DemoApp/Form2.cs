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
    public partial class Form2 : YamuiMainAppli
    {
        public Form2() {
            InitializeComponent();
        }

        private void yamuiButton1_ButtonPressed(object sender, EventArgs e)
        {
            var toastNotification = new YamuiNotification("title", "<img src='high_importance' />This is a notification test", 5);
            toastNotification.Show();
            var toastNotification2 = new YamuiNotification("title", "<img src='poison' />Can i display a link? <br><a href='plswork?'>yop</a>", 0);
            toastNotification2.Show();
        }
    }
}
