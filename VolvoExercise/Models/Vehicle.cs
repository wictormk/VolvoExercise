using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace VolvoExercise.Models
{
    [PrimaryKey(nameof(_id))]
    public class Vehicle
    {
        private Int32 _id;
        private ChassisId _chassisId;
        private String _type;
        private String _color;
        private UInt32 _passengerCapacity;

        public Vehicle() { }

        public Vehicle(Int32 id, ChassisId chassisId, string type, string color, UInt32 passengerCapacity)
        {
            _id = id;
            ChassisId = chassisId;
            Type = type;
            Color = color;
            PassengerCapacity = passengerCapacity;
        }

        [Required]
        public Int32 Id { get { return _id; } }
        [Required]
        public ChassisId ChassisId { get { return _chassisId; } set { _chassisId = value; } }
        [Required]
        public String Type { get { return _type; } set { _type = value; } }
        [Required]
        public UInt32 PassengerCapacity { get { return _passengerCapacity; } set { _passengerCapacity = value; } }
        [Required]
        public String Color { get { return _color; } set { _color = value; } }
    }
}
