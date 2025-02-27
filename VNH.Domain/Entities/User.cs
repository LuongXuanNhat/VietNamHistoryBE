﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using VNH.Domain.Entities;
using VNH.Domain.Enums;

namespace VNH.Domain
{
    [Table("User")]
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            AnswerVotes = new HashSet<AnswerVote>();
            Answers = new HashSet<Answer>();
            CourseComments = new HashSet<CourseComment>();
            CourseRatings = new HashSet<CourseRating>();
            CourseSaves = new HashSet<CourseSave>();
            CourseSubComments = new HashSet<CourseSubComment>();
            Courses = new HashSet<Course>();
            DocumentSaves = new HashSet<DocumentSave>();
            Documents = new HashSet<Document>();
            ExerciseDetails = new HashSet<ExerciseDetail>();
            PostComments = new HashSet<PostComment>();
            PostLikes = new HashSet<PostLike>();
            PostReportDetails = new HashSet<PostReportDetail>();
            PostSaves = new HashSet<PostSave>();
            PostSubComments = new HashSet<PostSubComment>();
            Posts = new HashSet<Post>();
            MultipleChoices = new HashSet<MultipleChoice>();
            QuestionLikes = new HashSet<QuestionLike>();
            QuestionReportDetails = new HashSet<QuestionReportDetail>();
            QuestionSaves = new HashSet<QuestionSave>();
            Questions = new HashSet<Question>();
            Searches = new HashSet<Search>();
            SubAnswers = new HashSet<SubAnswer>();
            Topics = new HashSet<Topic>();
            NotificationDetails = new HashSet<NotificationDetail>();
        }

        [StringLength(100)]
        public string Fullname { get; set; }

        [Column(TypeName = "datetime")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        public string Introduction { get; set; }
        public Gender Gender { get; set; }
        public string Image { get; set; } = string.Empty;
        public string NumberConfirm { get; set; } // Confirm Email
        public bool IsDeleted { get; set; } = false;
        [InverseProperty("User")]
        public virtual ICollection<AnswerVote> AnswerVotes { get; set; }
        [InverseProperty("Author")]
        public virtual ICollection<Answer> Answers { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<MultipleChoice> MultipleChoices{ get; set; }

        [InverseProperty("User")]
        public virtual ICollection<CourseComment> CourseComments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CourseRating> CourseRatings { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CourseSave> CourseSaves { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<CourseSubComment> CourseSubComments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Course> Courses { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<DocumentSave> DocumentSaves { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Document> Documents { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<ExerciseDetail> ExerciseDetails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PostComment> PostComments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PostLike> PostLikes { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PostReportDetail> PostReportDetails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PostSave> PostSaves { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<PostSubComment> PostSubComments { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Post> Posts { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<QuestionLike> QuestionLikes { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<QuestionReportDetail> QuestionReportDetails { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<QuestionSave> QuestionSaves { get; set; }
        [InverseProperty("Author")]
        public virtual ICollection<Question> Questions { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Search> Searches { get; set; }
        [InverseProperty("Author")]
        public virtual ICollection<SubAnswer> SubAnswers { get; set; }
        [InverseProperty("Author")]
        public virtual ICollection<Topic> Topics { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<NotificationDetail> NotificationDetails { get; set; }

       
    }
}