using Common;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class FruitService : IFruitRepository<Fruits>
    {
        private FruitContext _context;

        public FruitService(FruitContext context)
        {
            _context = context;
        }

        public void delete(int id)
        {
            _context.Fruits.Remove(_context.Fruits.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<Fruits> Get()
        {
            return _context.Fruits;
        }

        public Fruits Get(int id)
        {
            return _context.Fruits.Find(id);
        }

        public int Insert(Fruits entity)
        {
            Fruits addedFruit = _context.Fruits.Add(entity).Entity;
            _context.SaveChanges();
            return addedFruit.FruitID;
        }

        public void update(int id, Fruits entity)
        {   
            Fruits unchangedFruit = _context.Fruits.Find(id);

            unchangedFruit.FruitName = entity.FruitName;
            unchangedFruit.Quantity = entity.Quantity;
            unchangedFruit.Date_Achat = entity.Date_Achat;
            _context.SaveChanges();
        }
    }
}
