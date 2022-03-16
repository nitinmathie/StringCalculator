using System;
using System.Linq;

public class StringCalculatorTdd
    {
        public static int Add(string numbers)
        {
        if (numbers == string.Empty)
        {
            return 0;
        }
        else if (numbers.Length > 2)
        {
            var sum = 0;
            if (numbers.Substring(0, 2) == "//")
            {
                var delimiter = numbers[2];
                var numbersList = numbers.Split(delimiter);
                var countOfNumbers = numbersList.Count();
                if (numbersList[countOfNumbers - 1] == "\n")
                {
                    sum = -1;
                }
                else
                {
                    for (int i = 1; i < countOfNumbers; i++)
                    {
                        if (numbersList[i] == "\n")
                        {
                            numbersList[i] = "0";
                        }
                        sum = sum + int.Parse(numbersList[i]);
                    }
                   
                }

            }
         else if (numbers.Contains(','))
            {
                var numbersList = numbers.Split(',');
                var countOfNumbers = numbersList.Count();
                if (numbersList[countOfNumbers - 1] == "\n")
                {
                    sum = -1;
                }
                else
                {
                    for (int i = 0; i < countOfNumbers; i++)
                    {
                        if (numbersList[i] == "\n")
                        {
                            numbersList[i] = "0";
                        }
                        sum = sum + int.Parse(numbersList[i]);
                    }

                }
            }
            return sum;
        }
        else
        {
            var sum = int.Parse(numbers);
            return sum;
        }
        }
    }
