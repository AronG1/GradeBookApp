namespace GradeBookApp
{
    partial class UserControl_Classes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_BackToStartingForm = new System.Windows.Forms.Button();
            this.btn_ChooseCourse = new System.Windows.Forms.Button();
            this.btn_AddNewCourse = new System.Windows.Forms.Button();
            this.btn_DeleteCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_BackToStartingForm
            // 
            this.btn_BackToStartingForm.Location = new System.Drawing.Point(624, 343);
            this.btn_BackToStartingForm.Name = "btn_BackToStartingForm";
            this.btn_BackToStartingForm.Size = new System.Drawing.Size(125, 40);
            this.btn_BackToStartingForm.TabIndex = 0;
            this.btn_BackToStartingForm.Text = "Back";
            this.btn_BackToStartingForm.UseVisualStyleBackColor = true;
            this.btn_BackToStartingForm.Click += new System.EventHandler(this.btn_BackToStartingForm_Click);
            // 
            // btn_ChooseCourse
            // 
            this.btn_ChooseCourse.Location = new System.Drawing.Point(110, 76);
            this.btn_ChooseCourse.Name = "btn_ChooseCourse";
            this.btn_ChooseCourse.Size = new System.Drawing.Size(317, 47);
            this.btn_ChooseCourse.TabIndex = 1;
            this.btn_ChooseCourse.Text = "Choose course";
            this.btn_ChooseCourse.UseVisualStyleBackColor = true;
            // 
            // btn_AddNewCourse
            // 
            this.btn_AddNewCourse.Location = new System.Drawing.Point(110, 129);
            this.btn_AddNewCourse.Name = "btn_AddNewCourse";
            this.btn_AddNewCourse.Size = new System.Drawing.Size(317, 47);
            this.btn_AddNewCourse.TabIndex = 2;
            this.btn_AddNewCourse.Text = "Add new course";
            this.btn_AddNewCourse.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteCourse
            // 
            this.btn_DeleteCourse.Location = new System.Drawing.Point(110, 182);
            this.btn_DeleteCourse.Name = "btn_DeleteCourse";
            this.btn_DeleteCourse.Size = new System.Drawing.Size(317, 47);
            this.btn_DeleteCourse.TabIndex = 3;
            this.btn_DeleteCourse.Text = "Delete course";
            this.btn_DeleteCourse.UseVisualStyleBackColor = true;
            // 
            // UserControl_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btn_DeleteCourse);
            this.Controls.Add(this.btn_AddNewCourse);
            this.Controls.Add(this.btn_ChooseCourse);
            this.Controls.Add(this.btn_BackToStartingForm);
            this.Name = "UserControl_Classes";
            this.Size = new System.Drawing.Size(762, 395);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_BackToStartingForm;
        private System.Windows.Forms.Button btn_ChooseCourse;
        private System.Windows.Forms.Button btn_AddNewCourse;
        private System.Windows.Forms.Button btn_DeleteCourse;
    }
}
