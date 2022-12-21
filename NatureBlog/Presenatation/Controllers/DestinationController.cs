﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using NatureBlog.Application.Destinations.AllDestinations.Commands.DeleteDestination;
using NatureBlog.Application.Destinations.AllDestinations.Queries.FilterByRegion;
using NatureBlog.Application.Destinations.AllDestinations.Queries.GetMostVisited;
using NatureBlog.Application.Destinations.AllDestinations.Queries.SearchByKeyword;
using NatureBlog.Application.Destinations.AllDestinations.Queries.SordDestinations;
using NatureBlog.Application.Dto.Region;
using NatureBlog.Application.Dto.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NatureBlog.Presenatation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinationController : ControllerBase
    {
        public readonly IMediator _mediator;

        public DestinationController(IMapper mapper, IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetMostVisited()
        {
            var result = _mediator.Send(new GetMostVisited());

            if (result is null)
                return StatusCode(500);

            return Ok(result.Result);
        }

        [HttpGet]
        [Route("region/{id}")]
        public async Task<IActionResult> FilterByRegion(int id)
        {
            var result = await _mediator.Send(new FilterByRegionQuerry { RegionId = id });

            if (result is null)
                return StatusCode(500);

            if (result.Count == 0)
                return NotFound("No destinations in this region");

            return Ok(result);
        }

        [HttpGet]
        [Route("search?q={searchString}")]
        public async Task<IActionResult> SearchByKeyword(string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return BadRequest("Search string can't be empty");

            var result = await _mediator.Send(new SearchByStringQuery { KeyString = searchString });

            if (result.Count < 0)
                return NotFound("No destination, containing this search string");

            if (result is null)
                return StatusCode(500);

            return Ok(result);
        }

        [HttpGet]
        [Route("sort/{condition}")]
        public async Task<IActionResult> SortDestination(string condition)
        {
            if (string.IsNullOrEmpty(condition))
                return BadRequest("Condition can't be empty!");

            var result = await _mediator.Send(new SortDestinationsQuery{ Condition = condition });

            if(result is null)
                return StatusCode(500);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteDestination(int id, [FromBody] UserIdGetDto userId)
        {
            var result = await _mediator.Send(new DeleteDestinationCommand { DestinationId = id, UserId = userId.UserId });

            if (result)
                return Ok("Destination sucessfully deleted!");

            return BadRequest("No destination with such id!");
        }
    }
}
