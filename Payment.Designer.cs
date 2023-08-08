namespace Cinema
{
    partial class Payment
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
            this.txtBox_FullName = new System.Windows.Forms.TextBox();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_numOfTickets = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_Seats = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txtBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name :";
            // 
            // txtBox_FullName
            // 
            this.txtBox_FullName.Location = new System.Drawing.Point(218, 49);
            this.txtBox_FullName.Name = "txtBox_FullName";
            this.txtBox_FullName.Size = new System.Drawing.Size(191, 22);
            this.txtBox_FullName.TabIndex = 1;
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(218, 114);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Id.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID :";
            // 
            // txtBox_Price
            // 
            this.txtBox_Price.Location = new System.Drawing.Point(218, 232);
            this.txtBox_Price.Name = "txtBox_Price";
            this.txtBox_Price.ReadOnly = true;
            this.txtBox_Price.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Price.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price :";
            // 
            // txtBox_numOfTickets
            // 
            this.txtBox_numOfTickets.Location = new System.Drawing.Point(218, 289);
            this.txtBox_numOfTickets.Name = "txtBox_numOfTickets";
            this.txtBox_numOfTickets.ReadOnly = true;
            this.txtBox_numOfTickets.Size = new System.Drawing.Size(191, 22);
            this.txtBox_numOfTickets.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number Of Tickets :";
            // 
            // txtBox_Seats
            // 
            this.txtBox_Seats.Location = new System.Drawing.Point(218, 352);
            this.txtBox_Seats.Name = "txtBox_Seats";
            this.txtBox_Seats.ReadOnly = true;
            this.txtBox_Seats.Size = new System.Drawing.Size(191, 22);
            this.txtBox_Seats.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seats :";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.Color.White;
            this.btn_pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.Color.Red;
            this.btn_pay.Location = new System.Drawing.Point(154, 411);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(167, 47);
            this.btn_pay.TabIndex = 10;
            this.btn_pay.Text = "Pay";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txtBox_PhoneNumber
            // 
            this.txtBox_PhoneNumber.Location = new System.Drawing.Point(218, 174);
            this.txtBox_PhoneNumber.Name = "txtBox_PhoneNumber";
            this.txtBox_PhoneNumber.Size = new System.Drawing.Size(191, 22);
            this.txtBox_PhoneNumber.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "PhoneNumber :";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(475, 488);
            this.Controls.Add(this.txtBox_PhoneNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.txtBox_Seats);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBox_numOfTickets);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBox_Price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_FullName);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_FullName;
        private System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.TextBox txtBox_PhoneNumber;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtBox_Price;
        public System.Windows.Forms.TextBox txtBox_numOfTickets;
        public System.Windows.Forms.TextBox txtBox_Seats;
    }
}