using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsTrackingApp.Models;

namespace SportsTrackingApp.Controllers;

public class FitnessController : Controller
{
    private readonly ActivityContext _context;

    public FitnessController(ActivityContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var activities = await _context.FitnessActivities.ToListAsync();
        return View(activities);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create([Bind("Date,Type,DurationMinutes")] FitnessActivity activity)
    {
        _context.FitnessActivities.Add(activity);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var activity = _context.FitnessActivities.Find(id);
        if (activity == null)
        {
            return NotFound();
        }
        return View(activity);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Type,DurationMinutes")] FitnessActivity activity)
    {
        if (await _context.FitnessActivities.AnyAsync(a => a.Id == id))
        {
            activity = (await _context.FitnessActivities.FindAsync(id))!;
            _context.FitnessActivities.Update(activity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        else
        {
            return NotFound();
        }
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        var activity = await _context.FitnessActivities.FindAsync(id);
        if (activity != null)
        {
            _context.FitnessActivities.Remove(activity);
            await _context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Index));
    }
}