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
    public partial class FormEditing : Form
    {
        public FormEditing()
        {
            InitializeComponent();
        }
        private DataTable originalDataTable;
        private string openedFilePath;
        private void button_LoadFileToEditing_BMS_Click(object sender, EventArgs e)
        
            {
                // Диалог для выбора файла
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Сохраняем путь к открытому файлу
                    openedFilePath = openFileDialog.FileName;

                    // Очищаем существующие данные в dataGridView_Editing_BMS
                    dataGridView_Editing_BMS.DataSource = null;

                    // Загружаем данные из файла CSV
                    originalDataTable = LoadDataFromCSV(openedFilePath);

                    // Заполняем dataGridView_Editing_BMS данными
                    dataGridView_Editing_BMS.DataSource = originalDataTable;
                }
            }
        private DataTable LoadDataFromCSV(string filePath)
        {
            DataTable dataTable = new DataTable();

            using (StreamReader reader = new StreamReader(filePath, Encoding.Default))
            {
                // Читаем данные из файла CSV
                string fileContent = reader.ReadToEnd();
                string[] lines = fileContent.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                // Используем первую строку файла CSV для создания колонок DataTable
                if (lines.Length > 0)
                {
                    string[] columns = lines[0].Split(';');
                    foreach (string column in columns)
                    {
                        dataTable.Columns.Add(column);
                    }
                }

                // Заполняем DataTable данными из файла CSV, начиная со второй строки
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] values = lines[i].Split(';');
                    dataTable.Rows.Add(values);
                }
            }

            return dataTable;
        }

        private void button_SaveСhanges_BMS_Click(object sender, EventArgs e)
        
            {
                // Проверяем, был ли открыт файл
                if (string.IsNullOrEmpty(openedFilePath))
                {
                    MessageBox.Show("Выберите файл для сохранения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создаем StreamWriter для записи в тот же файл в формате UTF-8
                using (StreamWriter writer = new StreamWriter(openedFilePath, false, Encoding.UTF8))
                {
                    // Записываем заголовок с именами колонок
                    foreach (DataColumn column in originalDataTable.Columns)
                    {
                        writer.Write(column.ColumnName);
                        writer.Write(";");
                    }
                    writer.WriteLine();

                    // Записываем данные из исходного DataTable
                    foreach (DataRow row in originalDataTable.Rows)
                    {
                        foreach (var value in row.ItemArray)
                        {
                            writer.Write(value);
                            writer.Write(";");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show("Изменения сохранены успешно.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            private void UpdateOriginalDataTable()
            {
                // Очищаем исходный DataTable
                originalDataTable.Clear();

                // Заполняем его данными из dataGridView_Editing_BMS
                foreach (DataGridViewRow row in dataGridView_Editing_BMS.Rows)
                {
                    DataRow newRow = originalDataTable.NewRow();

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        newRow[cell.ColumnIndex] = cell.Value;
                    }

                    originalDataTable.Rows.Add(newRow);
                }
            }

        private void FormEditing_Load(object sender, EventArgs e)
        {

        }
    }
}
