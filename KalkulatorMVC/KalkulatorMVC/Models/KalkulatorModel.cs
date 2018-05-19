using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*U modele idu samo klase ili interface-i. Služe za definiranje šifrarnika*/

namespace KalkulatorMVC.Models
{
    public enum Operacija
    {
        Zbrajanje = '+',
        Oduzimanje = '-',
        Mnozenje = '*',
        Dijeljenje = '/'
    }

    public class KalkulatorModel
    {
        public decimal PrviOperand { get; set; }
        public decimal DrugiOperand { get; set; }
        public Operacija Operacija { get; set; }
        public decimal Rezultat { get; set; }
    }
}