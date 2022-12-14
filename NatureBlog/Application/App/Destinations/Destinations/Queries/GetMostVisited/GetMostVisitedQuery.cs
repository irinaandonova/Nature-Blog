using MediatR;
using NatureBlog.Application.Dto.Destination.Destination;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Destinations.AllDestinations.Queries.GetMostVisited
{
    public class GetMostVisitedQuery: IRequest<List<DestinationGetDto>>
    {
    }
}
