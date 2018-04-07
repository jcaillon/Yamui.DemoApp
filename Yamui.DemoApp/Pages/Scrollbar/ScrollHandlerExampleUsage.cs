#region header

// ========================================================================
// Copyright (c) 2016 - Julien Caillon (julien.caillon@gmail.com)
// This file (YamuiScrollPage.cs) is part of Yamui.Framework.
// 
// YamuiFramework is a free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// YamuiFramework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with Yamui.Framework. If not, see <http://www.gnu.org/licenses/>.
// ========================================================================

#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Yamui.Framework.Controls;
using Yamui.Framework.Fonts;
using Yamui.Framework.Helper;

namespace YamuiDemoApp.Pages.Navigation {
    
    public class ScrollHandlerExampleUsage : YamuiControl {

        #region fields

        [Browsable(false)]
        public YamuiScrollHandler VerticalScroll { get; }
        
        [Browsable(false)]
        public YamuiScrollHandler HorizontalScroll { get; }

        /// <summary>
        /// Can this control have vertical scroll?
        /// </summary>
        [DefaultValue(true)]
        public bool HScroll {
            get { return _hScroll; }
            set {
                _hScroll = value;
                HorizontalScroll.Enabled = _hScroll;
                PerformLayout();
            }
        }
        
        /// <summary>
        /// Can this control have vertical scroll?
        /// </summary>
        [DefaultValue(true)]
        public bool VScroll {
            get { return _vScroll; }
            set {
                _vScroll = value;
                VerticalScroll.Enabled = _vScroll;
                PerformLayout();
            }
        }

        private bool _vScroll = true;
        private bool _hScroll = true;

        #endregion

        #region constructor

        public ScrollHandlerExampleUsage() {
            SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.Selectable |
                ControlStyles.Opaque, true);

            VerticalScroll = new YamuiScrollHandler(true, this) {
                SmallChange = 70,
                LargeChange = 400
            };
            HorizontalScroll = new YamuiScrollHandler(false, this){
                SmallChange = 35,
                LargeChange = 200
            };
        }

        #endregion

        #region Paint

        protected override void OnPaint(PaintEventArgs e) {
            
            // paint background
            e.Graphics.Clear(Color.Black);
            var rect = new Rectangle(0, 0, ClientRectangle.Width - VerticalScroll.BarThickness, 20);
            TextRenderer.DrawText(e.Graphics, $"Horizontal scroll : {HorizontalScroll}", FontManager.GetStandardFont(), rect, Color.AntiqueWhite, FontManager.GetTextFormatFlags(ContentAlignment.MiddleLeft));
            rect.Y += rect.Height;
            TextRenderer.DrawText(e.Graphics, $"Vertical scroll : {VerticalScroll}", FontManager.GetStandardFont(), rect, Color.AntiqueWhite, FontManager.GetTextFormatFlags(ContentAlignment.MiddleLeft));

            VerticalScroll.Paint(e);
            HorizontalScroll.Paint(e);

        }

        #endregion

        #region handle windows events

        protected override void WndProc(ref Message m) {
            switch (m.Msg) {
                case (int) WinApi.Messages.WM_MOUSEWHEEL:
                    // delta negative when scrolling up
                    // delta negative when scrolling up
                    var delta = (short) (m.WParam.ToInt64() >> 16);
                    if (HorizontalScroll.IsHovered) {
                        HorizontalScroll.HandleScroll(null, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, delta));
                    } else {
                        VerticalScroll.HandleScroll(null, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, delta));
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Handle keydown
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e) {
            e.Handled = HorizontalScroll.HandleKeyDown(null, e) || VerticalScroll.HandleKeyDown(null, e);
            if (!e.Handled)
                base.OnKeyDown(e);
        }

        /// <summary>
        /// redirect all input key to keydown
        /// </summary>
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e) {
            e.IsInputKey = true;
            base.OnPreviewKeyDown(e);
        }

        protected override void OnMouseDown(MouseEventArgs e) {
            HorizontalScroll.HandleMouseDown(null, e);
            VerticalScroll.HandleMouseDown(null, e);
            Focus();
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e) {
            HorizontalScroll.HandleMouseUp(null, e);
            VerticalScroll.HandleMouseUp(null, e);
            base.OnMouseUp(e);
        }

        protected override void OnMouseMove(MouseEventArgs e) {
            HorizontalScroll.HandleMouseMove(null, e);
            VerticalScroll.HandleMouseMove(null, e);
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e) {
            HorizontalScroll.HandleMouseLeave(null, null);
            VerticalScroll.HandleMouseLeave(null, null);
            base.OnMouseLeave(e);
        }

        /// <summary>
        /// Programatically triggers the OnKeyDown event
        /// </summary>
        public bool PerformKeyDown(KeyEventArgs e) {
            OnKeyDown(e);
            return e.Handled;
        }
        
        protected override void OnResize(EventArgs e) {
            VerticalScroll.UpdateLength(VerticalScroll.LengthToRepresent, VerticalScroll.LengthAvailable, Height, Width);
            HorizontalScroll.UpdateLength(HorizontalScroll.LengthToRepresent, HorizontalScroll.LengthAvailable, Width, Height);
            base.OnResize(e);
        }

        #endregion


    }
}