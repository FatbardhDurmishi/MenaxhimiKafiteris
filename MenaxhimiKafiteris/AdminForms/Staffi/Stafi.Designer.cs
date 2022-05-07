
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
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.shtoStaffBtn = new Krypton.Toolkit.KryptonButton();
            this.deleteStafBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Location = new System.Drawing.Point(41, 12);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(669, 390);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // shtoStaffBtn
            // 
            this.shtoStaffBtn.Location = new System.Drawing.Point(70, 482);
            this.shtoStaffBtn.Name = "shtoStaffBtn";
            this.shtoStaffBtn.Size = new System.Drawing.Size(90, 25);
            this.shtoStaffBtn.TabIndex = 1;
            this.shtoStaffBtn.Values.Text = "Shto";
            // 
            // deleteStafBtn
            // 
            this.deleteStafBtn.Location = new System.Drawing.Point(255, 482);
            this.deleteStafBtn.Name = "deleteStafBtn";
            this.deleteStafBtn.Size = new System.Drawing.Size(90, 25);
            this.deleteStafBtn.TabIndex = 2;
            this.deleteStafBtn.Values.Text = "Delete";
            // 
            // Stafi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(755, 562);
            this.Controls.Add(this.deleteStafBtn);
            this.Controls.Add(this.shtoStaffBtn);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "Stafi";
            this.Text = "Stafi";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton shtoStaffBtn;
        private Krypton.Toolkit.KryptonButton deleteStafBtn;
    }
}