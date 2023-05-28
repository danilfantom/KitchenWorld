namespace itchenWorld.Forms
{
    partial class DataSempling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataSempling));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxtableName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxSorted = new System.Windows.Forms.CheckBox();
            this.buttonAddField = new System.Windows.Forms.Button();
            this.buttonDeleteField = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonExportWord = new System.Windows.Forms.Button();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxAddFields = new System.Windows.Forms.ListBox();
            this.listBoxFields = new System.Windows.Forms.ListBox();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSortedFilds = new System.Windows.Forms.ComboBox();
            this.saveFileDialogWord = new System.Windows.Forms.SaveFileDialog();
            this.buttonClear = new System.Windows.Forms.Button();
            this.saveFileDialogExcel = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // comboBoxtableName
            // 
            this.comboBoxtableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxtableName, "comboBoxtableName");
            this.comboBoxtableName.FormattingEnabled = true;
            this.comboBoxtableName.Name = "comboBoxtableName";
            this.comboBoxtableName.SelectedIndexChanged += new System.EventHandler(this.comboBoxtableName_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // checkBoxSorted
            // 
            resources.ApplyResources(this.checkBoxSorted, "checkBoxSorted");
            this.checkBoxSorted.Name = "checkBoxSorted";
            this.checkBoxSorted.UseVisualStyleBackColor = true;
            this.checkBoxSorted.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // buttonAddField
            // 
            resources.ApplyResources(this.buttonAddField, "buttonAddField");
            this.buttonAddField.Name = "buttonAddField";
            this.buttonAddField.UseVisualStyleBackColor = true;
            this.buttonAddField.Click += new System.EventHandler(this.buttonAddField_Click);
            // 
            // buttonDeleteField
            // 
            resources.ApplyResources(this.buttonDeleteField, "buttonDeleteField");
            this.buttonDeleteField.Name = "buttonDeleteField";
            this.buttonDeleteField.UseVisualStyleBackColor = true;
            this.buttonDeleteField.Click += new System.EventHandler(this.buttonDeleteField_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // buttonComplete
            // 
            resources.ApplyResources(this.buttonComplete, "buttonComplete");
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExportWord
            // 
            resources.ApplyResources(this.buttonExportWord, "buttonExportWord");
            this.buttonExportWord.Name = "buttonExportWord";
            this.buttonExportWord.UseVisualStyleBackColor = true;
            this.buttonExportWord.Click += new System.EventHandler(this.buttonExportWord_Click);
            // 
            // buttonExportExcel
            // 
            resources.ApplyResources(this.buttonExportExcel, "buttonExportExcel");
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.buttonExportExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // listBoxAddFields
            // 
            resources.ApplyResources(this.listBoxAddFields, "listBoxAddFields");
            this.listBoxAddFields.FormattingEnabled = true;
            this.listBoxAddFields.Name = "listBoxAddFields";
            // 
            // listBoxFields
            // 
            resources.ApplyResources(this.listBoxFields, "listBoxFields");
            this.listBoxFields.FormattingEnabled = true;
            this.listBoxFields.Name = "listBoxFields";
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxFilter, "comboBoxFilter");
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Name = "comboBoxFilter";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBoxSortedFilds
            // 
            this.comboBoxSortedFilds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortedFilds.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxSortedFilds, "comboBoxSortedFilds");
            this.comboBoxSortedFilds.Name = "comboBoxSortedFilds";
            // 
            // saveFileDialogWord
            // 
            this.saveFileDialogWord.DefaultExt = "doc";
            resources.ApplyResources(this.saveFileDialogWord, "saveFileDialogWord");
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // saveFileDialogExcel
            // 
            this.saveFileDialogExcel.DefaultExt = "xls";
            resources.ApplyResources(this.saveFileDialogExcel, "saveFileDialogExcel");
            // 
            // DataSempling
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxSortedFilds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.listBoxFields);
            this.Controls.Add(this.listBoxAddFields);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.buttonExportWord);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDeleteField);
            this.Controls.Add(this.buttonAddField);
            this.Controls.Add(this.checkBoxSorted);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxtableName);
            this.Controls.Add(this.label1);
            this.Name = "DataSempling";
            this.Load += new System.EventHandler(this.DataSempling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxtableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxSorted;
        private System.Windows.Forms.Button buttonAddField;
        private System.Windows.Forms.Button buttonDeleteField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonExportWord;
        private System.Windows.Forms.Button buttonExportExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxAddFields;
        private System.Windows.Forms.ListBox listBoxFields;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSortedFilds;
        private System.Windows.Forms.SaveFileDialog saveFileDialogWord;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel;
    }
}