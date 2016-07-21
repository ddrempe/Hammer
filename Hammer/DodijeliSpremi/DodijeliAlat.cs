using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hammer;
using System.ComponentModel;

namespace DodijeliSpremi
{
    public class DodijeliAlat
    {
        public static bool Provjeri(int idAlata)
        {
            using (var db = new Entities())
            {
                int sumaAlata = 1;
                foreach (var item in db.gradilista)
                {
                    foreach (var redak in item.alati)
                    {
                        if (redak.id == idAlata)
                        {
                            sumaAlata++;
                        }
                    }
                }

                var odabraniAlat = db.alati.FirstOrDefault(m => m.id == idAlata);
                if (sumaAlata > odabraniAlat.kolicina)
                {
                    return false;
                }
                else return true;
            }
        }

        public static void Spremi(int idAlata, gradilista odabranoGradiliste)
        {
            using (var db = new Entities())
            {
                BindingList<alati> listaAlata = null;
                listaAlata = new BindingList<alati>(db.alati.ToList());
                var gradiliste = db.gradilista.FirstOrDefault(m => m.ID == odabranoGradiliste.ID);
                alati alat = new alati();
                alati alatOznacen = new alati() { id = idAlata };
                foreach (var item in db.alati)
                {
                    if (item.id == alatOznacen.id)
                        alat = item;
                }
                alat.gradilista.Add(gradiliste);
                db.SaveChanges();
            }
        }
    }
}
