
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emriColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sallaIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTavolinaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emriColumn,
            this.sallaIDColumn,
            this.nrTavolinaveColumn});
            this.dataGridView1.Location = new System.Drawing.Point(211, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 249);
            this.dataGridView1.TabIndex = 41;
            // 
            // emriColumn
            // 
            this.emriColumn.HeaderText = "Emri";
            this.emriColumn.Name = "emriColumn";
            // 
            // sallaIDColumn
            // 
            this.sallaIDColumn.HeaderText = "SallaID";
            this.sallaIDColumn.Name = "sallaIDColumn";
            // 
            // nrTavolinaveColumn
            // 
            this.nrTavolinaveColumn.HeaderText = "NrTavolina";
            this.nrTavolinaveColumn.Name = "nrTavolinaveColumn";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Location = new System.Drawing.Point(211, 336);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 42;
            this.button9.Text = "Shto";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // Salla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(625, 491);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Salla";
            this.Text = "Salla";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sallaIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTavolinaveColumn;
        private System.Windows.Forms.Button button9;
    }
}