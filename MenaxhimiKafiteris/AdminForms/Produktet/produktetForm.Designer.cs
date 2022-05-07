
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
            this.kryptonDataGridView1 = new Krypton.Toolkit.KryptonDataGridView();
            this.fshijProduktinBtn = new Krypton.Toolkit.KryptonButton();
            this.shtoProduktinBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonDataGridView1
            // 
            this.kryptonDataGridView1.Location = new System.Drawing.Point(46, 29);
            this.kryptonDataGridView1.Name = "kryptonDataGridView1";
            this.kryptonDataGridView1.Size = new System.Drawing.Size(459, 432);
            this.kryptonDataGridView1.TabIndex = 18;
            // 
            // fshijProduktinBtn
            // 
            this.fshijProduktinBtn.Location = new System.Drawing.Point(555, 90);
            this.fshijProduktinBtn.Name = "fshijProduktinBtn";
            this.fshijProduktinBtn.Size = new System.Drawing.Size(90, 25);
            this.fshijProduktinBtn.TabIndex = 19;
            this.fshijProduktinBtn.Values.Text = "Fshij";
            // 
            // shtoProduktinBtn
            // 
            this.shtoProduktinBtn.Location = new System.Drawing.Point(555, 169);
            this.shtoProduktinBtn.Name = "shtoProduktinBtn";
            this.shtoProduktinBtn.Size = new System.Drawing.Size(90, 25);
            this.shtoProduktinBtn.TabIndex = 20;
            this.shtoProduktinBtn.Values.Text = "Shto";
            // 
            // produktetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(798, 501);
            this.Controls.Add(this.shtoProduktinBtn);
            this.Controls.Add(this.fshijProduktinBtn);
            this.Controls.Add(this.kryptonDataGridView1);
            this.Name = "produktetForm";
            this.Text = "produktetForm";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kryptonDataGridView1;
        private Krypton.Toolkit.KryptonButton fshijProduktinBtn;
        private Krypton.Toolkit.KryptonButton shtoProduktinBtn;
    }
}