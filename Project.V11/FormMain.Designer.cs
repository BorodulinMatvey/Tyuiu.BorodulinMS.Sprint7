
namespace Project.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_Button_BMS = new System.Windows.Forms.Panel();
            this.button_Editing_BMS = new System.Windows.Forms.Button();
            this.button_Serch_BMS = new System.Windows.Forms.Button();
            this.panel_Add_BMS = new System.Windows.Forms.Panel();
            this.groupBox_Add_BMS = new System.Windows.Forms.GroupBox();
            this.button_Help_BMS = new System.Windows.Forms.Button();
            this.button_Add_BMS = new System.Windows.Forms.Button();
            this.button_Save_BMS = new System.Windows.Forms.Button();
            this.textBox_JobTitle_BMS = new System.Windows.Forms.TextBox();
            this.textBox_Name_BMS = new System.Windows.Forms.TextBox();
            this.textBox_PhoneNuber_BMS = new System.Windows.Forms.TextBox();
            this.textBox_SurName_BMS = new System.Windows.Forms.TextBox();
            this.textBox_DateOfBirth_BMS = new System.Windows.Forms.TextBox();
            this.textBox_LastName_BMS = new System.Windows.Forms.TextBox();
            this.textBox_Address_BMS = new System.Windows.Forms.TextBox();
            this.textBox_DivisionName_BMS = new System.Windows.Forms.TextBox();
            this.textBox_Salarry_BMS = new System.Windows.Forms.TextBox();
            this.label_LastName_BMS = new System.Windows.Forms.Label();
            this.label_Name_BMS = new System.Windows.Forms.Label();
            this.label_DivisionName_BMS = new System.Windows.Forms.Label();
            this.label_SurName_BMS = new System.Windows.Forms.Label();
            this.label_Salarry_BMS = new System.Windows.Forms.Label();
            this.label_Address_BMS = new System.Windows.Forms.Label();
            this.label_JobTitle_BMS = new System.Windows.Forms.Label();
            this.label_PhoneNuber_BMS = new System.Windows.Forms.Label();
            this.label_DateOfBirth_BMS = new System.Windows.Forms.Label();
            this.button_ShowResult_BMS = new System.Windows.Forms.Button();
            this.panel_ResultAdd_BMS = new System.Windows.Forms.Panel();
            this.groupBox_Result_BMS = new System.Windows.Forms.GroupBox();
            this.dataGridView_Result_BMS = new System.Windows.Forms.DataGridView();
            this.toolTip_FormMain_BMS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_SaveFile_BMS = new System.Windows.Forms.SaveFileDialog();
            this.panel_Button_BMS.SuspendLayout();
            this.panel_Add_BMS.SuspendLayout();
            this.groupBox_Add_BMS.SuspendLayout();
            this.panel_ResultAdd_BMS.SuspendLayout();
            this.groupBox_Result_BMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Button_BMS
            // 
            this.panel_Button_BMS.Controls.Add(this.button_Editing_BMS);
            this.panel_Button_BMS.Controls.Add(this.button_Serch_BMS);
            this.panel_Button_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Button_BMS.Location = new System.Drawing.Point(0, 0);
            this.panel_Button_BMS.Name = "panel_Button_BMS";
            this.panel_Button_BMS.Size = new System.Drawing.Size(1039, 81);
            this.panel_Button_BMS.TabIndex = 6;
            // 
            // button_Editing_BMS
            // 
            this.button_Editing_BMS.Location = new System.Drawing.Point(87, 12);
            this.button_Editing_BMS.Name = "button_Editing_BMS";
            this.button_Editing_BMS.Size = new System.Drawing.Size(104, 49);
            this.button_Editing_BMS.TabIndex = 3;
            this.button_Editing_BMS.Text = "Редактирование ";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Editing_BMS, "Перейти в окно редактирования ");
            this.button_Editing_BMS.UseVisualStyleBackColor = true;
            this.button_Editing_BMS.Click += new System.EventHandler(this.button_Editing_BMS_Click);
            // 
            // button_Serch_BMS
            // 
            this.button_Serch_BMS.Location = new System.Drawing.Point(12, 12);
            this.button_Serch_BMS.Name = "button_Serch_BMS";
            this.button_Serch_BMS.Size = new System.Drawing.Size(69, 49);
            this.button_Serch_BMS.TabIndex = 2;
            this.button_Serch_BMS.Text = "Поиск";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Serch_BMS, "Перейти в окно поиска");
            this.button_Serch_BMS.UseVisualStyleBackColor = true;
            this.button_Serch_BMS.Click += new System.EventHandler(this.button_Serch_BMS_Click);
            // 
            // panel_Add_BMS
            // 
            this.panel_Add_BMS.Controls.Add(this.groupBox_Add_BMS);
            this.panel_Add_BMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Add_BMS.Location = new System.Drawing.Point(0, 81);
            this.panel_Add_BMS.Name = "panel_Add_BMS";
            this.panel_Add_BMS.Size = new System.Drawing.Size(510, 456);
            this.panel_Add_BMS.TabIndex = 7;
            // 
            // groupBox_Add_BMS
            // 
            this.groupBox_Add_BMS.Controls.Add(this.button_Help_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.button_Add_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.button_Save_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_JobTitle_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_Name_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_PhoneNuber_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_SurName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_DateOfBirth_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_LastName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_Address_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_DivisionName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.textBox_Salarry_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_LastName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_Name_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_DivisionName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_SurName_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_Salarry_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_Address_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_JobTitle_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_PhoneNuber_BMS);
            this.groupBox_Add_BMS.Controls.Add(this.label_DateOfBirth_BMS);
            this.groupBox_Add_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Add_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Add_BMS.Name = "groupBox_Add_BMS";
            this.groupBox_Add_BMS.Size = new System.Drawing.Size(510, 456);
            this.groupBox_Add_BMS.TabIndex = 0;
            this.groupBox_Add_BMS.TabStop = false;
            this.groupBox_Add_BMS.Text = "Добавьте данные";
            // 
            // button_Help_BMS
            // 
            this.button_Help_BMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Help_BMS.Image = ((System.Drawing.Image)(resources.GetObject("button_Help_BMS.Image")));
            this.button_Help_BMS.Location = new System.Drawing.Point(445, 19);
            this.button_Help_BMS.Name = "button_Help_BMS";
            this.button_Help_BMS.Size = new System.Drawing.Size(47, 43);
            this.button_Help_BMS.TabIndex = 27;
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Help_BMS, "Как работает данная часть приложения ");
            this.button_Help_BMS.UseVisualStyleBackColor = true;
            this.button_Help_BMS.Click += new System.EventHandler(this.button_Help_BMS_Click);
            // 
            // button_Add_BMS
            // 
            this.button_Add_BMS.Location = new System.Drawing.Point(73, 44);
            this.button_Add_BMS.Name = "button_Add_BMS";
            this.button_Add_BMS.Size = new System.Drawing.Size(91, 52);
            this.button_Add_BMS.TabIndex = 26;
            this.button_Add_BMS.Text = "Добавить данные";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Add_BMS, "С помощью этой кнопке можно добавить данные в таблицу из формы ниже");
            this.button_Add_BMS.UseVisualStyleBackColor = true;
            this.button_Add_BMS.Click += new System.EventHandler(this.button_Add_BMS_Click);
            // 
            // button_Save_BMS
            // 
            this.button_Save_BMS.Image = ((System.Drawing.Image)(resources.GetObject("button_Save_BMS.Image")));
            this.button_Save_BMS.Location = new System.Drawing.Point(15, 44);
            this.button_Save_BMS.Name = "button_Save_BMS";
            this.button_Save_BMS.Size = new System.Drawing.Size(52, 52);
            this.button_Save_BMS.TabIndex = 4;
            this.toolTip_FormMain_BMS.SetToolTip(this.button_Save_BMS, "Эта кнопка отвечает за первое создание файла и за первое добавление данных\r\n");
            this.button_Save_BMS.UseVisualStyleBackColor = true;
            this.button_Save_BMS.Click += new System.EventHandler(this.button_Save_BMS_Click);
            // 
            // textBox_JobTitle_BMS
            // 
            this.textBox_JobTitle_BMS.Location = new System.Drawing.Point(308, 311);
            this.textBox_JobTitle_BMS.Name = "textBox_JobTitle_BMS";
            this.textBox_JobTitle_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_JobTitle_BMS.TabIndex = 16;
            // 
            // textBox_Name_BMS
            // 
            this.textBox_Name_BMS.Location = new System.Drawing.Point(308, 122);
            this.textBox_Name_BMS.Name = "textBox_Name_BMS";
            this.textBox_Name_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_Name_BMS.TabIndex = 17;
            // 
            // textBox_PhoneNuber_BMS
            // 
            this.textBox_PhoneNuber_BMS.Location = new System.Drawing.Point(308, 200);
            this.textBox_PhoneNuber_BMS.Name = "textBox_PhoneNuber_BMS";
            this.textBox_PhoneNuber_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_PhoneNuber_BMS.TabIndex = 18;
            // 
            // textBox_SurName_BMS
            // 
            this.textBox_SurName_BMS.Location = new System.Drawing.Point(308, 148);
            this.textBox_SurName_BMS.Name = "textBox_SurName_BMS";
            this.textBox_SurName_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_SurName_BMS.TabIndex = 19;
            // 
            // textBox_DateOfBirth_BMS
            // 
            this.textBox_DateOfBirth_BMS.Location = new System.Drawing.Point(308, 278);
            this.textBox_DateOfBirth_BMS.Name = "textBox_DateOfBirth_BMS";
            this.textBox_DateOfBirth_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_DateOfBirth_BMS.TabIndex = 20;
            // 
            // textBox_LastName_BMS
            // 
            this.textBox_LastName_BMS.Location = new System.Drawing.Point(308, 96);
            this.textBox_LastName_BMS.Name = "textBox_LastName_BMS";
            this.textBox_LastName_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_LastName_BMS.TabIndex = 21;
            // 
            // textBox_Address_BMS
            // 
            this.textBox_Address_BMS.Location = new System.Drawing.Point(308, 174);
            this.textBox_Address_BMS.Name = "textBox_Address_BMS";
            this.textBox_Address_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_Address_BMS.TabIndex = 22;
            // 
            // textBox_DivisionName_BMS
            // 
            this.textBox_DivisionName_BMS.Location = new System.Drawing.Point(308, 252);
            this.textBox_DivisionName_BMS.Name = "textBox_DivisionName_BMS";
            this.textBox_DivisionName_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_DivisionName_BMS.TabIndex = 23;
            // 
            // textBox_Salarry_BMS
            // 
            this.textBox_Salarry_BMS.Location = new System.Drawing.Point(308, 226);
            this.textBox_Salarry_BMS.Name = "textBox_Salarry_BMS";
            this.textBox_Salarry_BMS.Size = new System.Drawing.Size(157, 20);
            this.textBox_Salarry_BMS.TabIndex = 24;
            // 
            // label_LastName_BMS
            // 
            this.label_LastName_BMS.AutoSize = true;
            this.label_LastName_BMS.Location = new System.Drawing.Point(12, 99);
            this.label_LastName_BMS.Name = "label_LastName_BMS";
            this.label_LastName_BMS.Size = new System.Drawing.Size(164, 13);
            this.label_LastName_BMS.TabIndex = 7;
            this.label_LastName_BMS.Text = "Введите фамилию сотрудника ";
            // 
            // label_Name_BMS
            // 
            this.label_Name_BMS.AutoSize = true;
            this.label_Name_BMS.Location = new System.Drawing.Point(12, 129);
            this.label_Name_BMS.Name = "label_Name_BMS";
            this.label_Name_BMS.Size = new System.Drawing.Size(133, 13);
            this.label_Name_BMS.TabIndex = 8;
            this.label_Name_BMS.Text = "Введите имя сотрудника";
            // 
            // label_DivisionName_BMS
            // 
            this.label_DivisionName_BMS.AutoSize = true;
            this.label_DivisionName_BMS.Location = new System.Drawing.Point(12, 259);
            this.label_DivisionName_BMS.Name = "label_DivisionName_BMS";
            this.label_DivisionName_BMS.Size = new System.Drawing.Size(268, 13);
            this.label_DivisionName_BMS.TabIndex = 9;
            this.label_DivisionName_BMS.Text = "Введите наименование подразделения сотрудника";
            // 
            // label_SurName_BMS
            // 
            this.label_SurName_BMS.AutoSize = true;
            this.label_SurName_BMS.Location = new System.Drawing.Point(12, 155);
            this.label_SurName_BMS.Name = "label_SurName_BMS";
            this.label_SurName_BMS.Size = new System.Drawing.Size(161, 13);
            this.label_SurName_BMS.TabIndex = 10;
            this.label_SurName_BMS.Text = "Введите отчество сотрудника ";
            // 
            // label_Salarry_BMS
            // 
            this.label_Salarry_BMS.AutoSize = true;
            this.label_Salarry_BMS.Location = new System.Drawing.Point(12, 233);
            this.label_Salarry_BMS.Name = "label_Salarry_BMS";
            this.label_Salarry_BMS.Size = new System.Drawing.Size(143, 13);
            this.label_Salarry_BMS.TabIndex = 11;
            this.label_Salarry_BMS.Text = "Введите оклад сотрудника";
            // 
            // label_Address_BMS
            // 
            this.label_Address_BMS.AutoSize = true;
            this.label_Address_BMS.Location = new System.Drawing.Point(12, 181);
            this.label_Address_BMS.Name = "label_Address_BMS";
            this.label_Address_BMS.Size = new System.Drawing.Size(143, 13);
            this.label_Address_BMS.TabIndex = 12;
            this.label_Address_BMS.Text = "Введите адрес сотрудника";
            // 
            // label_JobTitle_BMS
            // 
            this.label_JobTitle_BMS.AutoSize = true;
            this.label_JobTitle_BMS.Location = new System.Drawing.Point(12, 314);
            this.label_JobTitle_BMS.Name = "label_JobTitle_BMS";
            this.label_JobTitle_BMS.Size = new System.Drawing.Size(168, 13);
            this.label_JobTitle_BMS.TabIndex = 13;
            this.label_JobTitle_BMS.Text = "Введите должность сотрудника";
            // 
            // label_PhoneNuber_BMS
            // 
            this.label_PhoneNuber_BMS.AutoSize = true;
            this.label_PhoneNuber_BMS.Location = new System.Drawing.Point(12, 207);
            this.label_PhoneNuber_BMS.Name = "label_PhoneNuber_BMS";
            this.label_PhoneNuber_BMS.Size = new System.Drawing.Size(265, 13);
            this.label_PhoneNuber_BMS.TabIndex = 14;
            this.label_PhoneNuber_BMS.Text = "Введите номер телефона сотрудника (начиная с 8)";
            // 
            // label_DateOfBirth_BMS
            // 
            this.label_DateOfBirth_BMS.AutoSize = true;
            this.label_DateOfBirth_BMS.Location = new System.Drawing.Point(12, 285);
            this.label_DateOfBirth_BMS.Name = "label_DateOfBirth_BMS";
            this.label_DateOfBirth_BMS.Size = new System.Drawing.Size(243, 13);
            this.label_DateOfBirth_BMS.TabIndex = 15;
            this.label_DateOfBirth_BMS.Text = "Введите дату рождения сотрудника (цифрами)";
            // 
            // button_ShowResult_BMS
            // 
            this.button_ShowResult_BMS.Location = new System.Drawing.Point(18, 379);
            this.button_ShowResult_BMS.Name = "button_ShowResult_BMS";
            this.button_ShowResult_BMS.Size = new System.Drawing.Size(93, 52);
            this.button_ShowResult_BMS.TabIndex = 25;
            this.button_ShowResult_BMS.Text = "Показать добавленныен данные ";
            this.toolTip_FormMain_BMS.SetToolTip(this.button_ShowResult_BMS, "Эта кнопка позволяет увидеть добавленные данные");
            this.button_ShowResult_BMS.UseVisualStyleBackColor = true;
            this.button_ShowResult_BMS.Click += new System.EventHandler(this.button_ShowResult_BMS_Click);
            // 
            // panel_ResultAdd_BMS
            // 
            this.panel_ResultAdd_BMS.Controls.Add(this.groupBox_Result_BMS);
            this.panel_ResultAdd_BMS.Controls.Add(this.button_ShowResult_BMS);
            this.panel_ResultAdd_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ResultAdd_BMS.Location = new System.Drawing.Point(510, 81);
            this.panel_ResultAdd_BMS.Name = "panel_ResultAdd_BMS";
            this.panel_ResultAdd_BMS.Size = new System.Drawing.Size(529, 456);
            this.panel_ResultAdd_BMS.TabIndex = 8;
            // 
            // groupBox_Result_BMS
            // 
            this.groupBox_Result_BMS.Controls.Add(this.dataGridView_Result_BMS);
            this.groupBox_Result_BMS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_Result_BMS.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Result_BMS.Name = "groupBox_Result_BMS";
            this.groupBox_Result_BMS.Size = new System.Drawing.Size(529, 373);
            this.groupBox_Result_BMS.TabIndex = 26;
            this.groupBox_Result_BMS.TabStop = false;
            this.groupBox_Result_BMS.Text = "Вывод данных";
            // 
            // dataGridView_Result_BMS
            // 
            this.dataGridView_Result_BMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Result_BMS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Result_BMS.Location = new System.Drawing.Point(3, 16);
            this.dataGridView_Result_BMS.Name = "dataGridView_Result_BMS";
            this.dataGridView_Result_BMS.ReadOnly = true;
            this.dataGridView_Result_BMS.Size = new System.Drawing.Size(523, 354);
            this.dataGridView_Result_BMS.TabIndex = 0;
            // 
            // toolTip_FormMain_BMS
            // 
            this.toolTip_FormMain_BMS.IsBalloon = true;
            this.toolTip_FormMain_BMS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_FormMain_BMS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 537);
            this.Controls.Add(this.panel_ResultAdd_BMS);
            this.Controls.Add(this.panel_Add_BMS);
            this.Controls.Add(this.panel_Button_BMS);
            this.MinimumSize = new System.Drawing.Size(1055, 576);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_Button_BMS.ResumeLayout(false);
            this.panel_Add_BMS.ResumeLayout(false);
            this.groupBox_Add_BMS.ResumeLayout(false);
            this.groupBox_Add_BMS.PerformLayout();
            this.panel_ResultAdd_BMS.ResumeLayout(false);
            this.groupBox_Result_BMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Result_BMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Button_BMS;
        private System.Windows.Forms.Button button_Editing_BMS;
        private System.Windows.Forms.Button button_Serch_BMS;
        private System.Windows.Forms.Panel panel_Add_BMS;
        private System.Windows.Forms.GroupBox groupBox_Add_BMS;
        private System.Windows.Forms.Button button_Add_BMS;
        private System.Windows.Forms.Button button_ShowResult_BMS;
        private System.Windows.Forms.Button button_Save_BMS;
        private System.Windows.Forms.TextBox textBox_JobTitle_BMS;
        private System.Windows.Forms.TextBox textBox_Name_BMS;
        private System.Windows.Forms.TextBox textBox_PhoneNuber_BMS;
        private System.Windows.Forms.TextBox textBox_SurName_BMS;
        private System.Windows.Forms.TextBox textBox_DateOfBirth_BMS;
        private System.Windows.Forms.TextBox textBox_LastName_BMS;
        private System.Windows.Forms.TextBox textBox_Address_BMS;
        private System.Windows.Forms.TextBox textBox_DivisionName_BMS;
        private System.Windows.Forms.TextBox textBox_Salarry_BMS;
        private System.Windows.Forms.Label label_LastName_BMS;
        private System.Windows.Forms.Label label_Name_BMS;
        private System.Windows.Forms.Label label_DivisionName_BMS;
        private System.Windows.Forms.Label label_SurName_BMS;
        private System.Windows.Forms.Label label_Salarry_BMS;
        private System.Windows.Forms.Label label_Address_BMS;
        private System.Windows.Forms.Label label_JobTitle_BMS;
        private System.Windows.Forms.Label label_PhoneNuber_BMS;
        private System.Windows.Forms.Label label_DateOfBirth_BMS;
        private System.Windows.Forms.Panel panel_ResultAdd_BMS;
        private System.Windows.Forms.DataGridView dataGridView_Result_BMS;
        private System.Windows.Forms.ToolTip toolTip_FormMain_BMS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveFile_BMS;
        private System.Windows.Forms.GroupBox groupBox_Result_BMS;
        private System.Windows.Forms.Button button_Help_BMS;
    }
}

