namespace thomas_bell_cis3309_lab02
{
    partial class Form1
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
            this.gbMembershipType = new System.Windows.Forms.GroupBox();
            this.rbSenior = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbChild = new System.Windows.Forms.RadioButton();
            this.rbAdult = new System.Windows.Forms.RadioButton();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.chkPersonalTrainer = new System.Windows.Forms.CheckBox();
            this.chkKarate = new System.Windows.Forms.CheckBox();
            this.chkYoga = new System.Windows.Forms.CheckBox();
            this.gbMembershipLength = new System.Windows.Forms.GroupBox();
            this.txtMembershipLength = new System.Windows.Forms.TextBox();
            this.lblMembershipLength = new System.Windows.Forms.Label();
            this.gbMembershipFees = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMonthlyFee = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMonthlyFee = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMembershipType.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbMembershipLength.SuspendLayout();
            this.gbMembershipFees.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMembershipType
            // 
            this.gbMembershipType.Controls.Add(this.rbSenior);
            this.gbMembershipType.Controls.Add(this.rbStudent);
            this.gbMembershipType.Controls.Add(this.rbChild);
            this.gbMembershipType.Controls.Add(this.rbAdult);
            this.gbMembershipType.Location = new System.Drawing.Point(12, 12);
            this.gbMembershipType.Name = "gbMembershipType";
            this.gbMembershipType.Size = new System.Drawing.Size(154, 122);
            this.gbMembershipType.TabIndex = 0;
            this.gbMembershipType.TabStop = false;
            this.gbMembershipType.Text = "Type of Membership";
            // 
            // rbSenior
            // 
            this.rbSenior.AutoSize = true;
            this.rbSenior.Location = new System.Drawing.Point(7, 92);
            this.rbSenior.Name = "rbSenior";
            this.rbSenior.Size = new System.Drawing.Size(89, 17);
            this.rbSenior.TabIndex = 3;
            this.rbSenior.TabStop = true;
            this.rbSenior.Text = "Senior Citizen";
            this.rbSenior.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(7, 68);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(62, 17);
            this.rbStudent.TabIndex = 2;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbChild
            // 
            this.rbChild.AutoSize = true;
            this.rbChild.Location = new System.Drawing.Point(7, 44);
            this.rbChild.Name = "rbChild";
            this.rbChild.Size = new System.Drawing.Size(122, 17);
            this.rbChild.TabIndex = 1;
            this.rbChild.TabStop = true;
            this.rbChild.Text = "Child (12 and Under)";
            this.rbChild.UseVisualStyleBackColor = true;
            // 
            // rbAdult
            // 
            this.rbAdult.AutoSize = true;
            this.rbAdult.Location = new System.Drawing.Point(7, 20);
            this.rbAdult.Name = "rbAdult";
            this.rbAdult.Size = new System.Drawing.Size(95, 17);
            this.rbAdult.TabIndex = 0;
            this.rbAdult.TabStop = true;
            this.rbAdult.Text = "Standard Adult";
            this.rbAdult.UseVisualStyleBackColor = true;
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.chkPersonalTrainer);
            this.gbOptions.Controls.Add(this.chkKarate);
            this.gbOptions.Controls.Add(this.chkYoga);
            this.gbOptions.Location = new System.Drawing.Point(172, 12);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(187, 122);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Options";
            // 
            // chkPersonalTrainer
            // 
            this.chkPersonalTrainer.AutoSize = true;
            this.chkPersonalTrainer.Location = new System.Drawing.Point(7, 68);
            this.chkPersonalTrainer.Name = "chkPersonalTrainer";
            this.chkPersonalTrainer.Size = new System.Drawing.Size(103, 17);
            this.chkPersonalTrainer.TabIndex = 2;
            this.chkPersonalTrainer.Text = "Personal Trainer";
            this.chkPersonalTrainer.UseVisualStyleBackColor = true;
            // 
            // chkKarate
            // 
            this.chkKarate.AutoSize = true;
            this.chkKarate.Location = new System.Drawing.Point(7, 44);
            this.chkKarate.Name = "chkKarate";
            this.chkKarate.Size = new System.Drawing.Size(57, 17);
            this.chkKarate.TabIndex = 1;
            this.chkKarate.Text = "Karate";
            this.chkKarate.UseVisualStyleBackColor = true;
            // 
            // chkYoga
            // 
            this.chkYoga.AutoSize = true;
            this.chkYoga.Location = new System.Drawing.Point(7, 20);
            this.chkYoga.Name = "chkYoga";
            this.chkYoga.Size = new System.Drawing.Size(51, 17);
            this.chkYoga.TabIndex = 0;
            this.chkYoga.Text = "Yoga";
            this.chkYoga.UseVisualStyleBackColor = true;
            // 
            // gbMembershipLength
            // 
            this.gbMembershipLength.Controls.Add(this.txtMembershipLength);
            this.gbMembershipLength.Controls.Add(this.lblMembershipLength);
            this.gbMembershipLength.Location = new System.Drawing.Point(12, 150);
            this.gbMembershipLength.Name = "gbMembershipLength";
            this.gbMembershipLength.Size = new System.Drawing.Size(154, 74);
            this.gbMembershipLength.TabIndex = 2;
            this.gbMembershipLength.TabStop = false;
            this.gbMembershipLength.Text = "Membership Length";
            // 
            // txtMembershipLength
            // 
            this.txtMembershipLength.Location = new System.Drawing.Point(7, 33);
            this.txtMembershipLength.Name = "txtMembershipLength";
            this.txtMembershipLength.Size = new System.Drawing.Size(139, 20);
            this.txtMembershipLength.TabIndex = 1;
            // 
            // lblMembershipLength
            // 
            this.lblMembershipLength.AutoSize = true;
            this.lblMembershipLength.Location = new System.Drawing.Point(6, 16);
            this.lblMembershipLength.Name = "lblMembershipLength";
            this.lblMembershipLength.Size = new System.Drawing.Size(140, 13);
            this.lblMembershipLength.TabIndex = 0;
            this.lblMembershipLength.Text = "Enter the number of months:";
            // 
            // gbMembershipFees
            // 
            this.gbMembershipFees.Controls.Add(this.txtTotal);
            this.gbMembershipFees.Controls.Add(this.txtMonthlyFee);
            this.gbMembershipFees.Controls.Add(this.lblTotal);
            this.gbMembershipFees.Controls.Add(this.lblMonthlyFee);
            this.gbMembershipFees.Location = new System.Drawing.Point(172, 150);
            this.gbMembershipFees.Name = "gbMembershipFees";
            this.gbMembershipFees.Size = new System.Drawing.Size(187, 74);
            this.gbMembershipFees.TabIndex = 3;
            this.gbMembershipFees.TabStop = false;
            this.gbMembershipFees.Text = "Membership Fees";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(80, 42);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // txtMonthlyFee
            // 
            this.txtMonthlyFee.Location = new System.Drawing.Point(80, 16);
            this.txtMonthlyFee.Name = "txtMonthlyFee";
            this.txtMonthlyFee.Size = new System.Drawing.Size(100, 20);
            this.txtMonthlyFee.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(40, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total:";
            // 
            // lblMonthlyFee
            // 
            this.lblMonthlyFee.AutoSize = true;
            this.lblMonthlyFee.Location = new System.Drawing.Point(6, 16);
            this.lblMonthlyFee.Name = "lblMonthlyFee";
            this.lblMonthlyFee.Size = new System.Drawing.Size(68, 13);
            this.lblMonthlyFee.TabIndex = 0;
            this.lblMonthlyFee.Text = "Monthly Fee:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(19, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(146, 230);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(277, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 263);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gbMembershipFees);
            this.Controls.Add(this.gbMembershipLength);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.gbMembershipType);
            this.Name = "Form1";
            this.Text = "Membership Fee Calculator";
            this.gbMembershipType.ResumeLayout(false);
            this.gbMembershipType.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbMembershipLength.ResumeLayout(false);
            this.gbMembershipLength.PerformLayout();
            this.gbMembershipFees.ResumeLayout(false);
            this.gbMembershipFees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMembershipType;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.GroupBox gbMembershipLength;
        private System.Windows.Forms.GroupBox gbMembershipFees;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbSenior;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbChild;
        private System.Windows.Forms.RadioButton rbAdult;
        private System.Windows.Forms.CheckBox chkPersonalTrainer;
        private System.Windows.Forms.CheckBox chkKarate;
        private System.Windows.Forms.CheckBox chkYoga;
        private System.Windows.Forms.Label lblMembershipLength;
        private System.Windows.Forms.TextBox txtMembershipLength;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMonthlyFee;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMonthlyFee;
    }
}

