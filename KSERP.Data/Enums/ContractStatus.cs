using System;
using System.Collections.Generic;
using System.Text;

namespace KSERP.Data.Enums
{
    public enum ContractStatus
    {
        CREATED,
        SIGN,
        SIGN_WITH_DEPOSIT,
        REJECT,
        REJECT_WITH_REFUND,
        DELIVERIED_DONE
    }
}
