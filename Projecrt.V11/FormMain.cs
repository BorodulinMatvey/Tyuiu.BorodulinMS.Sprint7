using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecrt.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            

        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Add_BMS_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
        }

        private void button_Sort_BMS_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Statistic_BMS_Click(object sender, EventArgs e)
        {
            FormSerch formStatistic = new FormSerch();
            formStatistic.ShowDialog();
        }
    }
}
