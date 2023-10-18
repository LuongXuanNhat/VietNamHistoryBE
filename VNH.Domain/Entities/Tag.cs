﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using VNH.Domain.Entities;

namespace VNH.Domain
{
    [Table("Tag")]
    public partial class Tag
    {
        public Tag()
        {
            Id = Guid.NewGuid();
            ////QuestionTags = new HashSet<QuestionTag>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(255)]
        public string Name { get; set; }

        [InverseProperty("Tag")]
        public virtual ICollection<QuestionTag> QuestionTags { get; set; }
        [InverseProperty("Tag")]
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}