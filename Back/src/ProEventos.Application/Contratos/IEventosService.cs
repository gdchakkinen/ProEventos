﻿using ProEventos.Domain;
using System.Threading.Tasks;

namespace ProEventos.Application.Contratos
{
    public interface IEventosService
    {
        Task<Evento> AddEventos(Evento model);
        Task<Evento> UpdateEventos(int eventoId, Evento model);
        Task<bool> DeleteEventos(int eventoId);
        Task<Evento[]> GetAllEventosByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes);
    }
}