using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CMS.Data;
using CMS.Models;
using CMS.Areas.Admin;

namespace CMS.Controllers
{
    [Route("api/[controller]/[action]")]
    public class StandardBillsApiController : Controller
    {
        private AppDbContext _context;

        public StandardBillsApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            var standardbills = _context.StandardBills.Select(i => new
            {
                i.Id,
                i.Name
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "Id" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(standardbills, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values)
        {
            var model = new StandardBill();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            var validationModel = new StandardBillViewModel();
            PopulateModel(validationModel, valuesDict);

            if (!TryValidateModel(validationModel))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.StandardBills.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.Id });
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values)
        {
            var model = await _context.StandardBills.FirstOrDefaultAsync(item => item.Id == key);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            var validationModel = new StandardBillViewModel();
            PopulateModel(validationModel, valuesDict);

            if (!TryValidateModel(validationModel))
                return BadRequest(GetFullErrorMessage(ModelState)); 

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key)
        {
            var model = await _context.StandardBills.FirstOrDefaultAsync(item => item.Id == key);

            _context.StandardBills.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(StandardBill model, IDictionary values)
        {
            string ID = nameof(StandardBill.Id);
            string NAME = nameof(StandardBill.Name);

            if (values.Contains(ID))
            {
                model.Id = Convert.ToInt32(values[ID]);
            }

            if (values.Contains(NAME))
            {
                model.Name = Convert.ToString(values[NAME]);
            }
        }

        private void PopulateModel(StandardBillViewModel model, IDictionary values)
        {
            string ID = nameof(StandardBill.Id);
            string NAME = nameof(StandardBill.Name);

            if (values.Contains(ID))
            {
                model.Id = Convert.ToInt32(values[ID]);
            }

            if (values.Contains(NAME))
            {
                model.Name = Convert.ToString(values[NAME]);
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
}