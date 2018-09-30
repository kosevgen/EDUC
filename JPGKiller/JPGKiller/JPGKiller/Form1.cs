using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JPGKiller
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Messages.MessageForm messageForm = new Messages.MessageForm("Test message!!! \nThis message creat a test program!!!");
            messageForm.Show();
            FileManager.GetDirectoryAndFilesInfo getDirectoryAndFilesInfo = new FileManager.GetDirectoryAndFilesInfo();
            getDirectoryAndFilesInfo.RunFileManager();
            Messages.MessageForm messageForm2 = new Messages.MessageForm("!!!Test image!!!", "0",(float)16.0, "Courier New");
            messageForm2.Show();
            //Thread thread1 = new Thread(new ThreadStart());
            //thread1.Name = "one";
            //thread1.Start();
            //Thread thread2 = new Thread(new ThreadStart());
            //thread2.Name = "two";
            //thread2.Start();
            //Thread thread3 = new Thread(new ThreadStart());
            //thread3.Name = "tree";
            //thread3.Start();
            //Thread thread4 = new Thread(new ThreadStart());
            //thread4.Name = "four";
            //thread4.Start();
        }
    }
}
