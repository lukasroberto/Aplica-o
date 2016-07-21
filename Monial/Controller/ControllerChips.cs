using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monial
{
    class ControllerChips
    {
        monialEntities db = new monialEntities();

        public void cadastra(String imei, String operadora, DateTime dataEnvio, Double status, long cliID)
        {
            try
            {
                var chip = db.Chip.Create();

                chip.chip_imei = imei;
                chip.chip_operadora = operadora;
                chip.chip_data_envio = dataEnvio;
                chip.chip_status = status;
                chip.cli_id = cliID;

                db.Chip.Add(chip);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void exclui(int chipID)
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
}
