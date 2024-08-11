using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetStoreContext : DbContext
    {
        public PetStoreContext(DbContextOptions<PetStoreContext> options) : base(options)
        {

        }
        public DbSet<Animal>? Animal { get; set; }
        public DbSet<Comment>? Comment { get; set; }
        public DbSet<Category>? Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>().HasData(
    new Animal
    {
        AnimalId = 2,
        Name = "Elephant",
        Age = 15,
        PictureName = "elephant.jpg",
        Description = "Large land mammal with tusks",
        CategoryId = 1 // Mammals
    },
    new Animal
    {
        AnimalId = 3,
        Name = "Eagle",
        Age = 8,
        PictureName = "eagle.jpg",
        Description = "Majestic bird of prey",
        CategoryId = 2 // Birds
    },
    new Animal
    {
        AnimalId = 4,
        Name = "Shark",
        Age = 20,
        PictureName = "shark.jpg",
        Description = "Powerful marine predator",
        CategoryId = 3 // Fish
    },
    new Animal
    {
        AnimalId = 5,
        Name = "Giraffe",
        Age = 10,
        PictureName = "giraffe.jpg",
        Description = "Tall herbivorous mammal with a long neck",
        CategoryId = 1 // Mammals
    },
    new Animal
    {
        AnimalId = 6,
        Name = "Hawk",
        Age = 5,
        PictureName = "hawk.jpg",
        Description = "Bird of prey with excellent vision",
        CategoryId = 2 // Birds
    },
    new Animal
    {
        AnimalId = 7,
        Name = "Dolphin",
        Age = 12,
        PictureName = "dolphin.jpg",
        Description = "Intelligent marine mammal known for its playful behavior",
        CategoryId = 1 // Mammals
    },
    new Animal
    {
        AnimalId = 8,
        Name = "Penguin",
        Age = 3,
        PictureName = "penguin.jpg",
        Description = "Flightless bird adapted to cold climates",
        CategoryId = 2 // Birds
    },
    new Animal
    {
        AnimalId = 9,
        Name = "Salmon",
        Age = 2,
        PictureName = "salmon.jpg",
        Description = "Fish known for its migratory behavior",
        CategoryId = 3 // Fish
    },
    new Animal
    {
        AnimalId = 10,
        Name = "Kangaroo",
        Age = 7,
        PictureName = "kangaroo.jpg",
        Description = "Marsupial with a distinctive pouch for carrying young",
        CategoryId = 1 // Mammals
    },
    new Animal
    {
        AnimalId = 11,
        Name = "Owl",
        Age = 4,
        PictureName = "owl.jpg",
        Description = "Nocturnal bird of prey known for its hooting sound",
        CategoryId = 2 // Birds
    }

);

            modelBuilder.Entity<Category>().HasData(
    new Category
    {
        CategoryId = 1,
        Name = "Mammals"
    },
    new Category
    {
        CategoryId = 2,
        Name = "Birds"
    },
    new Category
    {
        CategoryId = 3,
        Name = "Fish"
    }
);

            modelBuilder.Entity<Comment>().HasData(
    new Comment
    {
        CommentId = 1,
        CommentText = "What a magnificent creature!",
        AnimalId = 2 // Elephant
    },
    new Comment
    {
        CommentId = 2,
        CommentText = "I love watching eagles soar in the sky!",
        AnimalId = 3 // Eagle
    },
    new Comment
    {
        CommentId = 3,
        CommentText = "Sharks are fascinating predators!",
        AnimalId = 4 // Shark
    },
    new Comment
    {
        CommentId = 4,
        CommentText = "Giraffes have such long necks!",
        AnimalId = 5 // Giraffe
    },
    new Comment
    {
        CommentId = 5,
        CommentText = "Dolphins are incredibly intelligent!",
        AnimalId = 7 // Dolphin
    },
    new Comment
    {
        CommentId = 6,
        CommentText = "Penguins are so cute!",
        AnimalId = 8 // Penguin
    },
    new Comment
    {
        CommentId = 7,
        CommentText = "Salmon's migratory journey is impressive!",
        AnimalId = 9 // Salmon
    },
    new Comment
    {
        CommentId = 8,
        CommentText = "Kangaroos are unique with their pouches!",
        AnimalId = 10 // Kangaroo
    },
    new Comment
    {
        CommentId = 9,
        CommentText = "Owls are mysterious creatures of the night.",
        AnimalId = 11 // Owl
    },
    new Comment
    {
        CommentId = 10,
        CommentText = "This zoo has an amazing collection of animals!",
        AnimalId = 2 // Elephant (for variety)
    }
);

        }
    }
}
