using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVVMEntityLayer
{
    public partial class UserLogin
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}