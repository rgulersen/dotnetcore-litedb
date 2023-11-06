namespace dotnetcore_litedb.Models
{
    public class StakeItem
    {
        public int Id { get; set; }
        public string? Asset { get; set; }
        public int Reward { get; set; }
        public int Duration { get; set; }
        public decimal Apy { get; set; }
    }
}