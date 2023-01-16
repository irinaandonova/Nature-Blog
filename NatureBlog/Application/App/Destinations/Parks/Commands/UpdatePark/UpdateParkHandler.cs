﻿using MediatR;
using NatureBlog.Application.Repositories;
using NatureBlog.Domain.Models;

namespace NatureBlog.Application.App.Destinations.Parks.Commands.UpdatePark
{
    public class UpdateParkHandler : IRequestHandler<UpdateParkCommand, bool?>
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateParkHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork= unitOfWork;
        }

        public async Task<bool?> Handle(UpdateParkCommand command, CancellationToken cancellationToken)
        {
            try
            {
                Park park = (Park)_unitOfWork.DestinationRepository.GetDestination(command.Id);

                if (park.CreatorId != command.UserId)
                    return null;

                _unitOfWork.DestinationRepository.UpdatePark(command.Name, command.Id, command.RegionId, command.ImageUrl, command.Description, command.HasPlayground, command.IsDogFriendly);
                await _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception in the Update Park Method! " + ex.Message);
                return false;
            }
        }

    }
}
