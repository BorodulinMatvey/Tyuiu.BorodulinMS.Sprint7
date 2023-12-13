
namespace Projecrt.V11
{
    partial class FormMain
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
            this.panel_Button_BMS = new System.Windows.Forms.Panel();
            this.button_Add_BMS = new System.Windows.Forms.Button();
            this.panel_Button_BMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Button_BMS
            // 
            this.panel_Button_BMS.Controls.Add(this.button_Add_BMS);
            this.panel_Button_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Button_BMS.Location = new System.Drawing.Point(0, 0);
            this.panel_Button_BMS.Name = "panel_Button_BMS";
            this.panel_Button_BMS.Size = new System.Drawing.Size(574, 83);
            this.panel_Button_BMS.TabIndex = 0;
            // 
            // button_Add_BMS
            // 
            this.button_Add_BMS.Location = new System.Drawing.Point(12, 12);
            this.button_Add_BMS.Name = "button_Add_BMS";
            this.button_Add_BMS.Size = new System.Drawing.Size(107, 48);
            this.button_Add_BMS.TabIndex = 0;
            this.button_Add_BMS.Text = "Добавить характеристики ";
            this.button_Add_BMS.UseVisualStyleBackColor = true;
            this.button_Add_BMS.Click += new System.EventHandler(this.button_Add_BMS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 359);
            this.Controls.Add(this.panel_Button_BMS);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_Button_BMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Button_BMS;
        private System.Windows.Forms.Button button_Add_BMS;
    }
}