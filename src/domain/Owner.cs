namespace propertymgr.domain {

    public class Owner
    {
        private Guid OwnerId { get; set; }
        public Guid NationalId { get; set; }
        public string? Name { get; set; }
        public string? PhoneNumber { get; set; }

        public Owner() { }

        public Owner(Guid ownerId, Guid nationalId, string name, string phoneNumber)
        {
            OwnerId = ownerId;
            NationalId = nationalId;
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}