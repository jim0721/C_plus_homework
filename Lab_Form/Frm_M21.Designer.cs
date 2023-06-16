namespace Lab_Form
{
    partial class Frm_M21
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
            this.btnReverse = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnIfElse = new System.Windows.Forms.Button();
            this.btnIfElseIf = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.labGrade = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(72, 38);
            this.btnReverse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(147, 41);
            this.btnReverse.TabIndex = 0;
            this.btnReverse.Text = "!";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 39);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "三元運算式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIf
            // 
            this.btnIf.Location = new System.Drawing.Point(382, 43);
            this.btnIf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIf.Name = "btnIf";
            this.btnIf.Size = new System.Drawing.Size(147, 36);
            this.btnIf.TabIndex = 2;
            this.btnIf.Text = "if";
            this.btnIf.UseVisualStyleBackColor = true;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click);
            // 
            // btnIfElse
            // 
            this.btnIfElse.Location = new System.Drawing.Point(537, 43);
            this.btnIfElse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIfElse.Name = "btnIfElse";
            this.btnIfElse.Size = new System.Drawing.Size(147, 41);
            this.btnIfElse.TabIndex = 3;
            this.btnIfElse.Text = "if...else...";
            this.btnIfElse.UseVisualStyleBackColor = true;
            this.btnIfElse.Click += new System.EventHandler(this.btnIfElse_Click);
            // 
            // btnIfElseIf
            // 
            this.btnIfElseIf.Location = new System.Drawing.Point(227, 93);
            this.btnIfElseIf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnIfElseIf.Name = "btnIfElseIf";
            this.btnIfElseIf.Size = new System.Drawing.Size(147, 43);
            this.btnIfElseIf.TabIndex = 4;
            this.btnIfElseIf.Text = "if...else if...";
            this.btnIfElseIf.UseVisualStyleBackColor = true;
            this.btnIfElseIf.Click += new System.EventHandler(this.btnIfElseIf_Click);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(72, 111);
            this.txtScore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(147, 25);
            this.txtScore.TabIndex = 5;
            this.txtScore.TextChanged += new System.EventHandler(this.txtScore_TextChanged);
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Location = new System.Drawing.Point(569, 107);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(37, 15);
            this.labGrade.TabIndex = 6;
            this.labGrade.Text = "級距";
            this.labGrade.Click += new System.EventHandler(this.labGrade_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.Location = new System.Drawing.Point(382, 93);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(147, 43);
            this.btnSwitch.TabIndex = 7;
            this.btnSwitch.Text = "switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // Frm_M21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnIfElseIf);
            this.Controls.Add(this.btnIfElse);
            this.Controls.Add(this.btnIf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReverse);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_M21";
            this.Text = "Frm_M21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnIfElse;
        private System.Windows.Forms.Button btnIfElseIf;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Button btnSwitch;
    }
}