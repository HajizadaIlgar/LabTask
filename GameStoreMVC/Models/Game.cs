namespace GameStoreMVC.Models
{
    public class Game : BaseEntity
    {
        public string GameName { get; set; }
        public string ImageUrl { get; set; }
        public int Discount { get; set; }
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }
        public string GameId { get; set; }
    }
}
