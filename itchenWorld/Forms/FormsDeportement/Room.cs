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
    public partial class Room : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Помещение";
        string FieldCode = "КодПомещения";
        string[] header = { "Код помещения", "Код отдела в помещении", "Назначение помещения", "Код кухни мира помещения", "Код инвентаризации помещения" };
        string[] fields = { "КодОтделаПомещения", "НазначениеПомещения", "КодКухниМираПомещения", "КодИнвентаризацииПомещения" };
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
            requestSQL.LoadDataGrid(ref dataGridViewRoom, nameTable, header);
        }
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxCodeCitchenWorld, "КодКухниМира", "КухниМира");
            requestSQL.LoadComboBox(ref comboBoxCodeDepartament, "КодОтдела", "Отдел");
            requestSQL.LoadComboBox(ref comboBoxCodeInventorization, "КодИнвентаризации", "Инвентаризаци");

        }

        public Room( int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeRoom.Text;
            requestSQL.SearchSQL(ref dataGridViewRoom, header, nameTable, FieldCode, code);
        }

        private void Room_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            ComboBoxLoad();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeRoom.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string codeInventorzation = comboBoxCodeInventorization.Text;
            string codeDepartament = comboBoxCodeDepartament.Text;
            string appointment = textBoxAppointment.Text;
            string codeKitchenWorld = comboBoxCodeCitchenWorld.Text;
            string[] values = { codeDepartament, appointment, codeKitchenWorld, codeInventorzation };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeRoom.Text;
            string codeInventorzation = comboBoxCodeInventorization.Text;
            string codeDepartament = comboBoxCodeDepartament.Text;
            string appointment = textBoxAppointment.Text;
            string codeKitchenWorld = comboBoxCodeCitchenWorld.Text;
            string[] values = { codeDepartament, appointment, codeKitchenWorld, codeInventorzation };
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
                if (control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }

        private void dataGridViewRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {

                textBoxCodeRoom.Text = dataGridViewRoom.CurrentRow.Cells[0].Value.ToString();
                comboBoxCodeInventorization.Text = dataGridViewRoom.CurrentRow.Cells[4].Value.ToString();
                comboBoxCodeDepartament.Text = dataGridViewRoom.CurrentRow.Cells[1].Value.ToString();
                textBoxAppointment.Text = dataGridViewRoom.CurrentRow.Cells[2].Value.ToString();
                comboBoxCodeCitchenWorld.Text = dataGridViewRoom.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
