namespace Lab_Form
{
    partial class Frm_M16_參數
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
            this.btnByValue = new System.Windows.Forms.Button();
            this.btnByReference = new System.Windows.Forms.Button();
            this.byRef = new System.Windows.Forms.Button();
            this.btnByOut = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnByValue
            // 
            this.btnByValue.Location = new System.Drawing.Point(67, 55);
            this.btnByValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnByValue.Name = "btnByValue";
            this.btnByValue.Size = new System.Drawing.Size(184, 53);
            this.btnByValue.TabIndex = 0;
            this.btnByValue.Text = "By Value參數";
            this.btnByValue.UseVisualStyleBackColor = true;
            this.btnByValue.Click += new System.EventHandler(this.btnByValue_Click);
            // 
            // btnByReference
            // 
            this.btnByReference.Location = new System.Drawing.Point(259, 55);
            this.btnByReference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnByReference.Name = "btnByReference";
            this.btnByReference.Size = new System.Drawing.Size(184, 53);
            this.btnByReference.TabIndex = 1;
            this.btnByReference.Text = "By Reference參數";
            this.btnByReference.UseVisualStyleBackColor = true;
            this.btnByReference.Click += new System.EventHandler(this.btnByReference_Click);
            // 
            // byRef
            // 
            this.byRef.Location = new System.Drawing.Point(451, 55);
            this.byRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.byRef.Name = "byRef";
            this.byRef.Size = new System.Drawing.Size(184, 53);
            this.byRef.TabIndex = 2;
            this.byRef.Text = "By ref 參數";
            this.byRef.UseVisualStyleBackColor = true;
            this.byRef.Click += new System.EventHandler(this.byRef_Click);
            // 
            // btnByOut
            // 
            this.btnByOut.Location = new System.Drawing.Point(643, 55);
            this.btnByOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnByOut.Name = "btnByOut";
            this.btnByOut.Size = new System.Drawing.Size(184, 53);
            this.btnByOut.TabIndex = 3;
            this.btnByOut.Text = "By out 參數";
            this.btnByOut.UseVisualStyleBackColor = true;
            this.btnByOut.Click += new System.EventHandler(this.btnByOut_Click);
            // 
            // btnParams
            // 
            this.btnParams.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnParams.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnParams.Location = new System.Drawing.Point(835, 55);
            this.btnParams.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(184, 53);
            this.btnParams.TabIndex = 4;
            this.btnParams.Text = "By Params參數";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // Frm_M16_參數
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnByOut);
            this.Controls.Add(this.byRef);
            this.Controls.Add(this.btnByReference);
            this.Controls.Add(this.btnByValue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_M16_參數";
            this.Text = "Frm_M16_參數";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByValue;
        private System.Windows.Forms.Button btnByReference;
        private System.Windows.Forms.Button byRef;
        private System.Windows.Forms.Button btnByOut;
        private System.Windows.Forms.Button btnParams;
    }
}