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
using CMS.Areas.Admin.ViewModels;
using CMS.Data;
using CMS.Models;

namespace CMS.Areas.Admin.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ContractorsApiController : BaseController
    {
        private AppDbContext _context;

        public ContractorsApiController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions)
        {
            var contractors = _context.Contractors.Select(i => new
            {
                i.ContractorId,
                i.TinNo,
                i.ContractorName,
                i.Address,
                i.ContactPerson,
                i.Email,
                i.Phone,
                i.Type,
                i.Classification
            });

            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
            // This can make SQL execution plans more efficient.
            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
            loadOptions.PrimaryKey = ["ContractorId"];
            loadOptions.PaginateViaPrimaryKey = true;

            return Json(await DataSourceLoader.LoadAsync(contractors, loadOptions));
        }

        [HttpPost]
        public async Task<IActionResult> Post(string values)
        {
            var model = new Contractor();
            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            var validationModel = new ContractorViewModel();
            PopulateModel(validationModel, valuesDict);

            if (!TryValidateModel(validationModel))
                return BadRequest(GetFullErrorMessage(ModelState));

            var result = _context.Contractors.Add(model);
            await _context.SaveChangesAsync();

            return Json(new { result.Entity.ContractorId });
        }

        [HttpPut]
        public async Task<IActionResult> Put(int key, string values)
        {
            var model = await _context.Contractors.FirstOrDefaultAsync(item => item.ContractorId == key);
            if (model == null)
                return StatusCode(409, "Object not found");

            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
            PopulateModel(model, valuesDict);

            var validationModel = new ContractorViewModel();
            PopulateModel(validationModel, valuesDict);

            PropertyMapper.CopyProperties(model, validationModel);

            if (!TryValidateModel(validationModel))
                return BadRequest(GetFullErrorMessage(ModelState));

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        public async Task Delete(int key)
        {
            var model = await _context.Contractors.FirstOrDefaultAsync(item => item.ContractorId == key);

            _context.Contractors.Remove(model);
            await _context.SaveChangesAsync();
        }


        private void PopulateModel(Contractor model, IDictionary values)
        {
            string CONTRACTOR_ID = nameof(Contractor.ContractorId);
            string TIN_NO = nameof(Contractor.TinNo);
            string CONTRACTOR_NAME = nameof(Contractor.ContractorName);
            string ADDRESS = nameof(Contractor.Address);
            string CONTACT_PERSON = nameof(Contractor.ContactPerson);
            string EMAIL = nameof(Contractor.Email);
            string PHONE = nameof(Contractor.Phone);
            string TYPE = nameof(Contractor.Type);
            string CLASSIFICATION = nameof(Contractor.Classification);

            if (values.Contains(CONTRACTOR_ID))
            {
                model.ContractorId = Convert.ToInt32(values[CONTRACTOR_ID]);
            }

            if (values.Contains(TIN_NO))
            {
                model.TinNo = Convert.ToString(values[TIN_NO]);
            }

            if (values.Contains(CONTRACTOR_NAME))
            {
                model.ContractorName = Convert.ToString(values[CONTRACTOR_NAME]);
            }

            if (values.Contains(ADDRESS))
            {
                model.Address = Convert.ToString(values[ADDRESS]);
            }

            if (values.Contains(CONTACT_PERSON))
            {
                model.ContactPerson = Convert.ToString(values[CONTACT_PERSON]);
            }

            if (values.Contains(EMAIL))
            {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if (values.Contains(PHONE))
            {
                model.Phone = Convert.ToString(values[PHONE]);
            }

            if (values.Contains(TYPE))
            {
                model.Type = Convert.ToString(values[TYPE]);
            }

            if (values.Contains(CLASSIFICATION))
            {
                model.Classification = Convert.ToString(values[CLASSIFICATION]);
            }
        }

        private void PopulateModel(ContractorViewModel model, IDictionary values)
        {
            string CONTRACTOR_ID = nameof(Contractor.ContractorId);
            string TIN_NO = nameof(Contractor.TinNo);
            string CONTRACTOR_NAME = nameof(Contractor.ContractorName);
            string ADDRESS = nameof(Contractor.Address);
            string CONTACT_PERSON = nameof(Contractor.ContactPerson);
            string EMAIL = nameof(Contractor.Email);
            string PHONE = nameof(Contractor.Phone);
            string TYPE = nameof(Contractor.Type);
            string CLASSIFICATION = nameof(Contractor.Classification);

            if (values.Contains(CONTRACTOR_ID))
            {
                model.ContractorId = Convert.ToInt32(values[CONTRACTOR_ID]);
            }

            if (values.Contains(TIN_NO))
            {
                model.TinNo = Convert.ToString(values[TIN_NO]);
            }

            if (values.Contains(CONTRACTOR_NAME))
            {
                model.ContractorName = Convert.ToString(values[CONTRACTOR_NAME]);
            }

            if (values.Contains(ADDRESS))
            {
                model.Address = Convert.ToString(values[ADDRESS]);
            }

            if (values.Contains(CONTACT_PERSON))
            {
                model.ContactPerson = Convert.ToString(values[CONTACT_PERSON]);
            }

            if (values.Contains(EMAIL))
            {
                model.Email = Convert.ToString(values[EMAIL]);
            }

            if (values.Contains(PHONE))
            {
                model.Phone = Convert.ToString(values[PHONE]);
            }

            if (values.Contains(TYPE))
            {
                model.Type = Convert.ToString(values[TYPE]);
            }

            if (values.Contains(CLASSIFICATION))
            {
                model.Classification = Convert.ToString(values[CLASSIFICATION]);
            }
        }

        
    }
}