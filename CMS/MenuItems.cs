namespace CMS
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; } // Can use Font Awesome, Bootstrap Icons, etc.
        public string Link { get; set; }
        public int Count { get; set; }
        public bool HasCount { get; set; } = true; 
    }
}
