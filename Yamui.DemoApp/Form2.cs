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
using Yamui.Framework.Controls;

namespace Yamui.DemoApp
{
    public partial class Form2 : YamuiMainAppli
    {
        public Form2() {
            InitializeComponent();

            CloseAllBox = true;

            _yamuiScrollControlExampleUsage1.Visible = false;

            htmlLabel1.HasBorder = true;
            htmlLabel1.AutoSize = true;
            htmlLabel1.AutoSizeHeightOnly = false;
            htmlLabel1.Text = "fuckkkk<br>second ligiiiiiiiiiiiiiiiiiiiiine";
            //htmlLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            htmlLabel1.Text = @"<h1>FastColoredTextBox</h1><br>
            Fast Colored TextBox is text editor component for .NET. Allows you to create custom text editor with syntax highlighting. It works well with small, medium, large and very-very large files.

                It has such settings as foreground color, font style, background color which can be adjusted for arbitrarily selected text symbols. One can easily gain access to a text with the use of regular expressions. WordWrap, Find/Replace, Code folding and multilevel Undo/Redo are supported as well.";
        }

        private void yamuiButton1_ButtonPressed(object sender, EventArgs e)
        {
            var toastNotification = new YamuiNotification("title", "<img src='high_importance' />This is a notification test", 120);
            toastNotification.Show();
            var toastNotification2 = new YamuiNotification("title", "<img src='poison' />Can i display a link? <br><a href='plswork?'>yop</a>", 0);
            toastNotification2.Show();
        }
    }
}
