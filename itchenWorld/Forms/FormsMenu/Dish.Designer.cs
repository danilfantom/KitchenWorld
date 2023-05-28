namespace itchenWorld.Forms.FormsMenu
{
    partial class Dish
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
            this.dataGridViewDish = new System.Windows.Forms.DataGridView();
            this.labelCodeDish = new System.Windows.Forms.Label();
            this.textBoxCodeDish = new System.Windows.Forms.TextBox();
            this.labelCodeKitchen = new System.Windows.Forms.Label();
            this.textBoxNameDish = new System.Windows.Forms.TextBox();
            this.labelNameDish = new System.Windows.Forms.Label();
            this.textBoxPriceDish = new System.Windows.Forms.TextBox();
            this.labelPriceDish = new System.Windows.Forms.Label();
            this.textBoxWeightDish = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxNameKitchen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDish
            // 
            this.dataGridViewDish.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDish.Location = new System.Drawing.Point(21, 278);
            this.dataGridViewDish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDish.Name = "dataGridViewDish";
            this.dataGridViewDish.RowHeadersVisible = false;
            this.dataGridViewDish.Size = new System.Drawing.Size(518, 242);
            this.dataGridViewDish.TabIndex = 0;
            this.dataGridViewDish.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDish_CellClick);
            // 
            // labelCodeDish
            // 
            this.labelCodeDish.AutoSize = true;
            this.labelCodeDish.Location = new System.Drawing.Point(17, 20);
            this.labelCodeDish.Name = "labelCodeDish";
            this.labelCodeDish.Size = new System.Drawing.Size(95, 21);
            this.labelCodeDish.TabIndex = 1;
            this.labelCodeDish.Text = "Код блюда";
            // 
            // textBoxCodeDish
            // 
            this.textBoxCodeDish.Location = new System.Drawing.Point(128, 12);
            this.textBoxCodeDish.Name = "textBoxCodeDish";
            this.textBoxCodeDish.Size = new System.Drawing.Size(250, 29);
            this.textBoxCodeDish.TabIndex = 2;
            // 
            // labelCodeKitchen
            // 
            this.labelCodeKitchen.AutoSize = true;
            this.labelCodeKitchen.Location = new System.Drawing.Point(18, 227);
            this.labelCodeKitchen.Name = "labelCodeKitchen";
            this.labelCodeKitchen.Size = new System.Drawing.Size(128, 21);
            this.labelCodeKitchen.TabIndex = 3;
            this.labelCodeKitchen.Text = "Название кухни";
            // 
            // textBoxNameDish
            // 
            this.textBoxNameDish.Location = new System.Drawing.Point(163, 140);
            this.textBoxNameDish.Name = "textBoxNameDish";
            this.textBoxNameDish.Size = new System.Drawing.Size(248, 29);
            this.textBoxNameDish.TabIndex = 6;
            // 
            // labelNameDish
            // 
            this.labelNameDish.AutoSize = true;
            this.labelNameDish.Location = new System.Drawing.Point(8, 148);
            this.labelNameDish.Name = "labelNameDish";
            this.labelNameDish.Size = new System.Drawing.Size(139, 21);
            this.labelNameDish.TabIndex = 5;
            this.labelNameDish.Text = "Название блюда";
            // 
            // textBoxPriceDish
            // 
            this.textBoxPriceDish.Location = new System.Drawing.Point(163, 95);
            this.textBoxPriceDish.Name = "textBoxPriceDish";
            this.textBoxPriceDish.Size = new System.Drawing.Size(248, 29);
            this.textBoxPriceDish.TabIndex = 8;
            // 
            // labelPriceDish
            // 
            this.labelPriceDish.AutoSize = true;
            this.labelPriceDish.Location = new System.Drawing.Point(-3, 103);
            this.labelPriceDish.Name = "labelPriceDish";
            this.labelPriceDish.Size = new System.Drawing.Size(149, 21);
            this.labelPriceDish.TabIndex = 7;
            this.labelPriceDish.Text = "Стоимость блюда";
            // 
            // textBoxWeightDish
            // 
            this.textBoxWeightDish.Location = new System.Drawing.Point(161, 183);
            this.textBoxWeightDish.Name = "textBoxWeightDish";
            this.textBoxWeightDish.Size = new System.Drawing.Size(250, 29);
            this.textBoxWeightDish.TabIndex = 10;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(53, 191);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(93, 21);
            this.labelWeight.TabIndex = 9;
            this.labelWeight.Text = "Вес блюда";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(8, 57);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(235, 25);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Редактирование данных";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(422, 63);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(117, 53);
            this.buttonRemove.TabIndex = 15;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(422, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 53);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Поиск по ко-ду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(422, 178);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 27);
            this.buttonChenge.TabIndex = 17;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(422, 216);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(117, 27);
            this.buttonClear.TabIndex = 18;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(422, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 27);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxNameKitchen
            // 
            this.textBoxNameKitchen.Location = new System.Drawing.Point(162, 227);
            this.textBoxNameKitchen.Name = "textBoxNameKitchen";
            this.textBoxNameKitchen.Size = new System.Drawing.Size(249, 29);
            this.textBoxNameKitchen.TabIndex = 20;
            // 
            // Dish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 540);
            this.Controls.Add(this.textBoxNameKitchen);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.textBoxWeightDish);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.textBoxPriceDish);
            this.Controls.Add(this.labelPriceDish);
            this.Controls.Add(this.textBoxNameDish);
            this.Controls.Add(this.labelNameDish);
            this.Controls.Add(this.labelCodeKitchen);
            this.Controls.Add(this.textBoxCodeDish);
            this.Controls.Add(this.labelCodeDish);
            this.Controls.Add(this.dataGridViewDish);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dish";
            this.Text = "Блюдо";
            this.Load += new System.EventHandler(this.Dish_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDish;
        private System.Windows.Forms.Label labelCodeDish;
        private System.Windows.Forms.TextBox textBoxCodeDish;
        private System.Windows.Forms.Label labelCodeKitchen;
        private System.Windows.Forms.TextBox textBoxNameDish;
        private System.Windows.Forms.Label labelNameDish;
        private System.Windows.Forms.TextBox textBoxPriceDish;
        private System.Windows.Forms.Label labelPriceDish;
        private System.Windows.Forms.TextBox textBoxWeightDish;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxNameKitchen;
    }
}