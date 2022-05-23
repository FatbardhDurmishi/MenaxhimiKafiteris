
namespace MenaxhimiKafiteris.AdminForms
{
    partial class Porosite
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
            this.dgPorosite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPorosite)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPorosite
            // 
            this.dgPorosite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPorosite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPorosite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgPorosite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPorosite.Location = new System.Drawing.Point(22, 32);
            this.dgPorosite.Name = "dgPorosite";
            this.dgPorosite.RowHeadersWidth = 51;
            this.dgPorosite.RowTemplate.Height = 24;
            this.dgPorosite.Size = new System.Drawing.Size(1231, 554);
            this.dgPorosite.TabIndex = 0;
            // 
            // Porosite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1279, 618);
            this.Controls.Add(this.dgPorosite);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Porosite";
            this.Text = "Porosite";
            ((System.ComponentModel.ISupportInitialize)(this.dgPorosite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPorosite;
    }
}