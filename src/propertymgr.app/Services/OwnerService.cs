using propertymgr.app.Models;

namespace propertymgr.app.Services;

public class OwnerService
{
    private readonly List<Owner> _owners = new List<Owner>
    {
        new Owner { OwnerId = 0, NationalId = "1231231", Name = "Agustin Tamagnone", PhoneNumber = "647019493" },
        new Owner { OwnerId = 1, NationalId = "4564564", Name = "Adrian Perez Sueiro", PhoneNumber = "640111222" },
        new Owner { OwnerId = 2, NationalId = "7897897", Name = "Razvan Savoianu", PhoneNumber = "647222333" }
    };

    public void AddOwners(IEnumerable<Owner> owners) => _owners.AddRange(owners);

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