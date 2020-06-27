namespace DatabaseWorkers
{
    partial class Form1
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
            this.listBoxWorkers = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFirtsName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateBegin = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMenager = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxWorkers
            // 
            this.listBoxWorkers.FormattingEnabled = true;
            this.listBoxWorkers.Location = new System.Drawing.Point(13, 13);
            this.listBoxWorkers.Name = "listBoxWorkers";
            this.listBoxWorkers.Size = new System.Drawing.Size(331, 264);
            this.listBoxWorkers.TabIndex = 0;
            this.listBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkers_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.66879F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.33121F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirtsName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDateBegin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMenager, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(371, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 171);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data_Zatrudnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wynagrodzenie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kierownik";
            // 
            // textBoxFirtsName
            // 
            this.textBoxFirtsName.Location = new System.Drawing.Point(158, 3);
            this.textBoxFirtsName.Name = "textBoxFirtsName";
            this.textBoxFirtsName.Size = new System.Drawing.Size(274, 20);
            this.textBoxFirtsName.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(158, 29);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(274, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // dateTimePickerDateBegin
            // 
            this.dateTimePickerDateBegin.Location = new System.Drawing.Point(158, 55);
            this.dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            this.dateTimePickerDateBegin.Size = new System.Drawing.Size(274, 20);
            this.dateTimePickerDateBegin.TabIndex = 7;
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.DecimalPlaces = 2;
            this.numericUpDownSalary.Location = new System.Drawing.Point(158, 81);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownSalary.Minimum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(274, 20);
            this.numericUpDownSalary.TabIndex = 8;
            this.numericUpDownSalary.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // checkBoxMenager
            // 
            this.checkBoxMenager.AutoSize = true;
            this.checkBoxMenager.Location = new System.Drawing.Point(158, 107);
            this.checkBoxMenager.Name = "checkBoxMenager";
            this.checkBoxMenager.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMenager.TabIndex = 9;
            this.checkBoxMenager.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(371, 190);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(195, 52);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(572, 190);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(195, 52);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usun";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(824, 317);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listBoxWorkers);
            this.Name = "Form1";
            this.Text = "DataBase for workers";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWorkers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFirtsName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateBegin;
        private System.Windows.Forms.NumericUpDown numericUpDownSalary;
        private System.Windows.Forms.CheckBox checkBoxMenager;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}

