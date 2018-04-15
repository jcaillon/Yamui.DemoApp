using System;
using System.Threading;
using System.Windows.Forms;
using Yamui.Framework.Forms;
using Yamui.Framework.Themes;

namespace Yamui.DemoApp {

    public class ColorScheme {
        public string Name = "Default";
        public int UniqueId = 0;
    }

    static class Program {

        public static YamuiMainAppli MainForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();

            // https://stackoverflow.com/questions/8283631/graphics-drawstring-vs-textrenderer-drawtextwhich-can-deliver-better-quality
            Application.SetCompatibleTextRenderingDefault(false);

            YamuiThemeManager.TabAnimationAllowed = true;
            //MainForm = new Form1();
            //Thread.Sleep(1000);

            Application.Run(new YamuiFormBaseShadow2());

            /*
             *  HwndSource hwndSource = HwndSource.FromHwnd(_parentWindowHndl);
            if (hwndSource != null)
            {
                hwndSource.AddHook(WndProc);
            }
             */
        }
    }


}
