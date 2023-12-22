
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
            this.pictureBox_Save_BMS = new System.Windows.Forms.PictureBox();
            this.button_Ok_BMS = new System.Windows.Forms.Button();
            this.pictureBox_Find_BMS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Find_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // label_HelpText_BMS
            // 
            this.label_HelpText_BMS.Location = new System.Drawing.Point(4, 9);
            this.label_HelpText_BMS.Name = "label_HelpText_BMS";
            this.label_HelpText_BMS.Size = new System.Drawing.Size(772, 438);
            this.label_HelpText_BMS.TabIndex = 0;
            this.label_HelpText_BMS.Text = resources.GetString("label_HelpText_BMS.Text");
            // 
            // pictureBox_Save_BMS
            // 
            this.pictureBox_Save_BMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Save_BMS.Image")));
            this.pictureBox_Save_BMS.Location = new System.Drawing.Point(218, 64);
            this.pictureBox_Save_BMS.Name = "pictureBox_Save_BMS";
            this.pictureBox_Save_BMS.Size = new System.Drawing.Size(29, 30);
            this.pictureBox_Save_BMS.TabIndex = 1;
            this.pictureBox_Save_BMS.TabStop = false;
            // 
            // button_Ok_BMS
            // 
            this.button_Ok_BMS.Location = new System.Drawing.Point(701, 424);
            this.button_Ok_BMS.Name = "button_Ok_BMS";
            this.button_Ok_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_Ok_BMS.TabIndex = 2;
            this.button_Ok_BMS.Text = "Ok";
            this.button_Ok_BMS.UseVisualStyleBackColor = true;
            this.button_Ok_BMS.Click += new System.EventHandler(this.button_Ok_BMS_Click);
            // 
            // pictureBox_Find_BMS
            // 
            this.pictureBox_Find_BMS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Find_BMS.Image")));
            this.pictureBox_Find_BMS.Location = new System.Drawing.Point(115, 364);
            this.pictureBox_Find_BMS.Name = "pictureBox_Find_BMS";
            this.pictureBox_Find_BMS.Size = new System.Drawing.Size(31, 32);
            this.pictureBox_Find_BMS.TabIndex = 3;
            this.pictureBox_Find_BMS.TabStop = false;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 452);
            this.Controls.Add(this.pictureBox_Find_BMS);
            this.Controls.Add(this.button_Ok_BMS);
            this.Controls.Add(this.pictureBox_Save_BMS);
            this.Controls.Add(this.label_HelpText_BMS);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(797, 491);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(797, 491);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Помощник";
            this.Load += new System.EventHandler(this.FormHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Save_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Find_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_HelpText_BMS;
        private System.Windows.Forms.PictureBox pictureBox_Save_BMS;
        private System.Windows.Forms.Button button_Ok_BMS;
        private System.Windows.Forms.PictureBox pictureBox_Find_BMS;
    }
}