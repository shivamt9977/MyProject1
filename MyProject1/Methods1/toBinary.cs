using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class toBinary
    {

        public void convertToBinary(int nm)
        {
            //2|15 - 1
            // |7  - 1
            // |3  - 1
            // |1  - 1
            while (nm!=0)
            {                
                int r = nm % 2;//1
                Console.Write(r+" ");

                nm = nm / 2;//7         
            }

        }
        static void Main(string[] args)
        {
            toBinary b = new toBinary();

            int num = int.Parse(Console.ReadLine());
            b.convertToBinary(num);

        }
    }
}
