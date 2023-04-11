namespace la_mia_pizzeria_model.Models
{
    public class Pizza
    {
        public Pizza() { }

        public Pizza(string _imgSrc, string _name, string _description, string _price) 
        {
            ImgSrc = _imgSrc;
            Name = _name;
            Description = _description;
            Price = _price;
        }

        public int Id { get; set; }
        public string ImgSrc { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;

    }
}
