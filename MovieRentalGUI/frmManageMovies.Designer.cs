namespace MovieRentalGUI
{
    partial class frmManageMovies
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.radSciFi = new System.Windows.Forms.RadioButton();
            this.radKids = new System.Windows.Forms.RadioButton();
            this.radHorror = new System.Windows.Forms.RadioButton();
            this.radFantasy = new System.Windows.Forms.RadioButton();
            this.radComedy = new System.Windows.Forms.RadioButton();
            this.radAdventure = new System.Windows.Forms.RadioButton();
            this.radAction = new System.Windows.Forms.RadioButton();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.radR = new System.Windows.Forms.RadioButton();
            this.radPGTT = new System.Windows.Forms.RadioButton();
            this.radPG = new System.Windows.Forms.RadioButton();
            this.radG = new System.Windows.Forms.RadioButton();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 163);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(179, 295);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 295);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(15, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 14;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Title";
            // 
            // radSciFi
            // 
            this.radSciFi.AutoSize = true;
            this.radSciFi.Location = new System.Drawing.Point(112, 110);
            this.radSciFi.Name = "radSciFi";
            this.radSciFi.Size = new System.Drawing.Size(51, 17);
            this.radSciFi.TabIndex = 43;
            this.radSciFi.TabStop = true;
            this.radSciFi.Text = "Sci-Fi";
            this.radSciFi.UseVisualStyleBackColor = true;
            // 
            // radKids
            // 
            this.radKids.AutoSize = true;
            this.radKids.Location = new System.Drawing.Point(112, 87);
            this.radKids.Name = "radKids";
            this.radKids.Size = new System.Drawing.Size(45, 17);
            this.radKids.TabIndex = 42;
            this.radKids.TabStop = true;
            this.radKids.Text = "Kids";
            this.radKids.UseVisualStyleBackColor = true;
            // 
            // radHorror
            // 
            this.radHorror.AutoSize = true;
            this.radHorror.Location = new System.Drawing.Point(112, 64);
            this.radHorror.Name = "radHorror";
            this.radHorror.Size = new System.Drawing.Size(54, 17);
            this.radHorror.TabIndex = 41;
            this.radHorror.TabStop = true;
            this.radHorror.Text = "Horror";
            this.radHorror.UseVisualStyleBackColor = true;
            // 
            // radFantasy
            // 
            this.radFantasy.AutoSize = true;
            this.radFantasy.Location = new System.Drawing.Point(15, 133);
            this.radFantasy.Name = "radFantasy";
            this.radFantasy.Size = new System.Drawing.Size(62, 17);
            this.radFantasy.TabIndex = 40;
            this.radFantasy.TabStop = true;
            this.radFantasy.Text = "Fantasy";
            this.radFantasy.UseVisualStyleBackColor = true;
            // 
            // radComedy
            // 
            this.radComedy.AutoSize = true;
            this.radComedy.Location = new System.Drawing.Point(15, 110);
            this.radComedy.Name = "radComedy";
            this.radComedy.Size = new System.Drawing.Size(63, 17);
            this.radComedy.TabIndex = 39;
            this.radComedy.TabStop = true;
            this.radComedy.Text = "Comedy";
            this.radComedy.UseVisualStyleBackColor = true;
            // 
            // radAdventure
            // 
            this.radAdventure.AutoSize = true;
            this.radAdventure.Location = new System.Drawing.Point(15, 87);
            this.radAdventure.Name = "radAdventure";
            this.radAdventure.Size = new System.Drawing.Size(74, 17);
            this.radAdventure.TabIndex = 38;
            this.radAdventure.TabStop = true;
            this.radAdventure.Text = "Adventure";
            this.radAdventure.UseVisualStyleBackColor = true;
            // 
            // radAction
            // 
            this.radAction.AutoSize = true;
            this.radAction.Location = new System.Drawing.Point(15, 64);
            this.radAction.Name = "radAction";
            this.radAction.Size = new System.Drawing.Size(55, 17);
            this.radAction.TabIndex = 37;
            this.radAction.TabStop = true;
            this.radAction.Text = "Action";
            this.radAction.UseVisualStyleBackColor = true;
            this.radAction.CheckedChanged += new System.EventHandler(this.radAction_CheckedChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(12, 48);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(95, 13);
            this.lblGenre.TabIndex = 36;
            this.lblGenre.Text = "Genre(Select One)";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(184, 48);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 49;
            this.lblRating.Text = "Rating";
            // 
            // radR
            // 
            this.radR.AutoSize = true;
            this.radR.Location = new System.Drawing.Point(187, 133);
            this.radR.Name = "radR";
            this.radR.Size = new System.Drawing.Size(33, 17);
            this.radR.TabIndex = 47;
            this.radR.TabStop = true;
            this.radR.Text = "R";
            this.radR.UseVisualStyleBackColor = true;
            // 
            // radPGTT
            // 
            this.radPGTT.AutoSize = true;
            this.radPGTT.Location = new System.Drawing.Point(187, 110);
            this.radPGTT.Name = "radPGTT";
            this.radPGTT.Size = new System.Drawing.Size(55, 17);
            this.radPGTT.TabIndex = 46;
            this.radPGTT.TabStop = true;
            this.radPGTT.Text = "PG-13";
            this.radPGTT.UseVisualStyleBackColor = true;
            // 
            // radPG
            // 
            this.radPG.AutoSize = true;
            this.radPG.Location = new System.Drawing.Point(187, 87);
            this.radPG.Name = "radPG";
            this.radPG.Size = new System.Drawing.Size(40, 17);
            this.radPG.TabIndex = 45;
            this.radPG.TabStop = true;
            this.radPG.Text = "PG";
            this.radPG.UseVisualStyleBackColor = true;
            // 
            // radG
            // 
            this.radG.AutoSize = true;
            this.radG.Location = new System.Drawing.Point(187, 64);
            this.radG.Name = "radG";
            this.radG.Size = new System.Drawing.Size(33, 17);
            this.radG.TabIndex = 44;
            this.radG.TabStop = true;
            this.radG.Text = "G";
            this.radG.UseVisualStyleBackColor = true;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(15, 180);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(227, 96);
            this.rtbDescription.TabIndex = 50;
            this.rtbDescription.Text = "";
            // 
            // frmManageMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 330);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.radR);
            this.Controls.Add(this.radPGTT);
            this.Controls.Add(this.radPG);
            this.Controls.Add(this.radG);
            this.Controls.Add(this.radSciFi);
            this.Controls.Add(this.radKids);
            this.Controls.Add(this.radHorror);
            this.Controls.Add(this.radFantasy);
            this.Controls.Add(this.radComedy);
            this.Controls.Add(this.radAdventure);
            this.Controls.Add(this.radAction);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmManageMovies";
            this.Text = "frmManageMovies";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radSciFi;
        private System.Windows.Forms.RadioButton radKids;
        private System.Windows.Forms.RadioButton radHorror;
        private System.Windows.Forms.RadioButton radFantasy;
        private System.Windows.Forms.RadioButton radComedy;
        private System.Windows.Forms.RadioButton radAdventure;
        private System.Windows.Forms.RadioButton radAction;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.RadioButton radR;
        private System.Windows.Forms.RadioButton radPGTT;
        private System.Windows.Forms.RadioButton radPG;
        private System.Windows.Forms.RadioButton radG;
        private System.Windows.Forms.RichTextBox rtbDescription;
    }
}