namespace itchenWorld.Forms.FormsMenu
{
    partial class Product
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.labelHeaderCodeProduct = new System.Windows.Forms.Label();
            this.textBoxNumberProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantityProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxCodePorductProvider = new System.Windows.Forms.ComboBox();
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxCodeWareHouse = new System.Windows.Forms.ComboBox();
            this.comboBoxCodePurcasthe = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(20, 393);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.Size = new System.Drawing.Size(619, 315);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // labelHeaderCodeProduct
            // 
            this.labelHeaderCodeProduct.AutoSize = true;
            this.labelHeaderCodeProduct.Location = new System.Drawing.Point(110, 42);
            this.labelHeaderCodeProduct.Name = "labelHeaderCodeProduct";
            this.labelHeaderCodeProduct.Size = new System.Drawing.Size(115, 21);
            this.labelHeaderCodeProduct.TabIndex = 1;
            this.labelHeaderCodeProduct.Text = "Код продукта";
            // 
            // textBoxNumberProduct
            // 
            this.textBoxNumberProduct.Location = new System.Drawing.Point(277, 39);
            this.textBoxNumberProduct.Name = "textBoxNumberProduct";
            this.textBoxNumberProduct.Size = new System.Drawing.Size(197, 29);
            this.textBoxNumberProduct.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Редактирование данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Код склада";
            // 
            // textBoxQuantityProduct
            // 
            this.textBoxQuantityProduct.Location = new System.Drawing.Point(277, 167);
            this.textBoxQuantityProduct.Name = "textBoxQuantityProduct";
            this.textBoxQuantityProduct.Size = new System.Drawing.Size(197, 29);
            this.textBoxQuantityProduct.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Код закупки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Название";
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Location = new System.Drawing.Point(277, 312);
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(197, 29);
            this.textBoxNameProduct.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Код поставщика продукта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Код типа продукта";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Количество продукта (кг)";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(522, 229);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 27);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(522, 305);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 27);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(522, 267);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 27);
            this.buttonChenge.TabIndex = 22;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(522, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 53);
            this.buttonSearch.TabIndex = 21;
            this.buttonSearch.Text = "Поиск по ко-ду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(522, 101);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(117, 53);
            this.buttonRemove.TabIndex = 20;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxCodePorductProvider
            // 
            this.comboBoxCodePorductProvider.FormattingEnabled = true;
            this.comboBoxCodePorductProvider.Location = new System.Drawing.Point(277, 132);
            this.comboBoxCodePorductProvider.Name = "comboBoxCodePorductProvider";
            this.comboBoxCodePorductProvider.Size = new System.Drawing.Size(197, 29);
            this.comboBoxCodePorductProvider.TabIndex = 25;
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(277, 203);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(197, 29);
            this.comboBoxTypeProduct.TabIndex = 26;
            // 
            // comboBoxCodeWareHouse
            // 
            this.comboBoxCodeWareHouse.FormattingEnabled = true;
            this.comboBoxCodeWareHouse.Location = new System.Drawing.Point(277, 242);
            this.comboBoxCodeWareHouse.Name = "comboBoxCodeWareHouse";
            this.comboBoxCodeWareHouse.Size = new System.Drawing.Size(197, 29);
            this.comboBoxCodeWareHouse.TabIndex = 27;
            // 
            // comboBoxCodePurcasthe
            // 
            this.comboBoxCodePurcasthe.FormattingEnabled = true;
            this.comboBoxCodePurcasthe.Location = new System.Drawing.Point(277, 277);
            this.comboBoxCodePurcasthe.Name = "comboBoxCodePurcasthe";
            this.comboBoxCodePurcasthe.Size = new System.Drawing.Size(197, 29);
            this.comboBoxCodePurcasthe.TabIndex = 28;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 727);
            this.Controls.Add(this.comboBoxCodePurcasthe);
            this.Controls.Add(this.comboBoxCodeWareHouse);
            this.Controls.Add(this.comboBoxTypeProduct);
            this.Controls.Add(this.comboBoxCodePorductProvider);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQuantityProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumberProduct);
            this.Controls.Add(this.labelHeaderCodeProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product";
            this.Text = "Продукты";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label labelHeaderCodeProduct;
        private System.Windows.Forms.TextBox textBoxNumberProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantityProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxCodePorductProvider;
        private System.Windows.Forms.ComboBox comboBoxTypeProduct;
        private System.Windows.Forms.ComboBox comboBoxCodeWareHouse;
        private System.Windows.Forms.ComboBox comboBoxCodePurcasthe;
    }
}