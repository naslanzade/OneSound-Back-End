﻿namespace OneSoundApp.Models
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Blog> Blog { get; set; }
        public ICollection<Podcast> Podcast { get; set; }
    }
}
