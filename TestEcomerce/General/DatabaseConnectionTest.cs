using Ecomerce.Context;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace TestEcomerce.General
{
    [TestFixture]
    public class DatabaseConnectionTest
    {
        private DBContext _dbContext;

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<DBContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;

            _dbContext = new DBContext(options);
        }

        [Test]
        public void TestDatabaseConnection()
        {
            Assert.DoesNotThrow(() => _dbContext.Database.CanConnect());
        }
    }
}
