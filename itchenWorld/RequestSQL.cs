using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itchenWorld
{
    public class RequestSQL
    {
        DataSet dataSet = new DataSet();
        OleDbConnection connection = new OleDbConnection(Connect.ConnectionString);

        string query;
        private void OpenConnection() => connection.Open();
        private void CloseConnection() => connection.Close();
        public void LoadDataGrid(ref DataGridView dataGrid, string nameTable,string[] header) //загружает данные в dataGrid
        {
            query = $"SELECT * FROM [{nameTable}]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query,Connect.ConnectionString);

            dataSet.Tables.Clear();
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];

            for (int i = 0; i < header.Length; i++)
            {
                dataGrid.Columns[i].HeaderText = header[i];
            }
        }
        public void InsertSql(string nameTable, string[] nameFiels, string[] values) // добавляет запись в бд
        {
            OpenConnection();
            query = $"Insert Into {nameTable} (";
            for(int i = 0; i < nameFiels.Length; i++)
            {
                query += nameFiels[i].ToString() + ",";
            }
            query = query.Remove(query.Length-1);
            query += ") Values('";
            for(int i = 0; i < values.Length; i++)
            {
                query += values[i].ToString() + "','";
            }
            
            query = query.Remove(query.Length-1);
            query = query.Remove(query.Length - 2);
            query += "')";

            OleDbCommand command = new OleDbCommand(query,connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void SearchSQL(ref DataGridView dataGrid, string[] header,string nameTable, string nameCode ,string code) // делает поиск по коду
        {
            OpenConnection();
            query = $"SELECT * FROM {nameTable} WHERE {nameCode} = {code}";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, Connect.ConnectionString);
            dataSet.Tables.Clear();
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];
            for (int i = 0; i < header.Length; i++)
            {
                dataGrid.Columns[i].HeaderText = header[i];
            }
            CloseConnection();
        }
        public void LoadComboBox(ref ComboBox comboBox, string nameFieldCode, string nameTable) // заполняет значения типа "КодЗакупки"
        {
            OpenConnection();
            query = $"SELECT {nameFieldCode} FROM {nameTable}";

            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, Connect.ConnectionString);
            dataAdapter.Fill(dataSet);

            OleDbDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox.Items.Add(dataReader[0].ToString());
            }
            CloseConnection();
        }
        public void RemoveSQL(string nameTable,string code,string fieldCode) //Удалет запись из БД
        {
            OpenConnection();
            query = $"DELETE FROM {nameTable} Where {fieldCode} = {code}";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void ChangeSQL(string nameTable, string code, string fieldCode, string[] field, string[] values) //изменяеет запись в БД
        {
            OpenConnection();
            query = $"UPDATE {nameTable} SET ";
            for (int i = 0; i < field.Length; i++)
            {
                query += field[i] + "='" + values[i] + "',";
            }
            query = query.Remove(query.Length - 1);
            query += " WHERE " + fieldCode + " = " + code;
            OleDbCommand command = new OleDbCommand(query, connection);
            command.ExecuteNonQuery();
            CloseConnection();
        }
        public void UnikalRequest(ref DataGridView dataGrid,string UnikalQuery)
        {
            OpenConnection();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(UnikalQuery, Connect.ConnectionString);
            dataSet.Tables.Clear();
            dataSet.Clear();
            dataAdapter.Fill(dataSet);
            dataGrid.DataSource = dataSet.Tables[0];
            CloseConnection();
        }
    }
}
