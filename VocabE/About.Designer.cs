
namespace VocabE
{
    partial class About
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
            this.copyright_image = new System.Windows.Forms.PictureBox();
            this.displayText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.copyright_image)).BeginInit();
            this.SuspendLayout();
            // 
            // copyright_image
            // 
            this.copyright_image.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyright_image.Image = global::VocabE.Properties.Resources.menu;
            this.copyright_image.Location = new System.Drawing.Point(340, 92);
            this.copyright_image.Name = "copyright_image";
            this.copyright_image.Size = new System.Drawing.Size(116, 110);
            this.copyright_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.copyright_image.TabIndex = 1;
            this.copyright_image.TabStop = false;
            // 
            // displayText
            // 
            this.displayText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.displayText.BackColor = System.Drawing.Color.Transparent;
            this.displayText.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayText.ForeColor = System.Drawing.Color.Black;
            this.displayText.Location = new System.Drawing.Point(177, 205);
            this.displayText.Name = "displayText";
            this.displayText.Size = new System.Drawing.Size(444, 38);
            this.displayText.TabIndex = 3;
            this.displayText.Text = "Copyright © 2023 KhanhGia-HaUI";
            this.displayText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(213, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "C#, TypeScript and JavaScript";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayText);
            this.Controls.Add(this.copyright_image);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.copyright_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox copyright_image;
        private System.Windows.Forms.Label displayText;
        private System.Windows.Forms.Label label1;
    }
}