using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Xceed.Document.NET;
using Xceed.Words.NET;
using Excel = Microsoft.Office.Interop.Excel;

namespace itchenWorld.Forms
{
    public partial class DataSempling : Form
    {
        string[] NameTables = { "Блюдо", "Закупка", "Инвентаризация", "Инвентарь", "КонтактноеЛицо", "КухниМира", "Кухня", "ЛичныеДанныеСотрудника", "Отдел", "ПоказаниеГаз", "ПоказанияВоды", "ПоказанияСвета", "Помещение", "Поставщик", "Продажа", "Продукты", "РабочиеДанныеСотрудника", "Склад", "СодержаниеЗакупки", "Сотрудник", "ТипИнвенторя", "ТипПродукта" };
        string ContextTable;
        string query;
        bool chec = false;
  
        Dictionary<string, string[]> Fields = new Dictionary<string, string[]>()
        {
            {"Блюдо", new string[]{ "КодБлюда", "НазваниеКухниБлюда", "НазваниеБлюда", "СтоимостьБлюда", "КодПродуктаБлюда", "ВесБлюда" } },
            {"Закупка",new string[]{ "КодЗакупки", "КодОтдела", "СтоимостьЗакупки" } },
            {"Инвентаризация",new string[] { "КодИнвенторизации" } },
            {"Инвентарь",new string[]{ "КодИнвентаря", "ТипИнвентаря", "КодИнвентаризации", "КоличествоИнвенторя", "Название" } },
            {"КонтактноеЛицо",new string[]{ "КодКонтактногоЛица", "ФИОКонтактногоЛица", "Email", "КодПоставщика" } },
            {"КухниМира",new string[]{ "КодКухниМира", "АдресКухниМира", "ЮрАдресКухниМира", "ТипОрганизацииКухниМира", "КонтактныеДанныеКухниМира" } },
            {"Кухня",new string[]{ "КодКухни", "КодПомещенияКухни", "НазваниеКухни", "НациональностьКухни" } },
            {"ЛичныеДанныеСотрудника",new string[]{ "КодЛичныхДаныхСотрудника", "ПаспортныеДанныеСотрудника", "ФамилияСотрудника", "ИмяСотрудника", "ОтчествоСотрудника", "АдресСотруднка", "ДатаРожденияСотрудника" } },
            {"Отдел",new string[]{ "КодОтдела", "НазваниеОтдела" } },
            {"ПоказаниеГаз",new string[]{"КодПоказанияГаза", "СтоимостьКубМ", "ПоказанияНаНачалоМесяца", "ПоказанияНаКонецМесяца", "КодПомещения" } },
            {"ПоказанияВоды",new string[]{"КодПоказанияВоды", "СтоимостьКубМ", "ПоказанияНаНачалоМесяца", "ПоказанияНаКонецМесяца", "КодПомещения" } },
            {"ПоказанияСвета",new string[]{ "КодПоказанияСвета", "СтоимостьКВч", "ПоказанияНаНачалоМесяца", "ПоказанияНаКонецМесяца", "КодПомещения" } },
            {"Помещение",new string[]{"КодПомещения", "КодОтделаПомещения", "НазначениеПомещения", "КодКухниМираПомещения", "КодИнвентаризацииПомещения" } },
            {"Поставщик",new string[]{ "КодПоставщика", "Название", "ИНН" } },
            {"Продажа",new string[]{ "КодПродажи", "КодБлюдаПродажи", "КоличествоПроданныхБлюд" } },
            {"Продукты",new string[]{ "КодПродукта", "КодСкладаПродукта", "КодЗакупкиПродукта", "НазваниеПродукта", "КоличествоПродукта(кг)", "ТипПродукта", "КодПоставщикаПродукта" } },
            {"РабочиеДанныеСотрудника",new string[]{ "КодРабочихДанныхСотрудника", "ДолжностьСотрудника", "ЗаработнаяПлатаСотрудника", "ДатаПриемаНаРаботу", "ДатаУвольнения" } },
            {"Склад",new string[]{ "КодСклада", "КодПомещения" } },
            {"СодержаниеЗакупки",new string[]{ "КодСодержанияЗакупки", "СодержаниеЗакупки" } },
            {"Сотрудник",new string[]{ "КодСотрудника", "КодОтдела", "КодКухни" } },
            {"ТипИнвенторя",new string[]{ "КодТипаИнвентаря", "ТипИнвентаря", "ХарактеристикаТипаИнвентаря" } },
            {"ТипПродукта",new string[]{ "КодТипаПродукта", "НазваниеТипаПродукта", "УсловияХранения" } }
        };
        public DataSempling()
        {
            InitializeComponent();
        }

