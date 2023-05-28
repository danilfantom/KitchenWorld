using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace itchenWorld.Forms.FormsMenu
{
    public partial class Kitchen : Form
    {
        OleDbConnection connection = new OleDbConnection(Connect.ConnectionString);
        DataSet dataSet = new DataSet();
        RequestSQL requestSQL = new RequestSQL();

        int aceessLevel;
        string nameTable = "Кухня";
        string[] header = { "Код кухни", "Код помещения", "Название кухни", "Национальность кухни" };
        public Kitchen( int AccessLevel)
        {
            InitializeComponent();
            connection.Open();
            LoadDataRoom();
            aceessLevel = AccessLevel;
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridViewMenu,nameTable,header);
        }
        private void LoadDataRoom() 
        {
            requestSQL.LoadComboBox(ref comboBoxNumberRoom,"КодПомещения","Помещение");
        }
        private void Kitchen_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
        }
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string national = textBoxNationalKitchen.Text;
            string name = textBoxNameKitchen.Text;
            string number = comboBoxNumberRoom.Text;
           
            string[] fieldsArray = { "КодПомещенияКухни", "НазваниеКухни", "НациональностьКухни" };
            string[] valuesArray = { number, name, national };

            requestSQL.InsertSql(nameTable,fieldsArray,valuesArray);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxNumberKutchen.Text;
            requestSQL.SearchSQL(ref dataGridViewMenu,header,nameTable,"КодКухни",code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (aceessLevel == 1)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxNumberKutchen.Text;
                requestSQL.RemoveSQL(nameTable,code,"КодКухни");
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumberKutchen.Text = "";
            textBoxNationalKitchen.Text = "";
            textBoxNameKitchen.Text = "";
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
        private void buttonChangeData_Click(object sender, EventArgs e)
        {
            string numberKitchen = textBoxNumberKutchen.Text;
            string national = textBoxNationalKitchen.Text;
            string name = textBoxNameKitchen.Text;
            string number = comboBoxNumberRoom.Text;
            string[] field = { "КодПомещенияКухни", "НазваниеКухни", "НациональностьКухни" };
            string[] values = {number,name,national };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable,numberKitchen,"КодКухни",field,values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxNumberKutchen.Text = dataGridViewMenu.CurrentRow.Cells[0].Value.ToString();
                textBoxNationalKitchen.Text = dataGridViewMenu.CurrentRow.Cells[3].Value.ToString();
                textBoxNameKitchen.Text = dataGridViewMenu.CurrentRow.Cells[2].Value.ToString();
                comboBoxNumberRoom.Text = dataGridViewMenu.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
