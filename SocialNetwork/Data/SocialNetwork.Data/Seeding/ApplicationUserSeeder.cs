using SocialNetwork.Data.Models;
using System;
using System.Threading.Tasks;

namespace SocialNetwork.Data.Seeding
{
    public class ApplicationUserSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var user = new ApplicationUser
            {
                Id = "seeduser",
                Email = "kristiando@abv.bg",
                Country = CountryEnum.BULGARIA,
                FirstName = "Kristian",
                LastName = "Georgiev",
                PhoneNumber = "0877159139",
                Password = "123456",
            };

            var user2 = new ApplicationUser
            {
                Id = "seeduser2",
                Email = "ivan@abv.bg",
                Country = CountryEnum.BULGARIA,
                FirstName = "Ivan",
                LastName = "Ivanov",
                PhoneNumber = "0877159140",
                Password = "123456",
            };

            var post = new ApplicationUserPost
            {
                Id = "seedpost",
                ApplicationUser = user,
                Location = "103,121",
                PostContent = "Hi guys",
            };

            var like = new PostLike
            {
                Id = "seedlike",
                ApplicationUser = user2,
                ApplicationUserPost = post,
            };

            var comment = new PostComment
            {
                Id = "seedcomment",
                ApplicationUser = user,
                ApplicationUserPost = post,
                Content = "Hi !",
            };

            var friendship = new Friendship
            {
                Id = "seedfriendship",
                Accepter = user,
                Requester = user2,
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.Users.AddAsync(user2);

            await dbContext.Posts.AddAsync(post);

            await dbContext.PostLikes.AddAsync(like);

            await dbContext.PostComments.AddAsync(comment);

            await dbContext.SaveChangesAsync();
        }
    }
}
