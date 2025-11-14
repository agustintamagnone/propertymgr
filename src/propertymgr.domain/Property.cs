namespace propertymgr.domain
{
    public class Property 
    {
        private Guid PropertyId { get; set; }
        public string? Name { get; set; }
        public float Price { get; set; }
        public string? Type { get; set; }
        public int Area { get; set; }
        public string? Address { get; set; }
        private Guid OwnerId { get; set; }

        public Property () { }

        public Property(Guid propertyId, string name, int price, string type, int area, string address, Guid ownerId) {
            PropertyId = propertyId;
            Name = name;
            Price = price;
            Type = type;
            Area = area;
            Address = address;
            OwnerId = ownerId;
        }
    }
}