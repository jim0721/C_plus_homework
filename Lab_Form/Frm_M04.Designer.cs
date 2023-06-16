namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnReturnMethod = new System.Windows.Forms.Button();
            this.btnFirstClass = new System.Windows.Forms.Button();
            this.btnMethod05 = new System.Windows.Forms.Button();
            this.btnMyPartialClass = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(251, 71);
            this.btnOpenHelloForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(217, 40);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(476, 71);
            this.btnMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(217, 45);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnReturnMethod
            // 
            this.btnReturnMethod.Location = new System.Drawing.Point(701, 71);
            this.btnReturnMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnMethod.Name = "btnReturnMethod";
            this.btnReturnMethod.Size = new System.Drawing.Size(216, 45);
            this.btnReturnMethod.TabIndex = 2;
            this.btnReturnMethod.Text = "Return Method";
            this.btnReturnMethod.UseVisualStyleBackColor = true;
            this.btnReturnMethod.Click += new System.EventHandler(this.btnReturnMethod_Click);
            // 
            // btnFirstClass
            // 
            this.btnFirstClass.Location = new System.Drawing.Point(16, 114);
            this.btnFirstClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFirstClass.Name = "btnFirstClass";
            this.btnFirstClass.Size = new System.Drawing.Size(216, 52);
            this.btnFirstClass.TabIndex = 3;
            this.btnFirstClass.Text = "First Class";
            this.btnFirstClass.UseVisualStyleBackColor = true;
            this.btnFirstClass.Click += new System.EventHandler(this.btnFirstClass_Click);
            // 
            // btnMethod05
            // 
            this.btnMethod05.Location = new System.Drawing.Point(251, 114);
            this.btnMethod05.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMethod05.Name = "btnMethod05";
            this.btnMethod05.Size = new System.Drawing.Size(217, 52);
            this.btnMethod05.TabIndex = 4;
            this.btnMethod05.Text = "封裝";
            this.btnMethod05.UseVisualStyleBackColor = true;
            this.btnMethod05.Click += new System.EventHandler(this.btnMethod05_Click);
            // 
            // btnMyPartialClass
            // 
            this.btnMyPartialClass.Location = new System.Drawing.Point(476, 119);
            this.btnMyPartialClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMyPartialClass.Name = "btnMyPartialClass";
            this.btnMyPartialClass.Size = new System.Drawing.Size(217, 47);
            this.btnMyPartialClass.TabIndex = 5;
            this.btnMyPartialClass.Text = "Partial Class";
            this.btnMyPartialClass.UseVisualStyleBackColor = true;
            this.btnMyPartialClass.Click += new System.EventHandler(this.btnMyPartialClass_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(16, 68);
            this.btnNewMember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(216, 43);
            this.btnNewMember.TabIndex = 6;
            this.btnNewMember.Text = "New Member初始化";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnMyPartialClass);
            this.Controls.Add(this.btnMethod05);
            this.Controls.Add(this.btnFirstClass);
            this.Controls.Add(this.btnReturnMethod);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnReturnMethod;
        private System.Windows.Forms.Button btnFirstClass;
        private System.Windows.Forms.Button btnMethod05;
        private System.Windows.Forms.Button btnMyPartialClass;
        private System.Windows.Forms.Button btnNewMember;
    }
}