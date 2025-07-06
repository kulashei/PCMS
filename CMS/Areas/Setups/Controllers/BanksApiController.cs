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

namespace CMS.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BanksApiController : Controller
    {
        private AppDbContext _context;

        public BanksApiController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
            var banks = _context.Banks.Select(i => new {
                i.BankId,
                i.BankCode,
                i.BankName
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            // loadOptions.PrimaryKey = new[] { "BankId" };
            // loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(banks, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values) {
            var model = new Bank();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Banks.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.BankId });
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values) {
            var model = await _context.Banks.FirstOrDefaultAsync(item => item.BankId == key);
            if(model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            if(!TryValidateModel(model))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key) {
            var model = await _context.Banks.FirstOrDefaultAsync(item => item.BankId == key);

            _context.Banks.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Bank model, IDictionary values) {
            string BANK_ID = nameof(Bank.BankId);
            string BANK_CODE = nameof(Bank.BankCode);
            string BANK_NAME = nameof(Bank.BankName);

            if(values.Contains(BANK_ID)) {
                model.BankId = Convert.ToInt32(values[BANK_ID]);
            }

            if(values.Contains(BANK_CODE)) {
                model.BankCode = Convert.ToString(values[BANK_CODE]);
            }

            if(values.Contains(BANK_NAME)) {
                model.BankName = Convert.ToString(values[BANK_NAME]);
            }
        }

        private string GetFullErrorMessage(ModelStateDictionary modelState) {
            var messages = new List<string>();

            foreach(var entry in modelState) {
                foreach(var error in entry.Value.Errors)
                    messages.Add(error.ErrorMessage);
            }

            return String.Join(" ", messages);
        }
    }
}