using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_27_Menagerie.Classes
{
    public class FishAnimal : AbstractAnimal
    {
        public FishAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Рыба";
            Type2 = "Рыбами";
            Biome = "в Океане";
            Feed = "Планктон";
            Feed2 = "Сахар";
            TypeAnimal = "Хищник";
            Do = "Плавает лучше всех";
            Sound = "Тишина";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Планктон" & portionOfFeed == 1)
            {
                Console.WriteLine($"{Name} покушал.");
                Ate += portionOfFeed;
                SatietyCheck();
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} не стал есть.");
            }
            return false;
        }
        public bool CheckPredator(string food)
        {
            if (food == "Планктон")
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
            if (Ate == 3)
            {
                Satiety = true;
                Console.WriteLine($"{Name} сыт.");
            }
            else
            {
                Satiety = false;
                Console.WriteLine($"{Name} не наелся.");
            }
            return Satiety;
        }
    }
}
