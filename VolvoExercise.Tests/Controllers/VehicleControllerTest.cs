using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using VolvoExercise.Controllers;
using VolvoExercise.Data;
using VolvoExercise.Models;
using Moq;

namespace VolvoExercise.Tests.Controllers
{
    public sealed class VehicleControllerTest
    {
        private VolvoExerciseDbContext context;
        [Fact]
        public void AddVehicleCall()
        {
            var dbContextOptions = new DbContextOptionsBuilder<VolvoExerciseDbContext>();
            dbContextOptions.UseInMemoryDatabase("VolvoExerciseDbTest");

            context = new VolvoExerciseDbContext(dbContextOptions.Options);

            VehicleController vehicleController = new VehicleController(context);
            var tempDataProvider = new Mock<ITempDataProvider>();
            vehicleController.TempData = new TempDataDictionary(new DefaultHttpContext(), tempDataProvider.Object);

            var chassisId = new ChassisId("ABC123", 123321);
            var vehicle = new Vehicle(1, chassisId, "Bus", "Deep Black", 42);

            ViewResult? controller = vehicleController.AddVehicle(vehicle) as ViewResult;

            Assert.Null(controller);
        }

        [Fact]
        public void EditVehicleCall()
        {
            var dbContextOptions = new DbContextOptionsBuilder<VolvoExerciseDbContext>();
            dbContextOptions.UseInMemoryDatabase("VolvoExerciseDbTest");

            context = new VolvoExerciseDbContext(dbContextOptions.Options);

            VehicleController vehicleController = new VehicleController(context);

            var id = 1;

            ViewResult? controller = vehicleController.EditVehicle(id) as ViewResult;

            Assert.NotNull(controller);
        }
    }
}
