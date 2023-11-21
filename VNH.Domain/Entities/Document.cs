﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VNH.Domain
{
    [Table("Document")]
    public partial class Document
    {
        public Document()
        {
            DocumentSaves = new HashSet<DocumentSave>();
        }

        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string SubId { get; set; }

        public string FileName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public Guid? UserId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedAt { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedAt { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Documents")]
        public virtual User User { get; set; }
        [InverseProperty("Document")]
        public virtual ICollection<DocumentSave> DocumentSaves { get; set; }
    }
}