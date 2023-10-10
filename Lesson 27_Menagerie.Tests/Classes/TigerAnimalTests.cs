using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class TigerAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", 5, true)]
        [TestCase("Трава", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            bool actual = tiger.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", true)]
        [TestCase("Трава", false)]
        [TestCase("Мясо и Трава", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            tiger.CheckPredator(food);
            bool actual = tiger.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Мясо", true)]
        [TestCase("Трава", false)]
        [TestCase("Мясо и Трава", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
            tiger.EatingPortionOfFeed(food, 5);
            tiger.EatingPortionOfFeed(food, 5);
            tiger.EatingPortionOfFeed(food, 5);
            bool actual = tiger.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
