using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms.FormsEquipment
{
    public partial class ContectPerson : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "КонтактноеЛицо";
        string FieldCode = "КодКонтактногоЛица";
        string[] header = { "Код контактного лица", "ФИО контактного лица", "Email", "Код поставщика"};
        string[] fields = { "КодКонтактногоЛица", "ФИОКонтактногоЛица", "Email", "КодПоставщика" };
        public ContectPerson(int AccessLevel)
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
            requestSQL.LoadDataGrid(ref dataGridViewContectPerson, nameTable, header);
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
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxCodeProvider,FieldCode,nameTable);
           
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeContectPerson.Text;
            requestSQL.SearchSQL(ref dataGridViewContectPerson, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 2)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeContectPerson.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void ContectPerson_Load(object sender, EventArgs e)
        {

            DataGridUpdate();
            ComboBoxLoad();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string FIO = textBoxFIOContactPerson.Text;
            string codeProvider = comboBoxCodeProvider.Text;
            string email = textBoxEmail.Text;

            string[] values = { FIO, codeProvider, email };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeContectPerson.Text;
            string FIO = textBoxFIOContactPerson.Text;
            string codeProvider = comboBoxCodeProvider.Text;
            string email = textBoxEmail.Text;

            string[] values = { FIO, codeProvider, email };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, code, FieldCode, fields, values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewContectPerson_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                textBoxCodeContectPerson.Text = dataGridViewContectPerson.CurrentRow.Cells[0].Value.ToString();
                textBoxFIOContactPerson.Text = dataGridViewContectPerson.CurrentRow.Cells[1].Value.ToString();
                comboBoxCodeProvider.Text = dataGridViewContectPerson.CurrentRow.Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridViewContectPerson.CurrentRow.Cells[2].Value.ToString();
                
            }
        }
    }
}
