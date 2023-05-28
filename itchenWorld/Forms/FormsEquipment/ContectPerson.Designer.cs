namespace itchenWorld.Forms.FormsEquipment
{
    partial class ContectPerson
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodeContectPerson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFIOContactPerson = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewContectPerson = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCodeProvider = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContectPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код контактного лица";
            // 
            // textBoxCodeContectPerson
            // 
            this.textBoxCodeContectPerson.Location = new System.Drawing.Point(215, 14);
            this.textBoxCodeContectPerson.Name = "textBoxCodeContectPerson";
            this.textBoxCodeContectPerson.Size = new System.Drawing.Size(240, 29);
            this.textBoxCodeContectPerson.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Редактирование данных";
            // 
            // textBoxFIOContactPerson
            // 
            this.textBoxFIOContactPerson.Location = new System.Drawing.Point(215, 124);
            this.textBoxFIOContactPerson.Name = "textBoxFIOContactPerson";
            this.textBoxFIOContactPerson.Size = new System.Drawing.Size(240, 29);
            this.textBoxFIOContactPerson.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО контактного лица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(215, 218);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(240, 29);
            this.textBoxEmail.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Код поставщика";
            // 
            // dataGridViewContectPerson
            // 
            this.dataGridViewContectPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContectPerson.Location = new System.Drawing.Point(17, 296);
            this.dataGridViewContectPerson.Name = "dataGridViewContectPerson";
            this.dataGridViewContectPerson.Size = new System.Drawing.Size(442, 203);
            this.dataGridViewContectPerson.TabIndex = 9;
            this.dataGridViewContectPerson.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContectPerson_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(474, 127);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 28);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(474, 196);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 28);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(474, 161);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(132, 28);
            this.buttonChenge.TabIndex = 33;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(474, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(132, 56);
            this.buttonSearch.TabIndex = 32;
            this.buttonSearch.Text = "Поиск по коду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(474, 67);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 56);
            this.buttonRemove.TabIndex = 31;
            this.buttonRemove.Text = "Удаление по ко-ду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCodeProvider
            // 
            this.comboBoxCodeProvider.FormattingEnabled = true;
            this.comboBoxCodeProvider.Location = new System.Drawing.Point(215, 176);
            this.comboBoxCodeProvider.Name = "comboBoxCodeProvider";
            this.comboBoxCodeProvider.Size = new System.Drawing.Size(240, 30);
            this.comboBoxCodeProvider.TabIndex = 36;
            // 
            // ContectPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 529);
            this.Controls.Add(this.comboBoxCodeProvider);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.dataGridViewContectPerson);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFIOContactPerson);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodeContectPerson);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ContectPerson";
            this.Text = "Контактное лицо";
            this.Load += new System.EventHandler(this.ContectPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContectPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodeContectPerson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFIOContactPerson;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewContectPerson;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxCodeProvider;
    }
}