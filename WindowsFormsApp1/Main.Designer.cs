
namespace WindowsFormsApp1
{
    partial class Main
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
            this.DGVSubjects = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btAddSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btDeleteSubject = new System.Windows.Forms.Button();
            this.btSiriaize = new System.Windows.Forms.Button();
            this.rbJSON = new System.Windows.Forms.RadioButton();
            this.rbXML = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbInFile = new System.Windows.Forms.RadioButton();
            this.rbFromFile = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVSubjects
            // 
            this.DGVSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubjects.Location = new System.Drawing.Point(12, 21);
            this.DGVSubjects.Name = "DGVSubjects";
            this.DGVSubjects.Size = new System.Drawing.Size(149, 217);
            this.DGVSubjects.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список предметів";
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(167, 60);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(117, 33);
            this.btAddSubject.TabIndex = 11;
            this.btAddSubject.Text = "Додати предмет";
            this.btAddSubject.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Натисніть двічі на назву";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "предмета щоб відобразити ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "студентів цього предмету";
            // 
            // btDeleteSubject
            // 
            this.btDeleteSubject.Location = new System.Drawing.Point(167, 99);
            this.btDeleteSubject.Name = "btDeleteSubject";
            this.btDeleteSubject.Size = new System.Drawing.Size(117, 33);
            this.btDeleteSubject.TabIndex = 15;
            this.btDeleteSubject.Text = "Видалити предмет";
            this.btDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // btSiriaize
            // 
            this.btSiriaize.Location = new System.Drawing.Point(167, 138);
            this.btSiriaize.Name = "btSiriaize";
            this.btSiriaize.Size = new System.Drawing.Size(117, 32);
            this.btSiriaize.TabIndex = 16;
            this.btSiriaize.Text = "Серіалізувати дані";
            this.btSiriaize.UseVisualStyleBackColor = true;
            // 
            // rbJSON
            // 
            this.rbJSON.AutoSize = true;
            this.rbJSON.Checked = true;
            this.rbJSON.Location = new System.Drawing.Point(9, 6);
            this.rbJSON.Name = "rbJSON";
            this.rbJSON.Size = new System.Drawing.Size(53, 17);
            this.rbJSON.TabIndex = 17;
            this.rbJSON.TabStop = true;
            this.rbJSON.Text = "JSON";
            this.rbJSON.UseVisualStyleBackColor = true;
            // 
            // rbXML
            // 
            this.rbXML.AutoSize = true;
            this.rbXML.Location = new System.Drawing.Point(72, 6);
            this.rbXML.Name = "rbXML";
            this.rbXML.Size = new System.Drawing.Size(47, 17);
            this.rbXML.TabIndex = 18;
            this.rbXML.Text = "XML";
            this.rbXML.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbXML);
            this.groupBox1.Controls.Add(this.rbJSON);
            this.groupBox1.Location = new System.Drawing.Point(167, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 32);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // rbInFile
            // 
            this.rbInFile.AutoSize = true;
            this.rbInFile.Checked = true;
            this.rbInFile.Location = new System.Drawing.Point(9, 10);
            this.rbInFile.Name = "rbInFile";
            this.rbInFile.Size = new System.Drawing.Size(59, 17);
            this.rbInFile.TabIndex = 20;
            this.rbInFile.TabStop = true;
            this.rbInFile.Text = "у файл";
            this.rbInFile.UseVisualStyleBackColor = true;
            // 
            // rbFromFile
            // 
            this.rbFromFile.AutoSize = true;
            this.rbFromFile.Location = new System.Drawing.Point(72, 10);
            this.rbFromFile.Name = "rbFromFile";
            this.rbFromFile.Size = new System.Drawing.Size(65, 17);
            this.rbFromFile.TabIndex = 21;
            this.rbFromFile.Text = "з файлу";
            this.rbFromFile.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFromFile);
            this.groupBox2.Controls.Add(this.rbInFile);
            this.groupBox2.Location = new System.Drawing.Point(167, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 33);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSiriaize);
            this.Controls.Add(this.btDeleteSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAddSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVSubjects);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Предмети";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAddSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeleteSubject;
        private System.Windows.Forms.Button btSiriaize;
        private System.Windows.Forms.RadioButton rbJSON;
        private System.Windows.Forms.RadioButton rbXML;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbInFile;
        private System.Windows.Forms.RadioButton rbFromFile;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

