﻿namespace BlazorApp.Models
{
    public record Movie
    {
        public string TitleId { get; set; } = default!;
        public string OriginalTitle { get; set; } = default!;
        public string TitleIT { get; set; } = default!;
        public int Year { get; set; }
        public string[] Directors { get; set; } = [];
        public string[] Countries { get; set; } = [];
    }
}
