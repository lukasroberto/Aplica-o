using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monial
{
    class ControllerChips
    {
        public void saveOrUpdate(Chip chip)
        {
            using (var db = new monialEntities())
            {
                try
                {
                    db.Entry(chip).State = chip.chip_id == 0 ?
                               EntityState.Added :
                               EntityState.Modified;

                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public void delete(int chipID)
        {
            using (var db = new monialEntities())
            {
                try
                {
                    var excluindoChip = db.Chip.Find(chipID);
                    db.Chip.Remove(excluindoChip);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public List<Chip> filtrar(String filtro, Chip coluna)
        {
            var db = new monialEntities();
                
            
                var query = (from Chip in db.Chip where coluna.chip_imei.Contains("123") select Chip).ToList();
            
            return query;
        }
    }
}
