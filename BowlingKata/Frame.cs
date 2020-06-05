namespace BowlingKata
{
    public class Frame
    {
        public int FirstRoll { get; set; }
        public int SecondRoll { get; set; }
        public int AnnoyingTenthOptionalRoll { get; set; }

        public int TotalScore => FirstRoll + SecondRoll + AnnoyingTenthOptionalRoll;
        public bool IsStrike => FirstRoll == 10;
        public bool IsSpare => FirstRoll + SecondRoll == 10;
    }
}
