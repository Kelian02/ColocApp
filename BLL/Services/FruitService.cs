using BLL.Mappers;
using BLL.Models;
using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll = BLL.Models;
using Dal = DAL.Models;

namespace BLL.Services
{
    public class FruitService : IFruitRepository<Bll.Fruit>
    {
        public IFruitRepository<Dal.Fruits> _repository { get; set; }


        public FruitService(IFruitRepository<Dal.Fruits> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Fruit> Get()
        {
            return _repository.Get().Select(dal => dal.toBLL());
        }

        public Fruit Get(int id)
        {
            return _repository.Get(id).toBLL();
        }

        public int Insert(Fruit entity)
        {
            return _repository.Insert(entity.toDAL());
            
        }

        public void update(int id, Fruit entity)
        {
            _repository.update(id, entity.toDAL());
        }
        public void delete(int id)
        {
            _repository.delete(id);
        }
    }
}
