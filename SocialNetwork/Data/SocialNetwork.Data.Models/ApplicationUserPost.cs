namespace SocialNetwork.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using SocialNetwork.Data.Common.Models;

    public class ApplicationUserPost : BaseDeletableModel<string>
    {
        [Required]
        [Range(1, 10000)]
        public string PostContent { get; set; }

        public string Location { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
