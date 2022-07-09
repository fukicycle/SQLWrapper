namespace SQLWrapperTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBSettings.DB_HOST = "localhost";
            DBSettings.DB_NAME   = "champion_road";
            DBSettings.DB_USERNAME = "root";
            DBSettings.DB_PASSWORD = "P@ssWord";
        }

        [Test]
        [Order(0)]
        public void GetConnectionStringTest()
        {
            Assert.IsTrue(DBSettings.GetConnectionString() == $"SERVER={DBSettings.DB_HOST}; DATABASE={DBSettings.DB_NAME}; UID={DBSettings.DB_USERNAME}; PASSWORD={DBSettings.DB_PASSWORD};");
        }
    }
}