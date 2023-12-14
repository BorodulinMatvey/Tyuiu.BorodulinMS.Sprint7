using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Projecrt.V11
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void button_LastName_BMS_Click(object sender, EventArgs e)

        {
            // Получаем данные из TextBox'ов
            string LastName = textBox_LastName_BMS.Text;
            string Name = textBox_Name_BMS.Text;
            string SurName = textBox_SurName_BMS.Text;
            string Address = textBox_Address_BMS.Text;
            string PhoneNuber = textBox_PhoneNuber_BMS.Text;
            string Salarry = textBox_Salarry_BMS.Text;
            string DivisionName = textBox_DivisionName_BMS.Text;
            string DateOfBirth = textBox_DateOfBirth_BMS.Text;
            string JobTitle = textBox_JobTitle_BMS.Text;

            // Формируем строку для сохранения
            string DataToSave = $"{LastName};{Name};{SurName};{Address};{PhoneNuber};{Salarry};{DivisionName};{DateOfBirth};{JobTitle}";

            try
            {
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filePath = Path.Combine(desktopPath, "saved_data.csv");

                // Открываем файл для записи
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    // Если файл пуст, добавляем заголовки столбцов
                    if (new FileInfo(filePath).Length == 0)
                    {
                        string header = "Фамилия;Имя;Отчество;Адрес;Номер Телефона;Оклад;Наименование подразделения;Дата рождения;Должность";
                        sw.WriteLine(header);
                    }

                    // Записываем данные в новую строку
                    sw.WriteLine(DataToSave.Replace(",", ";"));
                }

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        

        private void button_Name_BMS_Click(object sender, EventArgs e)
        { 
        }

        private void button_SurName_BMS_Click(object sender, EventArgs e)
        {
            
        }
    }
}
