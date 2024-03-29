﻿using MediatR;
using NatureBlog.Application.Exceptions;
using NatureBlog.Application.Repositories;

namespace NatureBlog.Application.App.Regions.Commands.DeleteRegion
{
    public class DeleteRegionHandler : IRequestHandler<DeleteRegionCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteRegionHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteRegionCommand command, CancellationToken cancellationToken)
        {
            try
            {
                bool result = _unitOfWork.RegionRepository.Delete(command.Id);
                if (result == false)
                    throw new ModificationFailedException("Region wasn't deleted!");

                await _unitOfWork.Save();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in DeleteRegion method", ex.Message);
                throw ex;
            }
        }
    }
}
