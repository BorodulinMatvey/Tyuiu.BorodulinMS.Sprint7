
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
            this.components = new System.ComponentModel.Container();
            this.button_Add_BMS = new System.Windows.Forms.Button();
            this.button_Sort_BMS = new System.Windows.Forms.Button();
            this.toolTip_FormMain_BMS = new System.Windows.Forms.ToolTip(this.components);
            this.button_Editing_BMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Add_BMS
            // 
            this.button_Add_BMS.Location = new System.Drawing.Point(12, 12);
            this.button_Add_BMS.Name = "button_Add_BMS";
            this.button_Add_BMS.Size = new System.Drawing.Size(107, 48);
            this.button_Add_BMS.TabIndex = 0;
            this.button_Add_BMS.Text = "Добавить сведения";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Add_BMS, "Нажмите кнопку для добавления сведений о сотрудниках\r\n");
            this.button_Add_BMS.UseVisualStyleBackColor = true;
            this.button_Add_BMS.Click += new System.EventHandler(this.button_Add_BMS_Click);
            // 
            // button_Sort_BMS
            // 
            this.button_Sort_BMS.Location = new System.Drawing.Point(12, 78);
            this.button_Sort_BMS.Name = "button_Sort_BMS";
            this.button_Sort_BMS.Size = new System.Drawing.Size(107, 49);
            this.button_Sort_BMS.TabIndex = 2;
            this.button_Sort_BMS.Text = "Поиск";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Sort_BMS, "Нажмите на кнопку, чтобы выполнить поиск данных ");
            this.button_Sort_BMS.UseVisualStyleBackColor = true;
            this.button_Sort_BMS.Click += new System.EventHandler(this.button_Statistic_BMS_Click);
            // 
            // toolTip_FormMain_BMS
            // 
            this.toolTip_FormMain_BMS.IsBalloon = true;
            this.toolTip_FormMain_BMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_FormMain_BMS.ToolTipTitle = "Подсказка";
            // 
            // button_Editing_BMS
            // 
            this.button_Editing_BMS.Location = new System.Drawing.Point(28, 151);
            this.button_Editing_BMS.Name = "button_Editing_BMS";
            this.button_Editing_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_Editing_BMS.TabIndex = 3;
            this.button_Editing_BMS.Text = "Редактирование ";
            this.button_Editing_BMS.UseVisualStyleBackColor = true;
            this.button_Editing_BMS.Click += new System.EventHandler(this.button_Editing_BMS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button_Editing_BMS);
            this.Controls.Add(this.button_Sort_BMS);
            this.Controls.Add(this.button_Add_BMS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Add_BMS;
        private System.Windows.Forms.Button button_Sort_BMS;
        private System.Windows.Forms.ToolTip toolTip_FormMain_BMS;
        private System.Windows.Forms.Button button_Editing_BMS;
    }
}