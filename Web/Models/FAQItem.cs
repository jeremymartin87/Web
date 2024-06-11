namespace Web.Models
{
    public class FAQItem
    {
        public string Question { get; set; }
        public List<string> Answers { get; set; }
        public bool IsExpanded { get; set; }
    }
}
