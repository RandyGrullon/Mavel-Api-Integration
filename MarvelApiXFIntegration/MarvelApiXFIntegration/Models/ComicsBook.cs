using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MarvelApiXFIntegration.Models
{
    public class PriceComic
    {

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }

    public class Thumbnail
    {

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        public string ImageComic { get =>$"{Path.Replace("http", "https")}.{Extension}";}
    }

    public class Image
    {

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }
    }

    public class Comic
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("digitalId")]
        public int DigitalId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("issueNumber")]
        public int IssueNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public object Modified { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("prices")]
        public IList<PriceComic> Prices { get; set; }

        [JsonProperty("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonProperty("images")]
        public IList<Image> Images { get; set; }

        public string ImageComic { get => $"{Thumbnail.Path.Replace("http", "https")}.{Thumbnail.Extension}"; }
    }

    public class Data
    {

        [JsonProperty("results")]
        public IList<Comic> Results { get; set; }
    }


    public class ComicsBook
    {

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}

