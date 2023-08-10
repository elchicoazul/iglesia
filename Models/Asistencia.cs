
using System;
using Microsoft.EntityFrameworkCore;
namespace iglesia.Models;
public class Asistencia
{
    
    public int Id { get; set; }
    public int ID_evento { get; set; }
    public int Dni { get; set; }
    public DateTime Fechahoraentrada { get; set; }
    
}