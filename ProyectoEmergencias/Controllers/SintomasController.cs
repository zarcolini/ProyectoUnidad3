using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoEmergencias;
using ProyectoEmergencias.Models;

namespace ProyectoEmergencias.Controllers
{
    public class SintomasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SintomasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Sintomas
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Sintomas.Include(s => s.Doctor).Include(s => s.Paciente);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Sintomas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintomas
                .Include(s => s.Doctor)
                .Include(s => s.Paciente)
                .FirstOrDefaultAsync(m => m.SintomasID == id);
            if (sintoma == null)
            {
                return NotFound();
            }

            return View(sintoma);
        }

        // GET: Sintomas/Create
        public IActionResult Create()
        {
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorID", "NombreDoc");
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "Nombre");
            return View();
        }

        // POST: Sintomas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SintomasID,Sintomas,Presion,Frecuencia_Cardiaca,Pulso,Temperatura,PacienteID,DoctorID")] Sintoma sintoma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sintoma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorID", "DoctorID", sintoma.DoctorID);
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "PacienteID", sintoma.PacienteID);
            return View(sintoma);
        }

        // GET: Sintomas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintomas.FindAsync(id);
            if (sintoma == null)
            {
                return NotFound();
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorID", "DoctorID", sintoma.DoctorID);
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "PacienteID", sintoma.PacienteID);
            return View(sintoma);
        }

        // POST: Sintomas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SintomasID,Sintomas,Presion,Frecuencia_Cardiaca,Pulso,Temperatura,PacienteID,DoctorID")] Sintoma sintoma)
        {
            if (id != sintoma.SintomasID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sintoma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SintomaExists(sintoma.SintomasID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DoctorID"] = new SelectList(_context.Doctors, "DoctorID", "DoctorID", sintoma.DoctorID);
            ViewData["PacienteID"] = new SelectList(_context.Pacientes, "PacienteID", "PacienteID", sintoma.PacienteID);
            return View(sintoma);
        }

        // GET: Sintomas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sintoma = await _context.Sintomas
                .Include(s => s.Doctor)
                .Include(s => s.Paciente)
                .FirstOrDefaultAsync(m => m.SintomasID == id);
            if (sintoma == null)
            {
                return NotFound();
            }

            return View(sintoma);
        }

        // POST: Sintomas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var sintoma = await _context.Sintomas.FindAsync(id);
            _context.Sintomas.Remove(sintoma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SintomaExists(int id)
        {
            return _context.Sintomas.Any(e => e.SintomasID == id);
        }
    }
}
