namespace Lab_Form
{
    partial class Frm_M15_CTS
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.txtReferenceType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Location = new System.Drawing.Point(366, 187);
            this.btnValueType.Margin = new System.Windows.Forms.Padding(4);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(191, 41);
            this.btnValueType.TabIndex = 0;
            this.btnValueType.Text = "Value Type";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnValueType_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Location = new System.Drawing.Point(565, 187);
            this.btnReferenceType.Margin = new System.Windows.Forms.Padding(4);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(191, 41);
            this.btnReferenceType.TabIndex = 1;
            this.btnReferenceType.Text = "Reference Type";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.btnReferenceType_Click);
            // 
            // txtReferenceType
            // 
            this.txtReferenceType.Location = new System.Drawing.Point(468, 154);
            this.txtReferenceType.Margin = new System.Windows.Forms.Padding(4);
            this.txtReferenceType.Name = "txtReferenceType";
            this.txtReferenceType.Size = new System.Drawing.Size(187, 25);
            this.txtReferenceType.TabIndex = 2;
            this.txtReferenceType.TextChanged += new System.EventHandler(this.txtReferenceType_TextChanged);
            // 
            // Frm_M15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txtReferenceType);
            this.Controls.Add(this.btnReferenceType);
            this.Controls.Add(this.btnValueType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M15_CTS";
            this.Text = "Frm_M15_CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnReferenceType;
        private System.Windows.Forms.TextBox txtReferenceType;
    }
}