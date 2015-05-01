namespace YearlyCostofaStudentApp
{
    partial class YearlyCostofaStudent
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectClassComboBox = new System.Windows.Forms.ComboBox();
            this.totalAmountButton = new System.Windows.Forms.Button();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectClassComboBox);
            this.groupBox1.Controls.Add(this.totalAmountButton);
            this.groupBox1.Controls.Add(this.discountCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculator for yearly cost of a student";
            // 
            // selectClassComboBox
            // 
            this.selectClassComboBox.FormattingEnabled = true;
            this.selectClassComboBox.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Class 4",
            "Class 5",
            "Class 6",
            "Class 7",
            "Class 8",
            "Class 9",
            "Class 10",
            "Class 11",
            "Class 12"});
            this.selectClassComboBox.Location = new System.Drawing.Point(118, 42);
            this.selectClassComboBox.Name = "selectClassComboBox";
            this.selectClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.selectClassComboBox.TabIndex = 0;
            // 
            // totalAmountButton
            // 
            this.totalAmountButton.Location = new System.Drawing.Point(30, 144);
            this.totalAmountButton.Name = "totalAmountButton";
            this.totalAmountButton.Size = new System.Drawing.Size(280, 45);
            this.totalAmountButton.TabIndex = 2;
            this.totalAmountButton.Text = "Calculate total amount for one year";
            this.totalAmountButton.UseVisualStyleBackColor = true;
            this.totalAmountButton.Click += new System.EventHandler(this.totalAmountButton_Click);
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.Location = new System.Drawing.Point(118, 94);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(192, 17);
            this.discountCheckBox.TabIndex = 1;
            this.discountCheckBox.Text = "Get 5% discount for early admission";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Class";
            // 
            // YearlyCostofaStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 279);
            this.Controls.Add(this.groupBox1);
            this.Name = "YearlyCostofaStudent";
            this.Text = "YearlyCostofaStudent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectClassComboBox;
        private System.Windows.Forms.Button totalAmountButton;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.Label label1;
    }
}

