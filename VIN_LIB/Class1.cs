using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIN_LIB
{
    public class Class1
    {
        /// <summary>
        /// разрешенный  символы 
        /// </summary>
        private List<char> trueSimbol = new List<char>()
        {
            '1' ,   '2' ,   '3' ,   '4' ,   '5' ,   '6' ,   '7' ,
            '8' ,   '9' ,   'A' ,   'B' ,   'C' ,   'D' ,   'E' ,
            'F' ,   'G' ,   'H' ,   'J' ,   'K' ,   'L' ,   'M' ,
            'N' ,   'P' ,   'R' ,   'S' ,   'T' ,   'U' ,   'V' ,
            'W' ,   'X' ,   'Y' ,   'Z'

        };


        public bool CheckVIN    (  string vin)
        {

          
            // проверка на  длинну 
            if ( vin.Length != 17   )
            {
                return false;
            }
           
            // проверка на  запрещенные символы
            if ( !CheckVINTrueSimboll (vin) )
            {
                return false;
            }


            


            throw new Exception("хз");

        }


        /// <summary>
        /// поиск  запрещенный  сиволов 
        /// </summary>
        /// <param name="vin"></param>
        /// <returns></returns>
        private bool CheckVINTrueSimboll ( string vin)
        {
            vin = vin.ToUpper();

            foreach ( var simb  in vin.ToArray())
            {
                if  (  !trueSimbol.Contains( simb) )
                {

                    return false;
                }
            }
            return true;
        }


        private  bool CheckVINTrueWMI ( string vin)
        {
           string wmi = vin.Substring(0, 3);


            //  to   вызов   поиска  страны  
            return true;
        }












        public string GetVINCountry(string vin)
        {
            return "Serbia";
        }


        public int GetTransportYear(string vin)
        {
            return 2031;
        }
    }
}
