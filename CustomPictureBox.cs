using System.Diagnostics;
namespace גמרא_ברורה
{
    public class CustomPictureBox : PictureBox
    {
        public bool IsClicked { get; set; }

        public int ParagraphIndex { get; set; }

        public bool IsParent(CustomPictureBox pictureBox2) 
                                                                                                 
        {
            if (ParagraphIndex > pictureBox2.ParagraphIndex)
            {
                return true;
            }
            else return false;
        }

        //to be invoked when only one is clicked to arrange order of parageraphs left/right
        public bool IsFirst(CustomPictureBox pictureBox2)
        {
            if (ParagraphIndex < pictureBox2.ParagraphIndex)
            {
                return true;
            }
            else return false;
        }

        public bool IsLeft (CustomPictureBox pictureBox2)
        {
            if (Left < pictureBox2.Left)
            {
                return true;
            }
            else return false;
        }

        public bool IsOverlapping (CustomPictureBox pictureBox2)
        {
            if (Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                return true;
            }
            else return false;
        }

        //want pbox with lowest index on right
        public void OrderParagraphs(CustomPictureBox pictureBox2)
        {
            CustomPictureBox x = pictureBox2;

            while (IsFirst(x) && (IsLeft(x)|IsOverlapping(x))) 
            {
                Left += 25;
                x.Left -= 25;
            }

        }

        //want fitst higher
        public void HeightOrder (CustomPictureBox pictureBox2)
        {

            if (IsFirst(pictureBox2) && this.Top > pictureBox2.Top)
            {
                Point tempLocation1 = this.Location;
                Point tempLocation2 = pictureBox2.Location;

                this.Location = tempLocation2;
                pictureBox2.Location = tempLocation1;
            }

        }
    }
}
