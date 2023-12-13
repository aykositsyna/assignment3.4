namespace ViewLayer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentsListView = new System.Windows.Forms.ListView();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SpecialityTB = new System.Windows.Forms.TextBox();
            this.GroupTB = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SpecialityLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.DeleteStudentBttn = new System.Windows.Forms.Button();
            this.AddStudentBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentsListView
            // 
            this.StudentsListView.HideSelection = false;
            this.StudentsListView.Location = new System.Drawing.Point(21, 12);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.Size = new System.Drawing.Size(457, 365);
            this.StudentsListView.TabIndex = 0;
            this.StudentsListView.UseCompatibleStateImageBehavior = false;
            this.StudentsListView.View = System.Windows.Forms.View.Details;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(496, 54);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(255, 22);
            this.NameTB.TabIndex = 1;
            // 
            // SpecialityTB
            // 
            this.SpecialityTB.Location = new System.Drawing.Point(496, 142);
            this.SpecialityTB.Name = "SpecialityTB";
            this.SpecialityTB.Size = new System.Drawing.Size(255, 22);
            this.SpecialityTB.TabIndex = 2;
            // 
            // GroupTB
            // 
            this.GroupTB.Location = new System.Drawing.Point(496, 230);
            this.GroupTB.Name = "GroupTB";
            this.GroupTB.Size = new System.Drawing.Size(255, 22);
            this.GroupTB.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(493, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(134, 16);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Enter student\'s name:";
            // 
            // SpecialityLabel
            // 
            this.SpecialityLabel.AutoSize = true;
            this.SpecialityLabel.Location = new System.Drawing.Point(493, 123);
            this.SpecialityLabel.Name = "SpecialityLabel";
            this.SpecialityLabel.Size = new System.Drawing.Size(157, 16);
            this.SpecialityLabel.TabIndex = 5;
            this.SpecialityLabel.Text = "Enter student\'s speciality:";
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Location = new System.Drawing.Point(493, 211);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(135, 16);
            this.GroupLabel.TabIndex = 6;
            this.GroupLabel.Text = "Enter student\'s group:";
            // 
            // DeleteStudentBttn
            // 
            this.DeleteStudentBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteStudentBttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteStudentBttn.Location = new System.Drawing.Point(21, 386);
            this.DeleteStudentBttn.Name = "DeleteStudentBttn";
            this.DeleteStudentBttn.Size = new System.Drawing.Size(457, 52);
            this.DeleteStudentBttn.TabIndex = 7;
            this.DeleteStudentBttn.Text = "Delete";
            this.DeleteStudentBttn.UseVisualStyleBackColor = true;
            this.DeleteStudentBttn.Click += new System.EventHandler(this.DeleteStudentBttn_Click);
            // 
            // AddStudentBttn
            // 
            this.AddStudentBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentBttn.ForeColor = System.Drawing.Color.Green;
            this.AddStudentBttn.Location = new System.Drawing.Point(496, 292);
            this.AddStudentBttn.Name = "AddStudentBttn";
            this.AddStudentBttn.Size = new System.Drawing.Size(255, 73);
            this.AddStudentBttn.TabIndex = 8;
            this.AddStudentBttn.Text = "Add";
            this.AddStudentBttn.UseVisualStyleBackColor = true;
            this.AddStudentBttn.Click += new System.EventHandler(this.AddStudentBttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStudentBttn);
            this.Controls.Add(this.DeleteStudentBttn);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.SpecialityLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.GroupTB);
            this.Controls.Add(this.SpecialityTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.StudentsListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView StudentsListView;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SpecialityTB;
        private System.Windows.Forms.TextBox GroupTB;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpecialityLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Button DeleteStudentBttn;
        private System.Windows.Forms.Button AddStudentBttn;
    }
}

