using Business_Logic_Layer;
using Cfa_Api.Controllers;
using Data_Access_Layer.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NSubstitute;
using System.Xml.Schema;
using Xunit;

namespace CfaAPI_xUnit
{
    public class UserControllerTest
    {
        private readonly IUserBLL _userBLL;
        [Fact]
        public void GetUserTest()
        {
            //Arrange
            var userBLL = Substitute.For<IUserBLL>();
            
            
           

            var _userModels = new List<User>()
            {
                 new User
            {
            Name = "Rajendra",
            Email = "rajendra.patel@qburst.com",
            Password = "rajendra"
            }
            };
            userBLL.GetUsers().Returns(_userModels);
            var userController = new UserController(userBLL);
            var _user = userController.GetUsers();
            Assert.Equal(_userModels, _user.Result.Value);
           
            //Act
           

            //Assert

           // Assert.NotNull(result);
           // Assert.IsType<ActionResult>(result);

           
        }
    }
}