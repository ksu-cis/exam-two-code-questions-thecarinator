using System;
using ExamTwoCodeQuestions.Data;
using Xunit;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerUnitTests
    {
        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ShouldBeAbleToSetFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            cobbler.Fruit = fruit;
            Assert.Equal(fruit, cobbler.Fruit);
        }

        [Fact]
        public void ShouldBeServedWithIceCreamByDefault()
        {
            var cobbler = new Cobbler();
            Assert.True(cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetWithIceCream(bool serveWithIceCream)
        {
            var cobbler = new Cobbler();
            cobbler.WithIceCream = serveWithIceCream;
            Assert.Equal(serveWithIceCream, cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true, 5.32)]
        [InlineData(false, 4.25)]
        public void PriceShouldReflectIceCream(bool serveWithIceCream, double price)
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = serveWithIceCream
            };
            Assert.Equal(price, cobbler.Price);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var cobbler = new Cobbler();
            Assert.Empty(cobbler.SpecialInstructions);
        }

        [Fact]
        public void SpecialIstructionsShouldSpecifyHoldIceCream()
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = false
            };
            Assert.Collection<string>(cobbler.SpecialInstructions, instruction =>
            {
                Assert.Equal("Hold Ice Cream", instruction);
            });
        }

        [Fact]
        public void ShouldImplementIOrderItemInterface()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<IOrderItem>(cobbler);
        }

        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }
        [Fact]

        public void ChangingWithIceCreamShouldInvokePropertyChangedForWithIceCream()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () => { cobbler.WithIceCream = false; });
        }
        [Fact]

        public void ChangingWithIceCreamShouldInvokePropertyChangedForPrice()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Price", () => { cobbler.WithIceCream = false; });
        }
        [Fact]

        public void ChangingWithIceCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "SpecialInstructions", () => { cobbler.WithIceCream = false; });
        }

        [Fact]

        public void ChangingFruitToPeachShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => { cobbler.Fruit = FruitFilling.Peach; });

        }

        [Fact]

        public void ChangingFruitToBlueberryShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => { cobbler.Fruit = FruitFilling.Blueberry; });

        }
        [Fact]

        public void ChangingFruitToCherryShouldInvokePropertyChangedForFruit()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => { cobbler.Fruit = FruitFilling.Cherry; });

        }
    }
}
