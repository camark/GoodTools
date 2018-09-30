using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoinLine.TextMsgBox
{
    public partial class MsgTextForm : Form
    {
        public MsgTextForm()
        {
            InitializeComponent();
        }

        public string msg { get; set; }
        private void MsgTextForm_Load(object sender, EventArgs e)
        {
            tbResult.Text = msg;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
