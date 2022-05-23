
namespace MenaxhimiKafiteris.AdminForms.Tavolinat
{
    partial class tavolina
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
            this.btnShto = new System.Windows.Forms.Button();
            this.dgTavolinat = new Krypton.Toolkit.KryptonDataGridView();
            this.btnFshij = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrUlseve = new Krypton.Toolkit.KryptonTextBox();
            this.cbSalla = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTavolinat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(53, 440);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(151, 28);
            this.btnShto.TabIndex = 33;
            this.btnShto.Text = "Shto";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // dgTavolinat
            // 
            this.dgTavolinat.ColumnHeadersHeight = 36;
            this.dgTavolinat.Location = new System.Drawing.Point(31, 28);
            this.dgTavolinat.Name = "dgTavolinat";
            this.dgTavolinat.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTavolinat.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTavolinat.RowTemplate.Height = 24;
            this.dgTavolinat.Size = new System.Drawing.Size(510, 254);
            this.dgTavolinat.TabIndex = 34;
            // 
            // btnFshij
            // 
            this.btnFshij.Location = new System.Drawing.Point(264, 440);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(169, 25);
            this.btnFshij.TabIndex = 35;
            this.btnFshij.Values.Text = "Fshij";
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(47, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Numri Ulseve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(50, 377);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Salla";
            // 
            // txtNrUlseve
            // 
            this.txtNrUlseve.Location = new System.Drawing.Point(203, 325);
            this.txtNrUlseve.Name = "txtNrUlseve";
            this.txtNrUlseve.Size = new System.Drawing.Size(139, 27);
            this.txtNrUlseve.TabIndex = 38;
            // 
            // cbSalla
            // 
            this.cbSalla.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSalla.DropDownWidth = 139;
            this.cbSalla.IntegralHeight = false;
            this.cbSalla.Location = new System.Drawing.Point(203, 377);
            this.cbSalla.Name = "cbSalla";
            this.cbSalla.Size = new System.Drawing.Size(139, 25);
            this.cbSalla.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbSalla.TabIndex = 39;
            // 
            // tavolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(740, 596);
            this.Controls.Add(this.cbSalla);
            this.Controls.Add(this.txtNrUlseve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFshij);
            this.Controls.Add(this.dgTavolinat);
            this.Controls.Add(this.btnShto);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tavolina";
            this.Text = "tavolina";
            ((System.ComponentModel.ISupportInitialize)(this.dgTavolinat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSalla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShto;
        private Krypton.Toolkit.KryptonDataGridView dgTavolinat;
        private Krypton.Toolkit.KryptonButton btnFshij;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox txtNrUlseve;
        private Krypton.Toolkit.KryptonComboBox cbSalla;
    }
}