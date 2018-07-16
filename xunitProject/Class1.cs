using System;
using xunitdemo;
using Xunit;
using Moq;

namespace xunitProject
{
    public class Class1
    {
        [Fact]
        public void AdditionTest()
        {
            var calc = new Calculator();
            var result = calc.Addition(1, 2);
            Assert.Equal(3, result);
        }

        [Fact]
        public void AdditionTest2()
        {
            var calc = new Calculator();
            var result = calc.Addition(1, 2);
            Assert.Equal(4, result);
        }
        [Fact]
        public void CreateUser()
        {
            var mockobject = new Mock<IUserRepository>();
            var user = new User { Age = 10, Name = "hhh" };
            mockobject.Setup(a => a.Add(user)).Returns(true);

            var usermanage = new UserManager(mockobject.Object);
            Assert.Throws<FormatException>(()=>usermanage.CreateNewUser(user));
        }


    }
}
