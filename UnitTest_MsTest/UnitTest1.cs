namespace UnitTest_MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UnitTest_MsTest1()//тест р≥к
        {
            // Arrange
            string input = "2023"; 
            int expected = 2023;   
            int actual;           

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine());

                // Assert
                Assert.AreEqual(expected, actual); 
            }
        }

        [TestMethod]
        public void UnitTest_MsTest2()//на некоректний вв≥д, €кий буде коректним
        {
            // Arrange
            string input = "10000\n2023"; 
            int expected = 2023;          
            int actual;                    

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine()); 
                Assert.IsTrue(actual > 9999 || actual < 1); 

                actual = int.Parse(Console.ReadLine()); 

                // Assert
                Assert.AreEqual(expected, actual); 
            }
        }
        [TestMethod]
        public void UnitTest_MsTest3()//ƒень з урахуванн€м року та м≥с€ц€
        {
            // Arrange
            int year = 2023; 
            int month = 2;     
            string input = "28";
            int expected = 28;   
            int actual;

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine()); 

                // Assert
                Assert.IsTrue(actual >= 1 && actual <= DateTime.DaysInMonth(year, month)); 
                Assert.AreEqual(expected, actual); 
            }
        }
        [TestMethod]
        public void UnitTest_MsTest4()//тест на вв≥д годин
        {
            // Arrange
            string input = "15"; 
            int expected = 15;   
            int actual;

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine());

                // Assert
                Assert.IsTrue(actual >= 0 && actual <= 23); 
                Assert.AreEqual(expected, actual); 
            }
        }
        [TestMethod]
        public void UnitTest_MsTest5()//тест на вв≥д хвилин
        {
            // Arrange
            string input = "45"; 
            int expected = 45;   
            int actual;

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine());

                // Assert
                Assert.IsTrue(actual >= 0 && actual <= 59); 
                Assert.AreEqual(expected, actual); 
            }
        }
        [TestMethod]
        public void UnitTest_MsTest6()//тест на вв≥д секунд
        {
            // Arrange
            string input = "30"; 
            int expected = 30;   
            int actual;

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                actual = int.Parse(Console.ReadLine());

                // Assert
                Assert.IsTrue(actual >= 0 && actual <= 59);
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        public void UnitTest_MsTest7()//тест на створенн€ дати
        {
            // Arrange
            int year = 2023;
            int month = 2;
            int day = 28;
            int hour = 15;
            int minute = 45;
            int second = 30;
            DateTime expected = new DateTime(2023, 2, 28, 15, 45, 30);

            DateTime actual;

            // Act
            actual = new DateTime(year, month, day, hour, minute, second);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void UnitTest_MsTest8() 
        {
            // Arrange
            string input = "InvalidYear";

            using (var sr = new StringReader(input))
            {
                Console.SetIn(sr);

                // Act
                int year = int.Parse(Console.ReadLine()); 
            }
        }
    }
}