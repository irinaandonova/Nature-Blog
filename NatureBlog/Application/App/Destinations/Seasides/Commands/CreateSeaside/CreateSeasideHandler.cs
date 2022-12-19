﻿using NatureBlog.Application.Repositories;
using MediatR;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.Destinations.Seasides.Commands.CreateSeaside
{
    public class CreateSeasideHandler : IRequestHandler<CreateSeasideCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateSeasideHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(CreateSeasideCommand command, CancellationToken cancellationToken)
        {
            try
            {
                Seaside seaside = new Seaside { Name = command.Name, CreatorId = command.CreatorId, Description = command.Description, ImageUrl = command.ImageUrl, RegionId = command.RegionId, OffersUmbrella = command.OffersUmbrella, IsGuarded= command.IsGuarded };
                
                _unitOfWork.DestinationRepository.AddSeaside(seaside);
                await _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in Add Method:" + ex.Message);
                return false;
            }
        }
    }
}
