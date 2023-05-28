using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms.FormsEquipment
{
    public partial class Inventory : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Инвентарь";
        string FieldCode = "КодИнвентаря";
        string[] header = { "Код инвентаря", "Тип инвентаря", "Код инвентаризации", "Количество инвенторя(шт)", "Название"};
        string[] fields = { "КодИнвентаря", "ТипИнвентаря", "КодИнвентаризации", "КоличествоИнвенторя", "Название" };
        public Inventory(int AccessLevel)
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
            requestSQL.LoadDataGrid(ref dataGridViewInventory, nameTable, header);
        }
       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxCodeInventory.Text = dataGridViewInventory.CurrentRow.Cells[0].Value.ToString();
                textBoxQuantityInventory.Text = dataGridViewInventory.CurrentRow.Cells[3].Value.ToString();
                textBoxCodeInventorization.Text = dataGridViewInventory.CurrentRow.Cells[2].Value.ToString();
                textBoxTypeInventory.Text = dataGridViewInventory.CurrentRow.Cells[1].Value.ToString();
                textBoxInventoryName.Text = dataGridViewInventory.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeInventory.Text;
            requestSQL.SearchSQL(ref dataGridViewInventory, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 2)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeInventory.Text;
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
                if (control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string quantity = textBoxQuantityInventory.Text;
            string inventarization = textBoxCodeInventorization.Text;
            string typeInventory = textBoxTypeInventory.Text;
            string nameInventory = textBoxInventoryName.Text;


            string[] values = { typeInventory, inventarization, quantity, nameInventory };

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string numberInventory = textBoxCodeInventory.Text;
            string quantity = textBoxQuantityInventory.Text;
            string inventarization = textBoxCodeInventorization.Text;
            string typeInventory = textBoxTypeInventory.Text;
            string nameInventory = textBoxInventoryName.Text;
            string[] values = { typeInventory, inventarization, quantity, nameInventory };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, numberInventory, FieldCode, fields, values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (OleDbConnection connection = new OleDbConnection(Connect.ConnectionString))
            {
                string query = "SELECT MAX(КодИнвенторизации) FROM Инвентаризация";
                connection.Open();
                DataSet dataSet = new DataSet();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query,Connect.ConnectionString);
                dataAdapter.Fill(dataSet);
                OleDbCommand command = new OleDbCommand(query, connection);
                object maxNumber = command.ExecuteScalar();
                int number = (int)maxNumber;
                number++;
                
                query = $"INSERT INTO Инвентаризация (КодИнвенторизации) VALUES ({number})";
                command = new OleDbCommand(query,connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Запись была добавлена", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
        }
    }
}
