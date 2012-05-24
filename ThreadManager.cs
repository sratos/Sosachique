using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2chReader
{
    public partial class ThreadManager : Form
    {
        public ThreadManager()
        {
            InitializeComponent();
        }

        private void tStart_Click(object sender, EventArgs e)
        {

            Thread2 t2 = new Thread2();
            t2.downloadThread(tSave.Text, false, false);
        }
    }
}
