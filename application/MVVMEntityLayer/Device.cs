using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMEntityLayer
{
    [Table("devices", Schema = "Public")]
    public partial class Device
    {
        public int Id { get; set; }
        public int SubId { get; set; }
    }
}