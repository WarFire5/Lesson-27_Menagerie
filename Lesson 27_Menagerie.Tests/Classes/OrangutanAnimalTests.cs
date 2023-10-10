using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class OrangutanAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", 3, true)]
        [TestCase("Чипсы", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            bool actual = orangutan.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", false)]
        [TestCase("Чипсы", false)]
        [TestCase("Фрукты и Чипсы", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            orangutan.CheckPredator(food);
            bool actual = orangutan.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Фрукты", true)]
        [TestCase("Чипсы", false)]
        [TestCase("Фрукты и Трава", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
            orangutan.EatingPortionOfFeed(food, 3);
            orangutan.EatingPortionOfFeed(food, 3);
            orangutan.EatingPortionOfFeed(food, 3);
            bool actual = orangutan.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
