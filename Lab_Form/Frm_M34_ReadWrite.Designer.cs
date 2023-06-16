namespace Lab_Form
{
    partial class Frm_M34_ReadWrite
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
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.btnStringWriter = new System.Windows.Forms.Button();
            this.txtReadWrite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(12, 84);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(122, 47);
            this.btnStreamReader.TabIndex = 0;
            this.btnStreamReader.Text = "StreamReader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // btnStringWriter
            // 
            this.btnStringWriter.Location = new System.Drawing.Point(12, 137);
            this.btnStringWriter.Name = "btnStringWriter";
            this.btnStringWriter.Size = new System.Drawing.Size(122, 47);
            this.btnStringWriter.TabIndex = 1;
            this.btnStringWriter.Text = "StreamWriter";
            this.btnStringWriter.UseVisualStyleBackColor = true;
            this.btnStringWriter.Click += new System.EventHandler(this.btnStringWriter_Click);
            // 
            // txtReadWrite
            // 
            this.txtReadWrite.Location = new System.Drawing.Point(268, 61);
            this.txtReadWrite.Multiline = true;
            this.txtReadWrite.Name = "txtReadWrite";
            this.txtReadWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadWrite.Size = new System.Drawing.Size(410, 328);
            this.txtReadWrite.TabIndex = 2;
            this.txtReadWrite.TextChanged += new System.EventHandler(this.txtReadWrite_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "中斷模式";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "try catch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_M34_ReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtReadWrite);
            this.Controls.Add(this.btnStringWriter);
            this.Controls.Add(this.btnStreamReader);
            this.Name = "Frm_M34_ReadWrite";
            this.Text = "Frm_M34_ReadWrite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.Button btnStringWriter;
        private System.Windows.Forms.TextBox txtReadWrite;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}