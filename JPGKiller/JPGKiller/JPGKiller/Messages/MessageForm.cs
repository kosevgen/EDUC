using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPGKiller.Messages
{
    public partial class MessageForm : Form
    {
        private string imageForMessageForm = "1";
        private string message;
        private string font = "Times New Roman";
        private float fontSize = (float)12.0;
        string imagePath;

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
                imagePath = "C:\\Users\\e.kos\\source\\repos\\C-Sharp\\EDUC\\JPGKiller\\JPGKiller\\JPGKiller\\Resources\\success.bmp";
            }
            else if(succInfoError == "1")
            {
                imagePath = "C:\\Users\\e.kos\\source\\repos\\C-Sharp\\EDUC\\JPGKiller\\JPGKiller\\JPGKiller\\Resources\\info.bmp";
            }
            else if(succInfoError == "2")
            {
                imagePath = "C:\\Users\\e.kos\\source\\repos\\C-Sharp\\EDUC\\JPGKiller\\JPGKiller\\JPGKiller\\Resources\\error404.bmp";
            }
            try
            {
                pictureBox.Image = new Bitmap(imagePath);
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
