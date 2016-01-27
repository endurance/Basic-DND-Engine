using System;

namespace DnDEngine.Roller
{
    public static class DiceRoller
    {
        public static int RollD100(int numberOfDice)
        {
            return RollDice(numberOfDice, 100);
        }

        public static int RollD20(int numberOfDice)
        {
            return RollDice(numberOfDice, 20);
        }

        public static int RollD12(int numberOfDice)
        {
            return RollDice(numberOfDice, 12);
        }

        public static int RollD10(int numberOfDice)
        {
            return RollDice(numberOfDice, 10);
        }

        public static int RollD8(int numberOfDice)
        {
            return RollDice(numberOfDice, 8);
        }

        public static int RollD6(int numberOfDice)
        {
            return RollDice(numberOfDice, 6);
        }

        public static int RollD4(int numberOfDice)
        {
            return RollDice(numberOfDice, 4);
        }

        // the no good fun killer lazy version of rolling dice
        public static int RollDice(int numberOfDice, int numberOfSides)
        {
            int randomNumber = 0;
            for (int i = 1; i <= numberOfDice; i++)
            {
                randomNumber += new Random().Next(1, numberOfSides);
            }
            return randomNumber;
        }
    }
}