using propertymgr.domain;

namespace propertymgr.service;

public interface IOwnerService
{
    Owner AddOwner(Owner owner);
    Owner DeleteOwner(Owner owner);
    IEnumerable<Owner> PrintOwners();
}