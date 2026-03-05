using blogsite.Models;
using Microsoft.EntityFrameworkCore;

namespace blogsite.Data;

public class BlogContext: DbContext
{
    public  BlogContext (DbContextOptions<BlogContext> options) : base(options)
    {
        
    }

    public DbSet<Post> Post = default!; //database table

public DbSet<blogsite.Models.Post> Post_1 { get; set; } = default!;


}