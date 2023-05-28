namespace itchenWorld.Forms.FormsEquipment
{
    partial class Inventory
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
            this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodeInventory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTypeInventory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCodeInventorization = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuantityInventory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInventoryName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddInventorization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            this.dataGridViewInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventory.Location = new System.Drawing.Point(18, 327);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.RowHeadersVisible = false;
            this.dataGridViewInventory.Size = new System.Drawing.Size(592, 200);
            this.dataGridViewInventory.TabIndex = 0;
            this.dataGridViewInventory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код инвенторя";
            // 
            // textBoxCodeInventory
            // 
            this.textBoxCodeInventory.Location = new System.Drawing.Point(249, 19);
            this.textBoxCodeInventory.Name = "textBoxCodeInventory";
            this.textBoxCodeInventory.Size = new System.Drawing.Size(209, 29);
            this.textBoxCodeInventory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Редактирование данных";
            // 
            // textBoxTypeInventory
            // 
            this.textBoxTypeInventory.Location = new System.Drawing.Point(249, 194);
            this.textBoxTypeInventory.Name = "textBoxTypeInventory";
            this.textBoxTypeInventory.Size = new System.Drawing.Size(209, 29);
            this.textBoxTypeInventory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип инвентаря";
            // 
            // textBoxCodeInventorization
            // 
            this.textBoxCodeInventorization.Location = new System.Drawing.Point(249, 152);
            this.textBoxCodeInventorization.Name = "textBoxCodeInventorization";
            this.textBoxCodeInventorization.Size = new System.Drawing.Size(209, 29);
            this.textBoxCodeInventorization.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Код инвентаризации";
            // 
            // textBoxQuantityInventory
            // 
            this.textBoxQuantityInventory.Location = new System.Drawing.Point(249, 114);
            this.textBoxQuantityInventory.Name = "textBoxQuantityInventory";
            this.textBoxQuantityInventory.Size = new System.Drawing.Size(209, 29);
            this.textBoxQuantityInventory.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Количество инвентаря (шт)";
            // 
            // textBoxInventoryName
            // 
            this.textBoxInventoryName.Location = new System.Drawing.Point(249, 234);
            this.textBoxInventoryName.Name = "textBoxInventoryName";
            this.textBoxInventoryName.Size = new System.Drawing.Size(209, 29);
            this.textBoxInventoryName.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Название";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(478, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 28);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(478, 204);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(132, 28);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(478, 170);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(132, 28);
            this.buttonChenge.TabIndex = 22;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(478, 14);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(132, 56);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Поиск по коду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(478, 75);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(132, 56);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Удаление по ко-ду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddInventorization
            // 
            this.buttonAddInventorization.Location = new System.Drawing.Point(478, 239);
            this.buttonAddInventorization.Name = "buttonAddInventorization";
            this.buttonAddInventorization.Size = new System.Drawing.Size(132, 82);
            this.buttonAddInventorization.TabIndex = 25;
            this.buttonAddInventorization.Text = "Создать инвен-таризацию";
            this.buttonAddInventorization.UseVisualStyleBackColor = true;
            this.buttonAddInventorization.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 556);
            this.Controls.Add(this.buttonAddInventorization);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxInventoryName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxQuantityInventory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCodeInventorization);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTypeInventory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodeInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewInventory);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inventory";
            this.Text = "Инвентарь";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodeInventory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTypeInventory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCodeInventorization;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuantityInventory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInventoryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddInventorization;
    }
}