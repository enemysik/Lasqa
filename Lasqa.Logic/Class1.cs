namespace Lasqa.Logic
{
    public class PathCreator
    {
        public Path Create()
        {
            return new Path
            {
                Valid = true,
            };
        }
    }
    public class Path
    {
        public bool Valid { get; set; }
    }
}
