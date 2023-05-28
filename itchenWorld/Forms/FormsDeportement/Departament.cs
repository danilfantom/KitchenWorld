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
    public partial class Departament : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Отдел";
        string FieldCode = "КодОтдела";
        string[] header = { "Код отдела","название отдела" };
        string[] fields = { "НазваниеОтдела"};

        public Departament(int AccessLevel)
        {
            accessLevel = AccessLevel;
            InitializeComponent();
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
            }
            return true;
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridViewDepartament, nameTable, header);
        }

        private void Departament_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxcodeDepartaent.Text;
            requestSQL.SearchSQL(ref dataGridViewDepartament, header, nameTable, FieldCode, code);
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
            string code = textBoxcodeDepartaent.Text;
            string nameDepartament = textBoxDepartamentName.Text;

            string[] values = {nameDepartament };

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string code = textBoxcodeDepartaent.Text;
            string nameDepartament = textBoxDepartamentName.Text;

            string[] values = { code, nameDepartament };
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string code = textBoxcodeDepartaent.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void dataGridViewDepartament_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxcodeDepartaent.Text = dataGridViewDepartament.CurrentRow.Cells[0].Value.ToString();
                textBoxDepartamentName.Text = dataGridViewDepartament.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
