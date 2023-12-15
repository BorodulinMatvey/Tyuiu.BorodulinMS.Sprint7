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
        public FormSearch()
        {
            InitializeComponent();

        }
        
        private void button_Load_BMS_Click(object sender, EventArgs e)
        {
            // Диалог для выбора файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Очищаем существующие данные в dataGridView_Result_BMS
                dataGridView_Result_BMS.DataSource = null;

                // Загружаем данные из файла CSV
                string filePath = openFileDialog.FileName;
                originalDataTable = LoadDataFromCSV(filePath);

                // Заполняем dataGridView_Result_BMS данными
                dataGridView_Result_BMS.DataSource = originalDataTable;
            }
        }

        private DataTable LoadDataFromCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    // Читаем заголовки столбцов
                    string[] headers = sr.ReadLine().Split(';');

                    // Добавляем столбцы в DataTable
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    // Заполняем DataTable данными
                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(';');
                        DataRow dr = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dataTable.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }

            return dataTable;
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
