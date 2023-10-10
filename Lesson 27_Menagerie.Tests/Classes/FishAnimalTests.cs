using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class FishAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", 1, true)]
        [TestCase("�����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            bool actual = fish.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", true)]
        [TestCase("�����", false)]
        [TestCase("����� � ��������", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            fish.CheckPredator(food);
            bool actual = fish.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("��������", true)]
        [TestCase("�����", false)]
        [TestCase("����� � ��������", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            FishAnimal fish = new FishAnimal("����", 3, 1, 1);
            fish.EatingPortionOfFeed(food, 1);
            fish.EatingPortionOfFeed(food, 1);
            fish.EatingPortionOfFeed(food, 1);
            bool actual = fish.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
