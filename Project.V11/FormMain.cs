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
using System.Globalization;
using Project.V11.Lib;


namespace Project.V11
{
    public partial class FormMain : Form
    {
        private string savedFilePath = "";

        public string SavedFilePath
        {
            get { return savedFilePath; }
        }

        public FormMain()
        {
            InitializeComponent();
            
        }
        DataService ds = new DataService();

        private void button_Save_BMS_Click(object sender, EventArgs e)
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
                    // Проверяем, начинается ли номер телефона с '8'
                    if (!PhoneNumber.StartsWith("8"))
                    {
                        MessageBox.Show("Номер телефона должен начинаться с '8'.");
                        return;
                    }

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
            ClearTextBoxes();
        }

        private void button_Add_BMS_Click(object sender, EventArgs e)
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
            else if (!PhoneNumber.StartsWith("8"))
            {
                MessageBox.Show("Номер телефона должен начинаться с '8'.");
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

            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            // Очищаем все TextBox'ы
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }

        private void button_ShowResult_BMS_Click(object sender, EventArgs e)
        {
            // Проверяем, что путь к файлу сохранен
            if (string.IsNullOrEmpty(savedFilePath))
            {
                MessageBox.Show("Пожалуйста, сначала сохраните данные.");
                return;
            }

            try
            {
                // Используем System.IO для подсчета строк в файле
                int lineCount = DataService.CountCsvLines(savedFilePath);

                // Выводим результат в textBox_Employees_BMS
                textBox_Employees_BMS.Text = lineCount.ToString();

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

                    // Очищаем существующие строки в DataTable
                    dataTable.Clear();

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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_Help_BMS_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }

        private void button_ShowResuktEditing_BMS_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, есть ли сохраненный путь к файлу
                if (string.IsNullOrEmpty(savedFilePath))
                {
                    MessageBox.Show("Файл не был загружен. Нельзя отобразить данные.");
                    return;
                }

                // Читаем данные из файла и заполняем DataTable
                DataTable resultDataTable = ReadDataFromFile(savedFilePath);

                // Устанавливаем источник данных в dataGridView_Result_BMS
                dataGridView_Result_BMS.DataSource = resultDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при отображении данных: {ex.Message}");
            }
        }

        private DataTable ReadDataFromFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                // Читаем все строки из файла
                string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                if (lines.Length > 0)
                {
                    // Разделяем заголовки столбцов
                    string[] headers = lines[0].Split(';');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Пропускаем первую строку (заголовки) и читаем остальные строки данных
                    for (int i = 1; i < lines.Length; i++)
                    {
                        string[] fields = lines[i].Split(';');
                        dataTable.Rows.Add(fields);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении данных из файла: {ex.Message}");
            }

            return dataTable;
        }

        private void panel_Button_BMS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Find_BMS_Click(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(savedFilePath))
                {
                    string searchText = textBox_Find_BMS.Text;

                    DataTable searchResult = PerformSearchInFile(searchText, savedFilePath);

                    dataGridView_Result_BMS.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("Выберите файл перед выполнением поиска.");
                }
            }


        }

        private DataTable PerformSearchInFile(string searchText, string filePath)
        {
            DataTable originalDataTable = ReadDatafromFile(filePath);

            if (originalDataTable != null)
            {
                // Добавим временный столбец для хранения значения, показывающего, содержится ли искомый текст в строке
                originalDataTable.Columns.Add("__IsSearchResult", typeof(bool));

                // Выполняем поиск в DataTable
                foreach (DataRow row in originalDataTable.Rows)
                {
                    bool found = false;

                    // Перебираем столбцы оригинальной строки
                    foreach (DataColumn column in originalDataTable.Columns)
                    {
                        // Получаем значение из оригинальной строки
                        string cellValue = row[column].ToString();

                        // Если значение содержит искомую подстроку, устанавливаем флаг found в true
                        if (cellValue.Contains(searchText))
                        {
                            found = true;
                            break;
                        }
                    }

                    // Устанавливаем значение временного столбца
                    row["__IsSearchResult"] = found;
                }

                // Сортируем по временному столбцу
                originalDataTable.DefaultView.Sort = "__IsSearchResult DESC";

                // Создаем новую таблицу с теми же столбцами, что и у оригинальной таблицы
                DataTable searchResult = originalDataTable.Clone();

                // Копируем строки из отсортированного представления
                foreach (DataRowView rowView in originalDataTable.DefaultView)
                {
                    DataRow row = searchResult.NewRow();
                    row.ItemArray = rowView.Row.ItemArray;
                    searchResult.Rows.Add(row);
                }

                // Удаляем временный столбец
                searchResult.Columns.Remove("__IsSearchResult");

                return searchResult;
            }
            else
            {
                MessageBox.Show("Не удалось прочитать данные из файла.");
                return null;
            }
        }

        private DataTable ReadDatafromFile(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] headers = reader.ReadLine().Split(';');

                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header.Trim());
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] values = reader.ReadLine().Split(';');
                        DataRow row = dataTable.NewRow();

                        for (int i = 0; i < values.Length; i++)
                        {
                            row[i] = values[i].Trim();
                        }

                        dataTable.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении данных из файла: {ex.Message}");
                return null;
            }

            return dataTable;
        }

        private void button_SaveEditing_BMS_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что путь к файлу сохранения установлен
                if (string.IsNullOrEmpty(savedFilePath))
                {
                    MessageBox.Show("Пожалуйста, укажите путь для сохранения данных.");
                    return;
                }

                // Получаем данные из dataGridView_Result_BMS и формируем строку для сохранения
                StringBuilder dataToSave = new StringBuilder();

                // Заголовки столбцов
                for (int i = 0; i < dataGridView_Result_BMS.Columns.Count; i++)
                {
                    dataToSave.Append(dataGridView_Result_BMS.Columns[i].HeaderText);
                    if (i < dataGridView_Result_BMS.Columns.Count - 1)
                    {
                        dataToSave.Append(";");
                    }
                }
                dataToSave.AppendLine();

                // Синхронизируем изменения из DataGridView с исходным источником данных (DataTable)
                dataGridView_Result_BMS.EndEdit();
                (dataGridView_Result_BMS.DataSource as DataTable)?.AcceptChanges();

                // Данные строк
                foreach (DataRowView rowView in (dataGridView_Result_BMS.DataSource as DataTable)?.DefaultView)
                {
                    DataRow row = rowView.Row;
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        dataToSave.Append(row[i]);
                        if (i < row.ItemArray.Length - 1)
                        {
                            dataToSave.Append(";");
                        }
                    }
                    dataToSave.AppendLine();
                }

                // Сохраняем данные в указанный файл
                File.WriteAllText(savedFilePath, dataToSave.ToString(), Encoding.UTF8);

                MessageBox.Show("Данные успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
        }
        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && cell.Value.ToString() != string.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        private void textBox_PhoneNuber_BMS_TextChanged(object sender, EventArgs e)
        {
            // Получаем текущий текст из текстового поля
            string currentText = textBox_PhoneNuber_BMS.Text;

            // Проверяем, содержит ли текст буквы
            if (currentText.Any(char.IsLetter))
            {
                // Если есть буквы, выдаем ошибку и очищаем поле
                MessageBox.Show("Пожалуйста, вводите только цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_PhoneNuber_BMS.Clear();
                return;
            }

            // Создаем новую строку, оставляя только цифры и управляющие символы
            string filteredText = new string(currentText.Where(c => char.IsDigit(c) || char.IsControl(c)).ToArray());

            // Если текст изменился, обновляем текстовое поле
            if (currentText != filteredText)
            {
                textBox_PhoneNuber_BMS.Text = filteredText;

                // Устанавливаем курсор в конец текста
                textBox_PhoneNuber_BMS.SelectionStart = filteredText.Length;
            }
        }

        private void textBox_Salarry_BMS_TextChanged(object sender, EventArgs e)
        {
            {
                // Получаем текущий текст из текстового поля
                string currentText = textBox_Salarry_BMS.Text;

                // Проверяем, содержит ли текст буквы
                if (currentText.Any(char.IsLetter))
                {
                    // Если есть буквы, выдаем ошибку и очищаем поле
                    MessageBox.Show("Пожалуйста, вводите только цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_Salarry_BMS.Clear();
                    return;
                }

                // Создаем новую строку, оставляя только цифры и управляющие символы
                string filteredText = new string(currentText.Where(c => char.IsDigit(c) || char.IsControl(c)).ToArray());

                // Если текст изменился, обновляем текстовое поле
                if (currentText != filteredText)
                {
                    textBox_Salarry_BMS.Text = filteredText;

                    // Устанавливаем курсор в конец текста
                    textBox_Salarry_BMS.SelectionStart = filteredText.Length;
                }
            }
        }

        private void textBox_DateOfBirth_BMS_TextChanged(object sender, EventArgs e)
        {
            // Получаем текущий текст из текстового поля
            string currentText = textBox_DateOfBirth_BMS.Text;

            // Проверяем, соответствует ли текст формату "dd.MM.yyyy"
            if (currentText.Length == 10 && !IsValidDateFormat(currentText))
            {
                // Если формат неверный, выдаем ошибку и очищаем поле
                MessageBox.Show("Пожалуйста, введите дату в формате dd.MM.yyyy.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_DateOfBirth_BMS.Clear();
                return;
            }
        }
        private bool IsValidDateFormat(string dateText)
        {
            DateTime result;
            return DateTime.TryParseExact(dateText, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out result);
        }
    }
}
    

