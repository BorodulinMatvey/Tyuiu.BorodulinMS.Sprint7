
namespace Project.V11
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.label_HelpText_BMS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Ok_BMS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_HelpText_BMS
            // 
            this.label_HelpText_BMS.Location = new System.Drawing.Point(4, 9);
            this.label_HelpText_BMS.Name = "label_HelpText_BMS";
            this.label_HelpText_BMS.Size = new System.Drawing.Size(626, 179);
            this.label_HelpText_BMS.TabIndex = 0;
            this.label_HelpText_BMS.Text = resources.GetString("label_HelpText_BMS.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Ok_BMS
            // 
            this.button_Ok_BMS.Location = new System.Drawing.Point(523, 179);
            this.button_Ok_BMS.Name = "button_Ok_BMS";
            this.button_Ok_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_Ok_BMS.TabIndex = 2;
            this.button_Ok_BMS.Text = "Ok";
            this.button_Ok_BMS.UseVisualStyleBackColor = true;
            this.button_Ok_BMS.Click += new System.EventHandler(this.button_Ok_BMS_Click);
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 214);
            this.Controls.Add(this.button_Ok_BMS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_HelpText_BMS);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_HelpText_BMS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Ok_BMS;
    }
}