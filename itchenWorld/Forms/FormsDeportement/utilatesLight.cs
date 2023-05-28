using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms.FormsDeportement
{
    public partial class utilatesLight : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "ПоказанияСвета";
        string FieldCode = "КодПоказанияСвета";
        string[] header = { "Код Показания Воды", "Стоимость КВ/ч", "Показания На Начало Месяца", "Показания На Конец Месяца", "КодПомещения" };
        string[] fields = {  "СтоимостьКВч", "ПоказанияНаНачалоМесяца", "ПоказанияНаКонецМесяца", "КодПомещения" };
        private bool Exam()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == "")
                    {
                        return false;
                    }
                }
                if (control is ComboBox)
                {
                    if (control.Text == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridViewUtilitesLight, nameTable, header);
        }
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxCodeRoom, "КодПомещения", "Помещение");


        }
        public utilatesLight(int Accesslevel)
        {
            InitializeComponent();
            accessLevel = Accesslevel;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxIndication.Text;
            requestSQL.SearchSQL(ref dataGridViewUtilitesLight, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxIndication.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string indication = textBoxIndication.Text;
            string startMonth = textBoxStartMonth.Text;
            string endMonth = textBoxEndMonth.Text;
            string price = textBoxPrice.Text;
            string codeRoom = comboBoxCodeRoom.Text;

            string[] values = { price, startMonth, endMonth, codeRoom };
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string indication = textBoxIndication.Text;
            string startMonth = textBoxStartMonth.Text;
            string endMonth = textBoxEndMonth.Text;
            string price = textBoxPrice.Text;
            string codeRoom = comboBoxCodeRoom.Text;

            string[] values = { price, startMonth, endMonth, codeRoom };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, FieldCode, indication, fields, values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                if (control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }

        private void utilatesLight_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            ComboBoxLoad();
        }
    }
}
