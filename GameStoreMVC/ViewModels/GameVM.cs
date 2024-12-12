namespace GameStoreMVC.ViewModels
{
    public class GameVM
    {
        public string GameName { get; set; }
        public IFormFile File { get; set; }
        public int Discount { get; set; }
        public int CostPrice { get; set; }
        public int SellPrice { get; set; }
        public string GameId { get; set; }
    }
}
