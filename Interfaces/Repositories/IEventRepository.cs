﻿using EventManager.Domain.Entities;

namespace EventManager.Interfaces.Repositories
{
    public interface IEventRepository
    {
        Task<Event> GetById(int id);

        Task<List<Event>> GetAll();

        Task Save(Event entity);
    }
}
