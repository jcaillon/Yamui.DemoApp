using System.Windows.Forms;
using Yamui.Framework.Controls;

namespace Yamui.DemoApp.Pages {
    public partial class PageTemplate : YamuiPage {

        #region fields
        private Form _ownerForm;
        #endregion


        #region constructor
        public PageTemplate() {
            InitializeComponent();
            _ownerForm = FindForm();
        }
        #endregion

    }
}
