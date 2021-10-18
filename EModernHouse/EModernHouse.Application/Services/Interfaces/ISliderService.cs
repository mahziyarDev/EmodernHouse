using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entites.Contacts;
using EModernHouse.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.Application.Services.Interfaces
{
    public interface ISliderService : IAsyncDisposable
    {
        Task<List<Slider>> GetAllSlider();
    }
}