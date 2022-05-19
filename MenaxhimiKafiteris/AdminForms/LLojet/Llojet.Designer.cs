
namespace MenaxhimiKafiteris.AdminForms.LLojet
{
    partial class Llojet
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
            this.btnShto = new System.Windows.Forms.Button();
            this.llojiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.llojetDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            this.deleteLLojinBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llojetDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.Location = new System.Drawing.Point(85, 464);
            this.btnShto.Margin = new System.Windows.Forms.Padding(4);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(117, 28);
            this.btnShto.TabIndex = 29;
            this.btnShto.Text = "Shto ";
            this.btnShto.UseVisualStyleBackColor = true;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // llojiTextBox
            // 
            this.llojiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llojiTextBox.Location = new System.Drawing.Point(184, 378);
            this.llojiTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.llojiTextBox.Name = "llojiTextBox";
            this.llojiTextBox.Size = new System.Drawing.Size(132, 29);
            this.llojiTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 378);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lloji";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // llojetDataGrid
            // 
            this.llojetDataGrid.ColumnHeadersHeight = 36;
            this.llojetDataGrid.Location = new System.Drawing.Point(85, 39);
            this.llojetDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.llojetDataGrid.Name = "llojetDataGrid";
            this.llojetDataGrid.RowHeadersWidth = 51;
            this.llojetDataGrid.Size = new System.Drawing.Size(503, 313);
            this.llojetDataGrid.TabIndex = 30;
            // 
            // deleteLLojinBtn
            // 
            this.deleteLLojinBtn.Location = new System.Drawing.Point(276, 461);
            this.deleteLLojinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteLLojinBtn.Name = "deleteLLojinBtn";
            this.deleteLLojinBtn.Size = new System.Drawing.Size(139, 31);
            this.deleteLLojinBtn.TabIndex = 31;
            this.deleteLLojinBtn.Values.Text = "Fshij";
            this.deleteLLojinBtn.Click += new System.EventHandler(this.deleteLLojinBtn_Click);
            // 
            // Llojet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(728, 624);
            this.Controls.Add(this.deleteLLojinBtn);
            this.Controls.Add(this.llojetDataGrid);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.llojiTextBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Llojet";
            this.Text = "Llojet";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llojetDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.TextBox llojiTextBox;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Krypton.Toolkit.KryptonDataGridView llojetDataGrid;
        private Krypton.Toolkit.KryptonButton deleteLLojinBtn;
    }
}