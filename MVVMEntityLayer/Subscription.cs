using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMEntityLayer
{
    [Table("subscription", Schema = "Public")]
    public partial class Subscription
    {
        public int? Id { get; set; }
        public string ApiKey { get; set; }
        public DateTime Created { get; set; }
        public DateTime Expires { get; set; }
        public int Status { get; set; }

    }
}