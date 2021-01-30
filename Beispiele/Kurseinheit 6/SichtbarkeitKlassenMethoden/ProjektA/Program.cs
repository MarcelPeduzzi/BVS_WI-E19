using ProjektB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektA
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateClassProjektA privateClassProjektA = new PrivateClassProjektA();
            privateClassProjektA.MeinePublicMethode();
            //privateClassProjektA.MeineProtectedMethode(); // verursacht Fehler
            //privateClassProjektA.MeinePrivateMethode(); // verursacht Fehler


            InternalClassProjektA internalClassProjektA = new InternalClassProjektA();
            internalClassProjektA.MeinePublicMethode();
            //internalClassProjektA.MeineProtectedMethode(); // verursacht Fehler
            //internalClassProjektA.MeinePrivateMethode(); // verursacht Fehler

            //InternalClassProjektB internalClassProjektB = new InternalClassProjektB(); // verursacht Fehler

            PublicClassProjektB publicClassProjektB = new PublicClassProjektB();
            publicClassProjektB.MeinePublicMethode();
            //publicClassProjektB.MeineProtectedMethode(); // verursacht Fehler
            //publicClassProjektB.MeinePrivateMethode(); // verursacht Fehler
        }


        private class PrivateClassProjektA
        {
            public void MeinePublicMethode()
            {
                // code ...
            }

            protected void MeineProtectedMethode()
            {
                // code
            }

            private void MeinePrivateMethode()
            {
                // code
            }
        }
    }

    

}
