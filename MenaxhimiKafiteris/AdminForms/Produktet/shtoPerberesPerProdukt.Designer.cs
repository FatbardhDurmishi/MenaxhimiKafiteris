
namespace MenaxhimiKafiteris.AdminForms.Produktet
{
    partial class shtoPerberesPerProdukt
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
            this.dgPerbersit = new Krypton.Toolkit.KryptonDataGridView();
            this.btnShtoPerberes = new Krypton.Toolkit.KryptonButton();
            this.tbSasia = new System.Windows.Forms.TextBox();
            this.lblSasia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerbersit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPerbersit
            // 
            this.dgPerbersit.Location = new System.Drawing.Point(55, 35);
            this.dgPerbersit.Name = "dgPerbersit";
            this.dgPerbersit.Size = new System.Drawing.Size(366, 322);
            this.dgPerbersit.TabIndex = 0;
            // 
            // btnShtoPerberes
            // 
            this.btnShtoPerberes.Location = new System.Drawing.Point(66, 447);
            this.btnShtoPerberes.Name = "btnShtoPerberes";
            this.btnShtoPerberes.Size = new System.Drawing.Size(90, 25);
            this.btnShtoPerberes.TabIndex = 1;
            this.btnShtoPerberes.Values.Text = "Shto";
            this.btnShtoPerberes.Click += new System.EventHandler(this.btnShtoPerberes_Click);
            // 
            // tbSasia
            // 
            this.tbSasia.Location = new System.Drawing.Point(174, 392);
            this.tbSasia.Name = "tbSasia";
            this.tbSasia.Size = new System.Drawing.Size(100, 20);
            this.tbSasia.TabIndex = 3;
            // 
            // lblSasia
            // 
            this.lblSasia.AutoSize = true;
            this.lblSasia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSasia.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSasia.Location = new System.Drawing.Point(63, 396);
            this.lblSasia.Name = "lblSasia";
            this.lblSasia.Size = new System.Drawing.Size(43, 16);
            this.lblSasia.TabIndex = 4;
            this.lblSasia.Text = "Sasia";
            // 
            // shtoPerberesPerProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(462, 558);
            this.Controls.Add(this.lblSasia);
            this.Controls.Add(this.tbSasia);
            this.Controls.Add(this.btnShtoPerberes);
            this.Controls.Add(this.dgPerbersit);
            this.Name = "shtoPerberesPerProdukt";
            this.Text = "shtoPerberesPerProdukt";
            ((System.ComponentModel.ISupportInitialize)(this.dgPerbersit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgPerbersit;
        private Krypton.Toolkit.KryptonButton btnShtoPerberes;
        private System.Windows.Forms.TextBox tbSasia;
        private System.Windows.Forms.Label lblSasia;
    }
}