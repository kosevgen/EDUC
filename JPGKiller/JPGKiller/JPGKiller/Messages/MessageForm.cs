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
        public MessageForm()
        {
            InitializeComponent();
            attachPicture();
        }
        public MessageForm( string mess)
        {
            InitializeComponent();
            setTexBox(mess);
            attachPicture();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {
            
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool setTexBox(string mess)
        {
            try
            {
                textBoxMess.Font = new Font("Times New Roman",(float)14.0);
                textBoxMess.AppendText(mess);
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool attachPicture()
        {
            try
            {
                
                pictureBox.Image = new Bitmap("C:\\Users\\e.kos\\source\\repos\\C-Sharp\\EDUC\\JPGKiller\\JPGKiller\\JPGKiller\\Resources\\error404.bmp");
                pictureBox.Show();
            }catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
