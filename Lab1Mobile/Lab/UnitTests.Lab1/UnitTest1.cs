using Lab.Services;
using System;
using Xunit;

namespace UnitTests.Lab1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Act
            var result = new MockDataStore();
            //Arrange
            var collection = result.GetItemsAsync(false);
            //Assert
            Assert.Empty(collection.Result);
        }
    }
}
