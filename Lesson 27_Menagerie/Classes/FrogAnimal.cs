using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27_Menagerie.Classes
{
    public class FrogAnimal : AbstractAnimal
    {
        public FrogAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Лягушка";
            Type2 = "Лягушками";
            Biome = "в Болоте";
            Feed = "Насекомые";
            Feed2 = "Сыр";
            TypeAnimal = "Хищник";
            Do = "Хорошо прыгает и стреляет липким языком";
            Sound = "Квааа!";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Насекомые" & portionOfFeed == 2)
            {
                Console.WriteLine($"{Name} покушала.");
                Ate += portionOfFeed;
                SatietyCheck();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} не стала есть.");
            }
            return false;
        }
        public bool CheckPredator(string food)
        {
            if (food == "Насекомые")
            {
                Console.WriteLine($"{Name} - {TypeAnimal}.");
                IsPredator = true;
                return IsPredator;
            }
            else
            {
                IsPredator = false;
                return IsPredator;
            }
        }
        public bool SatietyCheck()
        {
            if (Ate == 6)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыта.");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелась.");
            }
            return Satiety;
        }
    }
}
