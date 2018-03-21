namespace Shop
{
    partial class MainForm
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
            this.showProductsButton = new System.Windows.Forms.Button();
            this.productInformText = new System.Windows.Forms.RichTextBox();
            this.searchNameText = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.priceCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateSortItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minPriceBar = new System.Windows.Forms.TrackBar();
            this.priceValueLabel = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            this.closeMenuButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceBar)).BeginInit();
            this.SuspendLayout();
            // 
            // showProductsButton
            // 
            this.showProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showProductsButton.Location = new System.Drawing.Point(34, 270);
            this.showProductsButton.Name = "showProductsButton";
            this.showProductsButton.Size = new System.Drawing.Size(114, 43);
            this.showProductsButton.TabIndex = 34;
            this.showProductsButton.Text = "Show all information";
            this.showProductsButton.UseVisualStyleBackColor = true;
            this.showProductsButton.Click += new System.EventHandler(this.showProductsButton_Click);
            // 
            // productInformText
            // 
            this.productInformText.Location = new System.Drawing.Point(340, 42);
            this.productInformText.Name = "productInformText";
            this.productInformText.Size = new System.Drawing.Size(334, 366);
            this.productInformText.TabIndex = 33;
            this.productInformText.Text = "";
            // 
            // searchNameText
            // 
            this.searchNameText.Location = new System.Drawing.Point(80, 42);
            this.searchNameText.Name = "searchNameText";
            this.searchNameText.Size = new System.Drawing.Size(197, 20);
            this.searchNameText.TabIndex = 36;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Location = new System.Drawing.Point(80, 83);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(197, 24);
            this.searchComboBox.TabIndex = 37;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox.Location = new System.Drawing.Point(10, 42);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(64, 20);
            this.nameCheckBox.TabIndex = 40;
            this.nameCheckBox.Text = "Name";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCheckBox.Location = new System.Drawing.Point(10, 83);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(59, 20);
            this.typeCheckBox.TabIndex = 41;
            this.typeCheckBox.Text = "Type";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // priceCheckBox
            // 
            this.priceCheckBox.AutoSize = true;
            this.priceCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCheckBox.Location = new System.Drawing.Point(10, 156);
            this.priceCheckBox.Name = "priceCheckBox";
            this.priceCheckBox.Size = new System.Drawing.Size(58, 20);
            this.priceCheckBox.TabIndex = 42;
            this.priceCheckBox.Text = "Price";
            this.priceCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(174, 270);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 43);
            this.searchButton.TabIndex = 43;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem1,
            this.sortToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.saveResultsToolStripMenuItem,
            this.cleanWindowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addStripMenuItem1
            // 
            this.addStripMenuItem1.Name = "addStripMenuItem1";
            this.addStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.addStripMenuItem1.Text = "Add";
            this.addStripMenuItem1.Click += new System.EventHandler(this.addStripMenuItem1_Click);
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripMenuItem,
            this.dateSortItemMenu,
            this.priceToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // nameToolStripMenuItem
            // 
            this.nameToolStripMenuItem.Name = "nameToolStripMenuItem";
            this.nameToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.nameToolStripMenuItem.Text = "Name";
            this.nameToolStripMenuItem.Click += new System.EventHandler(this.nameToolStripMenuItem_Click);
            // 
            // dateSortItemMenu
            // 
            this.dateSortItemMenu.Name = "dateSortItemMenu";
            this.dateSortItemMenu.Size = new System.Drawing.Size(106, 22);
            this.dateSortItemMenu.Text = "Date";
            this.dateSortItemMenu.Click += new System.EventHandler(this.dateSortItemMenu_Click_1);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click_1);
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // saveResultsToolStripMenuItem
            // 
            this.saveResultsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.sortToolStripMenuItem1});
            this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
            this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveResultsToolStripMenuItem.Text = "Save";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // sortToolStripMenuItem1
            // 
            this.sortToolStripMenuItem1.Name = "sortToolStripMenuItem1";
            this.sortToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.sortToolStripMenuItem1.Text = "Sort";
            this.sortToolStripMenuItem1.Click += new System.EventHandler(this.sortToolStripMenuItem1_Click);
            // 
            // cleanWindowToolStripMenuItem
            // 
            this.cleanWindowToolStripMenuItem.Name = "cleanWindowToolStripMenuItem";
            this.cleanWindowToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cleanWindowToolStripMenuItem.Text = "Clean Window";
            this.cleanWindowToolStripMenuItem.Click += new System.EventHandler(this.cleanWindowToolStripMenuItem_Click);
            // 
            // minPriceBar
            // 
            this.minPriceBar.Location = new System.Drawing.Point(76, 156);
            this.minPriceBar.Maximum = 100;
            this.minPriceBar.Minimum = 1;
            this.minPriceBar.Name = "minPriceBar";
            this.minPriceBar.Size = new System.Drawing.Size(201, 45);
            this.minPriceBar.TabIndex = 45;
            this.minPriceBar.Value = 1;
            this.minPriceBar.Scroll += new System.EventHandler(this.minPriceBar_Scroll);
            // 
            // priceValueLabel
            // 
            this.priceValueLabel.AutoSize = true;
            this.priceValueLabel.Location = new System.Drawing.Point(264, 131);
            this.priceValueLabel.Name = "priceValueLabel";
            this.priceValueLabel.Size = new System.Drawing.Size(13, 13);
            this.priceValueLabel.TabIndex = 46;
            this.priceValueLabel.Text = "1";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informationLabel.Location = new System.Drawing.Point(12, 383);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(0, 16);
            this.informationLabel.TabIndex = 47;
            // 
            // closeMenuButton
            // 
            this.closeMenuButton.Location = new System.Drawing.Point(649, 0);
            this.closeMenuButton.Name = "closeMenuButton";
            this.closeMenuButton.Size = new System.Drawing.Size(37, 24);
            this.closeMenuButton.TabIndex = 48;
            this.closeMenuButton.Text = "X";
            this.closeMenuButton.UseVisualStyleBackColor = true;
            this.closeMenuButton.Click += new System.EventHandler(this.closeMenuButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 432);
            this.Controls.Add(this.closeMenuButton);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.priceValueLabel);
            this.Controls.Add(this.minPriceBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.priceCheckBox);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchNameText);
            this.Controls.Add(this.showProductsButton);
            this.Controls.Add(this.productInformText);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minPriceBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showProductsButton;
        private System.Windows.Forms.RichTextBox productInformText;
        private System.Windows.Forms.TextBox searchNameText;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox priceCheckBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateSortItemMenu;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem1;
        private System.Windows.Forms.TrackBar minPriceBar;
        private System.Windows.Forms.Label priceValueLabel;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem1;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.ToolStripMenuItem cleanWindowToolStripMenuItem;
        private System.Windows.Forms.Button closeMenuButton;
    }
}