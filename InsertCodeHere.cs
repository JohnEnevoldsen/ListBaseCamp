using System;
using System.Collections.Generic;
// ReSharper disable CollectionNeverQueried.Local

namespace ListBaseCamp
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> listOfInt = new List<int>();
            listOfInt.Add(4);
            listOfInt.Add(12);
            listOfInt.Add(9);

            // Den skriver 12
            // Case 1
            // Console.WriteLine($"Case 1: Element with index 1 is {listOfInt[1]}");
            // Den skriver 3
            // Case 2
            // Console.WriteLine($"Case 2: List contains {listOfInt.Count} elements");

            listOfInt.Add(5);
            listOfInt.Add(22);
            // Den skriver 5
            // Case 3
            // Console.WriteLine($"Case 3: Element with index 3 is {listOfInt[3]}");

            listOfInt.RemoveAt(0);
            // Den skriver 22
            // Case 4
            // Console.WriteLine($"Case 4: Element with index 3 is {listOfInt[3]}");



            listOfInt.Clear();
            listOfInt.Add(14);
            listOfInt.Add(87);
            listOfInt.Add(62);
            listOfInt.Add(21);
            listOfInt.Add(40);
            listOfInt.Add(3);

            // Case 5: Add code that prints out 
            // all the elements in the list
            // for(int i = 0; i < listOfInt.Count; i++){
            //     Console.WriteLine(listOfInt[i]);
            // }


            // Case 6: Add code that finds the 
            // sum of the elements in the list, and prints the result
            // int sum = 0;
            // for(int i = 0; i < listOfInt.Count; i++){
            //     sum+=listOfInt[i];
            // }
            // Console.WriteLine(sum);

            // [DIFFICULT]
            // Case 7: Add code that finds the smallest  
            // element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
            int smallest = listOfInt[0];
            for(int i = 0; i < listOfInt.Count; i++){
                if(smallest > listOfInt[i]){
                    smallest = listOfInt[i];
                }
            }
            // Console.WriteLine(smallest);

            // [(maybe) DIFFICULT]
            // Case 8: Add code that sorts the content of the list.
            // Tip: Think before you code...
            int smallInInt = listOfInt[0];
            for(int i = 0; i < listOfInt.Count; i++){
                smallInInt = listOfInt[0+i];
                for(int j = 0+i; j < listOfInt.Count; j++){
                    if(smallInInt > listOfInt[j]){
                    smallInInt = listOfInt[j];
                    }
                }
                int tempIndex = listOfInt.IndexOf(smallInInt);
                int temp = listOfInt[i];
                listOfInt[i] = smallInInt;
                listOfInt[tempIndex] = temp;
            }
            foreach(var hej in listOfInt){
                Console.WriteLine(hej);
            }
            // listOfInt.Sort();

            // The LAST line of code should be ABOVE this line
        }
    }
}