namespace גמרא_ברורה
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            paragraphButton = new RadioButton();
            clasifyButton = new RadioButton();
            connectButton = new RadioButton();
            groupBox = new GroupBox();
            otherButton = new RadioButton();
            conclusionButton = new RadioButton();
            answerButton = new RadioButton();
            contradictionButton = new RadioButton();
            questionnButton = new RadioButton();
            statementButton = new RadioButton();
            textBox1 = new RichTextBox();
            undoButton = new Button();
            panel1 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            helpButton = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(827, 55);
            button1.Name = "button1";
            button1.Size = new Size(141, 34);
            button1.TabIndex = 1;
            button1.Text = "Paste";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // paragraphButton
            // 
            paragraphButton.AutoSize = true;
            paragraphButton.Location = new Point(827, 124);
            paragraphButton.Name = "paragraphButton";
            paragraphButton.Size = new Size(117, 29);
            paragraphButton.TabIndex = 2;
            paragraphButton.TabStop = true;
            paragraphButton.Text = "Paragraph";
            paragraphButton.UseVisualStyleBackColor = true;
            // 
            // clasifyButton
            // 
            clasifyButton.AutoSize = true;
            clasifyButton.Location = new Point(827, 170);
            clasifyButton.Name = "clasifyButton";
            clasifyButton.Size = new Size(96, 29);
            clasifyButton.TabIndex = 3;
            clasifyButton.TabStop = true;
            clasifyButton.Text = "Classify";
            clasifyButton.UseVisualStyleBackColor = true;
            clasifyButton.CheckedChanged += ClasifyButton_CheckedChanged;
            // 
            // connectButton
            // 
            connectButton.AutoSize = true;
            connectButton.Location = new Point(827, 216);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(102, 29);
            connectButton.TabIndex = 4;
            connectButton.TabStop = true;
            connectButton.Text = "Connect";
            connectButton.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(otherButton);
            groupBox.Controls.Add(conclusionButton);
            groupBox.Controls.Add(answerButton);
            groupBox.Controls.Add(contradictionButton);
            groupBox.Controls.Add(questionnButton);
            groupBox.Controls.Add(statementButton);
            groupBox.Location = new Point(812, 311);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(172, 237);
            groupBox.TabIndex = 5;
            groupBox.TabStop = false;
            groupBox.Text = "Classifications";
            // 
            // otherButton
            // 
            otherButton.AutoSize = true;
            otherButton.Location = new Point(14, 201);
            otherButton.Name = "otherButton";
            otherButton.Size = new Size(82, 29);
            otherButton.TabIndex = 11;
            otherButton.TabStop = true;
            otherButton.Text = "Other";
            otherButton.UseVisualStyleBackColor = true;
            // 
            // conclusionButton
            // 
            conclusionButton.AutoSize = true;
            conclusionButton.Location = new Point(14, 166);
            conclusionButton.Name = "conclusionButton";
            conclusionButton.Size = new Size(124, 29);
            conclusionButton.TabIndex = 10;
            conclusionButton.TabStop = true;
            conclusionButton.Text = "Conclusion";
            conclusionButton.UseVisualStyleBackColor = true;
            // 
            // answerButton
            // 
            answerButton.AutoSize = true;
            answerButton.Location = new Point(14, 135);
            answerButton.Name = "answerButton";
            answerButton.Size = new Size(95, 29);
            answerButton.TabIndex = 9;
            answerButton.TabStop = true;
            answerButton.Text = "Answer";
            answerButton.UseVisualStyleBackColor = true;
            // 
            // contradictionButton
            // 
            contradictionButton.AutoSize = true;
            contradictionButton.Location = new Point(14, 100);
            contradictionButton.Name = "contradictionButton";
            contradictionButton.Size = new Size(144, 29);
            contradictionButton.TabIndex = 8;
            contradictionButton.TabStop = true;
            contradictionButton.Text = "Contradiction";
            contradictionButton.UseVisualStyleBackColor = true;
            // 
            // questionnButton
            // 
            questionnButton.AutoSize = true;
            questionnButton.Location = new Point(14, 65);
            questionnButton.Name = "questionnButton";
            questionnButton.Size = new Size(109, 29);
            questionnButton.TabIndex = 7;
            questionnButton.TabStop = true;
            questionnButton.Text = "Question";
            questionnButton.UseVisualStyleBackColor = true;
            // 
            // statementButton
            // 
            statementButton.AutoSize = true;
            statementButton.Location = new Point(14, 30);
            statementButton.Name = "statementButton";
            statementButton.Size = new Size(117, 29);
            statementButton.TabIndex = 6;
            statementButton.TabStop = true;
            statementButton.Text = "Statement";
            statementButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 29);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(775, 719);
            textBox1.TabIndex = 12;
            textBox1.Text = "";
            textBox1.Click += TextBox1_Click;
            // 
            // undoButton
            // 
            undoButton.Location = new Point(827, 580);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(141, 73);
            undoButton.TabIndex = 13;
            undoButton.Text = "Undo Last Action";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += UndoButton_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(999, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(623, 719);
            panel1.TabIndex = 14;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(838, 672);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(112, 34);
            helpButton.TabIndex = 15;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1673, 769);
            Controls.Add(helpButton);
            Controls.Add(panel1);
            Controls.Add(undoButton);
            Controls.Add(textBox1);
            Controls.Add(groupBox);
            Controls.Add(connectButton);
            Controls.Add(clasifyButton);
            Controls.Add(paragraphButton);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private RadioButton paragraphButton;
        private RadioButton clasifyButton;
        private RadioButton connectButton;
        private GroupBox groupBox;
        private RadioButton otherButton;
        private RadioButton conclusionButton;
        private RadioButton answerButton;
        private RadioButton contradictionButton;
        private RadioButton questionnButton;
        private RadioButton statementButton;
        private RichTextBox textBox1;
        private Button undoButton;
        private Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private Button helpButton;
    }
}