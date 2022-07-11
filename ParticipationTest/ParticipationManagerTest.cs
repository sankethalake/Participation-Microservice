using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using ParticipationMicroservice.Controllers;
using ParticipationMicroservice.DBContexts;
using ParticipationMicroservice.Model;
using ParticipationMicroservice.Models.DataManager;
using ParticipationMicroservice.Models.Repository;
using System.Collections.Generic;
using System.Net.Http;

namespace ParticipationTest
{
    [TestFixture]
    public class Tests
    {
        ParticipationManager _dataRepository;
        [SetUp]
        public void Setup()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ParticipationContext>();
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server=DESKTOP-A2H2D45;database=ParticipationDB;Integrated Security=True");  
            ParticipationContext participationContext = new ParticipationContext(optionsBuilder.Options);
            _dataRepository = new ParticipationManager(participationContext);
        }

        [Test]
        public void Test_GetAll()
        {
            // Arrange
            var controller = new ParticipationController(_dataRepository);

            // Act
            var result = controller.Get();
            var okResult = result as OkObjectResult;

            // Assert
            Assert.IsNotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }

        [Test]
        public void Test_Add()
        {
        }
    }
}