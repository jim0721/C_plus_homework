namespace Lab_Form
{
    partial class Frm_M26_Array
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
            this.btnArray = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(24, 28);
            this.btnArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(138, 33);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "建立陣列";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "建立多維陣列";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(312, 23);
            this.btnCreateArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(138, 42);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "建立陣列方法";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "建立陣列方法";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_M26_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 375);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnArray);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_M26_Array";
            this.Text = "Frm_M26_Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button button2;
    }
}