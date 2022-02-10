using FullStack_Task.Models.OtherModels;
using System.Collections.Generic;

namespace FullStack_Task.Models.DTO
{
    public class GetStatesDto
    {
        public ICollection<Country> Countries { get; set; }
        public string CountryName { get; set; }
    }
}
