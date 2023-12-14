
namespace Projecrt.V11
{
    partial class FormSerch
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
            this.dataGridView_Result_BMS = new System.Windows.Forms.DataGridView();
            this.button_Load_BMS = new System.Windows.Forms.Button();
            this.textBox_Find_BMS = new System.Windows.Forms.TextBox();
            this.button_Find_BMS = new System.Windows.Forms.Button();
            this.dataGridView_Find_BMS = new System.Windows.Forms.DataGridView();
            this.groupBox_Load_BMS = new System.Windows.Forms.GroupBox();
            this.groupBox_Find_BMS = new System.Windows.Forms.GroupBox();
            this.label_Find_BMS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Find_BMS)).BeginInit();
            this.groupBox_Load_BMS.SuspendLayout();
            this.groupBox_Find_BMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Result_BMS
            // 
            this.dataGridView_Result_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result_BMS.Location = new System.Drawing.Point(238, 18);
            this.dataGridView_Result_BMS.Name = "dataGridView_Result_BMS";
            this.dataGridView_Result_BMS.Size = new System.Drawing.Size(981, 196);
            this.dataGridView_Result_BMS.TabIndex = 0;
            this.dataGridView_Result_BMS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Result_BMS_CellContentClick);
            // 
            // button_Load_BMS
            // 
            this.button_Load_BMS.Location = new System.Drawing.Point(12, 31);
            this.button_Load_BMS.Name = "button_Load_BMS";
            this.button_Load_BMS.Size = new System.Drawing.Size(173, 80);
            this.button_Load_BMS.TabIndex = 1;
            this.button_Load_BMS.Text = "Загрузить данные из файла";
            this.button_Load_BMS.UseVisualStyleBackColor = true;
            this.button_Load_BMS.Click += new System.EventHandler(this.button_Load_BMS_Click);
            // 
            // textBox_Find_BMS
            // 
            this.textBox_Find_BMS.Location = new System.Drawing.Point(9, 233);
            this.textBox_Find_BMS.Name = "textBox_Find_BMS";
            this.textBox_Find_BMS.Size = new System.Drawing.Size(107, 20);
            this.textBox_Find_BMS.TabIndex = 0;
            this.textBox_Find_BMS.TextChanged += new System.EventHandler(this.textBox_Find_BMS_TextChanged);
            // 
            // button_Find_BMS
            // 
            this.button_Find_BMS.Location = new System.Drawing.Point(139, 230);
            this.button_Find_BMS.Name = "button_Find_BMS";
            this.button_Find_BMS.Size = new System.Drawing.Size(75, 23);
            this.button_Find_BMS.TabIndex = 1;
            this.button_Find_BMS.Text = "Найти ";
            this.button_Find_BMS.UseVisualStyleBackColor = true;
            this.button_Find_BMS.Click += new System.EventHandler(this.button_Find_BMS_Click);
            // 
            // dataGridView_Find_BMS
            // 
            this.dataGridView_Find_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Find_BMS.Location = new System.Drawing.Point(238, 41);
            this.dataGridView_Find_BMS.Name = "dataGridView_Find_BMS";
            this.dataGridView_Find_BMS.Size = new System.Drawing.Size(981, 237);
            this.dataGridView_Find_BMS.TabIndex = 3;
            // 
            // groupBox_Load_BMS
            // 
            this.groupBox_Load_BMS.Controls.Add(this.dataGridView_Result_BMS);
            this.groupBox_Load_BMS.Controls.Add(this.button_Load_BMS);
            this.groupBox_Load_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Load_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Load_BMS.Name = "groupBox_Load_BMS";
            this.groupBox_Load_BMS.Size = new System.Drawing.Size(1249, 220);
            this.groupBox_Load_BMS.TabIndex = 4;
            this.groupBox_Load_BMS.TabStop = false;
            this.groupBox_Load_BMS.Text = "Загрузка данных из файла";
            // 
            // groupBox_Find_BMS
            // 
            this.groupBox_Find_BMS.Controls.Add(this.label_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.button_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.dataGridView_Find_BMS);
            this.groupBox_Find_BMS.Controls.Add(this.textBox_Find_BMS);
            this.groupBox_Find_BMS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox_Find_BMS.Location = new System.Drawing.Point(0, 302);
            this.groupBox_Find_BMS.Name = "groupBox_Find_BMS";
            this.groupBox_Find_BMS.Size = new System.Drawing.Size(1249, 284);
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
            // FormSerch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 586);
            this.Controls.Add(this.groupBox_Find_BMS);
            this.Controls.Add(this.groupBox_Load_BMS);
            this.MaximumSize = new System.Drawing.Size(1265, 625);
            this.MinimumSize = new System.Drawing.Size(1265, 625);
            this.Name = "FormSerch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск ";
            this.Load += new System.EventHandler(this.FormStatistic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Find_BMS)).EndInit();
            this.groupBox_Load_BMS.ResumeLayout(false);
            this.groupBox_Find_BMS.ResumeLayout(false);
            this.groupBox_Find_BMS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Result_BMS;
        private System.Windows.Forms.Button button_Load_BMS;
        private System.Windows.Forms.Button button_Find_BMS;
        private System.Windows.Forms.TextBox textBox_Find_BMS;
        private System.Windows.Forms.DataGridView dataGridView_Find_BMS;
        private System.Windows.Forms.GroupBox groupBox_Load_BMS;
        private System.Windows.Forms.GroupBox groupBox_Find_BMS;
        private System.Windows.Forms.Label label_Find_BMS;
    }
}