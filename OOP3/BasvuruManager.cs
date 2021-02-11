using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //altta ki kod  yanlış olur
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //Başvuru kredi bağımsız hale gelmesi için alttaki kod
            krediManager.Hesapla(); //hangi kredi seçilmişse onu hesapla demek
            //loggerService.Log(); //hangi logger servis gönderilmişse onu logla demek
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }
    }
}
