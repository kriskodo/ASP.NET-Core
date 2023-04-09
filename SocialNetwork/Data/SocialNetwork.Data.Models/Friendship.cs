namespace SocialNetwork.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    using SocialNetwork.Data.Common.Models;

    public class Friendship : BaseDeletableModel<string>
    {
        [ForeignKey(nameof(ApplicationUser))]
        public string RequesterId { get; set; }

        public virtual ApplicationUser Requester { get; set; }

        [ForeignKey(nameof(ApplicationUser))]
        public string AccepterId { get; set; }

        public virtual ApplicationUser Accepter { get; set; }
    }
}
