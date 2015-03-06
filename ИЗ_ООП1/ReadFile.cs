using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ИЗ_ООП1
{
    class ReadFile
    {
        int counter;
        
        public string[] mass(string path)
        {
            string[] masList = new string[1];
            counter = 0;
            string line;
    
            StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                masList[counter] = line;
                
                counter++;
                Array.Resize(ref masList, counter+1);
            }

            Array.Resize(ref masList, counter);
            file.Close();
            return masList;
        }
    }
}
