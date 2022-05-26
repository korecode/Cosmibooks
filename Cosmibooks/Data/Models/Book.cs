namespace Cosmibooks.Data.Models
{
    public class Book
    {
        public int id { get; set; }

        public string name { get; set; }

        public string author { get; set; }

        public string shortDesc { get; set; }

        public string longDesc { get; set; }

        public string img { get; set; }

        public string subs { get; set; }

        public ushort price { get; set; }

        public bool isFavourite { get; set; }

        public bool available { get; set; }

        public virtual Category Category { get; set; }

    }
}
