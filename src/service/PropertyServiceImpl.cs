using propertymgr.domain;

namespace propertymgr.service;

public class PropertyServiceImpl
{
    private readonly HashSet<Property> _properties = new HashSet<Property>();
    public void CreateListProperties(Property property) => _properties.Add(property);
    
    public void AddProperty(Property property)
    {
        
    }

    public void DeleteProperty(Property property)
    {
        
    }

    public IEnumerable<Property> GetProperties()
    {
        return new List<Property>();
    }
}