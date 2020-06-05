namespace BowlingKata
{
    //Write a class 'Game' with two methods
    //void Roll(int pins) is called each time the player rolls a ball. The argument is the number of pins knocked down.
    //int Score() is called only at the very end of the game. It returns the total score for that game.
    public class Game
    {
        public int PinsKnockedDown = 0;
        public int[] Frames = new int[10];
        public int RollCounter = 0;
        public int FrameNumber = 0;
        public int TotalScore = 0;
        public bool GameOver = false;

        public void Roll(int pins)
        {
            if (FrameNumber == 10)
            {
                GameOver = true;
                return;
            }

            PinsKnockedDown += pins;
            ++RollCounter;

            if (PinsKnockedDown == 10 && (RollCounter % 2 == 1))
            {
                RollCounter++;
            }

            if (RollCounter % 2 == 0)
            {

                Frames[FrameNumber] = PinsKnockedDown;
                ++FrameNumber;
                PinsKnockedDown = 0;
            }
        }

        public int Score()
        {
            for (int i = 0; i < 10; i++)
            {
                TotalScore += Frames[i];
            }
            return TotalScore;
        }


    }
}
