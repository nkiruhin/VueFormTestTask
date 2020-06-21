using System;
using VueForm.Core.Enums;
using VueForm.SharedKernel;

namespace VueForm.Core.Entities
{
    public class EntityForm : BaseEntity
    {
        public Guid EntityId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public FieldTypes Type { get; set; }
    }
}
