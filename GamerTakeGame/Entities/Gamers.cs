using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerTakeGame.Abstract;

namespace GamerTakeGame.Entities
{
    public class Gamers : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NationalId { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
