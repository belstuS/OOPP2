namespace Lab1_2
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
            this.studentsCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.createCollection = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.studentsCollection = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sortedCollection = new System.Windows.Forms.ListView();
            this.sortedName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sortedAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeCollection = new System.Windows.Forms.MaskedTextBox();
            this.warningText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentsCount
            // 
            this.studentsCount.AutoSize = true;
            this.studentsCount.Location = new System.Drawing.Point(234, 9);
            this.studentsCount.Name = "studentsCount";
            this.studentsCount.Size = new System.Drawing.Size(90, 13);
            this.studentsCount.TabIndex = 0;
            this.studentsCount.Text = "Count of students";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "ASC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AscButton);
            // 
            // createCollection
            // 
            this.createCollection.Location = new System.Drawing.Point(255, 78);
            this.createCollection.Name = "createCollection";
            this.createCollection.Size = new System.Drawing.Size(198, 50);
            this.createCollection.TabIndex = 3;
            this.createCollection.Text = "Create Collection";
            this.createCollection.UseVisualStyleBackColor = true;
            this.createCollection.Click += new System.EventHandler(this.createButton);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(542, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 42);
            this.button3.TabIndex = 4;
            this.button3.Text = "DESC";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DescClick);
            // 
            // minButton
            // 
            this.minButton.Location = new System.Drawing.Point(84, 146);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(111, 54);
            this.minButton.TabIndex = 5;
            this.minButton.Text = "Min age";
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(307, 160);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(111, 54);
            this.maxButton.TabIndex = 6;
            this.maxButton.Text = "Max age";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(516, 146);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(111, 54);
            this.countButton.TabIndex = 7;
            this.countButton.Text = "Count Students";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // studentsCollection
            // 
            this.studentsCollection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.Age});
            this.studentsCollection.Location = new System.Drawing.Point(30, 239);
            this.studentsCollection.Name = "studentsCollection";
            this.studentsCollection.Size = new System.Drawing.Size(273, 186);
            this.studentsCollection.TabIndex = 8;
            this.studentsCollection.UseCompatibleStateImageBehavior = false;
            this.studentsCollection.View = System.Windows.Forms.View.Details;
            // 
            // fullName
            // 
            this.fullName.Text = "Name";
            this.fullName.Width = 201;
            // 
            // Age
            // 
            this.Age.Text = "Age";
            this.Age.Width = 57;
            // 
            // sortedCollection
            // 
            this.sortedCollection.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sortedName,
            this.sortedAge});
            this.sortedCollection.Location = new System.Drawing.Point(405, 239);
            this.sortedCollection.Name = "sortedCollection";
            this.sortedCollection.Size = new System.Drawing.Size(273, 186);
            this.sortedCollection.TabIndex = 9;
            this.sortedCollection.UseCompatibleStateImageBehavior = false;
            this.sortedCollection.View = System.Windows.Forms.View.Details;
            // 
            // sortedName
            // 
            this.sortedName.Text = "Name";
            this.sortedName.Width = 202;
            // 
            // sortedAge
            // 
            this.sortedAge.Text = "Age";
            // 
            // resultString
            // 
            this.resultString.Location = new System.Drawing.Point(414, 475);
            this.resultString.Name = "resultString";
            this.resultString.Size = new System.Drawing.Size(163, 20);
            this.resultString.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Age:";
            // 
            // sizeCollection
            // 
            this.sizeCollection.Location = new System.Drawing.Point(330, 2);
            this.sizeCollection.Mask = "000";
            this.sizeCollection.Name = "sizeCollection";
            this.sizeCollection.Size = new System.Drawing.Size(26, 20);
            this.sizeCollection.TabIndex = 12;
            // 
            // warningText
            // 
            this.warningText.AutoSize = true;
            this.warningText.Location = new System.Drawing.Point(371, 5);
            this.warningText.Name = "warningText";
            this.warningText.Size = new System.Drawing.Size(0, 13);
            this.warningText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 507);
            this.Controls.Add(this.warningText);
            this.Controls.Add(this.sizeCollection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultString);
            this.Controls.Add(this.sortedCollection);
            this.Controls.Add(this.studentsCollection);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.minButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createCollection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentsCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentsCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button createCollection;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button minButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.ListView studentsCollection;
        private System.Windows.Forms.ListView sortedCollection;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.TextBox resultString;
        private System.Windows.Forms.ColumnHeader sortedName;
        private System.Windows.Forms.ColumnHeader sortedAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox sizeCollection;
        private System.Windows.Forms.Label warningText;
    }
}

