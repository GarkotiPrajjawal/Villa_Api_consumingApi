﻿using Magic_Villa_webapp.Models.Dto;

namespace Magic_Villa_webapp.Services.IServices
{
    public interface IVillaService
    {
		Task<T> GetAllAsync<T>();
		Task<T> GetAsync<T>(int id);
		Task<T> CreateAsync<T>(VillaCreateDTO dto);
		Task<T> UpdateAsync<T>(VillaUpdateDTO dto);
		Task<T> DeleteAsync<T>(int id);
	}
}
