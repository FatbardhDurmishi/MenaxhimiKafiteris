
namespace MenaxhimiKafiteris.AdminForms.Staffi
{
    partial class ShtoStaff
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
            this.shtoStaffUsernameTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shtoStaffPasswordextBox = new Krypton.Toolkit.KryptonTextBox();
            this.shtoStaffGenderTextBox = new Krypton.Toolkit.KryptonTextBox();
            this.roliDropDownBtn = new Krypton.Toolkit.KryptonDropButton();
            this.SuspendLayout();
            // 
            // shtoStaffUsernameTextBox
            // 
            this.shtoStaffUsernameTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.shtoStaffUsernameTextBox.Location = new System.Drawing.Point(161, 48);
            this.shtoStaffUsernameTextBox.Name = "shtoStaffUsernameTextBox";
            this.shtoStaffUsernameTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.shtoStaffUsernameTextBox.Size = new System.Drawing.Size(234, 20);
            this.shtoStaffUsernameTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.shtoStaffUsernameTextBox.TabIndex = 0;
            this.shtoStaffUsernameTextBox.Text = "kryptonTextBox1";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLbl.Location = new System.Drawing.Point(49, 54);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(49, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gjinia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(49, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roli";
            // 
            // shtoStaffPasswordextBox
            // 
            this.shtoStaffPasswordextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.shtoStaffPasswordextBox.Location = new System.Drawing.Point(161, 114);
            this.shtoStaffPasswordextBox.Name = "shtoStaffPasswordextBox";
            this.shtoStaffPasswordextBox.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.shtoStaffPasswordextBox.PasswordChar = '●';
            this.shtoStaffPasswordextBox.Size = new System.Drawing.Size(234, 20);
            this.shtoStaffPasswordextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.shtoStaffPasswordextBox.TabIndex = 5;
            this.shtoStaffPasswordextBox.Text = "kryptonTextBox2";
            this.shtoStaffPasswordextBox.UseSystemPasswordChar = true;
            // 
            // shtoStaffGenderTextBox
            // 
            this.shtoStaffGenderTextBox.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.shtoStaffGenderTextBox.Location = new System.Drawing.Point(161, 187);
            this.shtoStaffGenderTextBox.Name = "shtoStaffGenderTextBox";
            this.shtoStaffGenderTextBox.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.shtoStaffGenderTextBox.Size = new System.Drawing.Size(234, 20);
            this.shtoStaffGenderTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.shtoStaffGenderTextBox.TabIndex = 6;
            this.shtoStaffGenderTextBox.Text = "kryptonTextBox3";
            // 
            // roliDropDownBtn
            // 
            this.roliDropDownBtn.Location = new System.Drawing.Point(161, 241);
            this.roliDropDownBtn.Name = "roliDropDownBtn";
            this.roliDropDownBtn.Size = new System.Drawing.Size(90, 25);
            this.roliDropDownBtn.TabIndex = 7;
            this.roliDropDownBtn.Values.Text = "kryptonDropButton1";
            // 
            // ShtoStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roliDropDownBtn);
            this.Controls.Add(this.shtoStaffGenderTextBox);
            this.Controls.Add(this.shtoStaffPasswordextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.shtoStaffUsernameTextBox);
            this.Name = "ShtoStaff";
            this.Text = "ShtoStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox shtoStaffUsernameTextBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox shtoStaffPasswordextBox;
        private Krypton.Toolkit.KryptonTextBox shtoStaffGenderTextBox;
        private Krypton.Toolkit.KryptonDropButton roliDropDownBtn;
    }
}