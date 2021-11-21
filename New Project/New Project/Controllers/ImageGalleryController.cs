﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ImageGallery.data.Models;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace New_Project.Controllers
{
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            var weeImageTags = new List<ImageTag>();

            var seaImageTags = new List<ImageTag>();

            var tag = new ImageTag()
            {
                Id = 0,
                Description = "Wam Bam"
            };
            var tag1 = new ImageTag()
            {
                Id = 1,
                Description = "Ocean"
            };
            var tag2 = new ImageTag()
            {
                Id = 2,
                Description = "Funny"
            };

            var imageList = new List<GalleryImage>();
            {
                new GalleryImage()
                {
                    Title = "wee",
                    Created = DateTime.Now,
                    Url = "",
                    Tags = weeImageTags
                };

                new GalleryImage()
                {
                    Title = "sea",
                    Created = DateTime.Now,
                    Url = "",
                    Tags = weeImageTags
                };

                new GalleryImage()
                {
                    Title = "sea wee",
                    Created = DateTime.Now,
                    Url = "",
                    Tags = weeImageTags
                };
                
            };
            var model = new GalleryIndexModel()
            {
                Images = imageList
            };
            return View(model);
        }
    }
}