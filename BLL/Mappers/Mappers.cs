using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bll = BLL.Models;
using Dal = DAL.Models;

namespace BLL.Mappers
{
    public static class Mappers
    {
        public static Bll.Fruit toBLL(this Dal.Fruits entity)
        {
            return new Bll.Fruit()
            {
                FruitID = entity.FruitID,
                FruitName = entity.FruitName,
                Quantity = entity.Quantity,
                Date_Achat = entity.Date_Achat
            };
        }
        public static Dal.Fruits toDAL(this Bll.Fruit entity)
        {
            return new Dal.Fruits()
            {
                FruitID = entity.FruitID,
                FruitName = entity.FruitName,
                Quantity = entity.Quantity,
                Date_Achat = entity.Date_Achat
            };
        }

    }
}
