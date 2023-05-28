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
    public partial class Purchase : Form
    {

        RequestSQL requestSQL = new RequestSQL();

        int accessLevel;
        string nameTable = "Закупка";
        string FieldCode = "КодЗакупки";
        string[] header = { "Код закупки", "Код отдела", "Стоимость закупки" };
        string[] fields = { "КодЗакупки", "КодОтдела", "СтоимостьЗакупки" };
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
            requestSQL.LoadDataGrid(ref dataGridViewPurche, nameTable, header);
        }
        private void ComboBoxLoad()
        {
            requestSQL.LoadComboBox(ref comboBoxCodeDepartament, "КодПомещения", "Помещение");
        }
        public Purchase(int Accesslevel)
        {
            InitializeComponent();
            accessLevel = Accesslevel;
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            DataGridUpdate();
            ComboBoxLoad();
        }

        private void dataGridViewPurche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                textBoxCodePurcashe.Text = dataGridViewPurche.CurrentRow.Cells[0].Value.ToString();
                textBoxPricePurcashe.Text = dataGridViewPurche.CurrentRow.Cells[2].Value.ToString();
                comboBoxCodeDepartament.Text = dataGridViewPurche.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string code = textBoxCodePurcashe.Text;
            requestSQL.SearchSQL(ref dataGridViewPurche, header, nameTable, FieldCode, code);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (accessLevel == 3)
            {
                MessageBox.Show("Невозможно выполнить, у вас не достаточно прав", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = textBoxCodePurcashe.Text;
                requestSQL.RemoveSQL(nameTable, code, FieldCode);
                MessageBox.Show("Данные были удалены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridUpdate();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string codePurcahe = textBoxCodePurcashe.Text;
            string price = textBoxPricePurcashe.Text;
            string codeDepartament = comboBoxCodeDepartament.Text;

            string[] values = { codeDepartament, codeDepartament, price};
            requestSQL.InsertSql(nameTable, fields, values);
            MessageBox.Show("Данные были добавлены", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridUpdate();
        }

        private void buttonChenge_Click(object sender, EventArgs e)
        {
            string codePurcahe = textBoxCodePurcashe.Text;
            string price = textBoxPricePurcashe.Text;
            string codeDepartament = comboBoxCodeDepartament.Text;

            string[] values = { codeDepartament, codeDepartament , price};
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
