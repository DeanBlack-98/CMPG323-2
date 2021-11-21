using ImageGallery.data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ImageGallery.data
{
    public class ImageGalleryDbContext : DbContext
    {
        public ImageGalleryDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }
    }
}
