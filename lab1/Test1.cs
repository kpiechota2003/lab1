using lab1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 1, 4, 16 };
            foreach (int i in sizes)
            {
                Problem problem = new Problem(i, 0);
                Assert.AreEqual(i, problem.items.Count);
            }
        }


        [TestMethod]
        public void TestMethodItemsAreSortedCorrectly()
        {
            int size = 5;
            Problem problem = new Problem(size, 0);
            problem.Solve(10);

            for (int i = 0; i < size - 1; i++)
            {
                Assert.IsTrue(problem.items[i].value * (1000 / problem.items[i].weight) >= problem.items[i+1].value * (1000 / problem.items[i+1].weight));
            }
        }

        [TestMethod]
        public void TestMethodEmptyResult()
        {
            int size = 5;
            Problem problem = new Problem(size, 0);
            Result result = problem.Solve(0);

            Assert.IsTrue(result.items.Count == 0);
        }

        [TestMethod]
        public void TestMethodAtLeastOne()
        {
            List<int> sizes = new List<int>() { 10, 22, 35 };
            int capacity = 10;
            foreach (int i in sizes)
            {
                Problem problem = new Problem(i, 0);
                Result result = problem.Solve(capacity);
                
                bool fits_in_backpack = false;

                foreach (int j in result.items)
                {
                    if(j < capacity) fits_in_backpack = true;
                }

                if (fits_in_backpack)
                {
                    Assert.IsTrue(result.items.Count > 0);
                }
                else
                {
                    Assert.IsTrue(result.items.Count == 0);
                }

            }

        }


        [TestMethod]
        public void TestMethotCorrectBackpack()
        {
            int size = 5;
            int capacity = 10;
            Problem problem = new Problem(size, 0);
            Result result = problem.Solve(capacity);

            int total_weight = 0;

            foreach (int i in result.items)
            {
                foreach (Item j in problem.items)
                {
                    if(i == j.index) total_weight += j.weight;
                }
            }

            Assert.IsTrue(total_weight <= capacity);
        }

        //czy indeksy w result sa poprawne
        [TestMethod]
        public void TestMethotResultIndexes()
        {
            List<int> sizes = new List<int>() { 10, 22, 35 };
            int capacity = 10;

            foreach (int i in sizes)
            {
                Problem problem = new Problem(i, 0);
                Result result = problem.Solve(capacity);

                foreach (int j in result.items)
                {
                    Assert.IsTrue(j >= 0);
                    Assert.IsTrue(j < i);
                }


            }
        }


    }
}
