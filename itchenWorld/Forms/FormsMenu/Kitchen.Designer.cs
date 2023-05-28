namespace itchenWorld.Forms.FormsMenu
{
    partial class Kitchen
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
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.label1HeaderSearch = new System.Windows.Forms.Label();
            this.labelHeaderEditing = new System.Windows.Forms.Label();
            this.textBoxNumberKutchen = new System.Windows.Forms.TextBox();
            this.labelHeaderRoom = new System.Windows.Forms.Label();
            this.comboBoxNumberRoom = new System.Windows.Forms.ComboBox();
            this.labelNameKitchen = new System.Windows.Forms.Label();
            this.textBoxNameKitchen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNationalKitchen = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(10, 264);
            this.dataGridViewMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersVisible = false;
            this.dataGridViewMenu.Size = new System.Drawing.Size(672, 242);
            this.dataGridViewMenu.TabIndex = 0;
            this.dataGridViewMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellClick);
            // 
            // label1HeaderSearch
            // 
            this.label1HeaderSearch.AutoSize = true;
            this.label1HeaderSearch.Location = new System.Drawing.Point(16, 34);
            this.label1HeaderSearch.Name = "label1HeaderSearch";
            this.label1HeaderSearch.Size = new System.Drawing.Size(84, 21);
            this.label1HeaderSearch.TabIndex = 1;
            this.label1HeaderSearch.Text = "Код кухни";
            // 
            // labelHeaderEditing
            // 
            this.labelHeaderEditing.AutoSize = true;
            this.labelHeaderEditing.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeaderEditing.Location = new System.Drawing.Point(15, 75);
            this.labelHeaderEditing.Name = "labelHeaderEditing";
            this.labelHeaderEditing.Size = new System.Drawing.Size(235, 25);
            this.labelHeaderEditing.TabIndex = 2;
            this.labelHeaderEditing.Text = "Редактирование данных";
            // 
            // textBoxNumberKutchen
            // 
            this.textBoxNumberKutchen.Location = new System.Drawing.Point(213, 34);
            this.textBoxNumberKutchen.Name = "textBoxNumberKutchen";
            this.textBoxNumberKutchen.Size = new System.Drawing.Size(278, 29);
            this.textBoxNumberKutchen.TabIndex = 3;
            // 
            // labelHeaderRoom
            // 
            this.labelHeaderRoom.AutoSize = true;
            this.labelHeaderRoom.Location = new System.Drawing.Point(15, 203);
            this.labelHeaderRoom.Name = "labelHeaderRoom";
            this.labelHeaderRoom.Size = new System.Drawing.Size(131, 21);
            this.labelHeaderRoom.TabIndex = 4;
            this.labelHeaderRoom.Text = "Код помещения";
            // 
            // comboBoxNumberRoom
            // 
            this.comboBoxNumberRoom.FormattingEnabled = true;
            this.comboBoxNumberRoom.Location = new System.Drawing.Point(213, 203);
            this.comboBoxNumberRoom.Name = "comboBoxNumberRoom";
            this.comboBoxNumberRoom.Size = new System.Drawing.Size(278, 29);
            this.comboBoxNumberRoom.TabIndex = 5;
            // 
            // labelNameKitchen
            // 
            this.labelNameKitchen.AutoSize = true;
            this.labelNameKitchen.Location = new System.Drawing.Point(15, 159);
            this.labelNameKitchen.Name = "labelNameKitchen";
            this.labelNameKitchen.Size = new System.Drawing.Size(128, 21);
            this.labelNameKitchen.TabIndex = 6;
            this.labelNameKitchen.Text = "Название кухни";
            // 
            // textBoxNameKitchen
            // 
            this.textBoxNameKitchen.Location = new System.Drawing.Point(213, 156);
            this.textBoxNameKitchen.Name = "textBoxNameKitchen";
            this.textBoxNameKitchen.Size = new System.Drawing.Size(278, 29);
            this.textBoxNameKitchen.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Национальность кухни";
            // 
            // textBoxNationalKitchen
            // 
            this.textBoxNationalKitchen.Location = new System.Drawing.Point(213, 115);
            this.textBoxNationalKitchen.Name = "textBoxNationalKitchen";
            this.textBoxNationalKitchen.Size = new System.Drawing.Size(278, 29);
            this.textBoxNationalKitchen.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(574, 155);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(108, 29);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(548, 76);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(134, 55);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Удалить по ко-ду кухни";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(574, 192);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(108, 29);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Location = new System.Drawing.Point(574, 227);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(108, 29);
            this.buttonChangeData.TabIndex = 14;
            this.buttonChangeData.Text = "Изменить";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            this.buttonChangeData.Click += new System.EventHandler(this.buttonChangeData_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(548, 19);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 51);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Найти по коду кухни";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 520);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonChangeData);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNationalKitchen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNameKitchen);
            this.Controls.Add(this.labelNameKitchen);
            this.Controls.Add(this.comboBoxNumberRoom);
            this.Controls.Add(this.labelHeaderRoom);
            this.Controls.Add(this.textBoxNumberKutchen);
            this.Controls.Add(this.labelHeaderEditing);
            this.Controls.Add(this.label1HeaderSearch);
            this.Controls.Add(this.dataGridViewMenu);
            this.Font = new System.Drawing.Font("Segoe UI Symbol", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Kitchen";
            this.Text = "Кухни";
            this.Load += new System.EventHandler(this.Kitchen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.Label label1HeaderSearch;
        private System.Windows.Forms.Label labelHeaderEditing;
        private System.Windows.Forms.TextBox textBoxNumberKutchen;
        private System.Windows.Forms.Label labelHeaderRoom;
        private System.Windows.Forms.ComboBox comboBoxNumberRoom;
        private System.Windows.Forms.Label labelNameKitchen;
        private System.Windows.Forms.TextBox textBoxNameKitchen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNationalKitchen;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.Button buttonSearch;
    }
}