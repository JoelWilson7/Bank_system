using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system
{
    internal class InfoEnter
    {
        public void Info()
        {
            Bank bank = new Bank();
            // 2 nya konton
            bank.CreateAccount(0000, "Joel Wilson");
            bank.CreateAccount(0001, "Olof Li");
            // dra ut eller ta in pengar (true= sätta in pengar. false= ta ut pengar)
            bank.PerformTransaction(0000, 10, true);
            bank.PerformTransaction(0001, 30, false);
            // hämta alla acconts displays
            Account JoelsAccount = bank.GetAccount(0000);
            Account OlofsAccount = bank.GetAccount(0001);



        }
    }
}
