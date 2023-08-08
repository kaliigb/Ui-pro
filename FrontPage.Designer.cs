
namespace Cinema
{
    partial class FrontPage
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
            this.byn_Admin = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.label_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // byn_Admin
            // 
            this.byn_Admin.BackColor = System.Drawing.Color.Snow;
            this.byn_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byn_Admin.ForeColor = System.Drawing.Color.Red;
            this.byn_Admin.Location = new System.Drawing.Point(30, 148);
            this.byn_Admin.Name = "byn_Admin";
            this.byn_Admin.Size = new System.Drawing.Size(206, 64);
            this.byn_Admin.TabIndex = 0;
            this.byn_Admin.Text = "Admin";
            this.byn_Admin.UseVisualStyleBackColor = false;
            this.byn_Admin.Click += new System.EventHandler(this.byn_Admin_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.Snow;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.Red;
            this.btn_Customer.Location = new System.Drawing.Point(295, 148);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(206, 64);
            this.btn_Customer.TabIndex = 1;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.BackColor = System.Drawing.Color.Black;
            this.label_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1.ForeColor = System.Drawing.Color.Snow;
            this.label_1.Location = new System.Drawing.Point(124, 9);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(280, 69);
            this.label_1.TabIndex = 2;
            this.label_1.Text = "Welcome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(155, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "What Are You ?";
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(531, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.byn_Admin);
            this.Name = "FrontPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button byn_Admin;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.Label label1;
    }
}

