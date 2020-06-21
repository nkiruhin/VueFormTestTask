using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueForm.Core.Entities;
using VueForm.Core.Expressions;
using VueForm.SharedKernel.Interfaces;
using VueForm.Web.ApiModels;

namespace VueForm.Web.Api
{
    public class EntityFormController : BaseApiController
    {
        private readonly IRepository _repository;

        public EntityFormController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/EntityForm
        [HttpGet]
        public async Task<IActionResult> List()
        {
            IEnumerable<EntityFormDTO> items = EntityFormDTO.GetDtos(await _repository.ListAsync<EntityForm>());
            return Ok(items);
        }

        // GET: api/EntityForm/{searchText}
        [HttpGet("{searchText}")]
        public async Task<IActionResult> Filtred(string searchText)
        {
            IQueryable<Guid> filtredEntity = _repository
                .GetQuery<EntityForm>()
                .WhereIf(searchText != null, x => x.Value.Contains(searchText))
                .GroupBy(x => x.EntityId)
                .Select(x => x.Key);

            IEnumerable<EntityFormDTO> items = EntityFormDTO.GetDtos(await _repository
                .GetQuery<EntityForm>()
                .WhereIf(searchText != null, x => filtredEntity.Contains(x.EntityId))
                .ToListAsync());

            return Ok(items);
        }
        // GET: api/EntityForm
        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            IEnumerable<EntityFormDTO> item = EntityFormDTO.GetDtos(await _repository
                .GetQuery<EntityForm>()
                .Where(x => x.EntityId == id)
                .ToListAsync());

            return Ok(item);
        }

        // POST: api/EntityForm
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Dictionary<string, object> fields)
        {
            Guid entityId = Guid.NewGuid();
            await _repository.AddRangeAsync(EntityFormDTO.FromFieldsDictionary(entityId, fields));
            return CreatedAtAction("Entity has been created", new { id = entityId });
        }

    }
}
