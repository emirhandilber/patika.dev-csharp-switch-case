using System;

namespace switch_case{
    class Program{
        static void Main(string[] args){
            int month = DateTime.Now.Month;
            switch(month){
                
                case 1:
                    Console.WriteLine("Ocak ayındasınz");
                    break; 
                case 2:
                    Console.WriteLine("Şubat ayındasınız");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayındasınız");
                    break;
                case 9:
                    Console.WriteLine("Eylüldesiniz");
                    break;
                default:
                    Console.WriteLine("yanlış veri girişi");
                    break;
            }  
            switch(month){
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kış ayındasınız");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("İlkbahardasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("yazdasınız");
                    break;
                case 10:
                case 11:
                case 9:
                    Console.WriteLine("Sonbahar ayındasınız");
                    break;

                default:
                    Console.WriteLine("Yanlış veri girişi");
                    break;
            }
        }
    }
}