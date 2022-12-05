﻿using MediatR;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Destinations.Parks.Commands.CreatePark
{
    public class CreateParkCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public Guid Creator { get; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public string Region { get; set; }

        public int? RatingScore { get; set; } = null;

        public Dictionary<Guid, Comment> Comments { get; set; } = new Dictionary<Guid, Comment> { };

        public Dictionary<User, int> Ratings { get; set; } = new Dictionary<User, int> { };

        public List<User> Visitors { get; set; } = new List<User> { };

        public bool HasPlayground { get; set; }

        public bool IsDogFriendly { get; set; }
    }
}