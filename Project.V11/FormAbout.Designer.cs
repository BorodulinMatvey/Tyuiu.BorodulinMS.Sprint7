
namespace Project.V11
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBox_Avatar_BMS = new System.Windows.Forms.PictureBox();
            this.label_Info_BMS = new System.Windows.Forms.Label();
            this.button_Ok_BMS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Avatar_BMS
            // 
            this.pictureBox_Avatar_BMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Avatar_BMS.Image")));
            this.pictureBox_Avatar_BMS.Location = new System.Drawing.Point(11, 4);
            this.pictureBox_Avatar_BMS.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Avatar_BMS.Name = "pictureBox_Avatar_BMS";
            this.pictureBox_Avatar_BMS.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.pictureBox_Avatar_BMS.Size = new System.Drawing.Size(215, 277);
            this.pictureBox_Avatar_BMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Avatar_BMS.TabIndex = 1;
            this.pictureBox_Avatar_BMS.TabStop = false;
            // 
            // label_Info_BMS
            // 
            this.label_Info_BMS.AutoSize = true;
            this.label_Info_BMS.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label_Info_BMS.Location = new System.Drawing.Point(238, 11);
            this.label_Info_BMS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Info_BMS.Name = "label_Info_BMS";
            this.label_Info_BMS.Size = new System.Drawing.Size(284, 130);
            this.label_Info_BMS.TabIndex = 2;
            this.label_Info_BMS.Text = resources.GetString("label_Info_BMS.Text");
            // 
            // button_Ok_BMS
            // 
            this.button_Ok_BMS.BackColor = System.Drawing.SystemColors.Menu;
            this.button_Ok_BMS.Location = new System.Drawing.Point(451, 256);
            this.button_Ok_BMS.Margin = new System.Windows.Forms.Padding(2);
            this.button_Ok_BMS.Name = "button_Ok_BMS";
            this.button_Ok_BMS.Size = new System.Drawing.Size(71, 25);
            this.button_Ok_BMS.TabIndex = 3;
            this.button_Ok_BMS.Text = "Ok";
            this.button_Ok_BMS.UseVisualStyleBackColor = false;
            this.button_Ok_BMS.Click += new System.EventHandler(this.button_Ok_BMS_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.button_Ok_BMS);
            this.Controls.Add(this.label_Info_BMS);
            this.Controls.Add(this.pictureBox_Avatar_BMS);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(549, 331);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(549, 331);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Avatar_BMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Avatar_BMS;
        private System.Windows.Forms.Label label_Info_BMS;
        private System.Windows.Forms.Button button_Ok_BMS;
    }
}