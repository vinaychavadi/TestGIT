using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGIT
{
    class Program
    {
        static void Main(string[] args)
        {
            int tm = 160;
            TimeSpan time = TimeSpan.FromMinutes(tm);
            string str1 = time.ToString("h:mm");
            string str = "10h";    
            string[] arr = str.Split('h');
            string hr = string.Empty;
            string min = string.Empty;
            int h = 0;
            int m = 0;
            int t = 0;
            //Test gain
            if (arr.Length > 1)
            {
                 h =  int.Parse(arr[0].ToString()) * 60;
                hr = h.ToString();
                if (arr.Length == 2)
                {
                    if (arr[1].ToString() != String.Empty)
                    {
                        string[] arr1 = arr[1].ToString().Split('m');
                        m = int.Parse(arr1[0].ToString());
                    }
                }
                
            }
            else
            {
                string[] arr1 = str.Split('m');
                 m = int.Parse(arr1[0].ToString()) ;
                
            }
            t = h + m;
            //Testing

        }
    }
}
