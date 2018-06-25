using System;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            string output = $"{number} can fit in:{Environment.NewLine}";
            bool issByte = true;
            bool isByte = true;
            bool isShort = true;
            bool isuShort = true;
            bool isInt = true;
            bool isuInt = true;
            bool isLong = true;

            try
            {
                sbyte numberSbyte = sbyte.Parse(number);
            }
            catch (Exception)
            {
                issByte = false;
            }
            try
            {
                byte numberByte = byte.Parse(number);

            }
            catch (Exception)
            {

                isByte = false;
            }
            try
            {
                short numberShort = short.Parse(number);
            }
            catch (Exception)
            {
                isShort = false;

            }
            try
            {
                ushort numberUshort = ushort.Parse(number);
            }
            catch (Exception)
            {

                isuShort = false;
            }
            try
            {
                int numberInt = int.Parse(number);
            }
            catch (Exception)
            {

                isInt = false;
            }
            try
            {
                uint numberUint = uint.Parse(number);
            }
            catch (Exception)
            {
                isuInt = false;

            }
            try
            {
                long numberLong = long.Parse(number);
            }
            catch (Exception)
            {

                isLong = false;
            }
            if (isByte == false && issByte == false && isLong == false && isuInt == false
                && isInt == false && isShort == false && isuShort == false)
            {
                Console.WriteLine($"{number} can't fit in any type");
                return;
            }

            if (issByte)
            {
                output += $"* sbyte{Environment.NewLine}";
            }
            if (isByte)
            {
                output += $"* byte{Environment.NewLine}";
            }
            
            if (isShort)
            {
                output += $"* short{Environment.NewLine}";
            }
            if (isuShort)
            {
                output += $"* ushort{Environment.NewLine}";
            }
            
            if (isInt)
            {
                output += $"* int{Environment.NewLine}";
            }
            if (isuInt)
            {
                output += $"* uint{Environment.NewLine}";
            }
            if (isLong)
            {
                output += $"* long{Environment.NewLine}";
            }

            Console.WriteLine(output);
            
        }
    }
}
