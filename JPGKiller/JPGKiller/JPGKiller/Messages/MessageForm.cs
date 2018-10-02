using System;
using System.Drawing;
using System.Windows.Forms;

namespace JPGKiller.Messages
{
    public partial class MessageForm : Form
    {
        private string imageForMessageForm = "1";
        private string font = "Times New Roman";
        private float fontSize = (float)12.0;
        Bitmap imagePath;

        public MessageForm( string setMessages, string setImage, float setFontSize, string setFont)
        {
            InitializeComponent();
            setTexBox(setMessages, setFont, setFontSize);
            attachPicture(setImage);
        }

        public MessageForm(string setMessages, string setImage, float setFontSize)
        {
            InitializeComponent();
            setTexBox(setMessages, font, setFontSize);
            attachPicture(setImage);
        }

        public MessageForm(string setMessages, string setImage)
        {
            InitializeComponent();
            setTexBox(setMessages, font, fontSize);
            attachPicture(setImage);
        }

        public MessageForm(string setMessages)
        {
            InitializeComponent();
            setTexBox(setMessages, font, fontSize);
            attachPicture(imageForMessageForm);
        }

        public MessageForm()
        {
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool setTexBox(string mess, string setF, float fontSize)
        {
            try
            {
                textBoxMess.Font = new Font(setF, fontSize);
                textBoxMess.AppendText(mess);
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool attachPicture(string succInfoError)
        {
            if(succInfoError == "0")
            {
                imagePath = Properties.Resources.success;
            }
            else if(succInfoError == "1")
            {
                imagePath = Properties.Resources.success;
            }
            else if(succInfoError == "2")
            {
                imagePath = Properties.Resources.error404;
            }
            try
            {
                pictureBox.Image = imagePath;
                pictureBox.Show();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
