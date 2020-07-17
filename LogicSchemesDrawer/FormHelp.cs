using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicSchemesDrawer
{
    public partial class FormHelp : Form
    {
        public FormHelp(bool isDarkTheme)
        {
            InitializeComponent();
            if (isDarkTheme)
            {
                richTextBox.BackColor = Color.FromArgb(64, 64, 64);
                richTextBox.ForeColor = Color.White;
            }
            richTextBox.Text = File.ReadAllText(Directory.GetParent(
                Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName +
                @"\Help.txt", Encoding.GetEncoding(1251));
        }
    }
}
