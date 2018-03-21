namespace Lab1_1
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
            this.inputString1 = new System.Windows.Forms.TextBox();
            this.inputString2 = new System.Windows.Forms.TextBox();
            this.unionButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.indexButton = new System.Windows.Forms.Button();
            this.lengthButton = new System.Windows.Forms.Button();
            this.doubleButton = new System.Windows.Forms.Button();
            this.inputString3 = new System.Windows.Forms.TextBox();
            this.resultString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputString4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.warningText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputString1
            // 
            this.inputString1.Location = new System.Drawing.Point(12, 41);
            this.inputString1.Name = "inputString1";
            this.inputString1.Size = new System.Drawing.Size(180, 20);
            this.inputString1.TabIndex = 0;
            // 
            // inputString2
            // 
            this.inputString2.Location = new System.Drawing.Point(209, 41);
            this.inputString2.Name = "inputString2";
            this.inputString2.Size = new System.Drawing.Size(188, 20);
            this.inputString2.TabIndex = 1;
            // 
            // unionButton
            // 
            this.unionButton.Location = new System.Drawing.Point(21, 95);
            this.unionButton.Name = "unionButton";
            this.unionButton.Size = new System.Drawing.Size(90, 53);
            this.unionButton.TabIndex = 3;
            this.unionButton.Text = "Union";
            this.unionButton.UseVisualStyleBackColor = true;
            this.unionButton.Click += new System.EventHandler(this.unionButton_Click);
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(475, 95);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(90, 53);
            this.replaceButton.TabIndex = 4;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(142, 95);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(90, 53);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // indexButton
            // 
            this.indexButton.Location = new System.Drawing.Point(267, 95);
            this.indexButton.Name = "indexButton";
            this.indexButton.Size = new System.Drawing.Size(90, 53);
            this.indexButton.TabIndex = 6;
            this.indexButton.Text = "Symbol By Index";
            this.indexButton.UseVisualStyleBackColor = true;
            this.indexButton.Click += new System.EventHandler(this.indexButton_Click);
            // 
            // lengthButton
            // 
            this.lengthButton.Location = new System.Drawing.Point(21, 262);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(90, 53);
            this.lengthButton.TabIndex = 7;
            this.lengthButton.Text = "Length";
            this.lengthButton.UseVisualStyleBackColor = true;
            this.lengthButton.Click += new System.EventHandler(this.lengthButton_Click);
            // 
            // doubleButton
            // 
            this.doubleButton.Location = new System.Drawing.Point(159, 262);
            this.doubleButton.Name = "doubleButton";
            this.doubleButton.Size = new System.Drawing.Size(90, 53);
            this.doubleButton.TabIndex = 8;
            this.doubleButton.Text = "Double Vowel";
            this.doubleButton.UseVisualStyleBackColor = true;
            this.doubleButton.Click += new System.EventHandler(this.doubleButton_Click);
            // 
            // inputString3
            // 
            this.inputString3.Location = new System.Drawing.Point(21, 204);
            this.inputString3.Name = "inputString3";
            this.inputString3.Size = new System.Drawing.Size(180, 20);
            this.inputString3.TabIndex = 9;
            // 
            // resultString
            // 
            this.resultString.Location = new System.Drawing.Point(427, 295);
            this.resultString.Name = "resultString";
            this.resultString.Size = new System.Drawing.Size(222, 20);
            this.resultString.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Result";
            // 
            // inputString4
            // 
            this.inputString4.Location = new System.Drawing.Point(444, 41);
            this.inputString4.Name = "inputString4";
            this.inputString4.Size = new System.Drawing.Size(149, 20);
            this.inputString4.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "for substitution by substring:";
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Location = new System.Drawing.Point(278, 295);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(0, 13);
            this.warningText.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 327);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputString4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultString);
            this.Controls.Add(this.inputString3);
            this.Controls.Add(this.doubleButton);
            this.Controls.Add(this.lengthButton);
            this.Controls.Add(this.indexButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.unionButton);
            this.Controls.Add(this.inputString2);
            this.Controls.Add(this.inputString1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputString1;
        private System.Windows.Forms.TextBox inputString2;
        private System.Windows.Forms.Button unionButton;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button indexButton;
        private System.Windows.Forms.Button lengthButton;
        private System.Windows.Forms.Button doubleButton;
        private System.Windows.Forms.TextBox inputString3;
        private System.Windows.Forms.TextBox resultString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputString4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label warningText;
    }
}

