namespace itchenWorld.Forms.FormsDeportement
{
    partial class CompositePurcahe
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonChenge = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxCodeRoom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCompositePurcahe = new System.Windows.Forms.DataGridView();
            this.comboBoxVodeStock = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompositePurcahe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(419, 180);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 46);
            this.buttonAdd.TabIndex = 49;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(420, 293);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(116, 46);
            this.buttonClear.TabIndex = 48;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonChenge
            // 
            this.buttonChenge.Location = new System.Drawing.Point(419, 237);
            this.buttonChenge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChenge.Name = "buttonChenge";
            this.buttonChenge.Size = new System.Drawing.Size(117, 46);
            this.buttonChenge.TabIndex = 47;
            this.buttonChenge.Text = "Изменить";
            this.buttonChenge.UseVisualStyleBackColor = true;
            this.buttonChenge.Click += new System.EventHandler(this.buttonChenge_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(419, 25);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(117, 58);
            this.buttonSearch.TabIndex = 46;
            this.buttonSearch.Text = "Поиск по коду";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(420, 97);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(116, 66);
            this.buttonRemove.TabIndex = 45;
            this.buttonRemove.Text = "Удаление по коду";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxCodeRoom
            // 
            this.textBoxCodeRoom.Location = new System.Drawing.Point(224, 22);
            this.textBoxCodeRoom.Name = "textBoxCodeRoom";
            this.textBoxCodeRoom.Size = new System.Drawing.Size(188, 29);
            this.textBoxCodeRoom.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Код содержания закупки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 41;
            this.label1.Text = "Содержание закупки";
            // 
            // dataGridViewCompositePurcahe
            // 
            this.dataGridViewCompositePurcahe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompositePurcahe.Location = new System.Drawing.Point(23, 130);
            this.dataGridViewCompositePurcahe.Name = "dataGridViewCompositePurcahe";
            this.dataGridViewCompositePurcahe.Size = new System.Drawing.Size(389, 212);
            this.dataGridViewCompositePurcahe.TabIndex = 40;
            this.dataGridViewCompositePurcahe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCompositePurcahe_CellClick);
            // 
            // comboBoxVodeStock
            // 
            this.comboBoxVodeStock.FormattingEnabled = true;
            this.comboBoxVodeStock.Location = new System.Drawing.Point(224, 67);
            this.comboBoxVodeStock.Name = "comboBoxVodeStock";
            this.comboBoxVodeStock.Size = new System.Drawing.Size(188, 30);
            this.comboBoxVodeStock.TabIndex = 50;
            // 
            // CompositePurcahe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 360);
            this.Controls.Add(this.comboBoxVodeStock);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChenge);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.textBoxCodeRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCompositePurcahe);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompositePurcahe";
            this.Text = "Содержание закупки";
            this.Load += new System.EventHandler(this.CompositePurcahe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompositePurcahe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonChenge;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxCodeRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCompositePurcahe;
        private System.Windows.Forms.ComboBox comboBoxVodeStock;
    }
}