using System;
using System.Collections.Generic;
using System.Text;
using VolvoExercise.Models;

namespace VolvoExercise.Tests.Models
{
    public class VehicleTest
    {
        [Fact]
        public void Constructor_EmptyParameters()
        {
            var vehicle = new Vehicle();

            Assert.Equal(0, vehicle.Id);
            Assert.Equal(null, vehicle.ChassisId);
            Assert.Equal(null, vehicle.Type);
            Assert.Equal(0.0, vehicle.PassengerCapacity);
            Assert.Equal(null, vehicle.Color);
        }

        [Fact]
        public void Constructor_GivenAllParameters()
        {
            Int32 expectedId = 1;
            ChassisId expectedChassisId = new ChassisId("ABC123", 123321);
            String expectedType = "Bus";
            UInt32 expectedPassengerCapacity = 42;
            String expectedColor = "DarkBlue";

            var vehicle = new Vehicle(expectedId, expectedChassisId, expectedType, expectedColor, expectedPassengerCapacity);

            Assert.Equal(1, vehicle.Id);
            Assert.NotNull(vehicle.ChassisId);
            Assert.Equal(expectedType, vehicle.Type);
            Assert.Equal(expectedPassengerCapacity, vehicle.PassengerCapacity);
            Assert.Equal(expectedColor, vehicle.Color);
        }
    }
}
