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
    public partial class Provider : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Поставщик";
        string FieldCode = "КодПоставщика";
        string[] header = { "Код поставщика", "Название", "ИНН"};
        string[] fields = { "КодПоставщика", "Название", "ИНН",};
        public Provider(int AccessLevel)
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
            requestSQL.LoadDataGrid(ref dataGridViewCodeProvider, nameTable, header);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeProvider.Text;
            requestSQL.SearchSQL(ref dataGridViewCodeProvider, header, nameTable, FieldCode, code);
        }

        private void dataGridViewCodeProvider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxCodeProvider.Text = dataGridViewCodeProvider.CurrentRow.Cells[0].Value.ToString();
                textBoxNameProvider.Text = dataGridViewCodeProvider.CurrentRow.Cells[1].Value.ToString();
                textBoxINN.Text = dataGridViewCodeProvider.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 2)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeProvider.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string nameProvider = textBoxCodeProvider.Text;
            string inn = textBoxINN.Text;

            string[] values = { nameProvider,inn };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string nameProvider = textBoxCodeProvider.Text;
            string inn = textBoxINN.Text;

            string[] values = { nameProvider, inn };

            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, FieldCode, FieldCode, fields, values);
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
            }
        }

        private void Provider_Load(object sender, EventArgs e)
        {
            DataGridUpdate();

        }
    }
}
