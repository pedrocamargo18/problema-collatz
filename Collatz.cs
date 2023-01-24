using  System;

namespace App
{
    public class Collatz{
        public static void Main()
        {
            int maior_num = 0;
            int sequencia = 0;
            
            for (int i = 1000000; i>1; i--)
            {
                int pos = i; int cont_pos = 0;
                while (pos !=1){

                    if(pos % 2 == 0 ){
                        pos = pos /2;
                    }else{
                        pos = (pos*3) + 1;
                    }
                    cont_pos++;
                    if(cont_pos > sequencia){
                        sequencia = cont_pos;
                        maior_num = pos;
                    }
                }
            }
            Console.WriteLine("Maior sequência foi : {0}", sequencia);
        }
    }
}