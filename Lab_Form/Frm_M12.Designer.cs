namespace Lab_Form
{
    partial class Frm_M12
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
            this.button1 = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labResult = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnConst = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClassVar = new System.Windows.Forms.Button();
            this.btnLocalVar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.labInstanceCount = new System.Windows.Forms.Label();
            this.labStaticCount = new System.Windows.Forms.Label();
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "+=, -=, *=, /=, %=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(520, 348);
            this.labCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(110, 31);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "Count: 0";
            this.labCount.Click += new System.EventHandler(this.labCount_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "++count , --count";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labResult
            // 
            this.labResult.AutoSize = true;
            this.labResult.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labResult.Location = new System.Drawing.Point(518, 405);
            this.labResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(112, 31);
            this.labResult.TabIndex = 3;
            this.labResult.Text = "Result: 0";
            this.labResult.Click += new System.EventHandler(this.labResult_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 120);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "count++ , count--";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnConst
            // 
            this.btnConst.Location = new System.Drawing.Point(13, 120);
            this.btnConst.Margin = new System.Windows.Forms.Padding(4);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(151, 62);
            this.btnConst.TabIndex = 5;
            this.btnConst.Text = "const";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClassVar);
            this.groupBox1.Controls.Add(this.btnLocalVar);
            this.groupBox1.Location = new System.Drawing.Point(337, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(325, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variable";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnClassVar
            // 
            this.btnClassVar.Location = new System.Drawing.Point(40, 94);
            this.btnClassVar.Margin = new System.Windows.Forms.Padding(4);
            this.btnClassVar.Name = "btnClassVar";
            this.btnClassVar.Size = new System.Drawing.Size(244, 49);
            this.btnClassVar.TabIndex = 1;
            this.btnClassVar.Text = "Class Var.";
            this.btnClassVar.UseVisualStyleBackColor = true;
            this.btnClassVar.Click += new System.EventHandler(this.btnClassVar_Click);
            // 
            // btnLocalVar
            // 
            this.btnLocalVar.Location = new System.Drawing.Point(40, 26);
            this.btnLocalVar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLocalVar.Name = "btnLocalVar";
            this.btnLocalVar.Size = new System.Drawing.Size(244, 48);
            this.btnLocalVar.TabIndex = 0;
            this.btnLocalVar.Text = "Local Var.";
            this.btnLocalVar.UseVisualStyleBackColor = true;
            this.btnLocalVar.Click += new System.EventHandler(this.btnLocalVar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(677, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(325, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static Lab";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(40, 100);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 66);
            this.button5.TabIndex = 1;
            this.button5.Text = "static var";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.StaticVar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 26);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 66);
            this.button4.TabIndex = 0;
            this.button4.Text = "instance var";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.InstanceVar_Click);
            // 
            // labInstanceCount
            // 
            this.labInstanceCount.AutoSize = true;
            this.labInstanceCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstanceCount.Location = new System.Drawing.Point(638, 348);
            this.labInstanceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInstanceCount.Name = "labInstanceCount";
            this.labInstanceCount.Size = new System.Drawing.Size(212, 31);
            this.labInstanceCount.TabIndex = 8;
            this.labInstanceCount.Text = "instance Count: 0";
            this.labInstanceCount.Click += new System.EventHandler(this.labInstanceCount_Click);
            // 
            // labStaticCount
            // 
            this.labStaticCount.AutoSize = true;
            this.labStaticCount.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStaticCount.Location = new System.Drawing.Point(638, 405);
            this.labStaticCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStaticCount.Name = "labStaticCount";
            this.labStaticCount.Size = new System.Drawing.Size(177, 31);
            this.labStaticCount.TabIndex = 9;
            this.labStaticCount.Text = "static Count: 0";
            this.labStaticCount.Click += new System.EventHandler(this.labStaticCount_Click);
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(536, 264);
            this.btnOpenHelloForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(225, 66);
            this.btnOpenHelloForm.TabIndex = 2;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Controls.Add(this.labStaticCount);
            this.Controls.Add(this.labInstanceCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labResult;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnConst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClassVar;
        private System.Windows.Forms.Button btnLocalVar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labInstanceCount;
        private System.Windows.Forms.Label labStaticCount;
        private System.Windows.Forms.Button btnOpenHelloForm;
    }
}