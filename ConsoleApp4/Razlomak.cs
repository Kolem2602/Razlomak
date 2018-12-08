using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Razlomak :IComparable<Razlomak>
    {
        private int brojnik;
        private int nazivnik;

        public Razlomak (int _brojnik, int _nazivnik)
        {
            brojnik = _brojnik;
            nazivnik = _nazivnik;
        }
        public int Brojnik 
        {
            set => brojnik = value;
            get => brojnik;
        }
        public int Nazivnik
        {
            set => nazivnik = value;
            get => nazivnik;
        }
        public float PretvoriUFloat()
        {
            return (float)brojnik / nazivnik;
        }

        public bool Ispravan()
        {
            if (nazivnik==0)
            
                return false;
            
            else
                return true;
        }

        protected int nzd()
        {
            int br = 0;
            if (nazivnik > brojnik)
            {
                for (int x = nazivnik; x > 0; x--)
                {
                    if (brojnik % x == 0 && nazivnik % x == 0)
                    {
                        br = x;
                        break;
                    }

                }
            }
            if (brojnik > nazivnik)
            {
                for (int x = brojnik; x > 0; x--)
                {
                    if (brojnik % x == 0 && nazivnik % x == 0)
                    {
                        br = x;
                        break;
                    }

                }
            }
            return br;
        }

        public string SkratiRazlomak()
        {
            string z = brojnik / nzd() + "/" + nazivnik / nzd();
            return z;
        }

        public int CompareTo(Razlomak other)
        {
            return this.PretvoriUFloat().CompareTo(other.PretvoriUFloat());
        }

    }
}
