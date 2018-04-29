﻿using System;
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
    public partial class Form2 : YamuiFormButtons
    {
        public Form2(): base(YamuiFormOption.IsPopup | YamuiFormOption.WithShadow | YamuiFormOption.AlwaysOnTop | YamuiFormOption.DontShowInAltTab | YamuiFormOption.DontActivateOnShow) {
            CloseAllBox = true;
            Movable = false;
            Resizable = false;
            InitializeComponent();
        }

    }
}
