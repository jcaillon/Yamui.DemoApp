﻿using System.ComponentModel;
using Yamui.Framework.Controls;

namespace Yamui.DemoApp.Pages.control {
    partial class Progress {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.yamuiProgressIndicator2 = new Yamui.Framework.Controls.YamuiProgressIndicator();
            this.yamuiProgressIndicator1 = new Yamui.Framework.Controls.YamuiProgressIndicator();
            this.yamuiLabel4 = new Yamui.Framework.Controls.YamuiLabel();
            this.yamuiLabel9 = new Yamui.Framework.Controls.YamuiLabel();
            this.yamuiProgressBar1 = new Yamui.Framework.Controls.YamuiProgressBar();
            this.yamuiProgressBar2 = new Yamui.Framework.Controls.YamuiProgressBar();
            this.yamuiLabel5 = new Yamui.Framework.Controls.YamuiLabel();
            this.yamuiProgressBar3 = new Yamui.Framework.Controls.YamuiProgressBar();
            this.SuspendLayout();
            // 
            // yamuiProgressIndicator2
            // 
            this.yamuiProgressIndicator2.AnimateInterval = 300;
            this.yamuiProgressIndicator2.CircleCount = 9;
            this.yamuiProgressIndicator2.CircleDiameter = 5;
            this.yamuiProgressIndicator2.Location = new System.Drawing.Point(40, 225);
            this.yamuiProgressIndicator2.Name = "yamuiProgressIndicator2";
            this.yamuiProgressIndicator2.Size = new System.Drawing.Size(30, 30);
            this.yamuiProgressIndicator2.TabIndex = 28;
            // 
            // yamuiProgressIndicator1
            // 
            this.yamuiProgressIndicator1.AnimateInterval = 300;
            this.yamuiProgressIndicator1.CircleCount = 6;
            this.yamuiProgressIndicator1.CircleDiameter = 15;
            this.yamuiProgressIndicator1.Location = new System.Drawing.Point(470, 213);
            this.yamuiProgressIndicator1.Name = "yamuiProgressIndicator1";
            this.yamuiProgressIndicator1.Size = new System.Drawing.Size(70, 70);
            this.yamuiProgressIndicator1.TabIndex = 27;
            // 
            // yamuiLabel4
            // 
            this.yamuiLabel4.Function = Yamui.Framework.Fonts.FontFunction.Heading;
            this.yamuiLabel4.Location = new System.Drawing.Point(0, 0);
            this.yamuiLabel4.Margin = new System.Windows.Forms.Padding(5, 18, 5, 7);
            this.yamuiLabel4.Name = "yamuiLabel4";
            this.yamuiLabel4.Size = new System.Drawing.Size(112, 19);
            this.yamuiLabel4.TabIndex = 22;
            this.yamuiLabel4.Text = "PROGRESS BAR";
            // 
            // yamuiLabel9
            // 
            this.yamuiLabel9.Function = Yamui.Framework.Fonts.FontFunction.Heading;
            this.yamuiLabel9.Location = new System.Drawing.Point(0, 185);
            this.yamuiLabel9.Margin = new System.Windows.Forms.Padding(5, 18, 5, 7);
            this.yamuiLabel9.Name = "yamuiLabel9";
            this.yamuiLabel9.Size = new System.Drawing.Size(131, 19);
            this.yamuiLabel9.TabIndex = 26;
            this.yamuiLabel9.Text = "WAIT ANIMATION";
            // 
            // yamuiProgressBar1
            // 
            this.yamuiProgressBar1.Location = new System.Drawing.Point(0, 22);
            this.yamuiProgressBar1.MarqueeWidth = 50;
            this.yamuiProgressBar1.Name = "yamuiProgressBar1";
            this.yamuiProgressBar1.Progress = 30F;
            this.yamuiProgressBar1.Size = new System.Drawing.Size(540, 23);
            this.yamuiProgressBar1.TabIndex = 21;
            // 
            // yamuiProgressBar2
            // 
            this.yamuiProgressBar2.Location = new System.Drawing.Point(0, 51);
            this.yamuiProgressBar2.MarqueeWidth = 50;
            this.yamuiProgressBar2.Name = "yamuiProgressBar2";
            this.yamuiProgressBar2.Progress = 0F;
            this.yamuiProgressBar2.Size = new System.Drawing.Size(540, 23);
            this.yamuiProgressBar2.TabIndex = 23;
            this.yamuiProgressBar2.UseMarquee = true;
            // 
            // yamuiLabel5
            // 
            this.yamuiLabel5.Function = Yamui.Framework.Fonts.FontFunction.Heading;
            this.yamuiLabel5.Location = new System.Drawing.Point(0, 123);
            this.yamuiLabel5.Margin = new System.Windows.Forms.Padding(5, 18, 5, 7);
            this.yamuiLabel5.Name = "yamuiLabel5";
            this.yamuiLabel5.Size = new System.Drawing.Size(92, 19);
            this.yamuiLabel5.TabIndex = 25;
            this.yamuiLabel5.Text = "SCROLL BAR";
            // 
            // yamuiProgressBar3
            // 
            this.yamuiProgressBar3.CenterText = Yamui.Framework.Controls.CenterElement.Percent;
            this.yamuiProgressBar3.Location = new System.Drawing.Point(0, 80);
            this.yamuiProgressBar3.MarqueeWidth = 50;
            this.yamuiProgressBar3.Name = "yamuiProgressBar3";
            this.yamuiProgressBar3.Progress = 30F;
            this.yamuiProgressBar3.Size = new System.Drawing.Size(540, 23);
            this.yamuiProgressBar3.Style = Yamui.Framework.Controls.ProgressStyle.Outwards;
            this.yamuiProgressBar3.TabIndex = 24;
            // 
            // Progress
            // 
            this.Controls.Add(this.yamuiProgressIndicator2);
            this.Controls.Add(this.yamuiProgressIndicator1);
            this.Controls.Add(this.yamuiLabel4);
            this.Controls.Add(this.yamuiLabel9);
            this.Controls.Add(this.yamuiProgressBar1);
            this.Controls.Add(this.yamuiProgressBar2);
            this.Controls.Add(this.yamuiLabel5);
            this.Controls.Add(this.yamuiProgressBar3);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(715, 315);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private YamuiProgressIndicator yamuiProgressIndicator2;
        private YamuiProgressIndicator yamuiProgressIndicator1;
        private YamuiLabel yamuiLabel4;
        private YamuiLabel yamuiLabel9;
        private YamuiProgressBar yamuiProgressBar1;
        private YamuiProgressBar yamuiProgressBar2;
        private YamuiLabel yamuiLabel5;
        private YamuiProgressBar yamuiProgressBar3;

    }
}
