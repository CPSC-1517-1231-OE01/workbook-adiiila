using ObjectClassLibrary;
using FluentAssertions;
using System.Runtime.Intrinsics.X86;

namespace ObjectClassLibraryTest
{
    
    public class BodyMassIndexTest
    {
        [Theory]
        [InlineData("Jack Black", 180,65)]
        public void BodyMassIndex_Bmi_ProperlyCalculatesBMI(string name, double weight, double height)
        {
            // Arrange
            BodyMassIndex bmi = new BodyMassIndex(name, weight, height);

            double actualBmi;
            double expectedBmi = 30.0;
            // Act 
            actualBmi = bmi.Bmi();

            // Assert
            actualBmi.Should().Be(expectedBmi);
        }

        [Theory]
        [InlineData("Jack Black", 180, 65)]
        public void BodyMassIndex_BmiCategory_ProperlyDeterminesCategory(string name, double weight, double height)
        {
            // Arrange 
            BodyMassIndex bmi = new BodyMassIndex(name, weight, height);
            string expectedBmiCategory = "obese";
            string actualBmiCategory;

            // Act
            actualBmiCategory = bmi.BmiCategory();

            // Assert
            actualBmiCategory.Should().Be(expectedBmiCategory);
        }

        [Theory]
        [InlineData("", 180, 65)]
        [InlineData(" ", 180, 65)]
        public void BodyMassIndex_NameProperty_ThrowExceptionWhenNull(string name, double weight, double height)
        {
            // Arrange
            Action act = () => new BodyMassIndex(name, weight, height);

            // Act and assert
            act.Should().Throw<ArgumentNullException>("Name cannot be blank");
        }

        [Theory]
        [InlineData("Jack Black", 0, 65)]
        [InlineData("Jack Black", -100, 65)]

        public void BodyMassIndex_WeightProperty_ThrowsExceptionWhenNonPositive(string name, double weight, double height)
        {
            // Arrange
            Action act = () => new BodyMassIndex(name, weight, height);

            // Act and Assert
            act.Should().Throw<ArgumentOutOfRangeException>("Weight must be a positive non-zero value");  
        }

        [Theory]
        [InlineData("Jack Black", 180, 0)]
        [InlineData("Jack Black", 180, -100)]
        public void BodyMassIndex_HeightProperty_ThrowsExceptionWehnNonPositive(string name, double weight, double height)
        {
            // Arrange 
            Action act = () => new BodyMassIndex(name, weight, height);

            // Act and Assert
            act.Should().Throw<ArgumentOutOfRangeException>("Height must be a positive non-zero number");
        }

        [Theory]
        [InlineData("Normal weight Person1", 111, 65, 18.5, "normal")]
        [InlineData("Normal weight Person2", 149, 65, 24.8, "normal")]
        public void BodyMassIndex_BmiCategory_ReturnsNormalWeightCategory(string name, double weight, double height, double Bmi, string bmicategory)
        {
            // Arrange
            BodyMassIndex bmi = new BodyMassIndex(name, weight, height);
            double expectedBmi = Bmi;
            string expectedBmiCategory = bmicategory;

            // Act
            double actualBmi = bmi.Bmi();
            string actualBmiCategory = bmi.BmiCategory();

            // Assert
            actualBmi.Should().Be(expectedBmi);
            actualBmiCategory.Should().Be(expectedBmiCategory);
        }

        [Theory]
        [InlineData("Overweight weight Person1", 150, 65, 25.0, "overweight")]
        [InlineData("Overweight weight Person2", 179, 65, 29.8, "overweight")]
        public void BodyMassIndex_BmiCategory_ReturnsOverWeightCategory(string name, double weight, double height, double Bmi, string bmicategory)
        {
            // Arrange
            BodyMassIndex bmi = new BodyMassIndex(name, weight, height);
            double expectedBmi = Bmi;
            string expectedBmiCategory = bmicategory;

            // Act
            double actualBmi = bmi.Bmi();
            string actualBmiCategory = bmi.BmiCategory();

            // Assert
            actualBmi.Should().Be(expectedBmi);
            actualBmiCategory.Should().Be(expectedBmiCategory);
        }

        [Theory]
        [InlineData("Obese Person1", 180, 65, 30.0, "obese")]
        [InlineData("Obese Person2", 210, 65, 34.9, "obese")]
        public void BodyMassIndex_BmiCategory_ReturnsObeseCategory(string name, double weight, double height, double Bmi, string bmicategory)
        {
            // Arrange
            BodyMassIndex bmi = new BodyMassIndex(name, weight, height);
            double expectedBmi = Bmi;
            string expectedBmiCategory = bmicategory;

            // Act
            double actualBmi = bmi.Bmi();
            string actualBmiCategory = bmi.BmiCategory();

            // Assert
            actualBmi.Should().Be(expectedBmi);
            actualBmiCategory.Should().Be(expectedBmiCategory);
        }
    }
}