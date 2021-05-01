using System;
using VaccinesDistributionReportAPI.API.v1.Controllers;
using Xunit;
using FakeItEasy;
using VaccinesDistributionReportAPI.API.v1.Repositories;
using Moq;
using VaccinesDistributionReportAPI.API.v1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace VaccinDistributionReportAPITest
{
    public class VaccineDeliveryReportControllerTests
    {
        [Fact]
        public async Task GetDelivery_Report()
        {
            //var dataStore = A.Fake<IDeliveryRepository>();
            //A.CallTo(() => dataStore.GetAllDeliveryReport()).Returns();
            //var controller = new VaccineDeliveryReportController(dataStore);
            // Arrange

            //var mockRepo = new Mock<IDeliveryRepository>();
            //mockRepo.Setup(repo => repo.AddDeliveryReport(new VaccineDeliveryReport())).Returns(Task.);
            //var controller = new VaccineDeliveryReportController(mockRepo.Object);
            //var model = new VaccineDeliveryReport() { Id=1, DeliveryDate= new DateTime(), GLN="xyz", HealthCareProvider="Hallunda", QuantityVial=345, ScheduledDeliveryDate=new DateTime(), VaccineSupplier="AstraZeneca"
            //};
            //ActionResult<VaccineDeliveryReport> result =await controller.AddDeliveryReport(model);

            //Assert.IsType<BadRequestObjectResult>(result.Result);

            // Arrange
            var controller = new VaccineDeliveryReportController()
             var model = new InputModel()

// Act
            ActionResult<Post> result = controller.Create();

            // Assert
            Post createdPost = result.Value;
            Assert.NotNull(createdPost);

        }
    }
}
