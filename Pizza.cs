using System;

public class Pizza
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string Image { get; set; }

    public double Price { get; set; }

    public int ID { get; set; }
    public Pizza(string name, string description, string image, double price, int iD)
    {
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        ID = iD;    
    }
}
