using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using VolvoExercise.Controllers;
using VolvoExercise.Data;
using VolvoExercise.Models;

namespace VolvoExercise.Tests.Controllers
{
    public sealed class HomeControllerTest
    {
        private VolvoExerciseDbContext context;

        [Fact]
        public void IndexCall_WithoutParameters()
        {
            var dbContextOptions = new DbContextOptionsBuilder<VolvoExerciseDbContext>();
            dbContextOptions.UseInMemoryDatabase("VolvoExerciseDbTest");

            context = new VolvoExerciseDbContext(dbContextOptions.Options);

            HomeController homeController = new HomeController(context);

            ViewResult? controller = homeController.Index() as ViewResult;

            Assert.NotNull(controller);
        }

        [Fact]
        public void IndexCall_WithParameters()
        {
            String series = "ABC123";
            UInt32 number = 321123;

            var dbContextOptions = new DbContextOptionsBuilder<VolvoExerciseDbContext>();
            dbContextOptions.UseInMemoryDatabase("VolvoExerciseDbTest");

            context = new VolvoExerciseDbContext(dbContextOptions.Options);

            HomeController homeController = new HomeController(context);

            ViewResult? controller = homeController.Index(series, number) as ViewResult;

            Assert.NotNull(controller);
        }
    }
}
