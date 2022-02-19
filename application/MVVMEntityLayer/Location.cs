using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMEntityLayer
{
    [Table("location", Schema = "Public")]
    public partial class Location
    {
        public int Id { get; set; }
        public int DevId { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Alt { get; set; }
        public double Speed { get; set; }
        public string Time { get; set; }

        [DataType(DataType.Date)]
        public DateTime? Ts { get; set; }
    }
}