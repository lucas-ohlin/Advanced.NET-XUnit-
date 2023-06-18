using CalculatorLabb7.Modules;

namespace CalculatorTestXUnit {

    public class CalculatorTest {

        [Fact]
        public void AdditionTestFact() {

            //Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 15;

            //Act
            var res = CalculatorFunctions.Add(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(10, 5, 15)]
        [InlineData(10, 10, 20)]
        [InlineData(5, 5, 10)]
        [InlineData(1, 5, 6)]
        [InlineData(20, 5, 25)]
        public void AdditionTestTheory(double num1, double num2, double expected) {

            //Act
            var res = CalculatorFunctions.Add(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }

        [Fact]
        public void SubtractTestFact() {

            //Arrange
            double num1 = 10;
            double num2 = 5;
            double expected = 5;

            //Act
            var res = CalculatorFunctions.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(10, 10, 0)]
        [InlineData(11, 5, 6)]
        [InlineData(6, 5, 1)]
        [InlineData(20, 5, 15)]
        public void SubtractTestTheory(double num1, double num2, double expected) {

            //Act
            var res = CalculatorFunctions.Subtract(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }


        [Fact]
        public void MultiplyTestFact() {

            //Arrange
            double num1 = 10;
            double num2 = 2;
            double expected = 20;

            //Act
            var res = CalculatorFunctions.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(10, 2, 20)]
        [InlineData(10, 1, 10)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(5, 4, 20)]
        public void MultiplyTestTheory(double num1, double num2, double expected) {

            //Act
            var res = CalculatorFunctions.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }


        [Fact]
        public void DivideTestFact() {

            //Arrange
            double num1 = 10;
            double num2 = 2;
            double expected = 5;

            //Act
            var res = CalculatorFunctions.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(10, 10, 1)]
        [InlineData(5, 5, 1)]
        [InlineData(20, 5, 4)]
        [InlineData(8, 2, 4)]
        public void DivideTestTheory(double num1, double num2, double expected) {

            //Act
            var res = CalculatorFunctions.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, res);

        }


    }

}