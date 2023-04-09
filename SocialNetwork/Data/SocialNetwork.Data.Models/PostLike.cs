namespace SocialNetwork.Data.Models
{
    using SocialNetwork.Data.Common.Models;

    public class PostLike : BaseDeletableModel<string>
    {
        public string ApplicationUserPostId { get; set; }

        public virtual ApplicationUserPost ApplicationUserPost { get; set; }

        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
