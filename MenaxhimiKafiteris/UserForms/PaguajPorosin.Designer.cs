namespace MenaxhimiKafiteris.UserForms
{
    partial class PaguajPorosin
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
            this.txtTotali = new System.Windows.Forms.TextBox();
            this.txtParatgatshme = new System.Windows.Forms.TextBox();
            this.txtKusuri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaguaj = new System.Windows.Forms.Button();
            this.btnLlogarit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTotali
            // 
            this.txtTotali.Location = new System.Drawing.Point(299, 132);
            this.txtTotali.Multiline = true;
            this.txtTotali.Name = "txtTotali";
            this.txtTotali.Size = new System.Drawing.Size(174, 33);
            this.txtTotali.TabIndex = 0;
            // 
            // txtParatgatshme
            // 
            this.txtParatgatshme.Location = new System.Drawing.Point(299, 189);
            this.txtParatgatshme.Multiline = true;
            this.txtParatgatshme.Name = "txtParatgatshme";
            this.txtParatgatshme.Size = new System.Drawing.Size(174, 29);
            this.txtParatgatshme.TabIndex = 1;
            // 
            // txtKusuri
            // 
            this.txtKusuri.Location = new System.Drawing.Point(299, 249);
            this.txtKusuri.Multiline = true;
            this.txtKusuri.Name = "txtKusuri";
            this.txtKusuri.Size = new System.Drawing.Size(174, 30);
            this.txtKusuri.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Totali";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Para te gatshme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Parate per tu kthyer";
            // 
            // btnPaguaj
            // 
            this.btnPaguaj.Location = new System.Drawing.Point(299, 329);
            this.btnPaguaj.Name = "btnPaguaj";
            this.btnPaguaj.Size = new System.Drawing.Size(174, 58);
            this.btnPaguaj.TabIndex = 6;
            this.btnPaguaj.Text = "Paguaj";
            this.btnPaguaj.UseVisualStyleBackColor = true;
            this.btnPaguaj.Click += new System.EventHandler(this.btnPaguaj_Click);
            // 
            // btnLlogarit
            // 
            this.btnLlogarit.Location = new System.Drawing.Point(519, 255);
            this.btnLlogarit.Name = "btnLlogarit";
            this.btnLlogarit.Size = new System.Drawing.Size(112, 31);
            this.btnLlogarit.TabIndex = 7;
            this.btnLlogarit.Text = "Llogarit";
            this.btnLlogarit.UseVisualStyleBackColor = true;
            this.btnLlogarit.Click += new System.EventHandler(this.btnLlogarit_Click);
            // 
            // PaguajPorosin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLlogarit);
            this.Controls.Add(this.btnPaguaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKusuri);
            this.Controls.Add(this.txtParatgatshme);
            this.Controls.Add(this.txtTotali);
            this.Name = "PaguajPorosin";
            this.Text = "PaguajPorosin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotali;
        private System.Windows.Forms.TextBox txtParatgatshme;
        private System.Windows.Forms.TextBox txtKusuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPaguaj;
        private System.Windows.Forms.Button btnLlogarit;
    }
}