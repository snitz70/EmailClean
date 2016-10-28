namespace EmailClean.Gui
{
    partial class Form1
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
            this.DomainComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DaysNumberBox = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DomainComboBox
            // 
            this.DomainComboBox.FormattingEnabled = true;
            this.DomainComboBox.Location = new System.Drawing.Point(78, 12);
            this.DomainComboBox.Name = "DomainComboBox";
            this.DomainComboBox.Size = new System.Drawing.Size(158, 21);
            this.DomainComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Domain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Folder";
            // 
            // FolderTextBox
            // 
            this.FolderTextBox.Location = new System.Drawing.Point(78, 55);
            this.FolderTextBox.Name = "FolderTextBox";
            this.FolderTextBox.Size = new System.Drawing.Size(158, 20);
            this.FolderTextBox.TabIndex = 3;
            this.FolderTextBox.Text = "Junk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days to keep";
            // 
            // DaysNumberBox
            // 
            this.DaysNumberBox.Location = new System.Drawing.Point(119, 99);
            this.DaysNumberBox.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.DaysNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DaysNumberBox.Name = "DaysNumberBox";
            this.DaysNumberBox.Size = new System.Drawing.Size(80, 20);
            this.DaysNumberBox.TabIndex = 5;
            this.DaysNumberBox.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(78, 156);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 209);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DaysNumberBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FolderTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DomainComboBox);
            this.Name = "Form1";
            this.Text = "Email Clean";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DomainComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FolderTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown DaysNumberBox;
        private System.Windows.Forms.Button StartButton;
    }
}

