
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
            this.dgProduktet = new Krypton.Toolkit.KryptonDataGridView();
            this.fshijProduktinBtn = new Krypton.Toolkit.KryptonButton();
            this.shtoProduktinBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduktet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduktet
            // 
            this.dgProduktet.ColumnHeadersHeight = 36;
            this.dgProduktet.Location = new System.Drawing.Point(61, 36);
            this.dgProduktet.Margin = new System.Windows.Forms.Padding(4);
            this.dgProduktet.Name = "dgProduktet";
            this.dgProduktet.RowHeadersWidth = 51;
            this.dgProduktet.Size = new System.Drawing.Size(864, 532);
            this.dgProduktet.TabIndex = 18;
            // 
            // fshijProduktinBtn
            // 
            this.fshijProduktinBtn.Location = new System.Drawing.Point(1017, 94);
            this.fshijProduktinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.fshijProduktinBtn.Name = "fshijProduktinBtn";
            this.fshijProduktinBtn.Size = new System.Drawing.Size(120, 31);
            this.fshijProduktinBtn.TabIndex = 19;
            this.fshijProduktinBtn.Values.Text = "Fshij";
            this.fshijProduktinBtn.Click += new System.EventHandler(this.fshijProduktinBtn_Click);
            // 
            // shtoProduktinBtn
            // 
            this.shtoProduktinBtn.Location = new System.Drawing.Point(1017, 183);
            this.shtoProduktinBtn.Margin = new System.Windows.Forms.Padding(4);
            this.shtoProduktinBtn.Name = "shtoProduktinBtn";
            this.shtoProduktinBtn.Size = new System.Drawing.Size(120, 31);
            this.shtoProduktinBtn.TabIndex = 20;
            this.shtoProduktinBtn.Values.Text = "Shto";
            this.shtoProduktinBtn.Click += new System.EventHandler(this.shtoProduktinBtn_Click);
            // 
            // produktetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1447, 617);
            this.Controls.Add(this.shtoProduktinBtn);
            this.Controls.Add(this.fshijProduktinBtn);
            this.Controls.Add(this.dgProduktet);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "produktetForm";
            this.Text = "produktetForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgProduktet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView dgProduktet;
        private Krypton.Toolkit.KryptonButton fshijProduktinBtn;
        private Krypton.Toolkit.KryptonButton shtoProduktinBtn;
    }
}