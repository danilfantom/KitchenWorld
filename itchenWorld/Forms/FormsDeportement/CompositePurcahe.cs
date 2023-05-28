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
    public partial class CompositePurcahe : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "СодержаниеЗакупки";
        string FieldCode = "КодСодержанияЗакупки";
        string[] header = { "Код содержания закупки", "Содержание закупки"};
        string[] fields = { "КодСодержанияЗакупки", "СодержаниеЗакупки" };
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
            requestSQL.LoadDataGrid(ref dataGridViewCompositePurcahe, nameTable, header);
        }
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxVodeStock, "КодПомещения", "Помещение");
        }
        public CompositePurcahe(int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }

        private void CompositePurcahe_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            ComboBoxLoad();
        }

        private void dataGridViewCompositePurcahe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxCodeRoom.Text = dataGridViewCompositePurcahe.CurrentRow.Cells[0].Value.ToString();
                comboBoxVodeStock.Text = dataGridViewCompositePurcahe.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            string code = textBoxCodeRoom.Text;
            requestSQL.SearchSQL(ref dataGridViewCompositePurcahe, header, nameTable, FieldCode, code);
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
            string codePurcahe = textBoxCodeRoom.Text;
            string Purcahe = comboBoxVodeStock.Text;

            string[] values = {  Purcahe,};
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string codePurcahe = textBoxCodeRoom.Text;
            string Purcahe = comboBoxVodeStock.Text;

            string[] values = { Purcahe, };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, FieldCode, codePurcahe, fields, values);
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
