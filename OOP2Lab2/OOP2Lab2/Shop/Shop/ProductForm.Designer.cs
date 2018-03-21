namespace Shop
{
    partial class ProductForm
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
            this.components = new System.ComponentModel.Container();
            this.productNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productDate = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.producerOrganizationText = new System.Windows.Forms.TextBox();
            this.producerCountryText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productTypeText = new System.Windows.Forms.ComboBox();
            this.productNumberText = new System.Windows.Forms.MaskedTextBox();
            this.productmassTrack = new System.Windows.Forms.TrackBar();
            this.producerAdressText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.producerTelephoneText = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stockmanAdressText = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.moreTenbutton = new System.Windows.Forms.RadioButton();
            this.fiveTenbutton = new System.Windows.Forms.RadioButton();
            this.lessFivebutton = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.stockmanLName = new System.Windows.Forms.TextBox();
            this.stockmanSName = new System.Windows.Forms.TextBox();
            this.stockmanFNameText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.massValue = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productmassTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // productNameText
            // 
            this.productNameText.Location = new System.Drawing.Point(82, 33);
            this.productNameText.Name = "productNameText";
            this.productNameText.Size = new System.Drawing.Size(185, 20);
            this.productNameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type";
            // 
            // productDate
            // 
            this.productDate.Location = new System.Drawing.Point(94, 241);
            this.productDate.Name = "productDate";
            this.productDate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // producerOrganizationText
            // 
            this.producerOrganizationText.Location = new System.Drawing.Point(86, 20);
            this.producerOrganizationText.Name = "producerOrganizationText";
            this.producerOrganizationText.Size = new System.Drawing.Size(185, 20);
            this.producerOrganizationText.TabIndex = 10;
            // 
            // producerCountryText
            // 
            this.producerCountryText.Location = new System.Drawing.Point(86, 46);
            this.producerCountryText.Name = "producerCountryText";
            this.producerCountryText.Size = new System.Drawing.Size(185, 20);
            this.producerCountryText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Organization";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Adress";
            // 
            // productTypeText
            // 
            this.productTypeText.FormattingEnabled = true;
            this.productTypeText.Location = new System.Drawing.Point(82, 187);
            this.productTypeText.Name = "productTypeText";
            this.productTypeText.Size = new System.Drawing.Size(185, 21);
            this.productTypeText.TabIndex = 18;
            // 
            // productNumberText
            // 
            this.productNumberText.Location = new System.Drawing.Point(82, 69);
            this.productNumberText.Mask = "000-000-000";
            this.productNumberText.Name = "productNumberText";
            this.productNumberText.Size = new System.Drawing.Size(82, 20);
            this.productNumberText.TabIndex = 19;
            // 
            // productmassTrack
            // 
            this.productmassTrack.Location = new System.Drawing.Point(82, 122);
            this.productmassTrack.Maximum = 100;
            this.productmassTrack.Minimum = 1;
            this.productmassTrack.Name = "productmassTrack";
            this.productmassTrack.Size = new System.Drawing.Size(191, 45);
            this.productmassTrack.TabIndex = 21;
            this.productmassTrack.Value = 1;
            this.productmassTrack.Scroll += new System.EventHandler(this.massTrackBar_Scroll);
            // 
            // producerAdressText
            // 
            this.producerAdressText.Location = new System.Drawing.Point(86, 101);
            this.producerAdressText.Name = "producerAdressText";
            this.producerAdressText.Size = new System.Drawing.Size(185, 50);
            this.producerAdressText.TabIndex = 24;
            this.producerAdressText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.producerTelephoneText);
            this.groupBox1.Controls.Add(this.producerAdressText);
            this.groupBox1.Controls.Add(this.producerOrganizationText);
            this.groupBox1.Controls.Add(this.producerCountryText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(395, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 176);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2)Producer";
            // 
            // producerTelephoneText
            // 
            this.producerTelephoneText.Location = new System.Drawing.Point(86, 72);
            this.producerTelephoneText.Mask = "(999)000-0000";
            this.producerTelephoneText.Name = "producerTelephoneText";
            this.producerTelephoneText.Size = new System.Drawing.Size(80, 20);
            this.producerTelephoneText.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stockmanAdressText);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.moreTenbutton);
            this.groupBox2.Controls.Add(this.fiveTenbutton);
            this.groupBox2.Controls.Add(this.lessFivebutton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.stockmanLName);
            this.groupBox2.Controls.Add(this.stockmanSName);
            this.groupBox2.Controls.Add(this.stockmanFNameText);
            this.groupBox2.Location = new System.Drawing.Point(340, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 192);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3)Stockman";
            // 
            // stockmanAdressText
            // 
            this.stockmanAdressText.Location = new System.Drawing.Point(55, 129);
            this.stockmanAdressText.Name = "stockmanAdressText";
            this.stockmanAdressText.Size = new System.Drawing.Size(182, 50);
            this.stockmanAdressText.TabIndex = 26;
            this.stockmanAdressText.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Adress";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Work experience";
            // 
            // moreTenbutton
            // 
            this.moreTenbutton.AutoSize = true;
            this.moreTenbutton.Location = new System.Drawing.Point(223, 92);
            this.moreTenbutton.Name = "moreTenbutton";
            this.moreTenbutton.Size = new System.Drawing.Size(43, 17);
            this.moreTenbutton.TabIndex = 30;
            this.moreTenbutton.TabStop = true;
            this.moreTenbutton.Text = ">10";
            this.moreTenbutton.UseVisualStyleBackColor = true;
            // 
            // fiveTenbutton
            // 
            this.fiveTenbutton.AutoSize = true;
            this.fiveTenbutton.Location = new System.Drawing.Point(127, 92);
            this.fiveTenbutton.Name = "fiveTenbutton";
            this.fiveTenbutton.Size = new System.Drawing.Size(46, 17);
            this.fiveTenbutton.TabIndex = 29;
            this.fiveTenbutton.TabStop = true;
            this.fiveTenbutton.Text = "5-10";
            this.fiveTenbutton.UseVisualStyleBackColor = true;
            // 
            // lessFivebutton
            // 
            this.lessFivebutton.AutoSize = true;
            this.lessFivebutton.Location = new System.Drawing.Point(31, 92);
            this.lessFivebutton.Name = "lessFivebutton";
            this.lessFivebutton.Size = new System.Drawing.Size(37, 17);
            this.lessFivebutton.TabIndex = 28;
            this.lessFivebutton.TabStop = true;
            this.lessFivebutton.Text = "<5";
            this.lessFivebutton.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(283, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Last name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Second name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "First name";
            // 
            // stockmanLName
            // 
            this.stockmanLName.Location = new System.Drawing.Point(286, 41);
            this.stockmanLName.Name = "stockmanLName";
            this.stockmanLName.Size = new System.Drawing.Size(143, 20);
            this.stockmanLName.TabIndex = 24;
            // 
            // stockmanSName
            // 
            this.stockmanSName.Location = new System.Drawing.Point(140, 41);
            this.stockmanSName.Name = "stockmanSName";
            this.stockmanSName.Size = new System.Drawing.Size(140, 20);
            this.stockmanSName.TabIndex = 23;
            // 
            // stockmanFNameText
            // 
            this.stockmanFNameText.Location = new System.Drawing.Point(6, 41);
            this.stockmanFNameText.Name = "stockmanFNameText";
            this.stockmanFNameText.Size = new System.Drawing.Size(128, 20);
            this.stockmanFNameText.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.massValue);
            this.groupBox3.Controls.Add(this.productDate);
            this.groupBox3.Controls.Add(this.productNameText);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.productmassTrack);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.productNumberText);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.productTypeText);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 433);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1)Product";
            // 
            // massValue
            // 
            this.massValue.AutoSize = true;
            this.massValue.Location = new System.Drawing.Point(226, 106);
            this.massValue.Name = "massValue";
            this.massValue.Size = new System.Drawing.Size(13, 13);
            this.massValue.TabIndex = 22;
            this.massValue.Text = "1";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(643, 395);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(132, 54);
            this.addProductButton.TabIndex = 29;
            this.addProductButton.Text = "Remember Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 461);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.global_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.productmassTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox productNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar productDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox producerOrganizationText;
        private System.Windows.Forms.TextBox producerCountryText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox productTypeText;
        private System.Windows.Forms.MaskedTextBox productNumberText;
        private System.Windows.Forms.TrackBar productmassTrack;
        private System.Windows.Forms.RichTextBox producerAdressText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox stockmanAdressText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton moreTenbutton;
        private System.Windows.Forms.RadioButton fiveTenbutton;
        private System.Windows.Forms.RadioButton lessFivebutton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox stockmanLName;
        private System.Windows.Forms.TextBox stockmanSName;
        private System.Windows.Forms.TextBox stockmanFNameText;
        private System.Windows.Forms.MaskedTextBox producerTelephoneText;
        private System.Windows.Forms.Label massValue;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

