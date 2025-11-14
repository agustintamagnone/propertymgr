namespace propertymgr.app.Models;

public class Owner
{
    public int OwnerId { get; set; }
    public string? NationalId { get; set; }
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }

    public Owner() { }

    public Owner(int ownerId, string nationalId, string name, string phoneNumber)
    {
        OwnerId = ownerId;
        NationalId = nationalId;
        Name = name;
        PhoneNumber = phoneNumber;
    }
}