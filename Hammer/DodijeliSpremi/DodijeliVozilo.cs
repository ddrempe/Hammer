using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hammer;
using System.ComponentModel;

namespace DodijeliSpremi
{
    public class DodijeliVozilo
    {
        public static bool Provjeri(int idVozila)
        {
            using (var db = new Entities())
            {
                int sumaVozila = 1;
                foreach (var item in db.zaposlenici)
                {
                    foreach (var redak in item.vozni_park)
                    {
                        if (redak.id == idVozila)
                        {
                            sumaVozila++;
                        }
                    }
                }

                var odabranoVozilo = db.vozni_park.FirstOrDefault(m => m.id == idVozila);
                if (sumaVozila > odabranoVozilo.kolicina)
                {
                    return false;
                }
                else return true;
            }
        }

        public static void Spremi(int idVozila, zaposlenici odabraniZaposlenik)
        {
            using (var db = new Entities())
            {
                BindingList<vozni_park> listaVozila = null;
                listaVozila = new BindingList<vozni_park>(db.vozni_park.ToList());
                var zaposlenik = db.zaposlenici.FirstOrDefault(m => m.oib == odabraniZaposlenik.oib);
                vozni_park vozilo = new vozni_park();
                vozni_park voziloOznaceno = new vozni_park() { id = idVozila };
                foreach (var item in db.vozni_park)
                {
                    if (item.id == voziloOznaceno.id)
                        vozilo = item;
                }
                vozilo.zaposlenici.Add(zaposlenik);
                db.SaveChanges();
            }
        }
    }
}
