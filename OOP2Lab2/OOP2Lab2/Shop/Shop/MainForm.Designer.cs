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
            this.addProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showProductsButton
            // 
            this.showProductsButton.Location = new System.Drawing.Point(441, 13);
            this.showProductsButton.Name = "showProductsButton";
            this.showProductsButton.Size = new System.Drawing.Size(279, 34);
            this.showProductsButton.TabIndex = 34;
            this.showProductsButton.Text = "All information";
            this.showProductsButton.UseVisualStyleBackColor = true;
            this.showProductsButton.Click += new System.EventHandler(this.showProductsButton_Click);
            // 
            // productInformText
            // 
            this.productInformText.Location = new System.Drawing.Point(12, 78);
            this.productInformText.Name = "productInformText";
            this.productInformText.Size = new System.Drawing.Size(729, 236);
            this.productInformText.TabIndex = 33;
            this.productInformText.Text = "";
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(25, 12);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(279, 35);
            this.addProductButton.TabIndex = 32;
            this.addProductButton.Text = "Add";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 335);
            this.Controls.Add(this.showProductsButton);
            this.Controls.Add(this.productInformText);
            this.Controls.Add(this.addProductButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button showProductsButton;
        private System.Windows.Forms.RichTextBox productInformText;
        private System.Windows.Forms.Button addProductButton;
    }
}