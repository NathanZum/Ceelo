using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using System.IO;

namespace DataAccessLayer
{
    public class BankAccessor
    {
        public bool saveBanks(int playerAmount, int comAmount)
        {
            bool result = false;
            string datapath = AppData.DataPath + "bank.txt";
            FileStream bankFile = null;
            StreamWriter writer = null;

            try{
                bankFile = new FileStream(datapath, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(bankFile);
                string line = playerAmount.ToString() + "," + comAmount.ToString();
                writer.WriteLine(line);
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                writer.Close();
            }

            return result;
        }

        public int[] ReadBanks()
        {
            int[] savedBanks = { 500, 500 };
            string dataPath = AppData.DataPath + "bank.txt";
            FileStream bankFile = null;
            StreamReader reader = null;

            try
            {
                bankFile = new FileStream(dataPath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(bankFile);
                string line = reader.ReadLine();
                String[] banks = line.Split(',');
                savedBanks[0] = int.Parse(banks[0]);
                savedBanks[1] = int.Parse(banks[1]);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                reader.Close();
            }

            return savedBanks;
        } 
    }
}
