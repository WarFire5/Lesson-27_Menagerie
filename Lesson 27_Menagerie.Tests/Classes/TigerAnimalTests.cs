using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class TigerAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", 5, true)]
        [TestCase("�����", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            bool actual = tiger.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("�����", false)]
        [TestCase("���� � �����", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            tiger.CheckPredator(food);
            bool actual = tiger.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("����", true)]
        [TestCase("�����", false)]
        [TestCase("���� � �����", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            TigerAnimal tiger = new TigerAnimal("�����", 15, 10, 50);
            tiger.EatingPortionOfFeed(food, 5);
            tiger.EatingPortionOfFeed(food, 5);
            tiger.EatingPortionOfFeed(food, 5);
            bool actual = tiger.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
