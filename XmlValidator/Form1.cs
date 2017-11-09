using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace XmlValidator
{
    public partial class Form1 : Form
    {
        private Font m_Font = new Font("Arial", 12);

        public Form1()
        {
            InitializeComponent();
        }

        // ***********************************************************************************
        //
        //  TABBLAD 1 : VALIDATE
        //
        // ***********************************************************************************

        #region "tabblad 1"

        /// <summary>
        /// Select an XML file and start validation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectXML_Click(object sender, EventArgs e)
        {
            // Alleen zoeken naar xlm bestanden
            this.openFileDialog1.FileName = "*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtXML.Text = openFileDialog1.FileName;
                btnValidate_Click(null, null);
            }
            else return;
        }
                
        /// <summary>
        /// Start check
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = String.Empty;
            if (String.IsNullOrEmpty(txtXML.Text))
            {
                rtbOutput.AppendText(String.Format("Please select XML file!"), Color.Red, m_Font);
				rtbOutput.AppendText(Environment.NewLine);
                return;
            }
            startValidation();
        }

        /// <summary>
        /// Start validation
        /// </summary>
        private void startValidation()
        {
            XmlReaderSettings settings = new XmlReaderSettings()
            {
                ValidationType = ValidationType.DTD,
                DtdProcessing = DtdProcessing.Parse,
                IgnoreWhitespace = true,
                IgnoreComments = true
            };
            settings.XmlResolver = new XmlUrlResolver();
            settings.ValidationEventHandler += Settings_ValidationEventHandler;

            // Create the XmlReader object
            XmlReader reader = XmlReader.Create(txtXML.Text, settings);

            // Parse the file
            while (reader.Read())
            {
            //    rtbOutput.AppendText(String.Format("{0}, {1}, {2} \r\n", reader.NodeType, reader.Name, reader.Value), rtbOutput.ForeColor);
            }

            if (rtbOutput.Text.Equals(String.Empty))
            {
                rtbOutput.AppendText(String.Format("Validation successful"), Color.Green, m_Font);
				rtbOutput.AppendText(Environment.NewLine);
            }
        }

        /// <summary>
        /// Error found in XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Settings_ValidationEventHandler(object sender, System.Xml.Schema.ValidationEventArgs e)
        {
            string error = String.Empty;
            if (e.Severity == System.Xml.Schema.XmlSeverityType.Warning)
            {
                error = String.Format("Warning: Matching Schema not found. No validation occurred. {0}", e.Message);
            }
            else
            {
                error = String.Format("Validation error on line {0:000}, position {1:000}: {2:000}", e.Exception.LineNumber, e.Exception.LinePosition, e.Message);
            }
            rtbOutput.AppendText(error, Color.Red, m_Font);
            rtbOutput.AppendText(Environment.NewLine);
        }

        #endregion "tabblad 1"


        // ***********************************************************************************
        //
        //  TABBLAD 2 : XML 2 PDF
        //
        // ***********************************************************************************

        #region "tabblad 2"

        private void btn2SelectXML_Click(object sender, EventArgs e)
        {
            // Alleen zoeken naar xlm of fo bestanden
            this.openFileDialog1.FileName = "*.xml;.fo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt2SelectXML.Text = openFileDialog1.FileName;
            }
            else return;
        }

        private void btn2SelectStylesheet_Click(object sender, EventArgs e)
        {
            // Alleen zoeken naar xsl of xslt bestanden
            this.openFileDialog1.FileName = "*.xsl;.xslt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txt2SelectStylesheet.Text = openFileDialog1.FileName;
            }
            else return;
        }

        private void btn2Format_Click(object sender, EventArgs e)
        {
            
        }

        #endregion "tabblad 2"

        /// <summary>
        /// Change font
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new XmlValidator.frmSettings(m_Font);
            DialogResult r = settings.ShowDialog();
            if (r == DialogResult.Cancel)
            {
                Font f = settings.getFont();
                if (f != m_Font)
                {
                    m_Font = f;
                    btnValidate_Click(null, null);
                }
            }
        }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color, Font font)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.Font = font;
            box.SelectionColor = color;
            box.AppendText(text);
        }

        public static void ChangeFont(this RichTextBox box, Font font)
        {
            box.SelectionStart = 0;
            box.SelectionLength = box.TextLength -1;
            Color color = box.SelectionColor;

            box.Font = font;
            box.SelectionColor = color;
        }
    }
}
