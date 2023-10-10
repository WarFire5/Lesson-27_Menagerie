using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class ElephantAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", 5, true)]
        [TestCase("Торт", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            bool actual = elephant.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", false)]
        [TestCase("Торт", false)]
        [TestCase("Сено и Торт", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            elephant.CheckPredator(food);
            bool actual = elephant.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Сено", true)]
        [TestCase("Торт", false)]
        [TestCase("Сено и Торт", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
            elephant.EatingPortionOfFeed(food, 5);
            elephant.EatingPortionOfFeed(food, 5);
            elephant.EatingPortionOfFeed(food, 5);
            bool actual = elephant.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
