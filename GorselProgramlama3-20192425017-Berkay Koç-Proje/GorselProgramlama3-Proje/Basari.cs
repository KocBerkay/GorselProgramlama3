using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama3_Proje
{
    class Basari
    {
        Random r = new Random();

        //* Anladığım kadarıyla her öğrenci için geçerli olacak ve sistem her kapanıp açıldığında her öğrencinin başarı oranının %40 ile %60 arasında olmasını sağlayacak bir metod yazmam gerekiyordu.
        // Ama araştırmalarıma rağmen öğrencilerin sabit bir olasılıkla başarılı olmalarını sağlayabildim. *//

        public int basari()
        {
            int sayi = r.Next(100);
            if (sayi < 50)
                return 1; //Öğrenci başarılı oldu.          
            else
                return 0; //Öğrenci başarısız oldu.
        }
    }
}
