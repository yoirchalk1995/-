namespace גמרא_ברורה
{
    public class CustomString
    {
        public string Text { get; set; }

        public bool IsUsedParagraph { get; set; }

        public bool IsUsedClasification { get; set; }


        public CustomString(string text, bool isUsedParagraph = 
            false, bool isUsedClasification = false) 
        {
            Text = text;
            IsUsedParagraph = isUsedParagraph;
            IsUsedClasification = isUsedClasification;
        }   

    }
}
