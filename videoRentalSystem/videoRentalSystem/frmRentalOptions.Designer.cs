namespace videoRentalSystem
{
    partial class frmRentalOptions
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
            this.btnReserveMovie = new System.Windows.Forms.Button();
            this.btnReturnMovie = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gBoxRental = new System.Windows.Forms.GroupBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.radNCST = new System.Windows.Forms.RadioButton();
            this.radR = new System.Windows.Forms.RadioButton();
            this.radPGTT = new System.Windows.Forms.RadioButton();
            this.radPG = new System.Windows.Forms.RadioButton();
            this.radG = new System.Windows.Forms.RadioButton();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.radAction = new System.Windows.Forms.RadioButton();
            this.radAdventure = new System.Windows.Forms.RadioButton();
            this.radComedy = new System.Windows.Forms.RadioButton();
            this.radFantasy = new System.Windows.Forms.RadioButton();
            this.radHorror = new System.Windows.Forms.RadioButton();
            this.radKids = new System.Windows.Forms.RadioButton();
            this.radSciFi = new System.Windows.Forms.RadioButton();
            this.gBoxAvalible = new System.Windows.Forms.GroupBox();
            this.txtIsAvalible = new System.Windows.Forms.TextBox();
            this.gBoxRental.SuspendLayout();
            this.gBoxAvalible.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReserveMovie
            // 
            this.btnReserveMovie.Location = new System.Drawing.Point(12, 302);
            this.btnReserveMovie.Name = "btnReserveMovie";
            this.btnReserveMovie.Size = new System.Drawing.Size(115, 61);
            this.btnReserveMovie.TabIndex = 2;
            this.btnReserveMovie.Text = "Reserve Movie";
            this.btnReserveMovie.UseVisualStyleBackColor = true;
            // 
            // btnReturnMovie
            // 
            this.btnReturnMovie.Location = new System.Drawing.Point(133, 302);
            this.btnReturnMovie.Name = "btnReturnMovie";
            this.btnReturnMovie.Size = new System.Drawing.Size(115, 61);
            this.btnReturnMovie.TabIndex = 3;
            this.btnReturnMovie.Text = "Return Movie";
            this.btnReturnMovie.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back to Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gBoxRental
            // 
            this.gBoxRental.Controls.Add(this.radSciFi);
            this.gBoxRental.Controls.Add(this.radKids);
            this.gBoxRental.Controls.Add(this.radHorror);
            this.gBoxRental.Controls.Add(this.radFantasy);
            this.gBoxRental.Controls.Add(this.radComedy);
            this.gBoxRental.Controls.Add(this.radAdventure);
            this.gBoxRental.Controls.Add(this.radAction);
            this.gBoxRental.Controls.Add(this.lblRating);
            this.gBoxRental.Controls.Add(this.radNCST);
            this.gBoxRental.Controls.Add(this.radR);
            this.gBoxRental.Controls.Add(this.radPGTT);
            this.gBoxRental.Controls.Add(this.radPG);
            this.gBoxRental.Controls.Add(this.radG);
            this.gBoxRental.Controls.Add(this.txtMovieTitle);
            this.gBoxRental.Controls.Add(this.lblTitle);
            this.gBoxRental.Controls.Add(this.lblGenre);
            this.gBoxRental.Location = new System.Drawing.Point(12, 12);
            this.gBoxRental.Name = "gBoxRental";
            this.gBoxRental.Size = new System.Drawing.Size(366, 248);
            this.gBoxRental.TabIndex = 6;
            this.gBoxRental.TabStop = false;
            this.gBoxRental.Text = "Rental Options";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(248, 92);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(38, 13);
            this.lblRating.TabIndex = 14;
            this.lblRating.Text = "Rating";
            // 
            // radNCST
            // 
            this.radNCST.AutoSize = true;
            this.radNCST.Location = new System.Drawing.Point(251, 200);
            this.radNCST.Name = "radNCST";
            this.radNCST.Size = new System.Drawing.Size(55, 17);
            this.radNCST.TabIndex = 13;
            this.radNCST.TabStop = true;
            this.radNCST.Text = "NC-17";
            this.radNCST.UseVisualStyleBackColor = true;
            // 
            // radR
            // 
            this.radR.AutoSize = true;
            this.radR.Location = new System.Drawing.Point(251, 177);
            this.radR.Name = "radR";
            this.radR.Size = new System.Drawing.Size(33, 17);
            this.radR.TabIndex = 12;
            this.radR.TabStop = true;
            this.radR.Text = "R";
            this.radR.UseVisualStyleBackColor = true;
            // 
            // radPGTT
            // 
            this.radPGTT.AutoSize = true;
            this.radPGTT.Location = new System.Drawing.Point(251, 154);
            this.radPGTT.Name = "radPGTT";
            this.radPGTT.Size = new System.Drawing.Size(55, 17);
            this.radPGTT.TabIndex = 11;
            this.radPGTT.TabStop = true;
            this.radPGTT.Text = "PG-13";
            this.radPGTT.UseVisualStyleBackColor = true;
            // 
            // radPG
            // 
            this.radPG.AutoSize = true;
            this.radPG.Location = new System.Drawing.Point(251, 131);
            this.radPG.Name = "radPG";
            this.radPG.Size = new System.Drawing.Size(40, 17);
            this.radPG.TabIndex = 10;
            this.radPG.TabStop = true;
            this.radPG.Text = "PG";
            this.radPG.UseVisualStyleBackColor = true;
            // 
            // radG
            // 
            this.radG.AutoSize = true;
            this.radG.Location = new System.Drawing.Point(251, 108);
            this.radG.Name = "radG";
            this.radG.Size = new System.Drawing.Size(33, 17);
            this.radG.TabIndex = 9;
            this.radG.TabStop = true;
            this.radG.Text = "G";
            this.radG.UseVisualStyleBackColor = true;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(6, 37);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(120, 20);
            this.txtMovieTitle.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(7, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(71, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Title of Movie";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(7, 92);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(95, 13);
            this.lblGenre.TabIndex = 6;
            this.lblGenre.Text = "Genre(Select One)";
            // 
            // radAction
            // 
            this.radAction.AutoSize = true;
            this.radAction.Location = new System.Drawing.Point(10, 108);
            this.radAction.Name = "radAction";
            this.radAction.Size = new System.Drawing.Size(55, 17);
            this.radAction.TabIndex = 15;
            this.radAction.TabStop = true;
            this.radAction.Text = "Action";
            this.radAction.UseVisualStyleBackColor = true;
            // 
            // radAdventure
            // 
            this.radAdventure.AutoSize = true;
            this.radAdventure.Location = new System.Drawing.Point(10, 131);
            this.radAdventure.Name = "radAdventure";
            this.radAdventure.Size = new System.Drawing.Size(74, 17);
            this.radAdventure.TabIndex = 16;
            this.radAdventure.TabStop = true;
            this.radAdventure.Text = "Adventure";
            this.radAdventure.UseVisualStyleBackColor = true;
            // 
            // radComedy
            // 
            this.radComedy.AutoSize = true;
            this.radComedy.Location = new System.Drawing.Point(10, 154);
            this.radComedy.Name = "radComedy";
            this.radComedy.Size = new System.Drawing.Size(63, 17);
            this.radComedy.TabIndex = 17;
            this.radComedy.TabStop = true;
            this.radComedy.Text = "Comedy";
            this.radComedy.UseVisualStyleBackColor = true;
            // 
            // radFantasy
            // 
            this.radFantasy.AutoSize = true;
            this.radFantasy.Location = new System.Drawing.Point(10, 177);
            this.radFantasy.Name = "radFantasy";
            this.radFantasy.Size = new System.Drawing.Size(62, 17);
            this.radFantasy.TabIndex = 18;
            this.radFantasy.TabStop = true;
            this.radFantasy.Text = "Fantasy";
            this.radFantasy.UseVisualStyleBackColor = true;
            // 
            // radHorror
            // 
            this.radHorror.AutoSize = true;
            this.radHorror.Location = new System.Drawing.Point(107, 108);
            this.radHorror.Name = "radHorror";
            this.radHorror.Size = new System.Drawing.Size(54, 17);
            this.radHorror.TabIndex = 19;
            this.radHorror.TabStop = true;
            this.radHorror.Text = "Horror";
            this.radHorror.UseVisualStyleBackColor = true;
            // 
            // radKids
            // 
            this.radKids.AutoSize = true;
            this.radKids.Location = new System.Drawing.Point(107, 131);
            this.radKids.Name = "radKids";
            this.radKids.Size = new System.Drawing.Size(45, 17);
            this.radKids.TabIndex = 20;
            this.radKids.TabStop = true;
            this.radKids.Text = "Kids";
            this.radKids.UseVisualStyleBackColor = true;
            // 
            // radSciFi
            // 
            this.radSciFi.AutoSize = true;
            this.radSciFi.Location = new System.Drawing.Point(107, 154);
            this.radSciFi.Name = "radSciFi";
            this.radSciFi.Size = new System.Drawing.Size(51, 17);
            this.radSciFi.TabIndex = 21;
            this.radSciFi.TabStop = true;
            this.radSciFi.Text = "Sci-Fi";
            this.radSciFi.UseVisualStyleBackColor = true;
            // 
            // gBoxAvalible
            // 
            this.gBoxAvalible.Controls.Add(this.txtIsAvalible);
            this.gBoxAvalible.Location = new System.Drawing.Point(384, 12);
            this.gBoxAvalible.Name = "gBoxAvalible";
            this.gBoxAvalible.Size = new System.Drawing.Size(126, 72);
            this.gBoxAvalible.TabIndex = 7;
            this.gBoxAvalible.TabStop = false;
            this.gBoxAvalible.Text = "Is this movie avalible?";
            // 
            // txtIsAvalible
            // 
            this.txtIsAvalible.Location = new System.Drawing.Point(6, 37);
            this.txtIsAvalible.Name = "txtIsAvalible";
            this.txtIsAvalible.Size = new System.Drawing.Size(100, 20);
            this.txtIsAvalible.TabIndex = 0;
            // 
            // frmRentalOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 375);
            this.Controls.Add(this.gBoxAvalible);
            this.Controls.Add(this.gBoxRental);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturnMovie);
            this.Controls.Add(this.btnReserveMovie);
            this.Name = "frmRentalOptions";
            this.Text = "frmRentalOptions";
            this.gBoxRental.ResumeLayout(false);
            this.gBoxRental.PerformLayout();
            this.gBoxAvalible.ResumeLayout(false);
            this.gBoxAvalible.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReserveMovie;
        private System.Windows.Forms.Button btnReturnMovie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBoxRental;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.RadioButton radNCST;
        private System.Windows.Forms.RadioButton radR;
        private System.Windows.Forms.RadioButton radPGTT;
        private System.Windows.Forms.RadioButton radPG;
        private System.Windows.Forms.RadioButton radG;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radHorror;
        private System.Windows.Forms.RadioButton radFantasy;
        private System.Windows.Forms.RadioButton radComedy;
        private System.Windows.Forms.RadioButton radAdventure;
        private System.Windows.Forms.RadioButton radAction;
        private System.Windows.Forms.RadioButton radSciFi;
        private System.Windows.Forms.RadioButton radKids;
        private System.Windows.Forms.GroupBox gBoxAvalible;
        private System.Windows.Forms.TextBox txtIsAvalible;

    }
}