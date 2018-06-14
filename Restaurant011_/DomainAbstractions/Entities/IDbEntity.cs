using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotation;

namespace Rest.DomainAbstractions.Entities
{
    public interface IDbEntity
    {
        [Key]
        Guid Id { get; set; }
    }
}
