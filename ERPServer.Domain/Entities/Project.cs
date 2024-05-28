using ERPServer.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPServer.Domain.Entities;

public sealed class Project : Entity
{
  
        public string ProjectName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string ProjectStatus  { get; set; } = string.Empty;  

}
