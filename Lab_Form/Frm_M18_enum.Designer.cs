namespace Lab_Form
{
    partial class Frm_M18_enum
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
            this.btnProdcuts = new System.Windows.Forms.Button();
            this.btnValidation01 = new System.Windows.Forms.Button();
            this.btnValidation02 = new System.Windows.Forms.Button();
            this.btnEnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProdcuts
            // 
            this.btnProdcuts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnProdcuts.Enabled = false;
            this.btnProdcuts.Location = new System.Drawing.Point(725, 64);
            this.btnProdcuts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProdcuts.Name = "btnProdcuts";
            this.btnProdcuts.Size = new System.Drawing.Size(187, 50);
            this.btnProdcuts.TabIndex = 0;
            this.btnProdcuts.Text = "Products";
            this.btnProdcuts.UseVisualStyleBackColor = false;
            this.btnProdcuts.Click += new System.EventHandler(this.btnProdcuts_Click);
            // 
            // btnValidation01
            // 
            this.btnValidation01.Location = new System.Drawing.Point(45, 64);
            this.btnValidation01.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidation01.Name = "btnValidation01";
            this.btnValidation01.Size = new System.Drawing.Size(212, 50);
            this.btnValidation01.TabIndex = 1;
            this.btnValidation01.Text = "Validation 01";
            this.btnValidation01.UseVisualStyleBackColor = true;
            this.btnValidation01.Click += new System.EventHandler(this.btnValidation01_Click);
            // 
            // btnValidation02
            // 
            this.btnValidation02.Location = new System.Drawing.Point(274, 67);
            this.btnValidation02.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidation02.Name = "btnValidation02";
            this.btnValidation02.Size = new System.Drawing.Size(212, 47);
            this.btnValidation02.TabIndex = 2;
            this.btnValidation02.Text = "Validation 02";
            this.btnValidation02.UseVisualStyleBackColor = true;
            this.btnValidation02.Click += new System.EventHandler(this.btnValidation02_Click);
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(494, 67);
            this.btnEnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(212, 47);
            this.btnEnum.TabIndex = 3;
            this.btnEnum.Text = "enum";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // Frm_M18_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.btnValidation02);
            this.Controls.Add(this.btnValidation01);
            this.Controls.Add(this.btnProdcuts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_M18_enum";
            this.Text = "Frm_M18_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProdcuts;
        private System.Windows.Forms.Button btnValidation01;
        private System.Windows.Forms.Button btnValidation02;
        private System.Windows.Forms.Button btnEnum;
    }
}