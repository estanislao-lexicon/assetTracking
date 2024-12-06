using OfficeNameSpace;

namespace AssetNameSpace
{
    internal class Asset
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        
        // Foreign key and navigation property for Office
        public int OfficeId { get; set; }
        public Office Office { get; set; }
    }
}