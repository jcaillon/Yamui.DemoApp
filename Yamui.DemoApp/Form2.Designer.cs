using Yamui.Framework.Controls;

namespace Yamui.DemoApp
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.htmlLabel1 = new YamuiHtml();
            this._yamuiScrollControlExampleUsage1 = new Yamui.DemoApp.Pages.Scrollbar.YamuiScrollControlExampleUsage();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.Location = new System.Drawing.Point(20, 43);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(59, 15);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.TabStop = false;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // scrollHandlerExampleUsage1
            // 
            this._yamuiScrollControlExampleUsage1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._yamuiScrollControlExampleUsage1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this._yamuiScrollControlExampleUsage1.AutoScrollPosition = new System.Drawing.Point(0, 0);
            this._yamuiScrollControlExampleUsage1.HScroll = true;
            this._yamuiScrollControlExampleUsage1.Location = new System.Drawing.Point(154, 21);
            this._yamuiScrollControlExampleUsage1.Name = "_yamuiScrollControlExampleUsage1";
            this._yamuiScrollControlExampleUsage1.ScrollBarWidth = 12;
            this._yamuiScrollControlExampleUsage1.Size = new System.Drawing.Size(184, 78);
            this._yamuiScrollControlExampleUsage1.TabIndex = 1;
            this._yamuiScrollControlExampleUsage1.TabStop = false;
            this._yamuiScrollControlExampleUsage1.Text = "scrollHandlerExampleUsage1";
            this._yamuiScrollControlExampleUsage1.VScroll = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 344);
            this.Controls.Add(this._yamuiScrollControlExampleUsage1);
            this.Controls.Add(this.htmlLabel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(17, 40, 17, 17);
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private YamuiHtml htmlLabel1;
        private Pages.Scrollbar.YamuiScrollControlExampleUsage _yamuiScrollControlExampleUsage1;
    }
}