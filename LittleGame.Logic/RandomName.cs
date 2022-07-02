namespace LittleGame.Logic
{
    public partial class RandomName
    {
        public ApiOwner ApiOwner { get; set; }
        public Body Body { get; set; }
    }

    public partial class ApiOwner
    {
        public string Author { get; set; }
        public Uri Cafecito { get; set; }
        public Uri Instagram { get; set; }
        public Uri Github { get; set; }
        public Uri Linkedin { get; set; }
        public Uri Twitter { get; set; }
    }

    public partial class Body
    {
        public string Name { get; set; }
        public string Genre { get; set; }
    }
}