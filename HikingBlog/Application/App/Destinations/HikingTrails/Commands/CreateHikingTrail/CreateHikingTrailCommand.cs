﻿using MediatR;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Destinations.HikingTrails.Commands.CreateHikingTrail
{
    public class CreateHikingTrailCommand: IRequest<int?>
    {
        public string Name { get; set; }

        public User Creator { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Region Region { get; set; }

        public int Difficulty { get; set; }

        public int Duration { get; set; }

        public int? RatingScore { get; set; } = null;

        public ICollection<Comment> Comments { get; set; } = null;

        public ICollection<Rating> Ratings { get; set; } = null;

        public ICollection<User> Visitors { get; set; } = null;
    }
}
