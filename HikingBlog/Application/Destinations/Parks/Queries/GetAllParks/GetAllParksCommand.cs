﻿using MediatR;
using NatureBlog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureBlog.Application.Destinations.Parks.Queries.GetAllPark
{
    public class GetAllParksCommand : IRequest<List<Park>>
    {
    }
}