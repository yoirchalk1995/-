using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace גמרא_ברורה
{
    public partial class HelpScreen : Form
    {
        public HelpScreen()
        {
            InitializeComponent();
            FormLayout();

        }

        private void FormLayout()
        {
            textBox1.ReadOnly = true;
            textBox1.WordWrap = true;
            textBox1.Multiline = true;
            textBox1.Text = "Welcome to גמרה ברורה.\n\n"
                + "To use, paste the desired text using the Paste button or ctl + v.\n"
                + "Assure that the text you paste only contains Hebrew Characters.\n\n"
                + "To separate into paragraphs, select the Paragraph radio button and click the place in the text where you want a new paragraph to be created.\n"
                + "To allocate a category to the paragraph, select the Classify radio button followed by the classification you want to use.\n"
                + "Select the paragraph you want to allocate\n"
                + "An image representing the text and classification will appear on the right side of the screen.\n\n"
                + "To connect two paragraphs, eg. an answer to a question select both of the images.\n"
                + "The images will arrange themselves.\n\n"
                + "To undo, press the Undo button and to print press the Print button."
                + "To view help again at any point press the Help button.";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
