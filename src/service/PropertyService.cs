using propertymgr.domain;

namespace propertymgr.service;

public interface PropertyService
{
    Property AddProperty(Property property);
    Property DeleteProperty(Property property);
    IEnumerable<Property> PrintProperties();
}