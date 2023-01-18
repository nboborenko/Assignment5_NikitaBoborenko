namespace Assignment5_NikitaBoborenko
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
            this.guesses_label = new System.Windows.Forms.Label();
            this.guess_button = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guesses_label
            // 
            this.guesses_label.AutoSize = true;
            this.guesses_label.Location = new System.Drawing.Point(211, 156);
            this.guesses_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.guesses_label.Name = "guesses_label";
            this.guesses_label.Size = new System.Drawing.Size(98, 13);
            this.guesses_label.TabIndex = 2;
            this.guesses_label.Text = "Number of guesses";
            this.guesses_label.Click += new System.EventHandler(this.guesses_label_Click);
            // 
            // guess_button
            // 
            this.guess_button.Location = new System.Drawing.Point(294, 171);
            this.guess_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guess_button.Name = "guess_button";
            this.guess_button.Size = new System.Drawing.Size(56, 19);
            this.guess_button.TabIndex = 4;
            this.guess_button.Text = "Guess";
            this.guess_button.UseVisualStyleBackColor = true;
            this.guess_button.Click += new System.EventHandler(this.guess_button_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(214, 171);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(76, 20);
            this.inputTextBox.TabIndex = 5;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.guess_button);
            this.Controls.Add(this.guesses_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label guesses_label;
        private System.Windows.Forms.Button guess_button;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

