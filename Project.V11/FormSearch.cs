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
    public partial class FormSearch : Form
    {
        private DataTable originalDataTable;
        private string filePathFromFormMain;
        public FormSearch()
        {
            InitializeComponent();
            
        }
        // Свойство для установки и получения пути файла
        public string FilePathFromFormMain
        {
            get { return filePathFromFormMain; }
            set { filePathFromFormMain = value; }
        }

        private void button_Load_BMS_Click(object sender, EventArgs e)
        {
            OpenFileInFormSearch();
        }

        private void OpenFileInFormSearch()
        {
            try
            {
                // Проверяем, что путь к файлу установлен
                if (!string.IsNullOrEmpty(filePathFromFormMain) && File.Exists(filePathFromFormMain))
                {
                    // Очищаем существующие данные в dataGridView_Result_BMS
                    dataGridView_Result_BMS.DataSource = null;

                    // Загружаем данные из файла CSV
                    originalDataTable = LoadDataFromCSV(filePathFromFormMain);

                    // Заполняем dataGridView_Result_BMS данными
                    dataGridView_Result_BMS.DataSource = originalDataTable;

                    MessageBox.Show("Файл успешно загружен");
                }
                else
                {
                    MessageBox.Show("Неверный путь к файлу.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}");
            }
        }

        private DataTable LoadDataFromCSV(string filePath)
        {
            try
            {
                DataTable dataTable = new DataTable();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string[] headers = reader.ReadLine().Split(';');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(';');
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }

                        dataTable.Rows.Add(dataRow);
                    }
                }

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка при загрузке данных из CSV: {ex.Message}");
            }
        }

        private void button_Find_BMS_Click(object sender, EventArgs e)
        {
            string searchText = textBox_Find_BMS.Text;

            // Проверяем, инициализирована ли originalDataTable
            if (originalDataTable != null)
            {
                // Выполняем поиск в DataTable
                DataTable searchResult = PerformSearch(searchText);

                // Обновляем DataGridView_Find_BMS
                dataGridView_Find_BMS.DataSource = searchResult;
            }
            else
            {
                MessageBox.Show("Сначала загрузите данные перед выполнением поиска.");
            }
        }

        private DataTable PerformSearch(string searchText)
        {
            DataTable originalDataTable = this.originalDataTable;

            // Создаем новую таблицу с теми же столбцами, что и у оригинальной таблицы
            DataTable searchResult = originalDataTable.Clone();

            // Выполняем поиск в DataTable
            foreach (DataRow row in originalDataTable.Rows)
            {
                bool found = false;

                // Создаем новую строку с теми же столбцами, что и у оригинальной строки
                DataRow newRow = searchResult.NewRow();

                // Перебираем столбцы оригинальной строки
                foreach (DataColumn column in originalDataTable.Columns)
                {
                    // Получаем значение из оригинальной строки
                    string cellValue = row[column].ToString();

                    // Если значение содержит искомую подстроку, добавляем строку в результат
                    if (cellValue.Contains(searchText))
                    {
                        found = true;
                    }

                    // Присваиваем значение новой строке
                    newRow[column.ColumnName] = cellValue;
                }

                // Если хотя бы в одном столбце было найдено совпадение, добавляем строку в результат
                if (found)
                {
                    searchResult.Rows.Add(newRow);
                }
            }

            return searchResult;
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
