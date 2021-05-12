using System;
using System.ComponentModel.DataAnnotations;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.App.Common
{
    public class BaseEntity
    {
        [Key]
        public Guid Guid { get; set; }
    }
}
