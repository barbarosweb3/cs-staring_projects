using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }

        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (LLPersonelListesi() == null)
            {
                return -1;
            }
            else
            {
                return DALPersonel.PersonelEkle(p);
            }
        }

        public static bool LLPersonelSil(int p)
        {
            if (LLPersonelListesi() == null)
            {
                return false;
            }
            else
            {
                return DALPersonel.PersonelSil(p);
            }
        }

        public static bool LLPersonelGuncelle(EntityPersonel p)
        {
            if (LLPersonelListesi() == null)
            {
                return false;
            }
            else
            {
                return DALPersonel.PersonelGuncelle(p);
            }
        }
    }
}
