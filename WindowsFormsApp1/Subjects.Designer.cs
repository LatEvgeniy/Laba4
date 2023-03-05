
namespace WindowsFormsApp1
{
    partial class Subjects
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
            this.DGVSelectedSubject = new System.Windows.Forms.DataGridView();
            this.labelInformation = new System.Windows.Forms.Label();
            this.btDeleteStudent = new System.Windows.Forms.Button();
            this.btStudentSort = new System.Windows.Forms.Button();
            this.btAddStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectedSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSelectedSubject
            // 
            this.DGVSelectedSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSelectedSubject.Location = new System.Drawing.Point(12, 38);
            this.DGVSelectedSubject.Name = "DGVSelectedSubject";
            this.DGVSelectedSubject.Size = new System.Drawing.Size(392, 230);
            this.DGVSelectedSubject.TabIndex = 0;
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(12, 22);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(176, 13);
            this.labelInformation.TabIndex = 8;
            this.labelInformation.Text = "Інформація про обраний предмет";
            // 
            // btDeleteStudent
            // 
            this.btDeleteStudent.Location = new System.Drawing.Point(143, 274);
            this.btDeleteStudent.Name = "btDeleteStudent";
            this.btDeleteStudent.Size = new System.Drawing.Size(122, 23);
            this.btDeleteStudent.TabIndex = 9;
            this.btDeleteStudent.Text = "Видалити студента";
            this.btDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // btStudentSort
            // 
            this.btStudentSort.Location = new System.Drawing.Point(271, 274);
            this.btStudentSort.Name = "btStudentSort";
            this.btStudentSort.Size = new System.Drawing.Size(133, 23);
            this.btStudentSort.TabIndex = 10;
            this.btStudentSort.Text = "Сортування студентів";
            this.btStudentSort.UseVisualStyleBackColor = true;
            // 
            // btAddStudent
            // 
            this.btAddStudent.Location = new System.Drawing.Point(15, 274);
            this.btAddStudent.Name = "btAddStudent";
            this.btAddStudent.Size = new System.Drawing.Size(122, 23);
            this.btAddStudent.TabIndex = 11;
            this.btAddStudent.Text = "Додати студента";
            this.btAddStudent.UseVisualStyleBackColor = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 298);
            this.Controls.Add(this.btAddStudent);
            this.Controls.Add(this.btStudentSort);
            this.Controls.Add(this.btDeleteStudent);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.DGVSelectedSubject);
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інформація про предмет";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelectedSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSelectedSubject;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.Button btDeleteStudent;
        private System.Windows.Forms.Button btStudentSort;
        private System.Windows.Forms.Button btAddStudent;
    }
}