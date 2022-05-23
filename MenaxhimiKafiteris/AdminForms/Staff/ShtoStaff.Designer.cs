
namespace MenaxhimiKafiteris.AdminForms.Staffi
{
    partial class ShtoStaff
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
            this.txtUsername = new Krypton.Toolkit.KryptonTextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordi = new Krypton.Toolkit.KryptonTextBox();
            this.btnRuaj = new Krypton.Toolkit.KryptonButton();
            this.txtGjinia = new Krypton.Toolkit.KryptonTextBox();
            this.cbRoli = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.cbRoli)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txtUsername.Location = new System.Drawing.Point(215, 59);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.txtUsername.Size = new System.Drawing.Size(312, 23);
            this.txtUsername.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtUsername.TabIndex = 0;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLbl.Location = new System.Drawing.Point(65, 66);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(70, 16);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(65, 149);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(65, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gjinia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(65, 311);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Roli";
            // 
            // txtPasswordi
            // 
            this.txtPasswordi.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.txtPasswordi.Location = new System.Drawing.Point(215, 140);
            this.txtPasswordi.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordi.Name = "txtPasswordi";
            this.txtPasswordi.PaletteMode = Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.txtPasswordi.PasswordChar = '●';
            this.txtPasswordi.Size = new System.Drawing.Size(312, 23);
            this.txtPasswordi.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPasswordi.TabIndex = 5;
            this.txtPasswordi.UseSystemPasswordChar = true;
            // 
            // btnRuaj
            // 
            this.btnRuaj.Location = new System.Drawing.Point(68, 406);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(90, 25);
            this.btnRuaj.TabIndex = 8;
            this.btnRuaj.Values.Text = "Ruaj";
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // txtGjinia
            // 
            this.txtGjinia.Location = new System.Drawing.Point(215, 223);
            this.txtGjinia.Name = "txtGjinia";
            this.txtGjinia.Size = new System.Drawing.Size(312, 27);
            this.txtGjinia.TabIndex = 9;
            // 
            // cbRoli
            // 
            this.cbRoli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoli.DropDownWidth = 157;
            this.cbRoli.IntegralHeight = false;
            this.cbRoli.Location = new System.Drawing.Point(215, 302);
            this.cbRoli.Name = "cbRoli";
            this.cbRoli.Size = new System.Drawing.Size(157, 25);
            this.cbRoli.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbRoli.TabIndex = 10;
            // 
            // ShtoStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.cbRoli);
            this.Controls.Add(this.txtGjinia);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.txtPasswordi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShtoStaff";
            this.Text = "ShtoStaff";
            ((System.ComponentModel.ISupportInitialize)(this.cbRoli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Krypton.Toolkit.KryptonTextBox txtPasswordi;
        private Krypton.Toolkit.KryptonButton btnRuaj;
        private Krypton.Toolkit.KryptonTextBox txtGjinia;
        private Krypton.Toolkit.KryptonComboBox cbRoli;
    }
}