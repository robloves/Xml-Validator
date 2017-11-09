namespace XmlValidator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectXML = new System.Windows.Forms.Button();
            this.txtXML = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn2Format = new System.Windows.Forms.Button();
            this.btn2SelectStylesheet = new System.Windows.Forms.Button();
            this.txt2SelectStylesheet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn2SelectXML = new System.Windows.Forms.Button();
            this.txt2SelectXML = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 28);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1072, 484);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtbOutput);
            this.tabPage1.Controls.Add(this.btnValidate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSelectXML);
            this.tabPage1.Controls.Add(this.txtXML);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1064, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Validate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbOutput.Location = new System.Drawing.Point(8, 63);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(1044, 381);
            this.rtbOutput.TabIndex = 13;
            this.rtbOutput.Text = "";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(643, 27);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(411, 28);
            this.btnValidate.TabIndex = 11;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kies het XML bestand:";
            // 
            // btnSelectXML
            // 
            this.btnSelectXML.Location = new System.Drawing.Point(535, 27);
            this.btnSelectXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectXML.Name = "btnSelectXML";
            this.btnSelectXML.Size = new System.Drawing.Size(100, 28);
            this.btnSelectXML.TabIndex = 8;
            this.btnSelectXML.Text = "Selecteer";
            this.btnSelectXML.UseVisualStyleBackColor = true;
            this.btnSelectXML.Click += new System.EventHandler(this.btnSelectXML_Click);
            // 
            // txtXML
            // 
            this.txtXML.Enabled = false;
            this.txtXML.Location = new System.Drawing.Point(164, 30);
            this.txtXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXML.Name = "txtXML";
            this.txtXML.Size = new System.Drawing.Size(361, 22);
            this.txtXML.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn2Format);
            this.tabPage2.Controls.Add(this.btn2SelectStylesheet);
            this.tabPage2.Controls.Add(this.txt2SelectStylesheet);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn2SelectXML);
            this.tabPage2.Controls.Add(this.txt2SelectXML);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1064, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XML 2 PDF";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn2Format
            // 
            this.btn2Format.Location = new System.Drawing.Point(652, 27);
            this.btn2Format.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Format.Name = "btn2Format";
            this.btn2Format.Size = new System.Drawing.Size(401, 68);
            this.btn2Format.TabIndex = 16;
            this.btn2Format.Text = "Format";
            this.btn2Format.UseVisualStyleBackColor = true;
            this.btn2Format.Click += new System.EventHandler(this.btn2Format_Click);
            // 
            // btn2SelectStylesheet
            // 
            this.btn2SelectStylesheet.Location = new System.Drawing.Point(544, 68);
            this.btn2SelectStylesheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2SelectStylesheet.Name = "btn2SelectStylesheet";
            this.btn2SelectStylesheet.Size = new System.Drawing.Size(100, 28);
            this.btn2SelectStylesheet.TabIndex = 15;
            this.btn2SelectStylesheet.Text = "Selecteer";
            this.btn2SelectStylesheet.UseVisualStyleBackColor = true;
            this.btn2SelectStylesheet.Click += new System.EventHandler(this.btn2SelectStylesheet_Click);
            // 
            // txt2SelectStylesheet
            // 
            this.txt2SelectStylesheet.Enabled = false;
            this.txt2SelectStylesheet.Location = new System.Drawing.Point(173, 70);
            this.txt2SelectStylesheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2SelectStylesheet.Name = "txt2SelectStylesheet";
            this.txt2SelectStylesheet.Size = new System.Drawing.Size(361, 22);
            this.txt2SelectStylesheet.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kies de stylesheet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kies het XML bestand:";
            // 
            // btn2SelectXML
            // 
            this.btn2SelectXML.Location = new System.Drawing.Point(544, 27);
            this.btn2SelectXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2SelectXML.Name = "btn2SelectXML";
            this.btn2SelectXML.Size = new System.Drawing.Size(100, 28);
            this.btn2SelectXML.TabIndex = 11;
            this.btn2SelectXML.Text = "Selecteer";
            this.btn2SelectXML.UseVisualStyleBackColor = true;
            this.btn2SelectXML.Click += new System.EventHandler(this.btn2SelectXML_Click);
            // 
            // txt2SelectXML
            // 
            this.txt2SelectXML.Enabled = false;
            this.txt2SelectXML.Location = new System.Drawing.Point(173, 30);
            this.txt2SelectXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt2SelectXML.Name = "txt2SelectXML";
            this.txt2SelectXML.Size = new System.Drawing.Size(361, 22);
            this.txt2SelectXML.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 503);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "Form1";
            this.Text = "XML Validator";
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectXML;
        private System.Windows.Forms.TextBox txtXML;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn2SelectXML;
        private System.Windows.Forms.TextBox txt2SelectXML;
        private System.Windows.Forms.Button btn2SelectStylesheet;
        private System.Windows.Forms.TextBox txt2SelectStylesheet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn2Format;
    }
}

