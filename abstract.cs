using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_5._1
{
    using System;

    abstract class sieunhan
    {
        public abstract void bienhinh();

        public void xuathien()
        {
            Console.WriteLine("Sieunhan den!");
        }
    }
    class SieunhanGao : sieunhan
    {
        public override void bienhinh()
        {
            Console.WriteLine("Rut kiem va het");
        }

    }
    class SieunhanCuongphong : sieunhan
    {
        public override void bienhinh()
        {
            Console.WriteLine("Rut o va het");
        }

    }
    class test
    {
        static void Main(string[] args)
        {
            sieunhan SieunhanGao = new SieunhanGao();
            SieunhanGao.bienhinh();
            SieunhanGao.xuathien();

            sieunhan SieunhanCuongphong = new SieunhanCuongphong();
            SieunhanCuongphong.bienhinh();
            SieunhanCuongphong.xuathien();
        }
    }


}
