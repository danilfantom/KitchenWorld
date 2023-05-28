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
using System.Xml;

namespace itchenWorld.Forms.FormsMenu
{
    public partial class Product : Form
    {
        RequestSQL requestSQL = new RequestSQL();
      
        int accessLevel;
        string nameTable = "Продукты";
        string FieldCode = "КодТипаПродукта";
        string[] fields = { "КодТипаПродукта", "НазваниеТипаПродукта", "УсловияХранения" };
        string[] header = { "Код продукта", "Код склада продукта", "Код закупки продукта", "Название продукта", "Количество продукта(кг)", "Код типа продукта", "Код поставщика продукта" };
        public Product( int AccessLevel)
        {
            InitializeComponent();
            accessLevel = AccessLevel;
        }
        private void DataGridUpdate()
        {
            requestSQL.LoadDataGrid(ref dataGridViewProducts, nameTable, header);
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
            requestSQL.LoadComboBox(ref comboBoxCodePorductProvider, "КодПоставщика", "Поставщик");
           requestSQL.LoadComboBox(ref comboBoxTypeProduct, "КодТипаПродукта", "ТипПродукта");
            requestSQL.LoadComboBox(ref comboBoxCodeWareHouse, "КодСклада", "Склад");
            requestSQL.LoadComboBox(ref comboBoxCodePurcasthe, "КодЗакупки", "Закупка");
        }
        private void Product_Load(object sender, EventArgs e)
        {
            ComboBoxLoad();
            DataGridUpdate();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxNumberProduct.Text;
            requestSQL.SearchSQL(ref dataGridViewProducts, header, nameTable, "КодКухни", code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 1)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxNumberProduct.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string codeProduct = textBoxNumberProduct.Text;
            string provider = comboBoxCodePorductProvider.Text;
            string quantityProduct = textBoxQuantityProduct.Text;
            string codeTypeProduct = comboBoxTypeProduct.Text;
            string wareHouse = comboBoxCodeWareHouse.Text;
            string purcasthe = comboBoxCodePurcasthe.Text;
            string nameProduct = textBoxNameProduct.Text;

            string[] fieldsArray = { "КодСкладаПродукта", "КодЗакупкиПродукта", "НазваниеПродукта", "КоличествоПродукта(кг)", "ТипПродукта", "КодПоставщикаПродукта" };
            string[] valuesArray = { provider, purcasthe, nameProduct,quantityProduct, codeTypeProduct,wareHouse};

            requestSQL.InsertSql(nameTable, fieldsArray, valuesArray);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                textBoxNumberProduct.Text = dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
                comboBoxTypeProduct.Text = dataGridViewProducts.CurrentRow.Cells[5].Value.ToString();
                comboBoxCodeWareHouse.Text = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
                comboBoxCodePurcasthe.Text = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
                textBoxNameProduct.Text = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();
                textBoxQuantityProduct.Text = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
                comboBoxCodePorductProvider.Text = dataGridViewProducts.CurrentRow.Cells[6].Value.ToString();

            }
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

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string codeProduct = textBoxNumberProduct.Text;
            string provider = comboBoxCodePorductProvider.Text;
            string quantityProduct = textBoxQuantityProduct.Text;
            string codeTypeProduct = comboBoxTypeProduct.Text;
            string wareHouse = comboBoxCodeWareHouse.Text;
            string purcasthe = comboBoxCodePurcasthe.Text;
            string nameProduct = textBoxNameProduct.Text;

            string[] fieldsArray = { "КодСкладаПродукта", "КодЗакупкиПродукта", "НазваниеПродукта", "КоличествоПродукта(кг)", "ТипПродукта", "КодПоставщикаПродукта" };
            string[] valuesArray = { provider, purcasthe, nameProduct, quantityProduct, codeTypeProduct, wareHouse };
            if (Exam())
            {
                requestSQL.ChangeSQL(nameTable, codeProduct,FieldCode, fieldsArray, valuesArray);
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
