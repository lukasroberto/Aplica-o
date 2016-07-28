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
        private List<Chip> listaDeChips = new List<Chip>();

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

        public List<Chip> filtraDadosChips(String condicao, String filtro)
        {
                switch (condicao)
                {
                    case "Código do Cliente":
                        return (from Chip in listaDeChips where Chip.Cliente.cli_id == int.Parse(filtro) select Chip).ToList();
                    case "Operadora":
                        return (from Chip in listaDeChips where Chip.chip_operadora.Contains(filtro.ToUpper()) select Chip).ToList();
                    case "Nome do Cliente":
                        return (from Chip in listaDeChips where Chip.Cliente.cli_nome.ToLower().Contains(filtro.ToLower()) select Chip).ToList();
                    case "Imei":
                        return (from Chip in listaDeChips where Chip.chip_imei.Contains(filtro) select Chip).ToList();
                }

                return listaDeChips;
        }

        public List<Chip> carregarDadosChips()
        {
            var db = new monialEntities();

            if (listaDeChips.Count > 0)
            {
                return listaDeChips;
            }
            else
            {
                listaDeChips = (from Chip in db.Chip select Chip).ToList();

                return listaDeChips;
            }
        }

        public void linpaListaDeChips()
        {
            if (listaDeChips.Count > 0)
            {
                listaDeChips.Clear();
            }
        }

    }
}

