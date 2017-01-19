using System;

namespace RPSLS_MVVM.Business
{
    public class GameLogic : IGameLogic
    {
        private readonly Random _random = new Random();

        public string Play(Option option)
        {
            var computer = _random.Next(1, 6);
            var computerOption = (Option) computer;

            switch (option)
            {
                case Option.Rock:
                    return Rock(computerOption);
                case Option.Paper:
                    return Paper(computerOption);
                case Option.Scissors:
                    return Scissors(computerOption);
                case Option.Lizard:
                    return Lizard(computerOption);
                case Option.Spock:
                    return Spock(computerOption);
            }

            return "ERROR";
        }

        private string Rock(Option computerOption)
        {
            switch (computerOption)
            {
                case Option.Rock:
                    return Tie("rock");
                case Option.Paper:
                    return "Paper covers rock.";
                case Option.Scissors:
                    return "Rock smashes scissors.";
                case Option.Lizard:
                    return "Rock crushes lizard.";
                case Option.Spock:
                    return "Spock vaporizes rock.";
            }

            return "ERROR";
        }

        private string Paper(Option computerOption)
        {
            switch (computerOption)
            {
                case Option.Rock:
                    return "Paper covers rock.";
                case Option.Paper:
                    return Tie("paper");
                case Option.Scissors:
                    return "Scissors cuts paper.";
                case Option.Lizard:
                    return "Lizard eats paper.";
                case Option.Spock:
                    return "Paper disproves Spock.";
            }

            return "ERROR";
        }

        private string Scissors(Option computerOption)
        {
            switch (computerOption)
            {
                case Option.Rock:
                    return "Rock smashes scissors.";
                case Option.Paper:
                    return "Scissors cuts paper.";
                case Option.Scissors:
                    return Tie("scissors");
                case Option.Lizard:
                    return "Scissors decapitate lizard.";
                case Option.Spock:
                    return "Spock smashes scissors.";
            }

            return "ERROR";
        }

        private string Lizard(Option computerOption)
        {
            switch (computerOption)
            {
                case Option.Rock:
                    return "Rock crushes lizard.";
                case Option.Paper:
                    return "Lizard eats paper.";
                case Option.Scissors:
                    return "Scissors decapitate lizard.";
                case Option.Lizard:
                    return Tie("lizard");
                case Option.Spock:
                    return "Lizard poisons Spock.";
            }

            return "ERROR";
        }

        private string Spock(Option computerOption)
        {
            switch (computerOption)
            {
                case Option.Rock:
                    return "Spock vaporizes rock.";
                case Option.Paper:
                    return "Paper disproves Spock.";
                case Option.Scissors:
                    return "Spock smashes scissors.";
                case Option.Lizard:
                    return "Lizard poisons Spock.";
                case Option.Spock:
                    return Tie("spock");
            }

            return "ERROR";
        }

        private string Tie(string option)
        {
            return $"Both choose {option}, tie";
        }
    }
}