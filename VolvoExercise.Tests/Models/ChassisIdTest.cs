using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VolvoExercise.Models;

namespace VolvoExercise.Tests.Models
{
    public sealed class ChassisIdTest
    {
        [Fact]
        public void Constructor_EmptyParameters()
        {
            var chassisId = new ChassisId();

            Assert.Equal(null, chassisId.Series);
            Assert.Equal(0.0, chassisId.Number);
        }

        [Fact]
        public void Constructor_GivenAllParameters()
        {
            String expectedSeries = "";
            UInt32 expectedNumber = 0;

            var chassisId = new ChassisId(expectedSeries, expectedNumber);

            Assert.Equal(expectedSeries, chassisId.Series);
            Assert.Equal(expectedNumber, chassisId.Number);
        }
    }
}