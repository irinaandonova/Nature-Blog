﻿using NatureBlog.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Presenatation.Dto.Destination.Seaside
{
    public class SeasidePostDto
    {
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public int CreatorId { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(2)]
        public string Description { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(5)]
        public string ImageUrl { get; set; }

        [Required]
        public int RegionId { get; set; }

        [Required]
        public bool IsGuarded { get; set; }

        [Required]
        public bool OffersUmbrella { get; set; }
    }
}
