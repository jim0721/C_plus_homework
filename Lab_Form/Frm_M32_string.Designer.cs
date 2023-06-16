namespace Lab_Form
{
    partial class Frm_M32_string
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
            this.components = new System.ComponentModel.Container();
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labPwValid = new System.Windows.Forms.Label();
            this.labIdValid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnValid = new System.Windows.Forms.Button();
            this.timerPW = new System.Windows.Forms.Timer(this.components);
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.labTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(47, 282);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(137, 31);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "string";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(190, 282);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(137, 31);
            this.btnStringBuilder.TabIndex = 1;
            this.btnStringBuilder.Text = "StringBuilder";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(47, 319);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(137, 36);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(295, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(165, 25);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "密碼";
            // 
            // labPwValid
            // 
            this.labPwValid.AutoSize = true;
            this.labPwValid.Location = new System.Drawing.Point(132, 127);
            this.labPwValid.Name = "labPwValid";
            this.labPwValid.Size = new System.Drawing.Size(37, 15);
            this.labPwValid.TabIndex = 5;
            this.labPwValid.Text = "驗證";
            this.labPwValid.Click += new System.EventHandler(this.labPwValid_Click);
            // 
            // labIdValid
            // 
            this.labIdValid.AutoSize = true;
            this.labIdValid.Location = new System.Drawing.Point(132, 86);
            this.labIdValid.Name = "labIdValid";
            this.labIdValid.Size = new System.Drawing.Size(37, 15);
            this.labIdValid.TabIndex = 8;
            this.labIdValid.Text = "驗證";
            this.labIdValid.Click += new System.EventHandler(this.labIdValid_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "身份證字號";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(295, 117);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(165, 25);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnValid
            // 
            this.btnValid.Location = new System.Drawing.Point(295, 148);
            this.btnValid.Name = "btnValid";
            this.btnValid.Size = new System.Drawing.Size(165, 31);
            this.btnValid.TabIndex = 9;
            this.btnValid.Text = "驗證";
            this.btnValid.UseVisualStyleBackColor = true;
            this.btnValid.Click += new System.EventHandler(this.btnValid_Click);
            // 
            // timerPW
            // 
            this.timerPW.Tick += new System.EventHandler(this.timerPW_Tick);
            // 
            // timerTime
            // 
            this.timerTime.Enabled = true;
            this.timerTime.Interval = 1000;
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.Location = new System.Drawing.Point(207, 340);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(41, 15);
            this.labTime.TabIndex = 10;
            this.labTime.Text = "label2";
            this.labTime.Click += new System.EventHandler(this.labTime_Click);
            // 
            // Frm_M32_string
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labTime);
            this.Controls.Add(this.btnValid);
            this.Controls.Add(this.labIdValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.labPwValid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnStringBuilder);
            this.Controls.Add(this.btnString);
            this.Name = "Frm_M32_string";
            this.Text = "Frm_M32_string";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labPwValid;
        private System.Windows.Forms.Label labIdValid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnValid;
        private System.Windows.Forms.Timer timerPW;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Label labTime;
    }
}