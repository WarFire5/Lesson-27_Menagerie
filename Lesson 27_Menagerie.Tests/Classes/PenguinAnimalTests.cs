using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class PenguinAnimalTests
    {
        /// <summary>
        /// Проверка факта одного приёма пищи
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", 1, true)]
        [TestCase("Хлеб", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            bool actual = penguin.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка хищничества
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", true)]
        [TestCase("Хлеб", false)]
        [TestCase("Хлеб и Рыба", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            penguin.CheckPredator(food);
            bool actual = penguin.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Проверка сытости
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("Рыба", true)]
        [TestCase("Хлеб", false)]
        [TestCase("Хлеб и Рыба", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
            penguin.EatingPortionOfFeed(food, 1);
            penguin.EatingPortionOfFeed(food, 1);
            penguin.EatingPortionOfFeed(food, 1);
            bool actual = penguin.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
