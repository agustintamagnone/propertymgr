using propertymgr.domain;

namespace propertymgr.service;

public class PropertyServiceImpl : IPropertyService
{
    private readonly HashSet<Property> _properties = new HashSet<Property>();
    public void CreateListProperties(Property property) => _properties.Add(property);
    
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