﻿using NatureBlog.Application.Repositories;
using MediatR;
using NatureBlog.Application.Exceptions;
using NatureBlog.Domain.Models;
using NatuteBlog.Application.Destinations.HikingTrails.Queries.FilterHikingTrails;

namespace NatureBlog.Application.Destinations.HikingTrails.Queries.FilterHikingTrails
{/*
    public class FilterHikingTrailsHandler : IRequestHandler<FilterHikingTrailsQuery, List<HikingTrail>>
    {
        private readonly IDestinationRepository _repository;

        public FilterHikingTrailsHandler(IDestinationRepository destinationRepository)
        {
            _repository = destinationRepository;
        }

        public Task<List<HikingTrail>> Handle(FilterHikingTrailsQuery querry, CancellationToken cancellationToken)
        {
            
            try
            {
                List<HikingTrail> hikingTrailsList = _repository.FilterHikingTrails(querry.difficulty);

                if (hikingTrailsList.Count() < 0)
                    throw new DestinationNotFoundException("There are no hiking trail elements that fullfil the condition in the collection");

                return Task.FromResult(hikingTrailsList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in the FilterHikingTrails Method" + ex.Message);
                return null;
            }
        }
            }
            */
    
}