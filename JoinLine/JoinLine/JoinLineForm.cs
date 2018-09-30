/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018-09-30
 * 时间: 13:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JoinLine
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class JoinLineForm : Form
	{
		public JoinLineForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void JoinLineLoad(object sender, EventArgs e)
		{
			tscbSplit.Items.AddRange(
				new [] {",","|"}
			);
			
			tscbSplit.SelectedIndex=0;

            tscbBaoguo.Items.AddRange(
                new [] {"\"","'",""}
                );

            tscbBaoguo.SelectedIndex = 0;
		}
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			var texts=from s in textBox1.Lines where s.Trim().Length>0 select s;

            if (texts.Count() > 0)
            {
                var target_Texts = from s in texts select tscbBaoguo.Text + s + tscbBaoguo.Text;

                String ret = String.Join(tscbSplit.Text, target_Texts);

                new TextMsgBox.MsgTextForm
                {
                    msg = ret
                }.ShowDialog();
            }
		}
	}
}
