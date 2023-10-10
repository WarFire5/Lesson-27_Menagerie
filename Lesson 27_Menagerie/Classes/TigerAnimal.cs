namespace Lesson_27_Menagerie.Classes
{
    public class TigerAnimal : AbstractAnimal
    {
        public TigerAnimal(string name, int volumeFeedPerDay, int age, int square)
        {
            Type = "Тигр";
            Type2 = "Тиграми";
            Biome = "в Джунглях";
            Feed = "Мясо";
            Feed2 = "Трава";
            TypeAnimal = "Хищник";
            Do = "Непревзойдённый охотник-убийца";
            Sound = "Рррр";
            IsPredator = true;
            Name = name;
            VolumeFeedPerDay = volumeFeedPerDay;
            Age = age;
            Square = square;
        }
        public override bool EatingPortionOfFeed(string food, int portionOfFeed)
        {
            if (food == "Мясо" & portionOfFeed == 5)
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
            if (food == "Мясо")
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
            if (Ate == 15)
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
