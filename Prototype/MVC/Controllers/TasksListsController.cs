using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UtaPrototype.Models;

namespace UtaPrototype.Controllers
{
    public class TasksListsController : Controller
    {
        private readonly UtaDbContext _context;

        public TasksListsController(UtaDbContext context)
        {
            _context = context;
        }

        // GET: TasksLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.TasksLists.ToListAsync());
        }

        // GET: TasksLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasksList = await _context.TasksLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tasksList == null)
            {
                return NotFound();
            }

            return View(tasksList);
        }

        // GET: TasksLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TasksLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TaskName,TaskInfo,TaskPrority,DateCreated,DueDate,IsComplete")] TasksList tasksList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tasksList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tasksList);
        }

        // GET: TasksLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasksList = await _context.TasksLists.FindAsync(id);
            if (tasksList == null)
            {
                return NotFound();
            }
            return View(tasksList);
        }

        // POST: TasksLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TaskName,TaskInfo,TaskPrority,DateCreated,DueDate,IsComplete")] TasksList tasksList)
        {
            if (id != tasksList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tasksList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TasksListExists(tasksList.Id))
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
            return View(tasksList);
        }

        // GET: TasksLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tasksList = await _context.TasksLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tasksList == null)
            {
                return NotFound();
            }

            return View(tasksList);
        }

        // POST: TasksLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tasksList = await _context.TasksLists.FindAsync(id);
            _context.TasksLists.Remove(tasksList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TasksListExists(int id)
        {
            return _context.TasksLists.Any(e => e.Id == id);
        }
    }
}
