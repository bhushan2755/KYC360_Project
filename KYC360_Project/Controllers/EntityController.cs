using Microsoft.AspNetCore.Mvc;
using KYC360_Project.Models;
using KYC360_Project.Interface;
using System.Collections.Generic;
using System.Linq;

namespace KYC360_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntityController : ControllerBase
    {
        private static List<Entity> entities = new List<Entity>();


        // GET: api/entity
        [HttpGet]
        public ActionResult<IEnumerable<Entity>> GetAllEntities()
             {
                   return Ok(entities);
             }

        // GET: api/entity/{id}
        [HttpGet("{id}")]
        public ActionResult<Entity> GetEntityById(string id)
        {
            var entity = entities.FirstOrDefault(e => e.Id == id);
            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        // POST: api/entity
        [HttpPost]
        public ActionResult<Entity> CreateEntity(Entity entity)
        {
            entity.Id = System.Guid.NewGuid().ToString(); // Generate a unique ID
            entities.Add(entity);
            return CreatedAtAction(nameof(GetEntityById), new { id = entity.Id }, entity);
        }

        // PUT: api/entity/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateEntity(string id, Entity updatedEntity)
        {
            var existingEntity = entities.FirstOrDefault(e => e.Id == id);
            if (existingEntity == null)
                return NotFound();

            // Update properties
            existingEntity.Addresses = updatedEntity.Addresses;
            existingEntity.Dates = updatedEntity.Dates;
            existingEntity.Deceased = updatedEntity.Deceased;
            existingEntity.Gender = updatedEntity.Gender;
            existingEntity.Names = updatedEntity.Names;

            return NoContent();
        }

        // DELETE: api/entity/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteEntity(string id)
        {
            var entityToRemove = entities.FirstOrDefault(e => e.Id == id);
            if (entityToRemove == null)
                return NotFound();

            entities.Remove(entityToRemove);
            return NoContent();
        }
    }
}
