namespace Учебное_заведение
{
    partial class Menu
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
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonLesson = new System.Windows.Forms.Button();
            this.buttonPoints = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroups.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroups.Location = new System.Drawing.Point(55, 103);
            this.buttonGroups.Margin = new System.Windows.Forms.Padding(7);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(205, 48);
            this.buttonGroups.TabIndex = 0;
            this.buttonGroups.TabStop = false;
            this.buttonGroups.Text = "Группы";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonStudents
            // 
            this.buttonStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudents.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudents.Location = new System.Drawing.Point(55, 165);
            this.buttonStudents.Margin = new System.Windows.Forms.Padding(7);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(205, 48);
            this.buttonStudents.TabIndex = 1;
            this.buttonStudents.TabStop = false;
            this.buttonStudents.Text = "Студенты";
            this.buttonStudents.UseVisualStyleBackColor = false;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonLesson
            // 
            this.buttonLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLesson.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLesson.Location = new System.Drawing.Point(55, 227);
            this.buttonLesson.Margin = new System.Windows.Forms.Padding(7);
            this.buttonLesson.Name = "buttonLesson";
            this.buttonLesson.Size = new System.Drawing.Size(205, 48);
            this.buttonLesson.TabIndex = 2;
            this.buttonLesson.TabStop = false;
            this.buttonLesson.Text = "Занятия";
            this.buttonLesson.UseVisualStyleBackColor = false;
            this.buttonLesson.Click += new System.EventHandler(this.buttonLesson_Click);
            // 
            // buttonPoints
            // 
            this.buttonPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(175)))));
            this.buttonPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPoints.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoints.Location = new System.Drawing.Point(55, 289);
            this.buttonPoints.Margin = new System.Windows.Forms.Padding(7);
            this.buttonPoints.Name = "buttonPoints";
            this.buttonPoints.Size = new System.Drawing.Size(205, 48);
            this.buttonPoints.TabIndex = 3;
            this.buttonPoints.TabStop = false;
            this.buttonPoints.Text = "Баллы";
            this.buttonPoints.UseVisualStyleBackColor = false;
            this.buttonPoints.Click += new System.EventHandler(this.buttonPoints_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Учебное_заведение.Properties.Resources.лого2;
            this.pictureBox2.Location = new System.Drawing.Point(90, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(313, 355);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPoints);
            this.Controls.Add(this.buttonLesson);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.buttonGroups);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonLesson;
        private System.Windows.Forms.Button buttonPoints;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}