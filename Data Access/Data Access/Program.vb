Imports System

Module Program
    Sub Main(args As String())

        Static void Main(String[] args)
            {
                Double num1 = 2;
                Double num2 = 3;
                Double num3 = 2;

               Double result = Add(5, 17.5);
               Console.WriteLine("5+17.5= " + result);

                Console.ReadLine();

                Double[] nums = { num1, num2, num3 };
              //  nums = New double[3];
               // nums[0] = num1;
                //nums[1] = num2;
               // nums[2] = num3;

            }

     


             Static double Add(Double[] numbersToAddUp)
            {
                Double r = 0;

                foreach(var number In numbersToAddUp)
                {
                    r += number;
                }
           
                Return r;

            }

            /// <summary>
            /// sums up 2 numbers And add results
            /// </summary>
            /// <param name="val1">left hand var</param>
            /// <param name="val2">right hand var</param>
            /// <returns></returns>

            Static double Add(Double val1, double val2)
            {
           
                Double sum = val1 + val2;
                Return sum;


            }




    End Sub
End Module
