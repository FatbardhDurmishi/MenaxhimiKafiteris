
namespace MenaxhimiKafiteris.UserForms
{
    partial class krijoPorosi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lstProduktetEPorosise = new System.Windows.Forms.ListBox();
            this.btnFshij = new System.Windows.Forms.Button();
            this.txtCmimiTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBejPorosi = new System.Windows.Forms.Button();
            this.cbTavolina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(826, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // lstProduktetEPorosise
            // 
            this.lstProduktetEPorosise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstProduktetEPorosise.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProduktetEPorosise.FormatString = "C2";
            this.lstProduktetEPorosise.FormattingEnabled = true;
            this.lstProduktetEPorosise.ItemHeight = 20;
            this.lstProduktetEPorosise.Location = new System.Drawing.Point(28, 15);
            this.lstProduktetEPorosise.MultiColumn = true;
            this.lstProduktetEPorosise.Name = "lstProduktetEPorosise";
            this.lstProduktetEPorosise.Size = new System.Drawing.Size(331, 384);
            this.lstProduktetEPorosise.TabIndex = 1;
            this.lstProduktetEPorosise.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.FormatListaProduktev);
            // 
            // btnFshij
            // 
            this.btnFshij.Location = new System.Drawing.Point(28, 421);
            this.btnFshij.Name = "btnFshij";
            this.btnFshij.Size = new System.Drawing.Size(121, 49);
            this.btnFshij.TabIndex = 2;
            this.btnFshij.Text = "Fshij";
            this.btnFshij.UseVisualStyleBackColor = true;
            this.btnFshij.Click += new System.EventHandler(this.btnFshij_Click);
            // 
            // txtCmimiTotal
            // 
            this.txtCmimiTotal.Location = new System.Drawing.Point(205, 421);
            this.txtCmimiTotal.Multiline = true;
            this.txtCmimiTotal.Name = "txtCmimiTotal";
            this.txtCmimiTotal.Size = new System.Drawing.Size(140, 49);
            this.txtCmimiTotal.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 472);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFshij);
            this.panel2.Controls.Add(this.txtCmimiTotal);
            this.panel2.Controls.Add(this.lstProduktetEPorosise);
            this.panel2.Location = new System.Drawing.Point(875, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 483);
            this.panel2.TabIndex = 5;
            // 
            // btnBejPorosi
            // 
            this.btnBejPorosi.Location = new System.Drawing.Point(15, 491);
            this.btnBejPorosi.Name = "btnBejPorosi";
            this.btnBejPorosi.Size = new System.Drawing.Size(120, 40);
            this.btnBejPorosi.TabIndex = 6;
            this.btnBejPorosi.Text = "Bej Porosin";
            this.btnBejPorosi.UseVisualStyleBackColor = true;
            this.btnBejPorosi.Click += new System.EventHandler(this.btnBejPorosi_Click);
            // 
            // cbTavolina
            // 
            this.cbTavolina.FormattingEnabled = true;
            this.cbTavolina.Location = new System.Drawing.Point(274, 490);
            this.cbTavolina.Name = "cbTavolina";
            this.cbTavolina.Size = new System.Drawing.Size(127, 24);
            this.cbTavolina.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tavolina";
            // 
            // krijoPorosi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1296, 543);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTavolina);
            this.Controls.Add(this.btnBejPorosi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "krijoPorosi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "krijoPorosi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ListBox lstProduktetEPorosise;
        private System.Windows.Forms.Button btnFshij;
        private System.Windows.Forms.TextBox txtCmimiTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBejPorosi;
        private System.Windows.Forms.ComboBox cbTavolina;
        private System.Windows.Forms.Label label1;
    }
}