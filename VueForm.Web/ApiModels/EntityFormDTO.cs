using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using VueForm.Core.Entities;
using VueForm.Core.Enums;

namespace VueForm.Web.ApiModels
{
    // Note: doesn't expose events or behavior
    public class EntityFormDTO
    {
        public Guid EntityId { get; set; }
        public Dictionary<string, object> Fields { get; set; }
        public static List<EntityForm> FromFieldsDictionary(Guid entityId, Dictionary<string, object> fields)
        {

            JArray emptyJArray = new JArray() { null };

            return fields
                .SelectMany(n => n.Value as JArray ?? emptyJArray,
                (n, v) => new EntityForm
                {
                    EntityId = entityId,
                    Name = n.Key,
                    Value = v.Type == JTokenType.Null ? n.Value.ToString() : v.ToString(),
                    Type = v.Type == JTokenType.Null ? FieldTypes.String : FieldTypes.Array
                }).ToList();
        }

        public static IEnumerable<EntityFormDTO> GetDtos(IEnumerable<EntityForm> entities)
        {
            return entities.GroupBy(x => x.EntityId,
                (id, fields) => new EntityFormDTO
                {
                    EntityId = id,
                    Fields = fields.GroupBy(f => new { f.Name, f.Type })
                             .ToDictionary(o => o.Key.Name,
                             o => o.Key.Type == FieldTypes.Array ? (object)o.Select(v => v.Value) : o.FirstOrDefault()?.Value)
                }
            );
        }

    }
}
