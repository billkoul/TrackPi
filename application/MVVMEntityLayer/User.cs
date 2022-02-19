using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMEntityLayer
{
    [Table("users", Schema = "Public")]
    public partial class User
    {
        public int? Id { get; set; }
        public int SubscriptionId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; }
        public int Status { get; set; }
    }
}