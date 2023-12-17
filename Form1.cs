using System.Text.RegularExpressions;
using System.Diagnostics;
using גמרא_ברורה.Properties;

namespace גמרא_ברורה
{
    public partial class Form1 : Form
    {
        private Stack<string> undoText = new();

        private string[] labelText = new string[0];

        private List<CustomPictureBox> orderList = new List<CustomPictureBox>();

        private Stack<CustomPictureBox> areClicked = new();

        private Stack<int> undoParagraphIndex = new();

        List<CustomString> isUsedList1 = new();

        private Stack<CustomPictureBox> undoPictureBox = new();

        private Stack<String> stackType = new();

        Stack<CustomPictureBox> lastMovedPicture = new();

        private Stack<Point> undoPoint = new();

        CustomPictureBox? selectedPixctureBox = new();

        int height = 0;

        readonly int width;

        Point previouseMousePosition;

        public Form1()
        {
            InitializeComponent();
            textBox1.ReadOnly = true;
            KeyPreview = true;
            groupBox.Enabled = false;
            stackType.Push("text");
            undoText.Push(textBox1.Text);
            panel1.AutoScroll = true;
            width = panel1.Width / 2;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string clipboardText = Clipboard.GetText();
            if (!DetectEnglishText(clipboardText))
            {
                undoText.Push(textBox1.Text);
                stackType.Push("text");
                string cleanedText = RemovePunctuation(clipboardText);
                textBox1.AppendText(cleanedText);

            }
            else
            {
                MessageBox.Show("Please enter only hebrew text", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool DetectEnglishText(string text)
        {
            string hebrewPattern = "[a-zA-Z]+";
            return Regex.IsMatch(text, hebrewPattern);
        }

        private static string RemovePunctuation(string text)
        {
            string abc = Regex.Replace(text, @"[^\p{L}\s]+", "");
            return Regex.Replace(abc, @"[\n\r]+", "");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();

                if (!DetectEnglishText(clipboardText))
                {
                    stackType.Push("text");
                    undoText.Push(textBox1.Text);

                    string cleanedText = RemovePunctuation(clipboardText);
                    textBox1.AppendText(cleanedText);
                    e.Handled = true;
                }
                else
                {
                    MessageBox.Show("Please enter only hebrew text", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
        }


        private void TextBox1_Click(object sender, EventArgs e)
        {
            int index = textBox1.GetCharIndexFromPosition
                (textBox1.PointToClient(Cursor.Position));

            if (paragraphButton.Checked == true)
            {
                index = Math.Min(index, textBox1.Text.Length - 1);

                if (textBox1.Text[index - 1] != '\n' | (textBox1.Text[index - 1] != ' '))
                {
                    stackType.Push("text");
                    undoText.Push(textBox1.Text);

                    int clickedPosition = textBox1.GetCharIndexFromPosition
                        (textBox1.PointToClient(Cursor.Position));

                    textBox1.Select(clickedPosition, 0);
                    textBox1.SelectedText = Environment.NewLine;
                    textBox1.SelectedText = Environment.NewLine;


                    string[] splitText = SplitString(textBox1.Text, '\n');
                    labelText = GetFirstThreeConsecutiveWords(splitText);
                }

            }


            else if (clasifyButton.Checked == true)
            {

                Image image;

                int paragraphIndex = GetParagraphIndexNumber(textBox1.Text, index);

                if (statementButton.Checked == true && isUsedList1[paragraphIndex]
                      .IsUsedClasification == false)
                {
                    image = Resources.statement;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;

                }


                else if (questionnButton.Checked == true && isUsedList1[paragraphIndex]
                      .IsUsedClasification == false)
                {
                    image = Resources.question;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;

                }


                else if (contradictionButton.Checked == true && isUsedList1[paragraphIndex]
                      .IsUsedClasification == false)
                {
                    image = Resources.contradiction;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;

                }


                else if (answerButton.Checked == true && isUsedList1[paragraphIndex].IsUsedClasification == false)
                {
                    image = Resources.contradiction;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;
                }


                else if (contradictionButton.Checked == true && isUsedList1[paragraphIndex].IsUsedClasification == false)
                {
                    image = Resources.contradiction;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;
                }


                else if (otherButton.Checked == true && isUsedList1[paragraphIndex].IsUsedClasification == false)
                {
                    image = Resources.other;
                    AddPictureBox(image, paragraphIndex);
                    undoParagraphIndex.Push(paragraphIndex);
                    isUsedList1[paragraphIndex]
                    .IsUsedClasification = true;

                }

            }
        }

        static string[] SplitString(string input, char seperator)
        {
            string[] parts = input.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            return parts;
        }


        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (stackType.Count > 0)
            {
                string type = stackType.Pop();
                if (type == "text")
                {
                    textBox1.Text = undoText.Pop();
                }
                else if (type == "picture")
                {
                    PictureBox toRemove = undoPictureBox.Pop();

                    height -= toRemove.Height + 25;

                    int i = undoParagraphIndex.Pop();

                    isUsedList1[i].IsUsedClasification = false;

                    panel1.Controls.Remove(toRemove);

                }
                else if (type == "move")
                {
                    lastMovedPicture.Pop().Location = undoPoint.Pop();
                }
            }
        }

        private void AddPictureBox(Image image, int paragraphIndex)
        {

            CustomPictureBox pictureBox = new CustomPictureBox()
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(60, 60),
                Image = image,
                ParagraphIndex = paragraphIndex

            };

            Label label = new Label()
            {
                Text = labelText[paragraphIndex],
                RightToLeft = RightToLeft.Yes,
                BackColor = Color.Transparent,
                Dock = DockStyle.Fill,
                Font = new Font("Ariel", 5),
                TextAlign = ContentAlignment.MiddleCenter
            };

            pictureBox.Controls.Add(label);

            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseUp += PictureBox_MouseUp;

            pictureBox.Location = new Point(width - (pictureBox.Width / 2), height);

            height += pictureBox.Height + 25;

            stackType.Push("picture");
            undoPictureBox.Push(pictureBox);
            orderList.Add(pictureBox);

            panel1.Controls.Add(pictureBox);

            foreach (CustomPictureBox pictureBoxs in panel1.Controls)
            {
                foreach (Label labels in pictureBoxs.Controls)
                {
                    Debug.WriteLine($"{labels.Text}");
                }
            }


            if (undoPictureBox.Count > 1)
            {
                for (int i = orderList.Count - 1; i > 0; i--)
                {
                    CustomPictureBox currentPictureBox = orderList[i];
                    CustomPictureBox previousPictureBox = orderList[i - 1];

                    // Call HeightOrder method to arrange the PictureBoxes
                    currentPictureBox.HeightOrder(previousPictureBox);
                }

            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            selectedPixctureBox.IsClicked = true;
            areClicked.Push(selectedPixctureBox);
            selectedPixctureBox.BackColor = Color.Aqua;

            selectedPixctureBox = null;
            timer1.Stop();
            if (areClicked.Count == 2)
            {
                CustomPictureBox picBox1 = areClicked.Pop();
                CustomPictureBox picBox2 = areClicked.Pop();

                picBox1.OrderParagraphs(picBox2); // something doesnt work +
                                                  // I have no idea how to work out
                                                  // what :S
                                                  // list *is* being populated with pairs


            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            selectedPixctureBox = (CustomPictureBox)sender;
            lastMovedPicture.Push(selectedPixctureBox);

            stackType.Push("move");
            undoPoint.Push(selectedPixctureBox.Location);

            previouseMousePosition = MousePosition;
            timer1.Start();

        }

        private void ClasifyButton_CheckedChanged(object sender, EventArgs e)
        {
            if (clasifyButton.Checked == true)
            {
                groupBox.Enabled = true;
            }
            else if (clasifyButton.Checked == false)
            {
                groupBox.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (selectedPixctureBox != null && connectButton.Checked)
            {

                int deltaX = MousePosition.X - previouseMousePosition.X;
                int deltaY = MousePosition.Y - previouseMousePosition.Y;

                int newX = selectedPixctureBox.Left + deltaX;
                int newY = selectedPixctureBox.Top + deltaY;

                selectedPixctureBox.Location = new Point(newX, newY);

                previouseMousePosition = MousePosition;
            }
        }

        private static int GetParagraphIndexNumber(string text, int index)
        {
            int count = 0;

            index = Math.Min(index, text.Length - 1);

            for (int i = 0; i < index; i++)
            {
                if (text[i] == '\n' && text[i + 1] == '\n')
                {
                    count++;
                }
            }

            return count;
        }


        static string[] GetFirstThreeConsecutiveWords(string[] inputArray)
        {
            List<string> result = new List<string>();

            foreach (string sentence in inputArray)
            {
                string[] words = sentence.Split(' ');

                // Find the first three consecutive words
                for (int i = 0; i <= words.Length - 3; i++)
                {
                    string consecutiveWords = $"{words[i]} {words[i + 1]} {words[i + 2]}";

                    // Check if these consecutive words appear in any other string
                    if (!inputArray.Any(otherSentence => otherSentence != sentence &&
                    otherSentence.Contains(consecutiveWords)))
                    {
                        result.Add(consecutiveWords);
                        break; // Break after finding the first occurrence
                    }
                }
            }

            return result.ToArray();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            using (HelpScreen helpScreen = new HelpScreen())
            {
                helpScreen.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (HelpScreen helpScreen = new HelpScreen())
            {
                helpScreen.ShowDialog();
            }
        }
    }

    //private void UpdateLabels(object sender, EventArgs e) //check and use this
    //{
    //    // Update labels for all PictureBox controls in the Panel
    //    foreach (Control control in panel1.Controls)
    //    {
    //        if (control is PictureBox pictureBox)
    //        {
    //            // Assuming the label is named labelX where X is the PictureBox number
    //            string labelName = "label" + pictureBox.Name.Substring("pictureBox".Length);
    //            if (panel1.Controls.ContainsKey(labelName) && panel1.Controls[labelName] is Label label)
    //            {
    //                // Update the label text or perform any other updates
    //                label.Text = "New Label Text";
    //            }
    //        }
    //    }
    //}
}