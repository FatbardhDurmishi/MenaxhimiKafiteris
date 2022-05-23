
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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Krijo porosi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // kamarierInfoTxt
            // 
            this.kamarierInfoTxt.AutoSize = true;
            this.kamarierInfoTxt.Location = new System.Drawing.Point(39, 36);
            this.kamarierInfoTxt.Name = "kamarierInfoTxt";
            this.kamarierInfoTxt.Size = new System.Drawing.Size(77, 13);
            this.kamarierInfoTxt.TabIndex = 2;
            this.kamarierInfoTxt.Text = "Kamarier Infos:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 241);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Raporti i dites";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // mainKamarier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kamarierInfoTxt);
            this.Controls.Add(this.button1);
            this.Name = "mainKamarier";
            this.Text = "mainKamarier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label kamarierInfoTxt;
        private System.Windows.Forms.Button button2;
    }
}