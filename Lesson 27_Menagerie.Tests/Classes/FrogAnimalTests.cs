using Lesson_27_Menagerie.Classes;

namespace Menagerie.Tests.Classes
{
    public class FrogAnimalTests
    {
        /// <summary>
        /// �������� ����� ������ ����� ����
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", 2, true)]
        [TestCase("���", 0, false)]
        public void EatingPortionOfFeedTests(string food, int portionOfFeed, bool expected)
        {
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            bool actual = frog.EatingPortionOfFeed(food, portionOfFeed);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �����������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", true)]
        [TestCase("���", false)]
        [TestCase("��������� � ���", false)]
        public void CheckPredatorTests(string food, bool expected)
        {
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            frog.CheckPredator(food);
            bool actual = frog.IsPredator;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="food"></param>
        [TestCase("���������", true)]
        [TestCase("���", false)]
        [TestCase("��������� � ���", false)]
        public void SatietyCheckTests(string food, bool expected)
        {
            FrogAnimal frog = new FrogAnimal("�����", 6, 3, 5);
            frog.EatingPortionOfFeed(food, 2);
            frog.EatingPortionOfFeed(food, 2);
            frog.EatingPortionOfFeed(food, 2);
            bool actual = frog.Satiety;
            Assert.AreEqual(expected, actual);
        }
    }
}
