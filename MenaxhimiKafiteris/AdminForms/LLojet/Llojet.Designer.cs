﻿
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
            this.button9 = new System.Windows.Forms.Button();
            this.llojiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.llojetDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            this.deleteLLojinBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llojetDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(64, 377);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 23);
            this.button9.TabIndex = 29;
            this.button9.Text = "Shto ";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // llojiTextBox
            // 
            this.llojiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llojiTextBox.Location = new System.Drawing.Point(138, 307);
            this.llojiTextBox.Name = "llojiTextBox";
            this.llojiTextBox.Size = new System.Drawing.Size(100, 24);
            this.llojiTextBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(61, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
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
            this.llojetDataGrid.Location = new System.Drawing.Point(64, 32);
            this.llojetDataGrid.Name = "llojetDataGrid";
            this.llojetDataGrid.Size = new System.Drawing.Size(377, 254);
            this.llojetDataGrid.TabIndex = 30;
            // 
            // deleteLLojinBtn
            // 
            this.deleteLLojinBtn.Location = new System.Drawing.Point(184, 377);
            this.deleteLLojinBtn.Name = "deleteLLojinBtn";
            this.deleteLLojinBtn.Size = new System.Drawing.Size(90, 25);
            this.deleteLLojinBtn.TabIndex = 31;
            this.deleteLLojinBtn.Values.Text = "Delete";
            this.deleteLLojinBtn.Click += new System.EventHandler(this.deleteLLojinBtn_Click);
            // 
            // Llojet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(546, 507);
            this.Controls.Add(this.deleteLLojinBtn);
            this.Controls.Add(this.llojetDataGrid);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.llojiTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Llojet";
            this.Text = "Llojet";
            this.Load += new System.EventHandler(this.Llojet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llojetDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox llojiTextBox;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Krypton.Toolkit.KryptonDataGridView llojetDataGrid;
        private Krypton.Toolkit.KryptonButton deleteLLojinBtn;
    }
}