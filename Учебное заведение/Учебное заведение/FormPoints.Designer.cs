namespace Учебное_заведение
{
    partial class FormPoints
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelStudent = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPoint = new System.Windows.Forms.Label();
            this.labelLesson = new System.Windows.Forms.Label();
            this.listViewPoint = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.comboBoxLesson = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(351, 165);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(7);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(87, 36);
            this.buttonEdit.TabIndex = 38;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(250, 165);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(7);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 36);
            this.buttonAdd.TabIndex = 37;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(452, 165);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(7);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(87, 36);
            this.buttonDel.TabIndex = 39;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Балл";
            this.columnHeader4.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Занятие";
            this.columnHeader3.Width = 132;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStudent.Location = new System.Drawing.Point(6, 9);
            this.labelStudent.Margin = new System.Windows.Forms.Padding(3);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(58, 18);
            this.labelStudent.TabIndex = 34;
            this.labelStudent.Text = "Студент";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ФИО студента";
            this.columnHeader2.Width = 99;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(6, 113);
            this.labelPoint.Margin = new System.Windows.Forms.Padding(3);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(39, 18);
            this.labelPoint.TabIndex = 44;
            this.labelPoint.Text = "Балл";
            // 
            // labelLesson
            // 
            this.labelLesson.AutoSize = true;
            this.labelLesson.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLesson.Location = new System.Drawing.Point(5, 61);
            this.labelLesson.Margin = new System.Windows.Forms.Padding(3);
            this.labelLesson.Name = "labelLesson";
            this.labelLesson.Size = new System.Drawing.Size(59, 18);
            this.labelLesson.TabIndex = 40;
            this.labelLesson.Text = "Занятие";
            // 
            // listViewPoint
            // 
            this.listViewPoint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewPoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewPoint.FullRowSelect = true;
            this.listViewPoint.GridLines = true;
            this.listViewPoint.HideSelection = false;
            this.listViewPoint.Location = new System.Drawing.Point(141, 12);
            this.listViewPoint.MultiSelect = false;
            this.listViewPoint.Name = "listViewPoint";
            this.listViewPoint.Size = new System.Drawing.Size(398, 143);
            this.listViewPoint.TabIndex = 36;
            this.listViewPoint.UseCompatibleStateImageBehavior = false;
            this.listViewPoint.View = System.Windows.Forms.View.Details;
            this.listViewPoint.SelectedIndexChanged += new System.EventHandler(this.listViewPoint_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPoint.Location = new System.Drawing.Point(8, 135);
            this.textBoxPoint.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxPoint.Multiline = true;
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.Size = new System.Drawing.Size(127, 24);
            this.textBoxPoint.TabIndex = 45;
            this.textBoxPoint.TabStop = false;
            this.textBoxPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPoint_KeyPress);
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(8, 31);
            this.comboBoxStudent.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(126, 26);
            this.comboBoxStudent.TabIndex = 46;
            // 
            // comboBoxLesson
            // 
            this.comboBoxLesson.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxLesson.FormattingEnabled = true;
            this.comboBoxLesson.Location = new System.Drawing.Point(8, 83);
            this.comboBoxLesson.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxLesson.Name = "comboBoxLesson";
            this.comboBoxLesson.Size = new System.Drawing.Size(127, 26);
            this.comboBoxLesson.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Учебное_заведение.Properties.Resources.лого2;
            this.pictureBox2.Location = new System.Drawing.Point(8, 169);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // FormPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(547, 230);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxLesson);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.labelLesson);
            this.Controls.Add(this.listViewPoint);
            this.Controls.Add(this.textBoxPoint);
            this.Name = "FormPoints";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Баллы";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Label labelLesson;
        private System.Windows.Forms.ListView listViewPoint;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.ComboBox comboBoxLesson;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}