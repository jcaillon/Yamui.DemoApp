using System.Collections.Generic;
using Yamui.DemoApp.Pages.control;
using Yamui.DemoApp.Pages.Scrollbar;
using Yamui.Framework.Controls;
using Yamui.Framework.Forms;

namespace Yamui.DemoApp {
    public partial class Form1 : YamuiMainAppli {
        public Form1() {
            InitializeComponent();
            
            CreateContent(new List<YamuiMainMenu> {
                new YamuiMainMenu("Control", null, false, new List<YamuiSecMenu> {
                    new YamuiSecMenu("Other", null, new ScrollBarPanel()),
                    new YamuiSecMenu("ProfilPages", null, new ProfilesPage()),
                    new YamuiSecMenu("Classic", null, new Classic()),
                    new YamuiSecMenu("Item controls", null, new ItemControl()),
                    new YamuiSecMenu("Text", null, new Text()),
                    new YamuiSecMenu("Progress", null, new Progress()),
                }),
                new YamuiMainMenu("Settings", null, true, new List<YamuiSecMenu> {
                    new YamuiSecMenu("yamuiTabSecAppearance", "yamuiTabSecAppearance", new Pages.SettingAppearance()),
                }),
                new YamuiMainMenu("Navigation", null, false, new List<YamuiSecMenu> {
                    new YamuiSecMenu("Other", null, new ScrollBarPanel()),
                }),
            });

            CreateTopLinks(new List<string> {"APPEARANCES", "NOTIFICATIONS", "TEST"}, (sender, tabArgs) => {
                switch (tabArgs.SelectedIndex) {
                    case 0:
                        ShowPage("yamuiTabSecAppearance");
                        break;
                    case 1:
                        var toastNotification = new YamuiNotification("title", "<img src='high_importance' />This is a notification test", 5);
                        toastNotification.Show();
                        var toastNotification2 = new YamuiNotification("title", "<img src='poison' />Can i display a link? <br><a href='plswork?'>yop</a>", 0);
                        toastNotification2.Show();
                        break;
                    case 2:
                        Notify("hello it's a rather long text! omgplease work on first shot?! I stay for 5s and i go!", 5);
                        break;
                }
            });
            
        }
    }
}
