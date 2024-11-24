using System;

namespace HelloWorld
{
    internal class Program
    {
        // static int accessibleInt = 0;
        // void TestMethod()
        // {
        //     Console.WriteLine(accessibleInt);
        // }
        static void Main(string[] args)
        {
            // Variables
            // // 1 byte is made up of 8 bits 00000000 - these bits can be used to store a number as follows
            // // Each bit can be worth 0 or 1 of the value it is placed in
            // // From the right we start with a value of 1 and double for each digit to the left
            // // 00000000 = 0
            // // 00000001 = 1
            // // 00000010 = 2
            // // 00000011 = 3
            // // 00000100 = 4
            // // 00000101 = 5
            // // 00000110 = 6
            // // 00000111 = 7
            // // 00001000 = 8

            // // // 1 byte (8 bit) unsigned, where signed means it can be negative
            // // byte myByte = 255;
            // // byte mySecondByte = 0;

            // // // 1 byte (8 bit) signed, where signed means it can be negative
            // // sbyte mySbyte = 127;
            // // sbyte mySecondSbyte = -128;


            // // // 2 byte (16 bit) unsigned, where signed means it can be negative
            // // ushort myUshort = 65535;

            // // // 2 byte (16 bit) signed, where signed means it can be negative
            // // short myShort = -32768;

            // // // 4 byte (32 bit) signed, where signed means it can be negative
            // // int myInt = 2147483647;
            // // int mySecondInt = -2147483648;

            // // // 8 byte (64 bit) signed, where signed means it can be negative
            // // long myLong = -9223372036854775808;


            // // 4 byte (32 bit) floating point number
            // float myFloat = 0.751f;
            // float mySecondFloat = 0.75f;

            // // 8 byte (64 bit) floating point number
            // double myDouble = 0.751;
            // double mySecondDouble = 0.75d;

            // // 16 byte (128 bit) floating point number
            // decimal myDecimal = 0.751m;
            // decimal mySecondDecimal = 0.75m;

            // // Console.WriteLine(myFloat - mySecondFloat);
            // // Console.WriteLine(myDouble - mySecondDouble);
            // // Console.WriteLine(myDecimal - mySecondDecimal);



            // string myString = "Hello World";
            // // Console.WriteLine(myString);
            // string myStringWithSymbols = "!@#$@^$%%^&(&%^*__)+%^@##$!@%123589071340698ughedfaoig137";
            // // Console.WriteLine(myStringWithSymbols);

            // bool myBool = true;
            // System.Boolean myBool2 = false;

            // // Console.WriteLine(myBool);
            // // Console.WriteLine(myBool2);

            // // array
            // string[] myGroceryArray = new string[2];
            // myGroceryArray[0] = "Milk";
            // myGroceryArray[1] = "Bread";
            // // myGroceryArray[2] = "Eggs";

            // // Console.WriteLine(myGroceryArray[0]);
            // // Console.WriteLine(myGroceryArray[1]);

            // string[] mySecondGroceryArray = { "Milk", "Bread" };
            // // Console.WriteLine(mySecondGroceryArray[0]);
            // // Console.WriteLine(mySecondGroceryArray[1]);

            // // list
            // List<string> myGroceryList = new List<string>();
            // myGroceryList.Add("Milk");
            // myGroceryList.Add("Cheese");

            // // Console.WriteLine(myGroceryList[0]);
            // // Console.WriteLine(myGroceryList[1]);
            // // myGroceryList.Add(args[0]);
            // // Console.WriteLine(myGroceryList[2]);

            // // Ienumerable
            // IEnumerable<string> myGroceryIEnumerable = myGroceryList;
            // // Console.WriteLine(myGroceryIEnumerable.First());

            // string[,] my2DArray = new string[,]{
            //     { "Milk", "Bread" },
            //     { "Eggs", "Cheese" }
            // };

            // // Console.WriteLine(my2DArray[0, 0]);
            // // Console.WriteLine(my2DArray[0, 1]);
            // // Console.WriteLine(my2DArray[1, 0]);
            // // Console.WriteLine(my2DArray[1, 1]);

            // // Dictionary
            // Dictionary<string, string> myDictionary = new Dictionary<string, string>(){
            //     {"Cheese", "Dairy"},
            // };

            // // Console.WriteLine(myDictionary["Cheese"]);

            // Dictionary<string, string[]> myGroceryDictionary = new Dictionary<string, string[]>(){
            //     {"Dairy", new string[]{"Cheese", "Milk", "Eggs"}},
            // };

            // Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>(){
            //     {"Cheese", 2.99m},
            //     {"Milk", 3.99m},
            //     {"Eggs", 4.99m}
            // };

            // // Console.WriteLine(myGroceryDictionary["Dairy"][0]);
            // Console.WriteLine(itemPrices["Cheese"].GetType());
            // Console.WriteLine(itemPrices["Cheese"]);
            // Console.WriteLine(itemPrices["Milk"]);

            // ------------------------- Operators and Conditionals -------------------------

            // int myInt = 5;
            // int mySecondInt = 10;

            // Console.WriteLine(myInt.Equals(mySecondInt));
            // Console.WriteLine(myInt.Equals(mySecondInt / 2));
            // Console.WriteLine(myInt == mySecondInt);
            // Console.WriteLine(myInt == mySecondInt / 2);
            // Console.WriteLine(myInt != mySecondInt);
            // Console.WriteLine(myInt != mySecondInt / 2);
            // Console.WriteLine(myInt);
            // Console.WriteLine(myInt > mySecondInt);
            // Console.WriteLine(myInt < mySecondInt);

            // Console.WriteLine(5 < 10 && 5 > 10);
            // Console.WriteLine(5 < 10 || 5 > 10);

            // myInt++;

            // Console.WriteLine(myInt);

            // myInt += 7;
            // Console.WriteLine(myInt);

            // myInt -= 8;
            // Console.WriteLine(myInt);

            // Console.WriteLine(myInt * mySecondInt);

            // Console.WriteLine(myInt / mySecondInt);

            // Console.WriteLine(myInt % mySecondInt);

            // Console.WriteLine(myInt + mySecondInt);

            // Console.WriteLine(myInt - mySecondInt);

            // Console.WriteLine(5 + 5 * 10);

            // Console.WriteLine((5 + 5) * 10);

            // Console.WriteLine(myInt > mySecondInt);

            // Console.WriteLine(Math.Pow(5, 4));

            // Console.WriteLine(Math.Sqrt(25));

            // string myString = "test";

            // Console.WriteLine(myString);

            // myString += ". second part.";

            // Console.WriteLine(myString);

            // myString += " \"third\\ part.";

            // Console.WriteLine(myString);

            // string[] myStringArray = myString.Split(". ");

            // Console.WriteLine(myStringArray[0]);
            // Console.WriteLine(myStringArray[1]);
            // Console.WriteLine(myStringArray[2]);

            // ------------------------- Conditional statements -------------------------

            // int myInt = 5;
            // int mySecondInt = 10;

            // if (myInt > mySecondInt)
            // {
            //     myInt += 10;
            // }

            // Console.WriteLine(myInt);

            // string myCow = "cow";
            // string myCapitalizedCow = "Cow";
            // string notCow = "x";

            // if elseif else
            // if (myCow == myCapitalizedCow)
            // {
            //     Console.WriteLine("Equal");
            // }
            // else if (myCow == myCapitalizedCow.ToLower())
            // {
            //     Console.WriteLine("Equal without case sensitivity");
            // }
            // else
            // {
            //     Console.WriteLine("Not Equal");
            // }

            // Switch
            // switch (notCow)
            // {
            //     case "cow":
            //         Console.WriteLine("Equal");
            //         break;
            //     case "Cow":
            //         Console.WriteLine("Capitalized Equal");
            //         break;
            //     default:
            //         Console.WriteLine("Not Equal");
            //         break;
            // }

            // ------------------------- Loops -------------------------
            // int[] instsToCompress = new int[] { 10, 15, 20, 25, 30, 12, 34 };

            // DateTime startTime = DateTime.Now;

            // int totalValue = 0;
            // startTime = DateTime.Now;
            // totalValue = instsToCompress[0] + instsToCompress[1] +
            // instsToCompress[2] + instsToCompress[3] +
            // instsToCompress[4] + instsToCompress[5] + instsToCompress[6];
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            //146

            // // ---------- for loop ----------
            // totalValue = 0;
            // startTime = DateTime.Now;
            // for (int i = 0; i < instsToCompress.Length; i++)
            // {
            //     totalValue += instsToCompress[i];
            // }
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // // ---------- foreach loop ----------
            // totalValue = 0;
            // startTime = DateTime.Now;
            // foreach (int instToCompression in instsToCompress)
            // {
            //     totalValue += instToCompression;
            // }
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // // ---------- while loop ----------
            // totalValue = 0;
            // startTime = DateTime.Now;
            // int index = 0;
            // while (index < instsToCompress.Length)
            // {
            //     totalValue += instsToCompress[index];
            //     index++;
            // }
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // // ---------- do while loop ----------
            // totalValue = 0;
            // startTime = DateTime.Now;
            // index = 0;
            // do
            // {
            //     totalValue += instsToCompress[index];
            //     index++;
            // } while (index < instsToCompress.Length);
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // ---------- sum method ----------
            // totalValue = 0;
            // startTime = DateTime.Now;
            // totalValue = instsToCompress.Sum();
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // totalValue = 0;
            // startTime = DateTime.Now;
            // foreach (int instToCompression in instsToCompress)
            // {
            //     if (instToCompression > 20)
            //     {
            //         totalValue += instToCompression;
            //     }
            // }

            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);


            // ------------------------- Methods -------------------------
            // startTime = DateTime.Now;
            // totalValue = GetSum(instsToCompress);
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // int[] intsToCompress2 = new int[] { 23, 23, 53, 56, 83, 93 };
            // startTime = DateTime.Now;
            // totalValue = GetSum(intsToCompress2);
            // Console.WriteLine((DateTime.Now - startTime).TotalSeconds);
            // Console.WriteLine(totalValue);

            // ------------------------- Scope -------------------------
            // Console.WriteLine(accessibleInt);

            // A static method can only access static attibutes.
            // A non static method can access both static and non static attributes.
            // Declare before using a accessible in a scope.

        }
        // ------------------------- Methods -------------------------
        // static private int GetSum(int[] compressibleIntArray)
        // {
        //     // int[] compressibleIntArray = new int[] { 10, 15, 20, 25, 30, 12, 34 };
        //     int totalValue = 0;
        //     foreach (int instToCompression in compressibleIntArray)
        //     {
        //         totalValue += instToCompression;
        //     }
        //     return totalValue;
        // }
    }
}