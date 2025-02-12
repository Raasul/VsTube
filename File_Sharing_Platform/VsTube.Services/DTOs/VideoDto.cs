﻿namespace MVC.VsTube.Services.DTOs
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime UploadDate { get; set; }
        public int UserId { get; set; }
    }
}
