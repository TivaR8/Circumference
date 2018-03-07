namespace Circumference
{
    partial class frmCircumference
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtUsersInputBox = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblQuestionAnswer = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(369, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 68);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(173, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Enter the radius of the circle (in cm)";
            // 
            // txtUsersInputBox
            // 
            this.txtUsersInputBox.Location = new System.Drawing.Point(210, 68);
            this.txtUsersInputBox.Name = "txtUsersInputBox";
            this.txtUsersInputBox.Size = new System.Drawing.Size(100, 20);
            this.txtUsersInputBox.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(137, 127);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblQuestionAnswer
            // 
            this.lblQuestionAnswer.AutoSize = true;
            this.lblQuestionAnswer.Location = new System.Drawing.Point(43, 205);
            this.lblQuestionAnswer.Name = "lblQuestionAnswer";
            this.lblQuestionAnswer.Size = new System.Drawing.Size(109, 13);
            this.lblQuestionAnswer.TabIndex = 4;
            this.lblQuestionAnswer.Text = "The circumference is:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(210, 205);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(42, 13);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "Answer";
            // 
            // frmCircumference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 261);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestionAnswer);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtUsersInputBox);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmCircumference";
            this.Text = "Circumference By Tiva Rait";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtUsersInputBox;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblQuestionAnswer;
        private System.Windows.Forms.Label lblAnswer;
    }
}

