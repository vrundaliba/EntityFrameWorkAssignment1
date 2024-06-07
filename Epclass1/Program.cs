using EFclass1;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

var dbcontect = new DataContext();


var user1 = new User
{
    Name = "Vrunda",
    Email = "vrunda.gohil@example.com",
    PhoneNumber = "123-456-7890"
};

var user2 = new User
{
    Name = "Karan",
    Email = "karan.Gohil@example.com",
    PhoneNumber = "987-654-3210"
};
dbcontect.Users.Add(user1);
dbcontect.Users.Add(user2);
dbcontect.SaveChanges();



var blogType = new BlogType
{
     
    Name = "cooking",
    Description = "A blog about cooking"
};

var postType = new PostType
{   
    Name = "Tutorial",
    Description = "A tutorial post"
};

dbcontect.BlogTypes.Add(blogType);
dbcontect.PostTypes.Add(postType);
dbcontect.SaveChanges();

var blog = new Blog
{
    Url = "http://example.com",
    IsPublic = true,
    Name = "vrunda",
    BlogTypeId = blogType.Id 
};
dbcontect.Blogs.Add(blog);
dbcontect.SaveChanges();



List<User> users;
List<Blog> blogs;
List<PostType> postTypes;
List<Post> posts;


posts = dbcontect.Posts.ToList();

users = dbcontect.Users.ToList();
var UserId = users.First().Id;

blogs = dbcontect.Blogs.ToList();
var BlogId = blogs.First().Id;

postTypes = dbcontect.PostTypes.ToList();
var postTypeId = postTypes.First().Id;


var newPost = new Post
{
    Title = "New Post Title",
    content = "This is the content of the new post",
    UserId = UserId,
    BlogId = BlogId,
    PostTypeId = postTypeId

};

dbcontect.Posts.Add(newPost);
dbcontect.SaveChanges();

Console.WriteLine("User List");
foreach (User user in users)
{
    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}, PhoneNumber: {user.PhoneNumber}");
}
Console.WriteLine(" ");
Console.WriteLine("Blog List");
foreach (Blog blg in blogs)
{
    Console.WriteLine($"Id: {blog.Id}, Name: {blg.Name}, Url: {blg.Url}");
}
Console.WriteLine(" ");
Console.WriteLine("Post List");
foreach (Post post in posts)
{
    Console.WriteLine($"Id: {post.Id}, Title: {post.Title}, Content: {post.content}, UserName: {post.Users.Name},, BlogUrl: {post.Blog.Url},, PosTypeName: {post.PostType.Name}");
}
Console.WriteLine(" ");
Console.WriteLine(" ");