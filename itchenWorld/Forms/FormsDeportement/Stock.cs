using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms
{
    public partial class Stock : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Склад";
        string FieldCode = "КодСклада";
        string[] header = { "Код склада", "Код помещения" };
        string[] fields = { "КодСклада", "КодПомещения" };

        public Stock(int AccessLevel)
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
            }
            return true;
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridView1 , nameTable, header);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxCodeRoom.Text =  dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxCoderStock.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCoderStock.Text;
            requestSQL.SearchSQL(ref dataGridView1, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCoderStock.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string codeStock = textBoxCoderStock.Text;
            string CodeRoom = textBoxCodeRoom.Text;

            string[] values = { codeStock, CodeRoom };
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string codeStock = textBoxCoderStock.Text;
            string CodeRoom = textBoxCodeRoom.Text;

            string[] values = { CodeRoom };

            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, FieldCode, codeStock, fields, values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
