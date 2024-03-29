﻿using MediatR;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Destinations.Parks.Queries.FilterParks
{
    public class FilterParksQuery : IRequest<List<Park>>
    {
        public bool HasPlayground;

        public bool IsDogFriendly;
    }
}
