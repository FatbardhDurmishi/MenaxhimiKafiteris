
namespace MenaxhimiKafiteris.AdminForms
{
    partial class produktetForm
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
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emriiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmimiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sasiaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.llojiColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.Location = new System.Drawing.Point(105, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 16;
            this.button9.Text = "Shto";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(232, 360);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "Fshij";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emriiColumn,
            this.cmimiColumn,
            this.sasiaColumn,
            this.llojiColumn});
            this.dataGridView1.Location = new System.Drawing.Point(36, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 290);
            this.dataGridView1.TabIndex = 18;
            // 
            // emriiColumn
            // 
            this.emriiColumn.HeaderText = "Emri";
            this.emriiColumn.Name = "emriiColumn";
            // 
            // cmimiColumn
            // 
            this.cmimiColumn.HeaderText = "Cmimi";
            this.cmimiColumn.Name = "cmimiColumn";
            // 
            // sasiaColumn
            // 
            this.sasiaColumn.HeaderText = "Sasia";
            this.sasiaColumn.Name = "sasiaColumn";
            // 
            // llojiColumn
            // 
            this.llojiColumn.HeaderText = "Lloji";
            this.llojiColumn.Name = "llojiColumn";
            // 
            // produktetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Name = "produktetForm";
            this.Text = "produktetForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emriiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmimiColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sasiaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn llojiColumn;
    }
}