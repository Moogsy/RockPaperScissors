using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsApp
{
    public enum RPSChoiceBase { Paper, Rock, Scissors };

    public class RPSChoice
    {
        public RPSChoiceBase choice;
        public readonly static RPSChoiceBase[] choices = (RPSChoiceBase[])Enum.GetValues(typeof(RPSChoiceBase));

        public RPSChoice(RPSChoiceBase choice)
        {
            this.choice = choice;
        }

        public static bool LhsWins(RPSChoice lhs, RPSChoice rhs)
        {
            int lhsChoiceIndex = Array.FindIndex(choices, v => v == lhs.choice);
            int nextChoiceIndex = (lhsChoiceIndex + 1) % 3;

            return rhs.choice == choices[nextChoiceIndex];
        }

        public static bool operator > (RPSChoice self, RPSChoice other) {
            return LhsWins(self, other);
        }

        public static bool operator < (RPSChoice self, RPSChoice other)
        {
            return LhsWins(other, self);
        }

        public static bool operator == (RPSChoice self, RPSChoice other)
        {
            return self.choice == other.choice;
        }

        public override bool Equals(object? obj)
        {
            if (obj is RPSChoice other)
            {
                return this == other;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return choice.GetHashCode();
        }

        public static bool operator != (RPSChoice self, RPSChoice other)
        {
            return self.choice != other.choice;
        }

        public override string ToString()
        {
            return this.choice.ToString();
        }
    }

    public class Rock: RPSChoice
    {
        public Rock() : base(RPSChoiceBase.Rock) { }
    }

    public class Paper : RPSChoice
    {
        public Paper() : base(RPSChoiceBase.Paper) { }
    }

    public class Scissors : RPSChoice
    {
        public Scissors() : base(RPSChoiceBase.Scissors) { }
    }
}
