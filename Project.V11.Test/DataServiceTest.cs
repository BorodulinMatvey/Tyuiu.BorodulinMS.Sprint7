using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Project.V11.Lib;

namespace Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CountCsvLines_ExcludeHeader_CorrectCount()
        {
            // Утверждение
            string testFilePath = @"C:\Users\motya\Source\Repos\Tyuiu.BorodulinMS.Sprint7\Project.V11\bin\Debug\Файл для проверки тестового метода (подсчет строк, не учитывая первую).csv";

            int lineCount = 0;

            // Действие
            using (var reader = new StreamReader(testFilePath))
            {
                // Пропускаем заголовок
                reader.ReadLine();

                // Считаем оставшиеся строки
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            // Проверка
            Assert.AreEqual(14, lineCount); // Предполагаемое количество строк: 14
        }
    }
}
