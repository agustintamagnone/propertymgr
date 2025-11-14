using propertymgr.domain;

namespace propertymgr.service;

public class OwnerService
{
    private readonly HashSet<Owner> _owners = new HashSet<Owner>();
    public void CreateListOwners(Owner owner) => _owners.Add(owner);
        
    public Owner AddOwner(Owner owner)
    {
        _owners.Add(owner);
        return owner;
    }

    public Owner DeleteOwner(Owner owner)
    {
        _owners.Remove(owner);
        return owner;
    }

    public IEnumerable<Owner> PrintOwners()
    {
        return new List<Owner>();
    }
}