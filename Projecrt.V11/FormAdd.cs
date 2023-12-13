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
            // Получаем текст из TextBox
            string nAme = textBox_Name_BMS.Text;
            string lnAme = textBox_LastName_BMS.Text;
            string aDdrees = textBox_Address_BMS.Text;
            string dateofbirth = textBox_DateOfBirth_BMS.Text;

            // Проверяем, содержит ли TextBox текст
            if (string.IsNullOrEmpty(nAme) || string.IsNullOrEmpty(lnAme) || string.IsNullOrEmpty(aDdrees) || string.IsNullOrEmpty(dateofbirth))
            {
                MessageBox.Show("Пожалуйста, введите текст в поле со здвездочкой (*).");
                return; // Останавливаем выполнение сохранения из-за невалидных данных
            }

            

           

            {
                //Формируем ячейки Exel
                string lastName = "Фамилия";
                string name = "Имя";
                string surName = "Отчество";
                string address = "Адрес";
                string phoneNuber = "Номер Телефона";
                string salarry = "Оклад";
                string divisionName = "Наименование подразделения";
                string dateOfBirth = "Дата рождения";
                string jobTitle = "Должность";
                // Формируем строку для сохранения
                string dataToSave = $"{lastName};{name};{surName};{address};{phoneNuber};{salarry};{divisionName};{dateOfBirth};{jobTitle}";
                // Открываем файл для записи (если файла нет, он будет создан)
                using (StreamWriter sw = new StreamWriter("saved_data.csv", true, Encoding.UTF8))
                {


                    if (new FileInfo("saved_data.csv").Length == 0)
                    {
                        sw.WriteLine(string.Join(",", dataToSave));
                    }

                }
            }
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
                    // Открываем файл для записи (если файла нет, он будет создан)
                    using (StreamWriter sw = new StreamWriter("saved_data.csv", true, Encoding.UTF8))
                    {

                        // Записываем данные в новый столбец
                        sw.WriteLine(DataToSave.Replace(",", ";\t"));
                    }

                    MessageBox.Show("Данные успешно сохранены!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                }
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
