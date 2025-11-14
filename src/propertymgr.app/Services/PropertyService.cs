using propertymgr.app.Models;

namespace propertymgr.app.Services;

public class PropertyService
{
    private readonly List<Property> _properties = new List<Property>
    {
        new Property { PropertyId = 0, Name = "StudioOne", Price = 60000, Type = "Studio", Area = 45, Address = "Calle de Goya", OwnerId = 1 },
        new Property { PropertyId = 1, Name = "PenthouseOne", Price = 800000, Type = "Penthouse", Area = 210, Address = "Calle de Alcalá", OwnerId = 2 },
        new Property { PropertyId = 2, Name = "House", Price = 300000, Type = "House", Area = 250, Address = "Calle de Jorge Juan", OwnerId = 3 }
    };

    public void AddProperties(IEnumerable<Property> properties) => _properties.AddRange(properties);

    public Property AddProperty(Property property)
    {
        _properties.Add(property);
        return property;
    }

    public Property DeleteProperty(Property property)
    {
        _properties.Remove(property);
        return property;
    }

    public IEnumerable<Property> PrintProperties()
    {
        return new List<Property>();
    }
}