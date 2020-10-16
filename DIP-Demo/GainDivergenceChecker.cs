using System;
using System.Collections.Generic;
using System.Runtime.Versioning;
using System.Text;

namespace SOLID.DIP
{
    public class GainDivergenceChecker
    {
        //private Accounter _privateAccounter;
        //private FiscalRegistrator _fr;
        private IAccounter _privateAccounter;
        private IFiscalRegistrator _fr;

        public GainDivergenceChecker(IAccounter accounter,IFiscalRegistrator fr)
        {
            //    _privateAccounter = new Accounter();
            //    _fr = new FiscalRegistrator();
                _privateAccounter = accounter;
                _fr = fr;
        }

        public bool HasDivergence()
        {
            decimal salesSumm = _privateAccounter.GetSalesSumm();
            decimal summOfRetuenedTicket = _privateAccounter.GetSummOfReturnedTickets();

            decimal salesSummByFiscalRegistor = _fr.GetSalesSumm();
            decimal summOfReturnedTicketsByFiscalRegistrator = _fr.GetSummOfReturnedTickets();

            return salesSumm == salesSummByFiscalRegistor &&
                   summOfRetuenedTicket == summOfReturnedTicketsByFiscalRegistrator;
        }
    }

    public interface IAccounter
    {
        decimal GetSalesSumm();
        decimal GetSummOfReturnedTickets();
    }

    public class Accounter: IAccounter
    {
        public  decimal GetSalesSumm()
        {
            return 0;
        }

        public decimal GetSummOfReturnedTickets()
        {
            return 0;
        }
    }

    public interface IFiscalRegistrator
    {
        public decimal GetSalesSumm();
        public decimal GetSummOfReturnedTickets();
    }
    public class FiscalRegistrator: IFiscalRegistrator
    {
        public decimal GetSalesSumm()
        {
            return 0;
        }

        public decimal GetSummOfReturnedTickets()
        {
            return 0;
        }
    }

}
