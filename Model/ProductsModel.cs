namespace Radzen2.Model;

public class ProductsModel
{
    public ProductsModel()
    {
    }
    
    public ProductsModel(int id, string title, decimal price, string description, string category, string image)
    {
        Id = id;
        Title = title;
        Price = price;
        Description = description;
        Category = category;
        Image = image;
    }
    
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    
}

