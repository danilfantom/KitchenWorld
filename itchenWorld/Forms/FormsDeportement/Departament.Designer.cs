namespace itchenWorld.Forms.FormsDeportement
{
    partial class Departament
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
            this.dataGridViewDepartament = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxcodeDepartaent = new System.Windows.Forms.TextBox();
            this.textBoxDepartamentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartament)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDepartament
            // 
            this.dataGridViewDepartament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepartament.Location = new System.Drawing.Point(12, 103);
            this.dataGridViewDepartament.Name = "dataGridViewDepartament";
            this.dataGridViewDepartament.Size = new System.Drawing.Size(279, 221);
            this.dataGridViewDepartament.TabIndex = 0;
            this.dataGridViewDepartament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDepartament_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код отдела";
            // 
            // textBoxcodeDepartaent
            // 
            this.textBoxcodeDepartaent.Location = new System.Drawing.Point(119, 10);
            this.textBoxcodeDepartaent.Name = "textBoxcodeDepartaent";
            this.textBoxcodeDepartaent.Size = new System.Drawing.Size(172, 29);
            this.textBoxcodeDepartaent.TabIndex = 2;
            // 
            // textBoxDepartamentName
            // 
            this.textBoxDepartamentName.Location = new System.Drawing.Point(119, 47);
            this.textBoxDepartamentName.Name = "textBoxDepartamentName";
            this.textBoxDepartamentName.Size = new System.Drawing.Size(172, 29);
            this.textBoxDepartamentName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(316, 164);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 46);
            this.buttonAdd.TabIndex = 34;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(317, 278);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 46);
            this.buttonClear.TabIndex = 33;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(316, 221);
            this.buttonChenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 46);
            this.buttonChenge.TabIndex = 32;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(316, 10);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 58);
            this.buttonSearch.TabIndex = 31;
            this.buttonSearch.Text = "Поиск по ко-ду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(317, 82);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(116, 66);
            this.buttonRemove.TabIndex = 30;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // Departament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 344);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxDepartamentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxcodeDepartaent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDepartament);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Departament";
            this.Text = "Отдел";
            this.Load += new System.EventHandler(this.Departament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepartament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDepartament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcodeDepartaent;
        private System.Windows.Forms.TextBox textBoxDepartamentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
    }
}