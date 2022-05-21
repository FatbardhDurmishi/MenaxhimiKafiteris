
namespace MenaxhimiKafiteris.AdminForms.Staffi
{
    partial class Stafi
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
            this.dgStafi = new Krypton.Toolkit.KryptonDataGridView();
            this.shtoStaffBtn = new Krypton.Toolkit.KryptonButton();
            this.deleteStafBtn = new Krypton.Toolkit.KryptonButton();
            this.btnShtoStaff = new Krypton.Toolkit.KryptonButton();
            this.btnFshijStaff = new Krypton.Toolkit.KryptonButton();
            this.btnUpdateUser = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgStafi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStafi
            // 
            this.dgStafi.ColumnHeadersHeight = 36;
            this.dgStafi.Location = new System.Drawing.Point(17, 11);
            this.dgStafi.Name = "dgStafi";
            this.dgStafi.RowHeadersWidth = 51;
            this.dgStafi.Size = new System.Drawing.Size(669, 390);
            this.dgStafi.TabIndex = 0;
            // 
            // shtoStaffBtn
            // 
            this.shtoStaffBtn.Location = new System.Drawing.Point(70, 482);
            this.shtoStaffBtn.Name = "shtoStaffBtn";
            this.shtoStaffBtn.Size = new System.Drawing.Size(90, 25);
            this.shtoStaffBtn.TabIndex = 1;
            this.shtoStaffBtn.Values.Text = "Shto";
            this.shtoStaffBtn.Click += new System.EventHandler(this.shtoStaffBtn_Click);
            // 
            // deleteStafBtn
            // 
            this.deleteStafBtn.Location = new System.Drawing.Point(255, 482);
            this.deleteStafBtn.Name = "deleteStafBtn";
            this.deleteStafBtn.Size = new System.Drawing.Size(90, 25);
            this.deleteStafBtn.TabIndex = 2;
            this.deleteStafBtn.Values.Text = "Delete";
            // 
            // btnShtoStaff
            // 
            this.btnShtoStaff.AutoSize = true;
            this.btnShtoStaff.Location = new System.Drawing.Point(17, 417);
            this.btnShtoStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShtoStaff.Name = "btnShtoStaff";
            this.btnShtoStaff.Size = new System.Drawing.Size(108, 22);
            this.btnShtoStaff.TabIndex = 3;
            this.btnShtoStaff.Values.Text = "Shto Staff";
            this.btnShtoStaff.Click += new System.EventHandler(this.btnShtoStaff_Click);
            // 
            // btnFshijStaff
            // 
            this.btnFshijStaff.AutoSize = true;
            this.btnFshijStaff.Location = new System.Drawing.Point(177, 417);
            this.btnFshijStaff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFshijStaff.Name = "btnFshijStaff";
            this.btnFshijStaff.Size = new System.Drawing.Size(87, 22);
            this.btnFshijStaff.TabIndex = 4;
            this.btnFshijStaff.Values.Text = "Fshij Staff";
            this.btnFshijStaff.Click += new System.EventHandler(this.btnFshijStaff_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.AutoSize = true;
            this.btnUpdateUser.Location = new System.Drawing.Point(310, 417);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(97, 22);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Values.Text = "Perditeso Userin";
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // Stafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(755, 562);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnFshijStaff);
            this.Controls.Add(this.btnShtoStaff);
            this.Controls.Add(this.deleteStafBtn);
            this.Controls.Add(this.shtoStaffBtn);
            this.Controls.Add(this.dgStafi);
            this.Name = "Stafi";
            this.Text = "Stafi";
            ((System.ComponentModel.ISupportInitialize)(this.dgStafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgStafi;
        private Krypton.Toolkit.KryptonButton shtoStaffBtn;
        private Krypton.Toolkit.KryptonButton deleteStafBtn;
        private Krypton.Toolkit.KryptonButton btnShtoStaff;
        private Krypton.Toolkit.KryptonButton btnFshijStaff;
        private Krypton.Toolkit.KryptonButton btnUpdateUser;
    }
}