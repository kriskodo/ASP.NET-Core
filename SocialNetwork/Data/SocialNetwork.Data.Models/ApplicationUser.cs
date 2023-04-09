// ReSharper disable VirtualMemberCallInConstructor
namespace SocialNetwork.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using SocialNetwork.Data.Common.Models;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
            this.Posts = new HashSet<ApplicationUserPost>();
            this.Friendships = new HashSet<Friendship>();
            this.PostLikes = new HashSet<PostLike>();
            this.PostComments = new HashSet<PostComment>();
        }

        // Custom fields for this project
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Range(6, 20)]
        [Required]
        public string Password { get; set; }

        [Required]
        public CountryEnum Country { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<ApplicationUserPost> Posts { get; set; }

        public virtual ICollection<Friendship> Friendships { get; set; }

        public virtual ICollection<PostLike> PostLikes { get; set; }

        public virtual ICollection<PostComment> PostComments { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
    }
}
