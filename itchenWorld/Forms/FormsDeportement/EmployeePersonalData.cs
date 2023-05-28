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
    public partial class EmployeePersonalData : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "ЛичныеДанныеСотрудника";
        string FieldCode = "КодЛичныхДаныхСотрудника";
        string[] header = { "Код личных даных сотрудника", "Паспортные данные сотрудника", "Фамилия","Имя","Отчество", "Адрес", "Дата рождения" };
        string[] fields = {  "ПаспортныеДанныеСотрудника", "ФамилияСотрудника", "ИмяСотрудника", "ОтчествоСотрудника", "АдресСотруднка", "ДатаРожденияСотрудника" };
        public EmployeePersonalData(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxCodePersonalData.Text = dataGridViewPersonalData.CurrentRow.Cells[0].Value.ToString();
                textBoxPassportData.Text = dataGridViewPersonalData.CurrentRow.Cells[1].Value.ToString();
                textBoxFirstName.Text = dataGridViewPersonalData.CurrentRow.Cells[2].Value.ToString();
                textBoxName.Text = dataGridViewPersonalData.CurrentRow.Cells[3].Value.ToString();
                textBoxAdress.Text = dataGridViewPersonalData.CurrentRow.Cells[5].Value.ToString();
                textBoxPatronomic.Text = dataGridViewPersonalData.CurrentRow.Cells[4].Value.ToString();
                textBoxDateBirth.Text = dataGridViewPersonalData.CurrentRow.Cells[7].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodePersonalData.Text;
            requestSQL.SearchSQL(ref dataGridViewPersonalData, header, nameTable, FieldCode, code);
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
            requestSQL.LoadDataGrid(ref dataGridViewPersonalData, nameTable, header);
        }
        private void EmployeePersonalData_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodePersonalData.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string pasport = textBoxPassportData.Text;
            string firstName = textBoxFirstName.Text;
            string nameEmployee = textBoxName.Text;
            string adress = textBoxAdress.Text;
            string patranomic = textBoxPatronomic.Text;
            string dateBirth = textBoxDateBirth.Text;

            string[] values = {pasport,firstName,nameEmployee,patranomic,adress,dateBirth };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string personalCode = textBoxCodePersonalData.Text;
            string pasport = textBoxPassportData.Text;
            string firstName = textBoxFirstName.Text;
            string nameEmployee = textBoxName.Text;
            string adress = textBoxAdress.Text;
            string patranomic = textBoxPatronomic.Text;
            string dateBirth = textBoxDateBirth.Text;

            string[] values = { pasport, firstName, nameEmployee, patranomic, adress, dateBirth };

            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, personalCode, FieldCode, fields, values);
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
    }
}
