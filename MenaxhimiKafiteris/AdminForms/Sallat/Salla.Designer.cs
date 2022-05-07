
namespace MenaxhimiKafiteris.AdminForms.Sallat
{
    partial class Salla
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
            this.shtoSallBtn = new Krypton.Toolkit.KryptonButton();
            this.tbEmriSalla = new Krypton.Toolkit.KryptonTextBox();
            this.tbNumriKarrigaveSalla = new Krypton.Toolkit.KryptonTextBox();
            this.emriLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Location = new System.Drawing.Point(41, 29);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(447, 270);
            this.kryptonDataGridView1.TabIndex = 0;
            // 
            // shtoSallBtn
            // 
            this.shtoSallBtn.Location = new System.Drawing.Point(41, 456);
            this.shtoSallBtn.Name = "shtoSallBtn";
            this.shtoSallBtn.Size = new System.Drawing.Size(90, 25);
            this.shtoSallBtn.TabIndex = 1;
            this.shtoSallBtn.Values.Text = "Shto";
            // 
            // tbEmriSalla
            // 
            this.tbEmriSalla.Location = new System.Drawing.Point(197, 361);
            this.tbEmriSalla.Name = "tbEmriSalla";
            this.tbEmriSalla.Size = new System.Drawing.Size(100, 23);
            this.tbEmriSalla.TabIndex = 2;
            // 
            // tbNumriKarrigaveSalla
            // 
            this.tbNumriKarrigaveSalla.Location = new System.Drawing.Point(197, 399);
            this.tbNumriKarrigaveSalla.Name = "tbNumriKarrigaveSalla";
            this.tbNumriKarrigaveSalla.Size = new System.Drawing.Size(100, 23);
            this.tbNumriKarrigaveSalla.TabIndex = 3;
            // 
            // emriLabel
            // 
            this.emriLabel.AutoSize = true;
            this.emriLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emriLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.emriLabel.Location = new System.Drawing.Point(49, 361);
            this.emriLabel.Name = "emriLabel";
            this.emriLabel.Size = new System.Drawing.Size(35, 16);
            this.emriLabel.TabIndex = 5;
            this.emriLabel.Text = "Emri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nr.Karrigave";
            // 
            // Salla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(625, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emriLabel);
            this.Controls.Add(this.tbNumriKarrigaveSalla);
            this.Controls.Add(this.tbEmriSalla);
            this.Controls.Add(this.shtoSallBtn);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "Salla";
            this.Text = "Salla";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton shtoSallBtn;
        private Krypton.Toolkit.KryptonTextBox tbEmriSalla;
        private Krypton.Toolkit.KryptonTextBox tbNumriKarrigaveSalla;
        private System.Windows.Forms.Label emriLabel;
        private System.Windows.Forms.Label label1;
    }
}