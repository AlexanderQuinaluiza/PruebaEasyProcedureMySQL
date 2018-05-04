using System;
using System.Windows.Forms;

namespace Procedimientos_MySQL
{
    public class MyTabPage : System.Windows.Forms.TabPage
    {
        public containt mainform;
        public FastColoredTextBoxNS.FastColoredTextBox _myRichTextBox = new FastColoredTextBoxNS.FastColoredTextBox();

        public MyTabPage(containt mf)
        {
            mainform = mf;

            this._myRichTextBox.Dock = DockStyle.Fill;

            this._myRichTextBox.Text = "";
            _myRichTextBox.Language= FastColoredTextBoxNS.Language.SQL;
            this._myRichTextBox.Select();
                    
            this._myRichTextBox.AutoCompleteBrackets=true;
            _myRichTextBox.TextChanged += new EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(richTextBox1_TextChanged);
            _myRichTextBox.SelectionChanged += new EventHandler(richTextBox1_SelectionChanged);

           // _myRichTextBox.LinkClicked += new LinkClickedEventHandler(this.richTextBox1_LinkClicked);

            this.Controls.Add(_myRichTextBox);
        }
        


        private void richTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            String str = this.Text;
            if (str.Contains("*"))
            {

            }
            else
            {
                this.Text = str + "*";
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            //    int index = _myRichTextBox.SelectionStart;
            //    int line = _myRichTextBox.GetLineLength(index);// richTextBox.GetLineFromCharIndex(index);

            //    // Get the column.
            //    int firstChar = _myRichTextBox.GetLineLength(line);//.GetFirstCharIndexFromLine(line);
            //    int column = index - firstChar;

            //    mainform.LineToolStripLabel.Text = "Line : " + line;
            //    mainform.ColumnToolStripLabel.Text = "Col : " +column;
        }





        //private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        //{
        //    Process.Start(e.LinkText);
        //}

    }
    }
