using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iglesia.Models; // Asegúrate de usar el namespace correcto de tu proyecto
using iglesia.Data;

public class EventosLiturgicosController : Controller
{
    private readonly TuDbContext _context; // Asegúrate de usar el contexto de base de datos correcto de tu proyecto

    public EventosLiturgicosController(TuDbContext context)
    {
        _context = context;
    }

    // Acción para mostrar la lista de eventos litúrgicos
    public IActionResult Index()
    {
        List<EventoModel> eventos = _context.EventosLiturgicos.ToList();
        return View(eventos);
    }

    // Acción para mostrar los detalles de un evento litúrgico
    public IActionResult Details(int id)
    {
        EventoModel evento = _context.EventosLiturgicos.FirstOrDefault(e => e.ID_evento == id);
        if (evento == null)
        {
            return NotFound();
        }
        return View(evento);
    }

    // Acción para crear un nuevo evento litúrgico (GET)
    public IActionResult Create()
    {
        return View();
    }

    // Acción para crear un nuevo evento litúrgico (POST)
    [HttpPost]
    public IActionResult Create(EventoModel evento)
    {
        if (ModelState.IsValid)
        { 
            evento.Fecha = evento.Fecha.ToUniversalTime();
            _context.EventosLiturgicos.Add(evento);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(evento);
    }

    // Acción para editar un evento litúrgico (GET)
    public IActionResult Edit(int id)
    {
        EventoModel evento = _context.EventosLiturgicos.FirstOrDefault(e => e.ID_evento == id);
        if (evento == null)
        {
            return NotFound();
        }
        return View(evento);
    }

    // Acción para editar un evento litúrgico (POST)
    [HttpPost]
    public IActionResult Edit(int id, EventoModel evento)
    {
        if (id != evento.ID_evento)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
           evento.Fecha = evento.Fecha.ToUniversalTime();
            _context.Entry(evento).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(evento);
    }

    // Acción para eliminar un evento litúrgico (GET)
    public IActionResult Delete(int id)
    {
        EventoModel evento = _context.EventosLiturgicos.FirstOrDefault(e => e.ID_evento == id);
        if (evento == null)
        {
            return NotFound();
        }
        return View(evento);
    }

    // Acción para eliminar un evento litúrgico (POST)
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        EventoModel evento = _context.EventosLiturgicos.FirstOrDefault(e => e.ID_evento == id);
        if (evento == null)
        {
            return NotFound();
        }

        _context.EventosLiturgicos.Remove(evento);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
