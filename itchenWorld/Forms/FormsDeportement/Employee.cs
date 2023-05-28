using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms.FormsDeportement
{
    public partial class Employee : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Сотрудник";
        string FieldCode = "КодСотрудника";
        string[] header = { "Код сотрудника", "Код отдела", "Код кухни" };
        string[] fields = { "Название", "ИНН", };
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
            requestSQL.LoadDataGrid(ref dataGridViewEmployee, nameTable, header);
        }
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxCodeDepartament, "КодПомещения", "Помещение");
            requestSQL.LoadComboBox(ref comboBoxCodeKutchen, "КодПомещения", "Помещение");

        }
        public Employee(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }
       

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeEmployee.Text;
            requestSQL.SearchSQL(ref dataGridViewEmployee, header, nameTable, FieldCode, code);
        }

        private void dataGridViewEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxCodeEmployee.Text = dataGridViewEmployee.CurrentRow.Cells[0].Value.ToString();
                comboBoxCodeDepartament.Text = dataGridViewEmployee.CurrentRow.Cells[1].Value.ToString();
                comboBoxCodeKutchen.Text = dataGridViewEmployee.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeEmployee.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string citchenCode = comboBoxCodeKutchen.Text;
            string departamentCode = comboBoxCodeDepartament.Text;

            string[] values = { departamentCode, citchenCode };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeEmployee.Text;
            string citchenCode = comboBoxCodeKutchen.Text;
            string departamentCode = comboBoxCodeDepartament.Text;

            string[] values = { departamentCode, citchenCode };

            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, FieldCode, code, fields, values);
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
                if(control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }
        private void Employee_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            ComboBoxLoad();
        }
    }
}
