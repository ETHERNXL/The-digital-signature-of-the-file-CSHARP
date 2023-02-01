namespace protect_inf_LR1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.signButton = new System.Windows.Forms.Button();
            this.checkSignButton = new System.Windows.Forms.Button();
            this.sourceFilePathTextBox = new System.Windows.Forms.TextBox();
            this.signFilePathTextBox = new System.Windows.Forms.TextBox();
            this.sourceFileButton = new System.Windows.Forms.Button();
            this.signFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signButton
            // 
            this.signButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.signButton.Location = new System.Drawing.Point(12, 160);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(207, 48);
            this.signButton.TabIndex = 1;
            this.signButton.Text = "Підписати";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // checkSignButton
            // 
            this.checkSignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkSignButton.Location = new System.Drawing.Point(223, 160);
            this.checkSignButton.Name = "checkSignButton";
            this.checkSignButton.Size = new System.Drawing.Size(207, 48);
            this.checkSignButton.TabIndex = 2;
            this.checkSignButton.Text = "Перевірка підпису";
            this.checkSignButton.UseVisualStyleBackColor = true;
            this.checkSignButton.Click += new System.EventHandler(this.buttonDecipher_Click);
            // 
            // sourceFilePathTextBox
            // 
            this.sourceFilePathTextBox.Enabled = false;
            this.sourceFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sourceFilePathTextBox.Location = new System.Drawing.Point(12, 22);
            this.sourceFilePathTextBox.Name = "sourceFilePathTextBox";
            this.sourceFilePathTextBox.Size = new System.Drawing.Size(418, 24);
            this.sourceFilePathTextBox.TabIndex = 13;
            // 
            // signFilePathTextBox
            // 
            this.signFilePathTextBox.Enabled = false;
            this.signFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFilePathTextBox.Location = new System.Drawing.Point(12, 80);
            this.signFilePathTextBox.Name = "signFilePathTextBox";
            this.signFilePathTextBox.Size = new System.Drawing.Size(418, 24);
            this.signFilePathTextBox.TabIndex = 14;
            // 
            // sourceFileButton
            // 
            this.sourceFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sourceFileButton.Location = new System.Drawing.Point(467, 22);
            this.sourceFileButton.Name = "sourceFileButton";
            this.sourceFileButton.Size = new System.Drawing.Size(150, 29);
            this.sourceFileButton.TabIndex = 15;
            this.sourceFileButton.Text = "Початковий файл";
            this.sourceFileButton.UseVisualStyleBackColor = true;
            this.sourceFileButton.Click += new System.EventHandler(this.sourceFileButton_Click);
            // 
            // signFileButton
            // 
            this.signFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.signFileButton.Location = new System.Drawing.Point(467, 77);
            this.signFileButton.Name = "signFileButton";
            this.signFileButton.Size = new System.Drawing.Size(150, 30);
            this.signFileButton.TabIndex = 16;
            this.signFileButton.Text = "Файл підпису";
            this.signFileButton.UseVisualStyleBackColor = true;
            this.signFileButton.Click += new System.EventHandler(this.signFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 437);
            this.Controls.Add(this.signFileButton);
            this.Controls.Add(this.sourceFileButton);
            this.Controls.Add(this.signFilePathTextBox);
            this.Controls.Add(this.sourceFilePathTextBox);
            this.Controls.Add(this.checkSignButton);
            this.Controls.Add(this.signButton);
            this.Name = "Form1";
            this.Text = "BEZPALYI ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button checkSignButton;
        private System.Windows.Forms.TextBox sourceFilePathTextBox;
        private System.Windows.Forms.TextBox signFilePathTextBox;
        private System.Windows.Forms.Button sourceFileButton;
        private System.Windows.Forms.Button signFileButton;
    }
}

