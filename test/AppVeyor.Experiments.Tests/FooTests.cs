// Copyright (c) Arjen Post. See LICENSE in the project root for license information.

using Xunit;

namespace AppVeyor.Experiments.Tests
{
    public class FooTests
    {
        [Fact]
        public void TheBarMethodShouldReturnValue()
        {
            // Arrange
            var value = "foo";

            // Act
            var result = Foo.Bar(value);

            // Assert
            Assert.Equal(value, result);
        }
    }
}
