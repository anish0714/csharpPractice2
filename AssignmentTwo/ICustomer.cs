using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    interface ICustomer
    {
        string CustName { get; set; }
        decimal SizeOfLot { get; set; }
        string SizeOfWorkArea { get; set; }
        string CreditCard { get; set; }
        string MaskCreditCardNum { get; }

        bool ValidateCustomerName();
        bool ValidateSizeOfLot();
        bool ValidateSizeOfWork();
        bool ValidCreditCardNumber();
        string MaskCreditCardNumber();
        void DesignCreation();
        void EstimateWork();
        void ArrangeWorkers();
        void Requirement();

    }
}
