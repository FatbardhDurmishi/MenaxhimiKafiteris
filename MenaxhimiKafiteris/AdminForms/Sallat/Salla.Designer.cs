
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgSallat = new Krypton.Toolkit.KryptonDataGridView();
            this.btnFshij = new Krypton.Toolkit.KryptonButton();
            this.emri = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmri = new Krypton.Toolkit.KryptonTextBox();
            this.txtnrTavolinat = new Krypton.Toolkit.KryptonTextBox();
            this.btnShto = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSallat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSallat
            // 
            this.dgSallat.ColumnHeadersHeight = 36;
            this.dgSallat.Location = new System.Drawing.Point(26, 31);
            this.dgSallat.Name = "dgSallat";
            this.dgSallat.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSallat.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgSallat.RowTemplate.Height = 24;
            this.dgSallat.Size = new System.Drawing.Size(503, 296);
            this.dgSallat.TabIndex = 43;
            // 
            // btnFshij
            // 
            this.btnFshij.Location = new System.Drawing.Point(254, 488);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(148, 25);
            this.btnFshij.TabIndex = 44;
            this.btnFshij.Values.Text = "Fshij";
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // emri
            // 
            this.emri.AutoSize = true;
            this.emri.ForeColor = System.Drawing.SystemColors.Control;
            this.emri.Location = new System.Drawing.Point(47, 374);
            this.emri.Name = "emri";
            this.emri.Size = new System.Drawing.Size(34, 16);
            this.emri.TabIndex = 46;
            this.emri.Text = "Emri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(47, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Numri Tavolinave";
            // 
            // txtEmri
            // 
            this.txtEmri.Location = new System.Drawing.Point(197, 374);
            this.txtEmri.Name = "txtEmri";
            this.txtEmri.Size = new System.Drawing.Size(140, 27);
            this.txtEmri.TabIndex = 48;
            // 
            // txtnrTavolinat
            // 
            this.txtnrTavolinat.Location = new System.Drawing.Point(197, 410);
            this.txtnrTavolinat.Name = "txtnrTavolinat";
            this.txtnrTavolinat.Size = new System.Drawing.Size(140, 27);
            this.txtnrTavolinat.TabIndex = 49;
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(50, 488);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(123, 25);
            this.btnShto.TabIndex = 50;
            this.btnShto.Values.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // Salla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(833, 604);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtnrTavolinat);
            this.Controls.Add(this.txtEmri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emri);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.dgSallat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Salla";
            this.Text = "Salla";
            ((System.ComponentModel.ISupportInitialize)(this.dgSallat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgSallat;
        private Krypton.Toolkit.KryptonButton btnFshij;
        private System.Windows.Forms.Label emri;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtEmri;
        private Krypton.Toolkit.KryptonTextBox txtnrTavolinat;
        private Krypton.Toolkit.KryptonButton btnShto;
    }
}