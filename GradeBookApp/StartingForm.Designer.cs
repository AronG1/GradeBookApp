namespace GradeBookApp
{
    partial class StartingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingForm));
            this.btn_ExitApp = new System.Windows.Forms.Button();
            this.picBox_HeaderImage = new System.Windows.Forms.PictureBox();
            this.lbl_HeaderText = new System.Windows.Forms.Label();
            this.btn_ManageClasses = new System.Windows.Forms.Button();
            this.btn_NewStudent = new System.Windows.Forms.Button();
            this.btn_ChangeStudentProperties = new System.Windows.Forms.Button();
            this.btn_StudentWithdraw = new System.Windows.Forms.Button();
            this.panel_ProfessorInfo = new System.Windows.Forms.Panel();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.picBox_ProfessorPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_ProfessorFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ProfessorUniversity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ProfessorTitle = new System.Windows.Forms.Label();
            this.lbl_LoggedAsMsg = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.userControl_Classes1 = new GradeBookApp.UserControl_Classes();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HeaderImage)).BeginInit();
            this.panel_ProfessorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfessorPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ExitApp
            // 
            this.btn_ExitApp.Location = new System.Drawing.Point(847, 509);
            this.btn_ExitApp.Name = "btn_ExitApp";
            this.btn_ExitApp.Size = new System.Drawing.Size(125, 40);
            this.btn_ExitApp.TabIndex = 0;
            this.btn_ExitApp.Text = "Exit";
            this.btn_ExitApp.UseVisualStyleBackColor = true;
            this.btn_ExitApp.Click += new System.EventHandler(this.btn_ExitApp_Click);
            // 
            // picBox_HeaderImage
            // 
            this.picBox_HeaderImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.picBox_HeaderImage.Location = new System.Drawing.Point(-1, 0);
            this.picBox_HeaderImage.Name = "picBox_HeaderImage";
            this.picBox_HeaderImage.Size = new System.Drawing.Size(986, 168);
            this.picBox_HeaderImage.TabIndex = 1;
            this.picBox_HeaderImage.TabStop = false;
            // 
            // lbl_HeaderText
            // 
            this.lbl_HeaderText.AutoSize = true;
            this.lbl_HeaderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_HeaderText.Font = new System.Drawing.Font("Sitka Display", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_HeaderText.Location = new System.Drawing.Point(313, 34);
            this.lbl_HeaderText.Name = "lbl_HeaderText";
            this.lbl_HeaderText.Size = new System.Drawing.Size(333, 92);
            this.lbl_HeaderText.TabIndex = 2;
            this.lbl_HeaderText.Text = "Grade Book";
            // 
            // btn_ManageClasses
            // 
            this.btn_ManageClasses.Location = new System.Drawing.Point(329, 201);
            this.btn_ManageClasses.Name = "btn_ManageClasses";
            this.btn_ManageClasses.Size = new System.Drawing.Size(317, 47);
            this.btn_ManageClasses.TabIndex = 3;
            this.btn_ManageClasses.Text = "Classes";
            this.btn_ManageClasses.UseVisualStyleBackColor = true;
            this.btn_ManageClasses.Click += new System.EventHandler(this.btn_ManageClasses_Click);
            // 
            // btn_NewStudent
            // 
            this.btn_NewStudent.Location = new System.Drawing.Point(329, 254);
            this.btn_NewStudent.Name = "btn_NewStudent";
            this.btn_NewStudent.Size = new System.Drawing.Size(317, 47);
            this.btn_NewStudent.TabIndex = 4;
            this.btn_NewStudent.Text = "Enroll student";
            this.btn_NewStudent.UseVisualStyleBackColor = true;
            // 
            // btn_ChangeStudentProperties
            // 
            this.btn_ChangeStudentProperties.Location = new System.Drawing.Point(329, 307);
            this.btn_ChangeStudentProperties.Name = "btn_ChangeStudentProperties";
            this.btn_ChangeStudentProperties.Size = new System.Drawing.Size(317, 47);
            this.btn_ChangeStudentProperties.TabIndex = 5;
            this.btn_ChangeStudentProperties.Text = "Change student informations";
            this.btn_ChangeStudentProperties.UseVisualStyleBackColor = true;
            // 
            // btn_StudentWithdraw
            // 
            this.btn_StudentWithdraw.Location = new System.Drawing.Point(329, 360);
            this.btn_StudentWithdraw.Name = "btn_StudentWithdraw";
            this.btn_StudentWithdraw.Size = new System.Drawing.Size(317, 47);
            this.btn_StudentWithdraw.TabIndex = 6;
            this.btn_StudentWithdraw.Text = "Student withdraw";
            this.btn_StudentWithdraw.UseVisualStyleBackColor = true;
            // 
            // panel_ProfessorInfo
            // 
            this.panel_ProfessorInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_ProfessorInfo.Controls.Add(this.lbl_LoggedAsMsg);
            this.panel_ProfessorInfo.Controls.Add(this.lbl_ProfessorTitle);
            this.panel_ProfessorInfo.Controls.Add(this.label3);
            this.panel_ProfessorInfo.Controls.Add(this.lbl_ProfessorUniversity);
            this.panel_ProfessorInfo.Controls.Add(this.label2);
            this.panel_ProfessorInfo.Controls.Add(this.lbl_ProfessorFullName);
            this.panel_ProfessorInfo.Controls.Add(this.label1);
            this.panel_ProfessorInfo.Controls.Add(this.picBox_ProfessorPicture);
            this.panel_ProfessorInfo.Location = new System.Drawing.Point(-1, 167);
            this.panel_ProfessorInfo.Name = "panel_ProfessorInfo";
            this.panel_ProfessorInfo.Size = new System.Drawing.Size(227, 319);
            this.panel_ProfessorInfo.TabIndex = 7;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(12, 509);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(125, 40);
            this.btn_LogIn.TabIndex = 8;
            this.btn_LogIn.Text = "Log in";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            // 
            // picBox_ProfessorPicture
            // 
            this.picBox_ProfessorPicture.Image = ((System.Drawing.Image)(resources.GetObject("picBox_ProfessorPicture.Image")));
            this.picBox_ProfessorPicture.Location = new System.Drawing.Point(71, 53);
            this.picBox_ProfessorPicture.Name = "picBox_ProfessorPicture";
            this.picBox_ProfessorPicture.Size = new System.Drawing.Size(70, 70);
            this.picBox_ProfessorPicture.TabIndex = 0;
            this.picBox_ProfessorPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full name: ";
            // 
            // lbl_ProfessorFullName
            // 
            this.lbl_ProfessorFullName.AutoSize = true;
            this.lbl_ProfessorFullName.Location = new System.Drawing.Point(77, 146);
            this.lbl_ProfessorFullName.Name = "lbl_ProfessorFullName";
            this.lbl_ProfessorFullName.Size = new System.Drawing.Size(56, 13);
            this.lbl_ProfessorFullName.TabIndex = 2;
            this.lbl_ProfessorFullName.Text = "Pero Peric";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "University: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_ProfessorUniversity
            // 
            this.lbl_ProfessorUniversity.AutoSize = true;
            this.lbl_ProfessorUniversity.Location = new System.Drawing.Point(78, 172);
            this.lbl_ProfessorUniversity.Name = "lbl_ProfessorUniversity";
            this.lbl_ProfessorUniversity.Size = new System.Drawing.Size(45, 13);
            this.lbl_ProfessorUniversity.TabIndex = 4;
            this.lbl_ProfessorUniversity.Text = "Harvard";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title: ";
            // 
            // lbl_ProfessorTitle
            // 
            this.lbl_ProfessorTitle.AutoSize = true;
            this.lbl_ProfessorTitle.Location = new System.Drawing.Point(77, 199);
            this.lbl_ProfessorTitle.Name = "lbl_ProfessorTitle";
            this.lbl_ProfessorTitle.Size = new System.Drawing.Size(84, 13);
            this.lbl_ProfessorTitle.TabIndex = 6;
            this.lbl_ProfessorTitle.Text = "Senior Professor";
            // 
            // lbl_LoggedAsMsg
            // 
            this.lbl_LoggedAsMsg.AutoSize = true;
            this.lbl_LoggedAsMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_LoggedAsMsg.Location = new System.Drawing.Point(10, 21);
            this.lbl_LoggedAsMsg.Name = "lbl_LoggedAsMsg";
            this.lbl_LoggedAsMsg.Size = new System.Drawing.Size(79, 16);
            this.lbl_LoggedAsMsg.TabIndex = 7;
            this.lbl_LoggedAsMsg.Text = "Logged as: ";
            this.lbl_LoggedAsMsg.Click += new System.EventHandler(this.label4_Click);
            // 
            // userControl_Classes1
            // 
            this.userControl_Classes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userControl_Classes1.Location = new System.Drawing.Point(226, 169);
            this.userControl_Classes1.Name = "userControl_Classes1";
            this.userControl_Classes1.Size = new System.Drawing.Size(762, 395);
            this.userControl_Classes1.TabIndex = 9;
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.panel_ProfessorInfo);
            this.Controls.Add(this.btn_StudentWithdraw);
            this.Controls.Add(this.btn_ChangeStudentProperties);
            this.Controls.Add(this.btn_NewStudent);
            this.Controls.Add(this.btn_ManageClasses);
            this.Controls.Add(this.lbl_HeaderText);
            this.Controls.Add(this.picBox_HeaderImage);
            this.Controls.Add(this.btn_ExitApp);
            this.Controls.Add(this.userControl_Classes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Book";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_HeaderImage)).EndInit();
            this.panel_ProfessorInfo.ResumeLayout(false);
            this.panel_ProfessorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ProfessorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ExitApp;
        private System.Windows.Forms.PictureBox picBox_HeaderImage;
        private System.Windows.Forms.Label lbl_HeaderText;
        private System.Windows.Forms.Button btn_ManageClasses;
        private System.Windows.Forms.Button btn_NewStudent;
        private System.Windows.Forms.Button btn_ChangeStudentProperties;
        private System.Windows.Forms.Button btn_StudentWithdraw;
        private System.Windows.Forms.Panel panel_ProfessorInfo;
        private System.Windows.Forms.PictureBox picBox_ProfessorPicture;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ProfessorFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ProfessorTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ProfessorUniversity;
        private System.Windows.Forms.Label lbl_LoggedAsMsg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private UserControl_Classes userControl_Classes1;
    }
}