        private void DataSempling_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonAddField,"Добавить выбраное значение");
            toolTip.SetToolTip(buttonDeleteField, "Удалить выбраное значение");
            comboBoxtableName.Items.AddRange(NameTables);
            comboBoxFilter.Items.AddRange(new string[] {"Алфавитный","Обратный алфавитный","В порядке возрастания","В порядке убывания" });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxtableName.Text == "")
            {
                MessageBox.Show("Не выбрана таблица","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                listBoxAddFields.Items.Clear();
                listBoxAddFields.Items.AddRange(Fields[ContextTable]);
            }
        }

        private void comboBoxtableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContextTable = comboBoxtableName.Text;
            listBoxFields.Items.Clear();
            listBoxFields.Items.AddRange(Fields[ContextTable]);
            listBoxAddFields.Items.Clear();
        }

        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (chec)
            {
                label6.Visible = false;
                comboBoxFilter.Visible = false;
                label5.Visible = false;
                comboBoxSortedFilds.Visible = false;
                chec = false;
            }
            else
            {
                label6.Visible = true;
                comboBoxFilter.Visible = true;
                label5.Visible = true;
                comboBoxSortedFilds.Visible = true;
                comboBoxSortedFilds.Items.AddRange(Fields[ContextTable]);
                chec = true;

            }
        }

        private void buttonAddField_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxAddFields.Items.Add(listBoxFields.SelectedItem.ToString());
                listBoxFields.Items.Remove(listBoxFields.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите поле", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void buttonDeleteField_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxFields.Items.Add(listBoxAddFields.SelectedItem.ToString());
                listBoxAddFields.Items.Remove(listBoxAddFields.SelectedItem);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Выберите поле","Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private string makeRequest()
        {
            query = "";
            query += "SELECT ";
            for (int i =0;i<listBoxAddFields.Items.Count;i++)
            {
                query += listBoxAddFields.Items[i].ToString() +",";
            }
            query = query.Remove(query.Length -1);
            query += $" FROM {ContextTable}";
            if (checkBoxSorted.Checked)
            {
                switch (comboBoxFilter.Text)
                {
                    case "Алфавитный":
                        query += " Order by " + comboBoxSortedFilds.Text;
                        return query;
                    case "Обратный алфавитный":
                        query += " Order by " + comboBoxSortedFilds.Text + " DESC";
                        return query;
                    case "В порядке возрастания":
                        query += " Order by " + comboBoxSortedFilds.Text;
                        return query;
                    case "В порядке убывания":
                        query += " Order by " + comboBoxSortedFilds.Text + " DESC";
                        return query;
                }
            }
            else
            {
                return query;
            }
            return query;
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            buttonExportExcel.Enabled = true;
            buttonExportWord.Enabled = true;
            RequestSQL requestSQL = new RequestSQL();
            requestSQL.UnikalRequest(ref dataGridView1,makeRequest());
        }

        private void buttonExportWord_Click(object sender, EventArgs e)
        {
            if (saveFileDialogWord.ShowDialog() == DialogResult.OK)
            {
                DocX doc = DocX.Create(Path.GetFullPath(saveFileDialogWord.FileName));
                doc.InsertParagraph("Отчет").Font("Times New Roman").FontSize(14).Alignment = Alignment.center;
                Xceed.Document.NET.Paragraph paragraph = doc.InsertParagraph();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null)
                        {
                            break;
                        }
                        paragraph.Append(dataGridView1.Columns[j].HeaderText + " ".ToString()).Font("Times New Roman").FontSize(12).Alignment = Alignment.left;
                        paragraph.Append(dataGridView1.Rows[i].Cells[j].Value + " ".ToString()).Font("Times New Roman").FontSize(12).Alignment = Alignment.left;
                        paragraph.AppendLine();
                    }
                    paragraph.AppendLine();
                }
                doc.Save();
                MessageBox.Show("Файл успешно сохранен", "Оповещение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {

           
            if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                Excel.Workbook workbook = ex.Workbooks.Add(Type.Missing);
                ex.DisplayAlerts = false;
                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
                sheet.Name = $"Отчет от {DateTime.Now.ToLongDateString()}";
                for(int i = 1; i < dataGridView1.ColumnCount + 1; i++)
                {
                    sheet.Cells[1, i].Value = dataGridView1.Columns[i-1].HeaderText;
                }
               for(int i = 2; i < dataGridView1.RowCount+2; i++)
                {
                    for(int j = 1; j < dataGridView1.ColumnCount+1; j++)
                    {
                        if (dataGridView1.Rows[i-2].Cells[j-1].Value == null)
                        {
                            break;
                        }
                        sheet.Cells[i,j].Value = dataGridView1.Rows[i-2].Cells[j-1].Value.ToString();
                    }
                }
                ex.Application.ActiveWorkbook.SaveAs(saveFileDialogExcel.FileName);
                ex.Application.Quit();

                MessageBox.Show("Файл успешно сохранен","Оповещение",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxAddFields.Items.Clear();
            listBoxFields.Items.Clear();
            checkBoxSorted.Checked = false;
        }
    }
    
}
