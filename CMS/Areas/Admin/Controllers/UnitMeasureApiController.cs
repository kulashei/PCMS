using System.Collections;
using CMS.Data;
using CMS.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CMS.Areas.Admin.Controllers;

[Route("api/[controller]/[action]")]
public class UnitMeasureApiController : Controller
{
    private AppDbContext _context;

    public UnitMeasureApiController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
    {
        var unitsMeasures = _context.Units.Select(i => new
        {
            i.UnitId,
            i.UnitCode,
            i.UnitDesc,
        }).OrderBy(o => o.UnitCode);

        return Json(await DataSourceLoader.LoadAsync(unitsMeasures, loadOptions));
    }

    [HttpPost]
    public async Task<IActionResult> Post(string values)
    {
        var model = new Unit();
        var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
        PopulateModel(model, valuesDict);


        if (!TryValidateModel(model))
            return BadRequest(GetFullErrorMessage(ModelState));
        
        if (_context.Units.Any(u => u.UnitCode == model.UnitCode))
        {
            return BadRequest(new { message = "UnitCode already exists." });
        }

        var result = _context.Units.Add(model);
        await _context.SaveChangesAsync();

        return Json(new { result.Entity.UnitId });
    }

    [HttpPut]
    public async Task<IActionResult> Put(decimal key, string values)
    {
        var model = await _context.Units.FirstOrDefaultAsync(item => item.UnitId == key);
        if (model == null)
            return StatusCode(409, "Object not found");

        var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
        PopulateModel(model, valuesDict);

        if (!TryValidateModel(model))
            return BadRequest(GetFullErrorMessage(ModelState));

        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpDelete]
    public async Task Delete(decimal key)
    {
        var model = await _context.Units.FirstOrDefaultAsync(item => item.UnitId == key);

        _context.Units.Remove(model);
        await _context.SaveChangesAsync();
    }

    private void PopulateModel(Unit model, IDictionary values)
    {
        string UNIT_ID = nameof(Unit.UnitId);
        string UNIT_CODE = nameof(Unit.UnitCode);
        string UNIT_DESCRIPTION = nameof(Unit.UnitDesc);


        if (values.Contains(UNIT_ID))
        {
            model.UnitId = Convert.ToInt32(values[UNIT_ID]);
        }

        if (values.Contains(UNIT_CODE))
        {
            model.UnitCode = Convert.ToString(values[UNIT_CODE]);
        }

        if (values.Contains(UNIT_DESCRIPTION))
        {
            model.UnitDesc = Convert.ToString(values[UNIT_DESCRIPTION]);
        }
    }


    private string GetFullErrorMessage(ModelStateDictionary modelState)
    {
        var messages = new List<string>();

        foreach (var entry in modelState)
        {
            foreach (var error in entry.Value.Errors)
                messages.Add(error.ErrorMessage);
        }

        return String.Join(" ", messages);
    }
}