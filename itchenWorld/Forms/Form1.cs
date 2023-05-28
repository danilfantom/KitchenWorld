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
using System.Data.SqlClient;
using System.Web;
using System.Security.Principal;

namespace itchenWorld
{
    public partial class FormAuthorization : Form
    {
        private OleDbConnection connection = new OleDbConnection( Connect.ConnectionString);
        DataSet dataSet = new DataSet();
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void FormAuthorization_Load(object sender, EventArgs e)
        {
            connection.Open();
        }

        private void FormAuthorization_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void buttonEntry_Click(object sender, EventArgs e)
        {
            string pass = textBoxPassword.Text;
            string log = textBoxLogin.Text;
            string query = $"Select [Логин], [Пароль], [Роль] From [Пользователь] WHERE [Логин] = '{log}' AND [Пароль] = '{pass}'";

            OleDbCommand command = new OleDbCommand(query,connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, Connect.ConnectionString);
            dataAdapter.Fill(dataSet);
            OleDbDataReader reader = command.ExecuteReader();
            int AccessLevel = 1;
            reader.Read();
            if (!reader.HasRows)
            {
                MessageBox.Show("Не найден пользователь с таким логином и паролем", "оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                switch (reader.GetValue(2))
                {
                    case "Пользователь":
                        AccessLevel = 1;
                        break;
                    case "Менеджер":
                        AccessLevel = 2;
                        break;
                    case "Администратор":
                        AccessLevel = 3;
                        break;
                    default:
                        AccessLevel = 1;
                        break;
                }

                if (dataSet.Tables.Count == 1)
                {
                    this.Hide();
                    FormMain formMain = new FormMain(AccessLevel);
                    formMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не найден пользователь с таким логином и паролем", "оповещение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
