using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace MenaxhimiKafiteris.AdminForms
{
    public partial class mainAdmin : Form
    {
        //create them here, initiate on start
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public mainAdmin()
        {
            //Initiate 
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            //Start datetime. On form, the object from toolbox gets the time
            timer1.Start();
        }

        private void mainAdmin_Load(object sender, EventArgs e)
        {

        }

        //Structs for colors themes. They correspond to pannel buttons.
        //in c# struct represent data strucutres. Dmth values
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(146, 121, 88);
            public static Color color8 = Color.FromArgb(184, 222, 213);
        }


        //This method is active when we click the pannel button
        //Accepts 3 parameters. The object, A color(struct), and text
        //The color determines what color to change on click
        //Text changes the head-pannel name corresponding to it
        private void ActivateButton(object senderBtn, Color color, String text)
        {
            //If we clicked smth
            if (senderBtn != null)
            {
                //Disables the previous clicked one
                DisableButton();

                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Head-pannel child. Change icon corresponding to what we clicked
                iconCurrentChild.IconChar = currentBtn.IconChar;
                iconCurrentChild.IconColor = color;
                labelCurrentChild.Text = text;
            }
        }

        //Disable the button from active state.
        //All buttons on disabled state have same properties
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //Reset used on clicking the icon. It resets the events of pannel and its buttons
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.MediumPurple;
            labelCurrentChild.Text = "Home";
        }
        //Events
        //Reset


        //Open new form based on the buttons
        private void OpenChildForm(Form childForm)
        {
            //open only form. Close the previous one if is not null
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            //Fill all space there
            childForm.Dock = DockStyle.Fill;

            //panel on adding the form.
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Give the ability to move the 
        //Drag Form on upper-pannel
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        //go back to home by clicking on picture left-top
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reset();
            currentChildForm.Close();
        }

        //Open new forms corresponding to the button.
        private void produktetButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1, "Produktet");
            OpenChildForm(new produktetForm());
        }

        private void perbersitButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2, "Perberesi");
            OpenChildForm(new Perberesit.Perberesi());
        }

        private void stokuButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3, "Stoku");
            OpenChildForm(new produktetForm());
        }

        private void porositeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4, "Porosite");
            OpenChildForm(new Porosite());
        }

        private void llojetProdukteveButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5, "Llojet e produkteve");
            OpenChildForm(new LLojet.Llojet());
        }

        private void sallatButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6, "Sallat");
            OpenChildForm(new Sallat.Salla());
        }

        private void tavolinatButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7, "Tavolinat");
            OpenChildForm(new Tavolinat.tavolina());
        }

        private void raportetButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color8, "Raportet");
        }

        //Timer object. Display on label the date.
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.timeLabel.Text = datetime.ToString();
        }

      
    }
}
