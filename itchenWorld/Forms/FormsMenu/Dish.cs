 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld.Forms.FormsMenu
{
    public partial class Dish : Form
    {
        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Блюдо";
        string FieldCode = "КодБлюда";
        string[] header = { "Код блюда","Код кухни", "Название блюда", "Стоимость блюда", "Код продукта","Вес блюда" };
        string[] fields = { "НазваниеКухниБлюда", "НазваниеБлюда", "СтоимостьБлюда", "КодПродуктаБлюда", "ВесБлюда" };
        public Dish( int AccessLevel)
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
            requestSQL.LoadDataGrid(ref dataGridViewDish, nameTable, header);
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodeDish.Text;
            requestSQL.SearchSQL(ref dataGridViewDish, header, nameTable, FieldCode, code);
        }

        private void Dish_Load(object sender, EventArgs e)
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 1)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodeDish.Text;
                requestSQL.RemoveSQL(nameTable, code,FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string price = textBoxPriceDish.Text;
            string nameDish = textBoxNameDish.Text;
            string weight = textBoxWeightDish.Text;
            string nameKitchen = textBoxNameKitchen.Text;

            
            string[] values = { nameKitchen, nameDish, price, weight};

            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string numberDish = textBoxCodeDish.Text;
            string price = textBoxPriceDish.Text;
            string nameDish = textBoxNameDish.Text;
            string weight = textBoxWeightDish.Text;
            string codeKitchen = textBoxNameKitchen.Text;
            string[] values = { codeKitchen, nameDish,price,weight };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, numberDish, FieldCode, fields, values);
                MessageBox.Show("Данные были изменены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
            else
            {
                MessageBox.Show("Данные не были изменены, убедитесь что все поял заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewDish_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                textBoxCodeDish.Text = dataGridViewDish.CurrentRow.Cells[0].Value.ToString();
                textBoxPriceDish.Text = dataGridViewDish.CurrentRow.Cells[3].Value.ToString();
                textBoxNameDish.Text = dataGridViewDish.CurrentRow.Cells[2].Value.ToString();
                textBoxWeightDish.Text = dataGridViewDish.CurrentRow.Cells[5].Value.ToString();
                textBoxNameKitchen.Text = dataGridViewDish.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}
