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
            this.yamuiScrollPanel1 = new Yamui.Framework.Controls.YamuiScrollPanel();
            this.yamuiButton1 = new Yamui.Framework.Controls.YamuiButton();
            this.yamuiButton2 = new Yamui.Framework.Controls.YamuiButton();
            this.yamuiButton3 = new Yamui.Framework.Controls.YamuiButton();
            this.yamuiScrollPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yamuiScrollPanel1
            // 
            this.yamuiScrollPanel1.AutoScrollPosition = new System.Drawing.Point(0, 0);
            this.yamuiScrollPanel1.Controls.Add(this.yamuiButton3);
            this.yamuiScrollPanel1.Controls.Add(this.yamuiButton2);
            this.yamuiScrollPanel1.Controls.Add(this.yamuiButton1);
            this.yamuiScrollPanel1.Location = new System.Drawing.Point(21, 34);
            this.yamuiScrollPanel1.Name = "yamuiScrollPanel1";
            this.yamuiScrollPanel1.ScrollBarWidth = 12;
            this.yamuiScrollPanel1.Size = new System.Drawing.Size(385, 270);
            this.yamuiScrollPanel1.TabIndex = 0;
            this.yamuiScrollPanel1.Text = "yamuiScrollPanel1";
            // 
            // yamuiButton1
            // 
            this.yamuiButton1.BackGrndImage = null;
            this.yamuiButton1.GreyScaleBackGrndImage = null;
            this.yamuiButton1.IsFocused = false;
            this.yamuiButton1.IsHovered = false;
            this.yamuiButton1.IsPressed = false;
            this.yamuiButton1.Location = new System.Drawing.Point(4, 10);
            this.yamuiButton1.Name = "yamuiButton1";
            this.yamuiButton1.SetImgSize = new System.Drawing.Size(0, 0);
            this.yamuiButton1.Size = new System.Drawing.Size(75, 23);
            this.yamuiButton1.TabIndex = 0;
            this.yamuiButton1.Text = "yamuiButton1";
            this.yamuiButton1.ButtonPressed += new System.EventHandler<System.EventArgs>(this.yamuiButton1_ButtonPressed);
            // 
            // yamuiButton2
            // 
            this.yamuiButton2.BackGrndImage = null;
            this.yamuiButton2.GreyScaleBackGrndImage = null;
            this.yamuiButton2.IsFocused = false;
            this.yamuiButton2.IsHovered = false;
            this.yamuiButton2.IsPressed = false;
            this.yamuiButton2.Location = new System.Drawing.Point(4, 40);
            this.yamuiButton2.Name = "yamuiButton2";
            this.yamuiButton2.SetImgSize = new System.Drawing.Size(0, 0);
            this.yamuiButton2.Size = new System.Drawing.Size(75, 23);
            this.yamuiButton2.TabIndex = 1;
            this.yamuiButton2.Text = "yamuiButton2";
            // 
            // yamuiButton3
            // 
            this.yamuiButton3.BackGrndImage = null;
            this.yamuiButton3.GreyScaleBackGrndImage = null;
            this.yamuiButton3.IsFocused = false;
            this.yamuiButton3.IsHovered = false;
            this.yamuiButton3.IsPressed = false;
            this.yamuiButton3.Location = new System.Drawing.Point(4, 70);
            this.yamuiButton3.Name = "yamuiButton3";
            this.yamuiButton3.SetImgSize = new System.Drawing.Size(0, 0);
            this.yamuiButton3.Size = new System.Drawing.Size(75, 23);
            this.yamuiButton3.TabIndex = 2;
            this.yamuiButton3.Text = "yamuiButton3";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 344);
            this.Controls.Add(this.yamuiScrollPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(17, 40, 17, 17);
            this.Text = "Form2";
            this.yamuiScrollPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Controls.YamuiScrollPanel yamuiScrollPanel1;
        private Framework.Controls.YamuiButton yamuiButton3;
        private Framework.Controls.YamuiButton yamuiButton2;
        private Framework.Controls.YamuiButton yamuiButton1;
    }
}