using Microsoft.EntityFrameworkCore;
using Spg.SpengerAdmin.Infrastructure;

namespace Spg.SpengerAdmin.DomainModelTest
{
    public class DatabaseTests
    {
        [Fact(DisplayName = "Should Create Database")]
        public void Should_CreateDatabase()
        {
            // Arrange
            DbContextOptions options = new DbContextOptionsBuilder()
                .UseSqlite("Data Source = SpengerAdmin.db")
                .Options;

            SpengerContext db = new SpengerContext(options);
            db.Database.EnsureDeleted();
            
            // Act
            db.Database.EnsureCreated();

            // Assert
            Assert.True(true);
        }

        [Fact()]
        public void Product_ShouldNOTCreate_WhenCategoryIsNull()
        {

        }

        [Fact()]
        public void Product_ShouldThrowException_WhenExpiryDateNotInFuture()
        {

        }
    }
}