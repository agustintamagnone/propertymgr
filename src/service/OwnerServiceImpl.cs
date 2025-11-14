using System.ComponentModel;
using propertymgr.domain;

namespace propertymgr.service;

public class OwnerServiceImpl
{
    private readonly HashSet<Owner> _owners = new HashSet<Owner>();
    public void CreateListOwners(Owner owner) => _owners.Add(owner);
        
    public void AddOwner(Owner owner)
    {
        
    }

    public void DeleteOwner(Owner owner)
    {
        
    }

    public IEnumerable<Owner> PrintOwners()
    {
        return new List<Owner>();
    }
}