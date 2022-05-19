
namespace MenaxhimiKafiteris.AdminForms.Perberesit
{
    partial class Perberesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPerbersi = new Krypton.Toolkit.KryptonDataGridView();
            this.btnShto = new Krypton.Toolkit.KryptonButton();
            this.btnFshij = new Krypton.Toolkit.KryptonButton();
            this.txtPerbersi = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSasia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPerbersi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPerbersi
            // 
            this.dgPerbersi.ColumnHeadersHeight = 36;
            this.dgPerbersi.Location = new System.Drawing.Point(31, 26);
            this.dgPerbersi.Name = "dgPerbersi";
            this.dgPerbersi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPerbersi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPerbersi.RowTemplate.Height = 24;
            this.dgPerbersi.Size = new System.Drawing.Size(498, 303);
            this.dgPerbersi.TabIndex = 0;
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(49, 508);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(140, 25);
            this.btnShto.TabIndex = 1;
            this.btnShto.Values.Text = "Shto";
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click_1);
            // 
            // btnFshij
            // 
            this.btnFshij.Location = new System.Drawing.Point(259, 508);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(162, 25);
            this.btnFshij.TabIndex = 2;
            this.btnFshij.Values.Text = "Fshij";
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // txtPerbersi
            // 
            this.txtPerbersi.Location = new System.Drawing.Point(178, 375);
            this.txtPerbersi.Name = "txtPerbersi";
            this.txtPerbersi.Size = new System.Drawing.Size(154, 27);
            this.txtPerbersi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(46, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Perbersi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sasia";
            // 
            // txtSasia
            // 
            this.txtSasia.Location = new System.Drawing.Point(178, 432);
            this.txtSasia.Name = "txtSasia";
            this.txtSasia.Size = new System.Drawing.Size(154, 22);
            this.txtSasia.TabIndex = 6;
            // 
            // Perberesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(868, 610);
            this.Controls.Add(this.txtSasia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPerbersi);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.dgPerbersi);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Perberesi";
            this.Text = "Perberesit";
            ((System.ComponentModel.ISupportInitialize)(this.dgPerbersi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgPerbersi;
        private Krypton.Toolkit.KryptonButton btnShto;
        private Krypton.Toolkit.KryptonButton btnFshij;
        private Krypton.Toolkit.KryptonTextBox txtPerbersi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSasia;
    }
}