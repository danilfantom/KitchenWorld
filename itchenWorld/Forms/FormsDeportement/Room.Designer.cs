namespace itchenWorld.Forms.FormsDeportement
{
    partial class Room
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
            this.textBoxCodeRoom = new System.Windows.Forms.TextBox();
            this.dataGridViewRoom = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAppointment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCodeInventorization = new System.Windows.Forms.ComboBox();
            this.comboBoxCodeDepartament = new System.Windows.Forms.ComboBox();
            this.comboBoxCodeCitchenWorld = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Код помещения";
            // 
            // textBoxCodeRoom
            // 
            this.textBoxCodeRoom.Location = new System.Drawing.Point(303, 22);
            this.textBoxCodeRoom.Name = "textBoxCodeRoom";
            this.textBoxCodeRoom.Size = new System.Drawing.Size(169, 29);
            this.textBoxCodeRoom.TabIndex = 1;
            // 
            // dataGridViewRoom
            // 
            this.dataGridViewRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoom.Location = new System.Drawing.Point(12, 270);
            this.dataGridViewRoom.Name = "dataGridViewRoom";
            this.dataGridViewRoom.Size = new System.Drawing.Size(455, 174);
            this.dataGridViewRoom.TabIndex = 2;
            this.dataGridViewRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoom_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Код отдела в помещении";
            // 
            // textBoxAppointment
            // 
            this.textBoxAppointment.Location = new System.Drawing.Point(303, 172);
            this.textBoxAppointment.Name = "textBoxAppointment";
            this.textBoxAppointment.Size = new System.Drawing.Size(169, 29);
            this.textBoxAppointment.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Назачение помещения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Код кухни мира";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Редактирование данных";
            // 
            // comboBoxCodeInventorization
            // 
            this.comboBoxCodeInventorization.FormattingEnabled = true;
            this.comboBoxCodeInventorization.Location = new System.Drawing.Point(303, 98);
            this.comboBoxCodeInventorization.Name = "comboBoxCodeInventorization";
            this.comboBoxCodeInventorization.Size = new System.Drawing.Size(169, 30);
            this.comboBoxCodeInventorization.TabIndex = 12;
            // 
            // comboBoxCodeDepartament
            // 
            this.comboBoxCodeDepartament.FormattingEnabled = true;
            this.comboBoxCodeDepartament.Location = new System.Drawing.Point(303, 135);
            this.comboBoxCodeDepartament.Name = "comboBoxCodeDepartament";
            this.comboBoxCodeDepartament.Size = new System.Drawing.Size(169, 30);
            this.comboBoxCodeDepartament.TabIndex = 13;
            // 
            // comboBoxCodeCitchenWorld
            // 
            this.comboBoxCodeCitchenWorld.FormattingEnabled = true;
            this.comboBoxCodeCitchenWorld.Location = new System.Drawing.Point(303, 214);
            this.comboBoxCodeCitchenWorld.Name = "comboBoxCodeCitchenWorld";
            this.comboBoxCodeCitchenWorld.Size = new System.Drawing.Size(169, 30);
            this.comboBoxCodeCitchenWorld.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Код инвентаризации помещения";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(497, 176);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 46);
            this.buttonAdd.TabIndex = 39;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(498, 289);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 46);
            this.buttonClear.TabIndex = 38;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(497, 233);
            this.buttonChenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 46);
            this.buttonChenge.TabIndex = 37;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(497, 22);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 58);
            this.buttonSearch.TabIndex = 36;
            this.buttonSearch.Text = "Поиск по коду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(498, 93);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(116, 66);
            this.buttonRemove.TabIndex = 35;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 485);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.comboBoxCodeCitchenWorld);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCodeDepartament);
            this.Controls.Add(this.comboBoxCodeInventorization);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewRoom);
            this.Controls.Add(this.textBoxCodeRoom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Room";
            this.Text = "Помещение";
            this.Load += new System.EventHandler(this.Room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodeRoom;
        private System.Windows.Forms.DataGridView dataGridViewRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCodeInventorization;
        private System.Windows.Forms.ComboBox comboBoxCodeDepartament;
        private System.Windows.Forms.ComboBox comboBoxCodeCitchenWorld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
    }
}