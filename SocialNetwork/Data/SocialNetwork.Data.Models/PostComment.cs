namespace SocialNetwork.Data.Models
{
    using SocialNetwork.Data.Common.Models;

    public class PostComment : BaseDeletableModel<string>
    {
        public string Content { get; set; }

        public string ApplicationUserPostId { get; set; }

        public virtual ApplicationUserPost ApplicationUserPost { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
