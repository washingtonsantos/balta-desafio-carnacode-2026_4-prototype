namespace Prototype.Document
{
    public class DocumentTemplate : IPrototype
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public List<Section> Sections { get; set; }
        public DocumentStyle Style { get; set; }
        public List<string> RequiredFields { get; set; }
        public Dictionary<string, string> Metadata { get; set; }
        public ApprovalWorkflow Workflow { get; set; }
        public List<string> Tags { get; set; }

        public DocumentTemplate()
        {
            Sections = new List<Section>();
            RequiredFields = new List<string>();
            Metadata = new Dictionary<string, string>();
            Tags = new List<string>();
        }

        public IPrototype Clone()
        {
            DocumentTemplate clone = (DocumentTemplate)this.MemberwiseClone();
            clone.Title = this.Title;
            clone.Category = this.Category;
            clone.Style = this.Style;
            clone.Workflow = this.Workflow;
            clone.Sections = this.Sections;
            clone.RequiredFields = this.RequiredFields;

            return clone;            
        }
    }
}
