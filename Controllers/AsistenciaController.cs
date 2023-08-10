using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iglesia.Models; // Asegúrate de usar el namespace correcto de tu proyecto
using iglesia.Data;

public class AsistenciaController : Controller
{
    private readonly TuDbContext _context; // Asegúrate de usar el contexto de base de datos correcto de tu proyecto

    public AsistenciaController(TuDbContext context)
    {
        _context = context;
    }

    // Acción para mostrar la lista de eventos litúrgicos
 
           public IActionResult Index()
        {

         //   var miembro = _context.AsistenciaLiturgico.ToList();
            return View();
            //return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult ListarAsistencias()
        {
            var asistencia = _context.AsistenciaLiturgico.ToList();
            return View(asistencia);
        }
      /* List<int> evento = new List<int>();
        public int elegirevento(int id_evento){

            evento.Add(id_evento);
        }*/
        public IActionResult RegistrarEntrada(Asistencia asis)
        {
            if (ModelState.IsValid)
        { 
            
            asis.Fechahoraentrada = DateTime.UtcNow;
            asis.ID_evento=1;
            _context.AsistenciaLiturgico.Add(asis);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(asis);

            
        }

        public IActionResult MostrarEventosProgramados(){


        List<EventoModel> eventos = _context.EventosLiturgicos.ToList();
        return View(eventos);
    

        }

        


    


public async Task<IActionResult> FiltrarPorDocumento(int dni)
{
    try
    {
        List<Asistencia> asistenciasFiltradas = await _context.AsistenciaLiturgico
            .Where(a => a.Dni == dni)
            .ToListAsync();

        return View(asistenciasFiltradas);
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
}






    
}