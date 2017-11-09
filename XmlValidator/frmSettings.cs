using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlValidator
{
    public partial class frmSettings : Form
    {
        private Font myFont;

        public frmSettings(Font font)
        {
            InitializeComponent();
            setFont(font);
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                setFont(fontDialog1.Font);
            }
        }

        private void setFont(Font font)
        {
            myFont = font;
            txtFont.Text = myFont.Name;
            txtFont.Font = myFont;
        }

        public Font getFont()
        {
            return myFont;
        }
    }
}
