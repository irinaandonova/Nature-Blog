﻿using HikingBlog;
using HikingBlog.Extensions;
using HikingBlog.Models;
using HikingBlog.Services;
using System;

try
{
    WebAPI webApi = new WebAPI();
    /*
    User user = Exceptions.CreateUser("irina@", "irina");
    Park park = new Park("Layta", user, "Amazing park", "image.com", "Plovdiv", true, false);
    park.CreateComment(user, "Beautiful Park");
    park.ShowComments();
    webApi.AddDestination(park);

    Seaside seaside = new Seaside("Konstantin and Elena", user, "Amazing beach", "image1.com", "Varna", true, true);
    seaside.AddUmbrellaPrices(5.00);
    seaside.ShowUmbrellaPrices();
    webApi.AddDestination(seaside);
    //webApi.GetAllSeaside();
    HikingTrail hikingTrail = new HikingTrail("Rila lakes", user, "Beautiful trail", "sjsj.com", "Rila", 2, 20);
    hikingTrail.RateDestination(4, user);
    webApi.AddDestination(hikingTrail);
    webApi.GetFirstTen();
    hikingTrail.ShowFullInformation();
    */
    webApi.GetFirstTen();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
