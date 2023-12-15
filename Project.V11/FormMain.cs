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

namespace Project.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private string savedFilePath;
        private void button_Save_BMS_Click(object sender, EventArgs e)
        {
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    savedFilePath = saveFileDialog.FileName;

                    // Получаем данные из TextBox'ов
                    string LastName = textBox_LastName_BMS.Text;
                    string Name = textBox_Name_BMS.Text;
                    string SurName = textBox_SurName_BMS.Text;
                    string Address = textBox_Address_BMS.Text;
                    string PhoneNumber = textBox_PhoneNuber_BMS.Text;
                    string Salary = textBox_Salarry_BMS.Text;
                    string DivisionName = textBox_DivisionName_BMS.Text;
                    string DateOfBirth = textBox_DateOfBirth_BMS.Text;
                    string JobTitle = textBox_JobTitle_BMS.Text;

                    // Проверяем, что все TextBox'ы содержат текст
                    if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(SurName) ||
                        string.IsNullOrWhiteSpace(Address) || string.IsNullOrWhiteSpace(PhoneNumber) || string.IsNullOrWhiteSpace(Salary) ||
                        string.IsNullOrWhiteSpace(DivisionName) || string.IsNullOrWhiteSpace(DateOfBirth) || string.IsNullOrWhiteSpace(JobTitle))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля перед сохранением данных.");
                    }
                    else
                    {
                        // Формируем строку для сохранения
                        string dataToSave = $"{LastName};{Name};{SurName};{Address};{PhoneNumber};{Salary};{DivisionName};{DateOfBirth};{JobTitle}";

                        try
                        {
                            // Открываем файл для записи с кодировкой UTF-8
                            using (StreamWriter sw = new StreamWriter(savedFilePath, true, Encoding.UTF8))
                            {
                                // Если файл пуст, добавляем заголовки столбцов
                                if (new FileInfo(savedFilePath).Length == 0)
                                {
                                    string header = "Фамилия;Имя;Отчество;Адрес;Номер Телефона;Оклад;Наименование подразделения;Дата рождения;Должность";
                                    sw.WriteLine(header);
                                }

                                // Записываем данные в новую строку
                                sw.WriteLine(dataToSave);
                            }

                            MessageBox.Show("Данные успешно сохранены!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void button_Add_BMS_Click(object sender, EventArgs e)
        {
            {
                {
                    // Получаем данные из TextBox'ов
                    string LastName = textBox_LastName_BMS.Text;
                    string Name = textBox_Name_BMS.Text;
                    string SurName = textBox_SurName_BMS.Text;
                    string Address = textBox_Address_BMS.Text;
                    string PhoneNumber = textBox_PhoneNuber_BMS.Text;
                    string Salary = textBox_Salarry_BMS.Text;
                    string DivisionName = textBox_DivisionName_BMS.Text;
                    string DateOfBirth = textBox_DateOfBirth_BMS.Text;
                    string JobTitle = textBox_JobTitle_BMS.Text;

                    // Проверяем, что все TextBox'ы содержат текст
                    if (string.IsNullOrWhiteSpace(LastName) || string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(SurName) ||
                        string.IsNullOrWhiteSpace(Address) || string.IsNullOrWhiteSpace(PhoneNumber) || string.IsNullOrWhiteSpace(Salary) ||
                        string.IsNullOrWhiteSpace(DivisionName) || string.IsNullOrWhiteSpace(DateOfBirth) || string.IsNullOrWhiteSpace(JobTitle))
                    {
                        MessageBox.Show("Пожалуйста, заполните все поля перед сохранением данных.");
                    }
                    else
                    {
                        // Формируем строку для сохранения
                        string dataToSave = $"{LastName};{Name};{SurName};{Address};{PhoneNumber};{Salary};{DivisionName};{DateOfBirth};{JobTitle}";

                        try
                        {
                            // Открываем файл для записи с кодировкой UTF-8
                            using (StreamWriter sw = new StreamWriter(savedFilePath, true, Encoding.UTF8))
                            {
                                // Если файл пуст, добавляем заголовки столбцов
                                if (new FileInfo(savedFilePath).Length == 0)
                                {
                                    string header = "Фамилия;Имя;Отчество;Адрес;Номер Телефона;Оклад;Наименование подразделения;Дата рождения;Должность";
                                    sw.WriteLine(header);
                                }

                                // Записываем данные в новую строку
                                sw.WriteLine(dataToSave);
                            }

                            MessageBox.Show("Данные успешно сохранены!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void button_ShowResult_BMS_Click(object sender, EventArgs e)
        {
            {
                // Проверяем, что путь к файлу сохранен
                if (string.IsNullOrEmpty(savedFilePath))
                {
                    MessageBox.Show("Пожалуйста, сначала сохраните данные.");
                    return;
                }

                try
                {
                    // Открываем файл для чтения
                    using (StreamReader sr = new StreamReader(savedFilePath, Encoding.UTF8))
                    {
                        // Создаем DataTable
                        DataTable dataTable = new DataTable();

                        // Читаем заголовки из файла и добавляем столбцы в DataTable
                        string[] headers = sr.ReadLine().Split(';');
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        // Читаем данные из файла и добавляем строки в DataTable
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(';');
                            dataTable.Rows.Add(rows);
                        }

                        // Заполняем DataGridView данными из DataTable
                        dataGridView_Result_BMS.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке данных из файла: {ex.Message}");
                }
            }
        }

        private void button_Serch_BMS_Click(object sender, EventArgs e)
        {
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }

        private void button_Editing_BMS_Click(object sender, EventArgs e)
        {
            FormEditing formEditing = new FormEditing();
            formEditing.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_Help_BMS_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
    }
}
