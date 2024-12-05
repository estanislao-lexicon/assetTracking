using AssetNameSpace;

namespace OfficeNameSpace
{
    internal class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LocalCurrency { get; set; }
        public List<Asset> Assets { get; set; }
    }
}