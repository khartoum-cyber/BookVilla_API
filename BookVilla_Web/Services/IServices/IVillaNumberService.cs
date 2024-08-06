﻿using BookVilla_Web.Models.DTO;

namespace BookVilla_Web.Services.IServices
{
    public interface IVillaNumberService
    {
        Task<T> GetAllAsync<T>(string token);
        Task<T> GetAsync<T>(int id, string token);
        Task<T> CreateAsync<T>(VillaNumberDTOcreate dto, string token);
        Task<T> UpdateAsync<T>(VillaNumberDTOupdate dto, string token);
        Task<T> DeleteAsync<T>(int id, string token);
    }
}
