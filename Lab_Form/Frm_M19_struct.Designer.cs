namespace Lab_Form
{
    partial class Frm_M19_struct
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnShowEmployee = new System.Windows.Forms.Button();
            this.labShowEmployee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(83, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "員工姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(200, 68);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(128, 39);
            this.txtEmployeeName.TabIndex = 1;
            this.txtEmployeeName.TextChanged += new System.EventHandler(this.txtEmployeeName_TextChanged);
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(200, 148);
            this.txtEmployeeAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(128, 39);
            this.txtEmployeeAge.TabIndex = 3;
            this.txtEmployeeAge.TextChanged += new System.EventHandler(this.txtEmployeeAge_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(83, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "員工年齡";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(50, 227);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(153, 44);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "加入員工";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnShowEmployee
            // 
            this.btnShowEmployee.Location = new System.Drawing.Point(221, 227);
            this.btnShowEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEmployee.Name = "btnShowEmployee";
            this.btnShowEmployee.Size = new System.Drawing.Size(153, 44);
            this.btnShowEmployee.TabIndex = 5;
            this.btnShowEmployee.Text = "顯示員工";
            this.btnShowEmployee.UseVisualStyleBackColor = true;
            this.btnShowEmployee.Click += new System.EventHandler(this.btnShowEmployee_Click);
            // 
            // labShowEmployee
            // 
            this.labShowEmployee.AutoSize = true;
            this.labShowEmployee.BackColor = System.Drawing.Color.Turquoise;
            this.labShowEmployee.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowEmployee.ForeColor = System.Drawing.Color.DarkBlue;
            this.labShowEmployee.Location = new System.Drawing.Point(176, 9);
            this.labShowEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShowEmployee.Name = "labShowEmployee";
            this.labShowEmployee.Size = new System.Drawing.Size(61, 30);
            this.labShowEmployee.TabIndex = 6;
            this.labShowEmployee.Text = "員工";
            this.labShowEmployee.Click += new System.EventHandler(this.labShowEmployee_Click);
            // 
            // Frm_M19_struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.labShowEmployee);
            this.Controls.Add(this.btnShowEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M19_struct";
            this.Text = "Frm_M19_struct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnShowEmployee;
        private System.Windows.Forms.Label labShowEmployee;
    }
}