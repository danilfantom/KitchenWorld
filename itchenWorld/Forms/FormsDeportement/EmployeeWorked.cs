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
    public partial class EmployeeWorked : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "РабочиеДанныеСотрудника";
        string FieldCode = "КодРабочихДанныхСотрудника";
        string[] header = { "Код рабочих данных сотрудника", "Должность сотрудника", "Заработная плата сотрудника", "ДатаПриемаНаРаботу" };
        string[] fields = { "ДолжностьСотрудника", "ЗаработнаяПлатаСотрудника", "ДатаПриемаНаРаботу", "ДатаУвольнения" };
        public EmployeeWorked(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

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
            requestSQL.LoadDataGrid(ref dataGridViewWorkedDataEmployee, nameTable, header);
        }

        private void EmployeeWorked_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
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

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeWorkedData.Text;
            string dismissal = dateTimePickerDismissal.Text;
            string wage = textBoxWage.Text;
            string hiring = dateTimePickerHiring.Text;
            string post = textBoxPost.Text;
            string[] values = { code, post,wage,dismissal,hiring };

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

        private void dataGridViewWorkedDataEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxCodeWorkedData.Text = dataGridViewWorkedDataEmployee.CurrentRow.Cells[0].Value.ToString();
                dateTimePickerDismissal.Text = dataGridViewWorkedDataEmployee.CurrentRow.Cells[3].Value.ToString();
                textBoxWage.Text = dataGridViewWorkedDataEmployee.CurrentRow.Cells[2].Value.ToString();
                dateTimePickerHiring.Text = dataGridViewWorkedDataEmployee.CurrentRow.Cells[4].Value.ToString();
                textBoxPost.Text = dataGridViewWorkedDataEmployee.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeWorkedData.Text;
            requestSQL.SearchSQL(ref dataGridViewWorkedDataEmployee, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeWorkedData.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dismissal = dateTimePickerDismissal.Text;
            string wage = textBoxWage.Text;
            string hiring = dateTimePickerHiring.Text;
            string post = textBoxPost.Text;
            string[] values = { post, wage, dismissal, hiring };
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }
    }
}
