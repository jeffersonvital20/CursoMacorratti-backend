using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Context;
using webapi.Models;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categorias01Controller : ControllerBase
    {
        private readonly AppDbContext _context;

        public Categorias01Controller(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.AsNoTracking().FirstOrDefault(c => c.CategoriaId == id);
            if (categoria == null)
            {
                return NotFound();
            }
            return categoria;
        }

         

    }
}
