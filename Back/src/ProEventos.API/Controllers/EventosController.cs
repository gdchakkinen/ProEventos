﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    
    public class EventosController : ControllerBase
    {
       
        private readonly ProEventosContext _context;
        public EventosController(ProEventosContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        } 
        [HttpGet("{id}")]

        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);
        }            
    
        [HttpPost]
            public string Post()
            {
                return "Post Example";
            }
        
        [HttpPut ("{id}")]
            public string Put(int id)
            {
                return $"Put Example with id: {id}";
            }
        
        [HttpDelete ("{id}")]
            public string Delete(int id)
            {
                return $"Delete Example deleting id: {id}";
            }
    }
}
