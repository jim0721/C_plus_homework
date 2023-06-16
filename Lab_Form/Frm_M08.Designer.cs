namespace Lab_Form
{
    partial class Frm_M08
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
            this.btnRegisterEvent = new System.Windows.Forms.Button();
            this.btnRegister01 = new System.Windows.Forms.Button();
            this.btnRegister02 = new System.Windows.Forms.Button();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSetProperty = new System.Windows.Forms.Button();
            this.btnGetProperty = new System.Windows.Forms.Button();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btnFDD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterEvent
            // 
            this.btnRegisterEvent.Location = new System.Drawing.Point(47, 64);
            this.btnRegisterEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterEvent.Name = "btnRegisterEvent";
            this.btnRegisterEvent.Size = new System.Drawing.Size(149, 40);
            this.btnRegisterEvent.TabIndex = 0;
            this.btnRegisterEvent.Text = "Register Event";
            this.btnRegisterEvent.UseVisualStyleBackColor = true;
            this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            // 
            // btnRegister01
            // 
            this.btnRegister01.Location = new System.Drawing.Point(204, 64);
            this.btnRegister01.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister01.Name = "btnRegister01";
            this.btnRegister01.Size = new System.Drawing.Size(149, 42);
            this.btnRegister01.TabIndex = 1;
            this.btnRegister01.Text = "Register01";
            this.btnRegister01.UseVisualStyleBackColor = true;
            this.btnRegister01.Click += new System.EventHandler(this.btnRegister01_Click);
            // 
            // btnRegister02
            // 
            this.btnRegister02.Location = new System.Drawing.Point(361, 64);
            this.btnRegister02.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister02.Name = "btnRegister02";
            this.btnRegister02.Size = new System.Drawing.Size(149, 42);
            this.btnRegister02.TabIndex = 2;
            this.btnRegister02.Text = "Register02";
            this.btnRegister02.UseVisualStyleBackColor = true;
            this.btnRegister02.Click += new System.EventHandler(this.btnRegister02_Click);
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.cmbDiscount.Location = new System.Drawing.Point(832, 167);
            this.cmbDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(195, 23);
            this.cmbDiscount.TabIndex = 3;
            this.cmbDiscount.SelectedIndexChanged += new System.EventHandler(this.cmbDiscount_SelectedIndexChanged);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(47, 167);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(149, 44);
            this.btnDiscount.TabIndex = 4;
            this.btnDiscount.Text = "計算金額";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(831, 198);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(196, 25);
            this.txtAmount.TabIndex = 5;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnSetProperty
            // 
            this.btnSetProperty.Location = new System.Drawing.Point(518, 64);
            this.btnSetProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetProperty.Name = "btnSetProperty";
            this.btnSetProperty.Size = new System.Drawing.Size(149, 42);
            this.btnSetProperty.TabIndex = 6;
            this.btnSetProperty.Text = "Set Property";
            this.btnSetProperty.UseVisualStyleBackColor = true;
            this.btnSetProperty.Click += new System.EventHandler(this.btnSetProperty_Click);
            // 
            // btnGetProperty
            // 
            this.btnGetProperty.Location = new System.Drawing.Point(675, 64);
            this.btnGetProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetProperty.Name = "btnGetProperty";
            this.btnGetProperty.Size = new System.Drawing.Size(149, 42);
            this.btnGetProperty.TabIndex = 7;
            this.btnGetProperty.Text = "Get Property";
            this.btnGetProperty.UseVisualStyleBackColor = true;
            this.btnGetProperty.Click += new System.EventHandler(this.btnGetProperty_Click);
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(832, 64);
            this.btnCallMethod.Margin = new System.Windows.Forms.Padding(4);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(149, 42);
            this.btnCallMethod.TabIndex = 8;
            this.btnCallMethod.Text = "Call Method";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(204, 167);
            this.btnMessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(149, 44);
            this.btnMessageBox.TabIndex = 9;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(685, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 133);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '@';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(306, 116);
            this.textBox1.TabIndex = 11;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(251, 284);
            this.btnOpenHelloForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(196, 46);
            this.btnOpenHelloForm.TabIndex = 12;
            this.btnOpenHelloForm.Text = "Open HelloForm";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnFDD
            // 
            this.btnFDD.Location = new System.Drawing.Point(47, 284);
            this.btnFDD.Margin = new System.Windows.Forms.Padding(4);
            this.btnFDD.Name = "btnFDD";
            this.btnFDD.Size = new System.Drawing.Size(196, 46);
            this.btnFDD.TabIndex = 13;
            this.btnFDD.Text = "float & double & decimal";
            this.btnFDD.UseVisualStyleBackColor = true;
            this.btnFDD.Click += new System.EventHandler(this.btnFDD_Click);
            // 
            // Frm_M08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnFDD);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.btnCallMethod);
            this.Controls.Add(this.btnGetProperty);
            this.Controls.Add(this.btnSetProperty);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.btnRegisterEvent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M08";
            this.Text = "Frm_M08";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterEvent;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSetProperty;
        private System.Windows.Forms.Button btnGetProperty;
        private System.Windows.Forms.Button btnCallMethod;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnFDD;
    }
}