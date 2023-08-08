namespace Cinema
{
    partial class AdminVerificationForm
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
            this.txtBox_AdminId = new System.Windows.Forms.TextBox();
            this.btn_AdminIdCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // txtBox_AdminId
            // 
            this.txtBox_AdminId.Location = new System.Drawing.Point(89, 51);
            this.txtBox_AdminId.Name = "txtBox_AdminId";
            this.txtBox_AdminId.Size = new System.Drawing.Size(192, 22);
            this.txtBox_AdminId.TabIndex = 1;
            // 
            // btn_AdminIdCheck
            // 
            this.btn_AdminIdCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminIdCheck.ForeColor = System.Drawing.Color.Red;
            this.btn_AdminIdCheck.Location = new System.Drawing.Point(307, 42);
            this.btn_AdminIdCheck.Name = "btn_AdminIdCheck";
            this.btn_AdminIdCheck.Size = new System.Drawing.Size(132, 40);
            this.btn_AdminIdCheck.TabIndex = 2;
            this.btn_AdminIdCheck.Text = "Login";
            this.btn_AdminIdCheck.UseVisualStyleBackColor = true;
            this.btn_AdminIdCheck.Click += new System.EventHandler(this.VerifyButton_Click);
            // 
            // AdminVerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(472, 119);
            this.Controls.Add(this.btn_AdminIdCheck);
            this.Controls.Add(this.txtBox_AdminId);
            this.Controls.Add(this.label1);
            this.Name = "AdminVerificationForm";
            this.Text = "AdminVerificationForm";
            this.Load += new System.EventHandler(this.AdminVerificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_AdminId;
        private System.Windows.Forms.Button btn_AdminIdCheck;
    }
}