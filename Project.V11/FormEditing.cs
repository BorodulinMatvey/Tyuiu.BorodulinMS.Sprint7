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
        private string filePathForEditing;

        public FormEditing(string filePath)
        {
            InitializeComponent();
            filePathForEditing = filePath;
        }
       



        
        private void button_LoadFileToEditing_BMS_Click(object sender, EventArgs e)
        {
            try
            {

                // Проверяем, что путь к файлу сохранен
                if (string.IsNullOrEmpty(filePathForEditing))
                {
                    MessageBox.Show("Пожалуйста, сначала сохраните данные.");
                    return;
                }

                // Читаем данные из файла и заполняем DataTable
                DataTable resultDataTable = ReadDataFromFile(filePathForEditing);

                // Устанавливаем источник данных в dataGridView_Editing_BMS
                dataGridView_Editing_BMS.DataSource = resultDataTable;

                MessageBox.Show("Данные успешно загружены в режим редактирования.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных для редактирования: {ex.Message}");
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





        private void button_SaveСhanges_BMS_Click(object sender, EventArgs e)

        {
            try
            {
                // Проверяем, что путь к файлу сохранен
                if (string.IsNullOrEmpty(filePathForEditing))
                {
                    MessageBox.Show("Пожалуйста, сначала сохраните данные.");
                    return;
                }

                // Получаем данные из dataGridView_Editing_BMS и формируем строку для сохранения
                StringBuilder dataToSave = new StringBuilder();

                // Заголовки столбцов
                for (int i = 0; i < dataGridView_Editing_BMS.Columns.Count; i++)
                {
                    dataToSave.Append(dataGridView_Editing_BMS.Columns[i].HeaderText);
                    if (i < dataGridView_Editing_BMS.Columns.Count - 1)
                    {
                        dataToSave.Append(";");
                    }
                }
                dataToSave.AppendLine();

                // Данные строк
                foreach (DataGridViewRow row in dataGridView_Editing_BMS.Rows)
                {
                    // Проверяем, что строка не является новой и не является пустой
                    if (!row.IsNewRow && !IsRowEmpty(row))
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            dataToSave.Append(row.Cells[i].Value);
                            if (i < row.Cells.Count - 1)
                            {
                                dataToSave.Append(";");
                            }
                        }
                        dataToSave.AppendLine();
                    }
                }

                // Сохраняем данные в файл
                File.WriteAllText(filePathForEditing, dataToSave.ToString(), Encoding.UTF8);

                MessageBox.Show("Изменения успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении изменений: {ex.Message}");
            }
        }
        private bool IsRowEmpty(DataGridViewRow row)
        {
            foreach (DataGridViewCell cell in row.Cells)
            {
                if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }




        private void FormEditing_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView_Editing_BMS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
