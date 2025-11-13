using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VolvoExercise.Models
{
    [Owned]
    public class ChassisId
    {
        private String _series;
        private UInt32 _number;

        public ChassisId() { }

        public ChassisId(String series, UInt32 number) 
        {
            _series = series;
            _number = number;
        }

        [Required]
        public String Series { get { return _series; } set { _series = value; } }
        [Required]
        public UInt32 Number { get { return _number; } set { _number = value; } }
    }
}
