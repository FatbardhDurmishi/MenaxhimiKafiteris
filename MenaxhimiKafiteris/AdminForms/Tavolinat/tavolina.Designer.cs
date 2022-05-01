
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tavolinaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrKarrigeveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sallaIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tavolinaID,
            this.nrKarrigeveColumn,
            this.sallaIDColumn});
            this.dataGridView1.Location = new System.Drawing.Point(51, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(341, 249);
            this.dataGridView1.TabIndex = 32;
            // 
            // tavolinaID
            // 
            this.tavolinaID.HeaderText = "TavolinaID";
            this.tavolinaID.Name = "tavolinaID";
            // 
            // nrKarrigeveColumn
            // 
            this.nrKarrigeveColumn.HeaderText = "NrKarrigeve";
            this.nrKarrigeveColumn.Name = "nrKarrigeveColumn";
            // 
            // sallaIDColumn
            // 
            this.sallaIDColumn.HeaderText = "SallaID";
            this.sallaIDColumn.Name = "sallaIDColumn";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(51, 318);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 33;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // tavolina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(555, 484);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dataGridView1);
            this.Name = "tavolina";
            this.Text = "tavolina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tavolinaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrKarrigeveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sallaIDColumn;
        private System.Windows.Forms.Button button9;
    }
}