namespace SQLWrapperTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBSettings.DB_HOST = "192.168.0.101";
            DBSettings.DB_NAME = "champion_road";
            DBSettings.DB_USERNAME = "dev";
            DBSettings.DB_PASSWORD = "P@ssWord";
        }

        [Test]
        [Order(1)]
        public void GetConnectionStringTest()
        {
            Assert.IsTrue(DBSettings.GetConnectionString() == $"SERVER={DBSettings.DB_HOST}; DATABASE={DBSettings.DB_NAME}; UID={DBSettings.DB_USERNAME}; PASSWORD={DBSettings.DB_PASSWORD};");
        }
        [Test]
        [Order(2)]
        public void ConnectTest()
        {
            Assert.IsTrue(MysqlWrapper.Connect());
        }

        [Test]
        [Order(3)]
        public void GetInstanceTest()
        {
            Assert.IsInstanceOf<MysqlWrapper>(MysqlWrapper.GetInstance());
        }

        [Test]
        [Order(4)]
        public void SameInstanceTest()
        {
            Assert.IsTrue(MysqlWrapper.GetInstance() == MysqlWrapper.GetInstance());
        }
    }
}