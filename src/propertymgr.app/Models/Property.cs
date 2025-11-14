namespace propertymgr.app.Models;

public class Property 
{
    public int PropertyId { get; set; }
    public string? Name { get; set; }
    public float Price { get; set; }
    public string? Type { get; set; }
    public int Area { get; set; }
    public string? Address { get; set; }
    public int OwnerId { get; set; }

    public Property () { }

    public Property(int propertyId, string name, int price, string type, int area, string address, int ownerId) {
        PropertyId = propertyId;
        Name = name;
        Price = price;
        Type = type;
        Area = area;
        Address = address;
        OwnerId = ownerId;
    }
}