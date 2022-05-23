
namespace MenaxhimiKafiteris.UserForms
{
    partial class mainKamarier
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
            this.button1 = new System.Windows.Forms.Button();
            this.kamarierInfoTxt = new System.Windows.Forms.Label();
            this.dgPorosite = new System.Windows.Forms.DataGridView();
            this.btnPaguajPorosin = new System.Windows.Forms.Button();
            this.lblKamarieri = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPorosite)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Shto Porosi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kamarierInfoTxt
            // 
            this.kamarierInfoTxt.AutoSize = true;
            this.kamarierInfoTxt.Location = new System.Drawing.Point(52, 44);
            this.kamarierInfoTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kamarierInfoTxt.Name = "kamarierInfoTxt";
            this.kamarierInfoTxt.Size = new System.Drawing.Size(67, 16);
            this.kamarierInfoTxt.TabIndex = 2;
            this.kamarierInfoTxt.Text = "Kamarieri:";
            // 
            // dgPorosite
            // 
            this.dgPorosite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPorosite.Location = new System.Drawing.Point(32, 82);
            this.dgPorosite.Name = "dgPorosite";
            this.dgPorosite.RowHeadersWidth = 51;
            this.dgPorosite.RowTemplate.Height = 24;
            this.dgPorosite.Size = new System.Drawing.Size(691, 324);
            this.dgPorosite.TabIndex = 3;
            // 
            // btnPaguajPorosin
            // 
            this.btnPaguajPorosin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaguajPorosin.Location = new System.Drawing.Point(484, 413);
            this.btnPaguajPorosin.Margin = new System.Windows.Forms.Padding(4);
            this.btnPaguajPorosin.Name = "btnPaguajPorosin";
            this.btnPaguajPorosin.Size = new System.Drawing.Size(217, 59);
            this.btnPaguajPorosin.TabIndex = 4;
            this.btnPaguajPorosin.Text = "Paguaj Porosin";
            this.btnPaguajPorosin.UseVisualStyleBackColor = true;
            this.btnPaguajPorosin.Click += new System.EventHandler(this.btnPaguajPorosin_Click);
            // 
            // lblKamarieri
            // 
            this.lblKamarieri.AutoSize = true;
            this.lblKamarieri.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKamarieri.Location = new System.Drawing.Point(153, 44);
            this.lblKamarieri.Name = "lblKamarieri";
            this.lblKamarieri.Size = new System.Drawing.Size(0, 20);
            this.lblKamarieri.TabIndex = 5;
            // 
            // mainKamarier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 495);
            this.Controls.Add(this.lblKamarieri);
            this.Controls.Add(this.btnPaguajPorosin);
            this.Controls.Add(this.dgPorosite);
            this.Controls.Add(this.kamarierInfoTxt);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainKamarier";
            this.Text = "mainKamarier";
            ((System.ComponentModel.ISupportInitialize)(this.dgPorosite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kamarierInfoTxt;
        private System.Windows.Forms.DataGridView dgPorosite;
        private System.Windows.Forms.Button btnPaguajPorosin;
        private System.Windows.Forms.Label lblKamarieri;
    }
}