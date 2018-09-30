/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018-09-30
 * 时间: 13:30
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JoinLine
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			NewChildForm<JoinLineForm>();
		}
		
		void NewChildForm<T>() where T:Form,new()
		{
			new T{
				
				MdiParent=this
			}.Show();
		}

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox.AboutForm
            {

            }.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
