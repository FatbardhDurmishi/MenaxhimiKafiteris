
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PorosiaIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaliColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tvshColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tavolinaIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kamerieriColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PorosiaIDColumn,
            this.dateColumn,
            this.totaliColumn,
            this.tvshColumn,
            this.tavolinaIDColumn,
            this.kamerieriColumn});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 399);
            this.dataGridView1.TabIndex = 0;
            // 
            // PorosiaIDColumn
            // 
            this.PorosiaIDColumn.HeaderText = "PorosiaID";
            this.PorosiaIDColumn.Name = "PorosiaIDColumn";
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Data";
            this.dateColumn.Name = "dateColumn";
            // 
            // totaliColumn
            // 
            this.totaliColumn.HeaderText = "Totali";
            this.totaliColumn.Name = "totaliColumn";
            // 
            // tvshColumn
            // 
            this.tvshColumn.HeaderText = "TVSH";
            this.tvshColumn.Name = "tvshColumn";
            // 
            // tavolinaIDColumn
            // 
            this.tavolinaIDColumn.HeaderText = "Tavolina";
            this.tavolinaIDColumn.Name = "tavolinaIDColumn";
            // 
            // kamerieriColumn
            // 
            this.kamerieriColumn.HeaderText = "Kamarieri";
            this.kamerieriColumn.Name = "kamerieriColumn";
            // 
            // Porosite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(814, 502);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Porosite";
            this.Text = "Porosite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorosiaIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaliColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tvshColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tavolinaIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kamerieriColumn;
    }
}