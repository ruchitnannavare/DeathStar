﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DeepGate.Models
{
    public class WallhavenResponse
    {
        [JsonPropertyName("data")]
        public WallhavenData Data { get; set; }
    }

    public class WallhavenData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("short_url")]
        public string ShortUrl { get; set; }

        [JsonPropertyName("uploader")]
        public Uploader Uploader { get; set; }

        [JsonPropertyName("views")]
        public int Views { get; set; }

        [JsonPropertyName("favorites")]
        public int Favorites { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("purity")]
        public string Purity { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("dimension_x")]
        public int DimensionX { get; set; }

        [JsonPropertyName("dimension_y")]
        public int DimensionY { get; set; }

        [JsonPropertyName("resolution")]
        public string Resolution { get; set; }

        [JsonPropertyName("ratio")]
        public string Ratio { get; set; }

        [JsonPropertyName("file_size")]
        public int FileSize { get; set; }

        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("colors")]
        public List<string> Colors { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("thumbs")]
        public Thumbs Thumbs { get; set; }

        [JsonPropertyName("tags")]
        public List<Tag> Tags { get; set; }
    }

    public class Uploader
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("group")]
        public string Group { get; set; }

        [JsonPropertyName("avatar")]
        public Avatar Avatar { get; set; }
    }

    public class Avatar
    {
        [JsonPropertyName("200px")]
        public string Size200px { get; set; }

        [JsonPropertyName("128px")]
        public string Size128px { get; set; }

        [JsonPropertyName("32px")]
        public string Size32px { get; set; }

        [JsonPropertyName("20px")]
        public string Size20px { get; set; }
    }

    public class Thumbs
    {
        [JsonPropertyName("large")]
        public string Large { get; set; }

        [JsonPropertyName("original")]
        public string Original { get; set; }

        [JsonPropertyName("small")]
        public string Small { get; set; }
    }

    public class Tag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("alias")]
        public string Alias { get; set; }

        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("purity")]
        public string Purity { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; }
    }
}