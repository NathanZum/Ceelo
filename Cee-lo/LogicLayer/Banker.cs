using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Banker
    {
        BankAccessor _bankAccessor = new BankAccessor();

        public bool SaveBank(int playerAmount, int comAmount)
        {
            bool result = false;
            try
            {
                result = _bankAccessor.saveBanks(playerAmount, comAmount);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was a problem saving your data.", ex);
            }
            return result;
        }

        public int[] RestoreBanks()
        {
            int[] banks;
            try
            {
                banks = _bankAccessor.ReadBanks();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("There was a problem restoring your data.", ex);
            }
            return banks;
        }
    }
}
