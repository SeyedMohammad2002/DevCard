﻿using System.Net.Mime;

namespace DevCard_MVC.Models
{
    public class Project
    {
        public Project(long id, string name, string description, string client, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Client { get; set; }

        public string Image { get; set; }
    }
}