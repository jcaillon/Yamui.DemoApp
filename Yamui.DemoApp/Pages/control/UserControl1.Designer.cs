﻿namespace Yamui.DemoApp.Pages.control
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yamuiButton1 = new Yamui.Framework.Controls.YamuiButton();
            this.SuspendLayout();
            // 
            // yamuiButton1
            // 
            this.yamuiButton1.BackGrndImage = null;
            this.yamuiButton1.GreyScaleBackGrndImage = null;
            this.yamuiButton1.IsFocused = false;
            this.yamuiButton1.IsHovered = false;
            this.yamuiButton1.IsPressed = false;
            this.yamuiButton1.Location = new System.Drawing.Point(0, 0);
            this.yamuiButton1.Name = "yamuiButton1";
            this.yamuiButton1.SetImgSize = new System.Drawing.Size(0, 0);
            this.yamuiButton1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(655, 321);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Controls.YamuiButton yamuiButton1;
    }
}
