
namespace Projecrt.V11
{
    partial class FormEditing
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
            this.panel_Rich_BMS = new System.Windows.Forms.Panel();
            this.button_LoadFileToEditing_BMS = new System.Windows.Forms.Button();
            this.button_SaveСhanges_BMS = new System.Windows.Forms.Button();
            this.dataGridView_Editing_BMS = new System.Windows.Forms.DataGridView();
            this.panel_Rich_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Editing_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Rich_BMS
            // 
            this.panel_Rich_BMS.Controls.Add(this.dataGridView_Editing_BMS);
            this.panel_Rich_BMS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Rich_BMS.Location = new System.Drawing.Point(263, 0);
            this.panel_Rich_BMS.Name = "panel_Rich_BMS";
            this.panel_Rich_BMS.Size = new System.Drawing.Size(779, 594);
            this.panel_Rich_BMS.TabIndex = 0;
            // 
            // button_LoadFileToEditing_BMS
            // 
            this.button_LoadFileToEditing_BMS.Location = new System.Drawing.Point(34, 43);
            this.button_LoadFileToEditing_BMS.Name = "button_LoadFileToEditing_BMS";
            this.button_LoadFileToEditing_BMS.Size = new System.Drawing.Size(168, 95);
            this.button_LoadFileToEditing_BMS.TabIndex = 1;
            this.button_LoadFileToEditing_BMS.Text = "Загрузить файл ";
            this.button_LoadFileToEditing_BMS.UseVisualStyleBackColor = true;
            this.button_LoadFileToEditing_BMS.Click += new System.EventHandler(this.button_LoadFileToEditing_BMS_Click);
            // 
            // button_SaveСhanges_BMS
            // 
            this.button_SaveСhanges_BMS.Location = new System.Drawing.Point(88, 365);
            this.button_SaveСhanges_BMS.Name = "button_SaveСhanges_BMS";
            this.button_SaveСhanges_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_SaveСhanges_BMS.TabIndex = 2;
            this.button_SaveСhanges_BMS.Text = "Сохранить ";
            this.button_SaveСhanges_BMS.UseVisualStyleBackColor = true;
            this.button_SaveСhanges_BMS.Click += new System.EventHandler(this.button_SaveСhanges_BMS_Click);
            // 
            // dataGridView_Editing_BMS
            // 
            this.dataGridView_Editing_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Editing_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Editing_BMS.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Editing_BMS.Name = "dataGridView_Editing_BMS";
            this.dataGridView_Editing_BMS.Size = new System.Drawing.Size(779, 594);
            this.dataGridView_Editing_BMS.TabIndex = 0;
            this.dataGridView_Editing_BMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Editing_BMS_CellContentClick);
            // 
            // FormEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 594);
            this.Controls.Add(this.button_SaveСhanges_BMS);
            this.Controls.Add(this.button_LoadFileToEditing_BMS);
            this.Controls.Add(this.panel_Rich_BMS);
            this.Name = "FormEditing";
            this.Text = "FormEditing";
            this.Load += new System.EventHandler(this.FormEditing_Load);
            this.panel_Rich_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Editing_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Rich_BMS;
        private System.Windows.Forms.Button button_LoadFileToEditing_BMS;
        private System.Windows.Forms.Button button_SaveСhanges_BMS;
        private System.Windows.Forms.DataGridView dataGridView_Editing_BMS;
    }
}