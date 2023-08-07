using System;
using Microsoft.EntityFrameworkCore;
namespace iglesia.Models;
public class EventoModel
{
   
    public int ID_evento { get; set; }
    public string? Nombre { get; set; }
    
    public DateTimeOffset  Fecha { get; set; }
    public TimeSpan Hora_inicio { get; set; }
    public TimeSpan Hora_fin { get; set; }
    public string? Descripcion { get; set; }
    public double? Latitud { get; set; }
    public double? Longitud { get; set; }
}

