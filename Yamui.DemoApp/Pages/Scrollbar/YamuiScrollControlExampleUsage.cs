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

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Yamui.Framework.Controls;
using Yamui.Framework.Fonts;
using Yamui.Framework.Helper;

namespace Yamui.DemoApp.Pages.Scrollbar {
    
    public class YamuiScrollControlExampleUsage : YamuiScrollControl {

        protected override Size ContentNaturalSize {
            get {
                // if you specify an empty, the scrollbars will not show since the available
                // space will always be superior to the natural size of the content
                return new Size(500, 1000);
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e) {
            base.OnMouseDoubleClick(e);
            HasBorder = true;
            InvalidateBorder();
        }

        #region Paint

        protected override void PaintContentSurface(Graphics g) {
            // paint background
            base.PaintContentSurface(g);
            var rect = new Rectangle(0, 0, ClientRectangle.Width - VerticalScroll.BarThickness, 20);
            rect.Y = -VerticalScroll.Value;
            TextRenderer.DrawText(g, $"Horizontal scroll : {HorizontalScroll}", FontManager.GetStandardFont(), rect, Color.Blue, FontManager.GetTextFormatFlags(ContentAlignment.MiddleLeft));
            rect.Y += rect.Height;
            TextRenderer.DrawText(g, $"Vertical scroll : {VerticalScroll}", FontManager.GetStandardFont(), rect, Color.Blue, FontManager.GetTextFormatFlags(ContentAlignment.MiddleLeft));

            rect.Width = rect.Height;
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_MENU, WinApi.DrawFrameControlStates.DFCS_MENUCHECK, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_MENU, WinApi.DrawFrameControlStates.DFCS_MENUARROW, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_MENU, WinApi.DrawFrameControlStates.DFCS_MENUBULLET, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_SCROLL, WinApi.DrawFrameControlStates.DFCS_SCROLLUP | WinApi.DrawFrameControlStates.DFCS_PUSHED, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_CAPTION, WinApi.DrawFrameControlStates.DFCS_CAPTIONCLOSE | WinApi.DrawFrameControlStates.DFCS_FLAT | WinApi.DrawFrameControlStates.DFCS_MONO, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFrameControl(g, rect, WinApi.DrawFrameControlTypes.DFC_CAPTION, WinApi.DrawFrameControlStates.DFCS_CAPTIONMAX | WinApi.DrawFrameControlStates.DFCS_MONO, Color.Red, Color.Black);
            rect.Y += rect.Height;
            PaintHelper.DrawFlatCheckBox(g, rect, Color.Red, Color.Black, ButtonState.Checked);

            rect.Y += rect.Height;
            rect.Width = rect.Height = 100;
            PaintHelper.DrawFlatCheckBox(g, rect, Color.Red, Color.Black, ButtonState.Checked);
            
            rect.Y += rect.Height;
            rect.Width = rect.Height = 50;
            PaintHelper.DrawFlatCheckBox(g, rect, Color.Red, Color.Black, ButtonState.Checked);
        }

        #endregion


    }
}