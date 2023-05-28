namespace itchenWorld.Forms.FormsDeportement
{
    partial class UtilitesWater
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
            this.textBoxIndication = new System.Windows.Forms.TextBox();
            this.dataGridViewUtilitesWater = new System.Windows.Forms.DataGridView();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStartMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEndMonth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCodeRoom = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilitesWater)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код показания воды";
            // 
            // textBoxIndication
            // 
            this.textBoxIndication.Location = new System.Drawing.Point(265, 10);
            this.textBoxIndication.Name = "textBoxIndication";
            this.textBoxIndication.Size = new System.Drawing.Size(121, 29);
            this.textBoxIndication.TabIndex = 1;
            // 
            // dataGridViewUtilitesWater
            // 
            this.dataGridViewUtilitesWater.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUtilitesWater.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUtilitesWater.Location = new System.Drawing.Point(12, 338);
            this.dataGridViewUtilitesWater.Name = "dataGridViewUtilitesWater";
            this.dataGridViewUtilitesWater.Size = new System.Drawing.Size(527, 157);
            this.dataGridViewUtilitesWater.TabIndex = 2;
            this.dataGridViewUtilitesWater.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUtilitesWater_CellClick);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(265, 207);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 29);
            this.textBoxPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Стоимость Куб/М";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14F);
            this.label3.Location = new System.Drawing.Point(13, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Редактироввание данных";
            // 
            // textBoxStartMonth
            // 
            this.textBoxStartMonth.Location = new System.Drawing.Point(265, 106);
            this.textBoxStartMonth.Name = "textBoxStartMonth";
            this.textBoxStartMonth.Size = new System.Drawing.Size(121, 29);
            this.textBoxStartMonth.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Показания на начало месяца";
            // 
            // textBoxEndMonth
            // 
            this.textBoxEndMonth.Location = new System.Drawing.Point(265, 155);
            this.textBoxEndMonth.Name = "textBoxEndMonth";
            this.textBoxEndMonth.Size = new System.Drawing.Size(121, 29);
            this.textBoxEndMonth.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Показания на конец месяца";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Код помещения";
            // 
            // comboBoxCodeRoom
            // 
            this.comboBoxCodeRoom.FormattingEnabled = true;
            this.comboBoxCodeRoom.Location = new System.Drawing.Point(265, 244);
            this.comboBoxCodeRoom.Name = "comboBoxCodeRoom";
            this.comboBoxCodeRoom.Size = new System.Drawing.Size(121, 30);
            this.comboBoxCodeRoom.TabIndex = 11;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(422, 166);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 46);
            this.buttonAdd.TabIndex = 44;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(423, 279);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 46);
            this.buttonClear.TabIndex = 43;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(422, 222);
            this.buttonChenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 46);
            this.buttonChenge.TabIndex = 42;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(422, 10);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 58);
            this.buttonSearch.TabIndex = 41;
            this.buttonSearch.Text = "Поиск по ко-ду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(423, 83);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(116, 66);
            this.buttonRemove.TabIndex = 40;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // UtilitesWater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 508);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxCodeRoom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxEndMonth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStartMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUtilitesWater);
            this.Controls.Add(this.textBoxIndication);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UtilitesWater";
            this.Text = "UtilitesWater";
            this.Load += new System.EventHandler(this.UtilitesWater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUtilitesWater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIndication;
        private System.Windows.Forms.DataGridView dataGridViewUtilitesWater;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStartMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEndMonth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCodeRoom;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
    }
}