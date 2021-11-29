namespace Domain
{
    public class Stepper
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsVisited { get; set; }
        public int? NodeStepNumber { get; set; }
        public string? NodeTextHTMLElement { get; set; }
        public string? NodeStepNumberHTMLElement { get; set; }
        public bool? IsHidden { get; set; }
        public bool? IsSubNode { get; set; }
        public bool? IsChildNode { get;set; }
        public string? NodeType { get; set; }
        public bool? IsComplete { get; set; }
        public string? ChildList { get; set; }
        public int? DisplayNodeNumber { get; set; }
        public decimal? DisplayPercentForParentNode { get; set; }
        public string? ParentCode { get; set; }
    }
}