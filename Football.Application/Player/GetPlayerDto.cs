using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Application.Player
{
    public class GetPlayerDto
    {
        [Required]
        public string GetBy { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int PositionId { get; set; }
        public int TeamId { get; set; }
        
    }
}
