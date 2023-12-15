
namespace Project.V11
{
    partial class FormSearch
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
            this.panel_Load_BMS = new System.Windows.Forms.Panel();
            this.groupBox_Load_BMS = new System.Windows.Forms.GroupBox();
            this.dataGridView_Result_BMS = new System.Windows.Forms.DataGridView();
            this.button_Load_BMS = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox_Find_BMS = new System.Windows.Forms.GroupBox();
            this.label_Find_BMS = new System.Windows.Forms.Label();
            this.dataGridView_Find_BMS = new System.Windows.Forms.DataGridView();
            this.button_Find_BMS = new System.Windows.Forms.Button();
            this.textBox_Find_BMS = new System.Windows.Forms.TextBox();
            this.toolTip_Search_BMS = new System.Windows.Forms.ToolTip(this.components);
            this.panel_Load_BMS.SuspendLayout();
            this.groupBox_Load_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox_Find_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Find_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Load_BMS
            // 
            this.panel_Load_BMS.Controls.Add(this.groupBox_Load_BMS);
            this.panel_Load_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Load_BMS.Location = new System.Drawing.Point(0, 0);
            this.panel_Load_BMS.Name = "panel_Load_BMS";
            this.panel_Load_BMS.Size = new System.Drawing.Size(1210, 261);
            this.panel_Load_BMS.TabIndex = 7;
            // 
            // groupBox_Load_BMS
            // 
            this.groupBox_Load_BMS.Controls.Add(this.dataGridView_Result_BMS);
            this.groupBox_Load_BMS.Controls.Add(this.button_Load_BMS);
            this.groupBox_Load_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Load_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Load_BMS.Name = "groupBox_Load_BMS";
            this.groupBox_Load_BMS.Size = new System.Drawing.Size(1210, 261);
            this.groupBox_Load_BMS.TabIndex = 4;
            this.groupBox_Load_BMS.TabStop = false;
            this.groupBox_Load_BMS.Text = "Загрузка данных из файла";
            // 
            // dataGridView_Result_BMS
            // 
            this.dataGridView_Result_BMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Result_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result_BMS.Location = new System.Drawing.Point(231, 19);
            this.dataGridView_Result_BMS.Name = "dataGridView_Result_BMS";
            this.dataGridView_Result_BMS.ReadOnly = true;
            this.dataGridView_Result_BMS.Size = new System.Drawing.Size(954, 196);
            this.dataGridView_Result_BMS.TabIndex = 0;
            // 
            // button_Load_BMS
            // 
            this.button_Load_BMS.Location = new System.Drawing.Point(12, 31);
            this.button_Load_BMS.Name = "button_Load_BMS";
            this.button_Load_BMS.Size = new System.Drawing.Size(173, 80);
            this.button_Load_BMS.TabIndex = 1;
            this.button_Load_BMS.Text = "Загрузить данные из файла";
            this.toolTip_Search_BMS.SetToolTip(this.button_Load_BMS, "Эта кнопка позволяет добавить файл");
            this.button_Load_BMS.UseVisualStyleBackColor = true;
            this.button_Load_BMS.Click += new System.EventHandler(this.button_Load_BMS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox_Find_BMS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 290);
            this.panel1.TabIndex = 8;
            // 
            // groupBox_Find_BMS
            // 
            this.groupBox_Find_BMS.Controls.Add(this.label_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.dataGridView_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.button_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.textBox_Find_BMS);
            this.groupBox_Find_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Find_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Find_BMS.Name = "groupBox_Find_BMS";
            this.groupBox_Find_BMS.Size = new System.Drawing.Size(1210, 290);
            this.groupBox_Find_BMS.TabIndex = 5;
            this.groupBox_Find_BMS.TabStop = false;
            this.groupBox_Find_BMS.Text = "Поиск";
            // 
            // label_Find_BMS
            // 
            this.label_Find_BMS.Location = new System.Drawing.Point(6, 123);
            this.label_Find_BMS.Name = "label_Find_BMS";
            this.label_Find_BMS.Size = new System.Drawing.Size(162, 81);
            this.label_Find_BMS.TabIndex = 4;
            this.label_Find_BMS.Text = "Введите в поле текст, котрый нужно найти.\r\n\r\nПримечание: поиск выполняется по тек" +
    "сту в одной ячейке\r\n";
            // 
            // dataGridView_Find_BMS
            // 
            this.dataGridView_Find_BMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Find_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Find_BMS.Location = new System.Drawing.Point(231, 51);
            this.dataGridView_Find_BMS.Name = "dataGridView_Find_BMS";
            this.dataGridView_Find_BMS.ReadOnly = true;
            this.dataGridView_Find_BMS.Size = new System.Drawing.Size(954, 202);
            this.dataGridView_Find_BMS.TabIndex = 3;
            // 
            // button_Find_BMS
            // 
            this.button_Find_BMS.Location = new System.Drawing.Point(139, 230);
            this.button_Find_BMS.Name = "button_Find_BMS";
            this.button_Find_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_Find_BMS.TabIndex = 1;
            this.button_Find_BMS.Text = "Найти ";
            this.toolTip_Search_BMS.SetToolTip(this.button_Find_BMS, "Эта кнопка позволяет найти данные в файле");
            this.button_Find_BMS.UseVisualStyleBackColor = true;
            this.button_Find_BMS.Click += new System.EventHandler(this.button_Find_BMS_Click);
            // 
            // textBox_Find_BMS
            // 
            this.textBox_Find_BMS.Location = new System.Drawing.Point(9, 233);
            this.textBox_Find_BMS.Name = "textBox_Find_BMS";
            this.textBox_Find_BMS.Size = new System.Drawing.Size(107, 20);
            this.textBox_Find_BMS.TabIndex = 0;
            // 
            // toolTip_Search_BMS
            // 
            this.toolTip_Search_BMS.IsBalloon = true;
            this.toolTip_Search_BMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_Search_BMS.ToolTipTitle = "Подсказка";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 586);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Load_BMS);
            this.MinimumSize = new System.Drawing.Size(1202, 625);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск ";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.panel_Load_BMS.ResumeLayout(false);
            this.groupBox_Load_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox_Find_BMS.ResumeLayout(false);
            this.groupBox_Find_BMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Find_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Load_BMS;
        private System.Windows.Forms.GroupBox groupBox_Load_BMS;
        private System.Windows.Forms.DataGridView dataGridView_Result_BMS;
        private System.Windows.Forms.Button button_Load_BMS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox_Find_BMS;
        private System.Windows.Forms.Label label_Find_BMS;
        private System.Windows.Forms.DataGridView dataGridView_Find_BMS;
        private System.Windows.Forms.Button button_Find_BMS;
        private System.Windows.Forms.TextBox textBox_Find_BMS;
        private System.Windows.Forms.ToolTip toolTip_Search_BMS;
    }
}