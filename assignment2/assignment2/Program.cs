﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");

            //Question 2
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 2, 7, 11, 15 };
            int target = 9;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        /// Shuffle the input array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
        /// Print the array in the form[x1, y1, x2, y2, ..., xn, yn].
        ///Example 1:
        ///Input: nums = [2,5,1,3,4,7], n = 3
        ///Output: [2,3,5,4,1,7]
        /// Explanation: Since x1 = 2, x2 = 5, x3 = 1, y1 = 3, y2 = 4, y3 = 7 then the answer is [2,3,5,4,1,7].
        ///Example 2:
        ///Input: nums = [1,2,3,4,4,3,2,1], n = 4
        ///Output: [1,4,2,3,3,2,4,1]
        ///Example 3:
        ///Input: nums = [1,1,2,2], n = 2
        ///Output: [1,2,1,2]
        /// </summary>
        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //write code here.
                // initialize an integer array result 
                int[] result = new int[n * 2];
                // loop through the items in the counter unitl it is less than n
                for (int ctr = 0; ctr < n; ++ctr)
                {
                    result[ctr * 2] = nums[ctr]; // nums array with counter as the index gets updated with result array[ctr*2]
                    result[ctr * 2 + 1] = nums[n + ctr]; // the next index of the result array[ctr*2+1] gets updated with nums array with the index n appended to the counter value
                }
                Console.Write("["); // output line starts with square brackets. 
                for (int ctr = 0; ctr < 2 * n; ++ctr) // looping through the counter for twice the n index value
                {
                    Console.Write(result[ctr]); // Printing the output of the result arry with the current counter value
                    if (ctr < 2 * n - 1) // an if conditional statement, if the counter < twice the index n - 1
                    {
                        Console.Write(","); // to separate the numbers in the output with "," punctuation
                    }
                }
                Console.WriteLine("]"); // close the output square bracket
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 2:
        /// <summary>
        /// Write method to move all 0's to the end of the given array. You should maintain the relative order of the non-zero elements.
        /// You must do it in-place without making a copy of the array.
        /// Example:
        ///Input: [0,1,0,3,12]
        /// Output: [1,3,12,0,0]
        /// </summary>

        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                //write code here.
                for (int i = 1; i < ar2.Length; ++i) // iterate through the array's length, going through all the elements
                {
                    for (int j = ar2.Length - 1; j >= i; --j) // another iteration to iterate through array length - 1, last but one element, decrementing the j 
                    {
                        if ((ar2[j - 1] == 0) && (ar2[j] > 0)) // an if conditional statement, if the array[j-1] is equal to 0 and array[j] is greater than 0
                        {
                            int t = ar2[j - 1]; // integer t is now assigned to the array[j-1]
                            ar2[j - 1] = ar2[j]; // array[j-1] is now assigned to the array[j]
                            ar2[j] = t; // swap the array[j] with the integer t
                        }
                    }
                }
                Console.Write("["); // output starts with the square bracket
                for (int ctr = 0; ctr < ar2.Length; ++ctr) // iterate through the for loop through the entire array
                {
                    Console.Write(ar2[ctr]);// print the array with the current counter value as the index
                    if (ctr < ar2.Length - 1) // a conditional if statement to check if the counter has reached the last but one element
                    {
                        Console.Write(","); // separate it with the "," punctuation
                    }
                }
                Console.WriteLine("]"); // close the output with the square bracket
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 3
        /// <summary>
        /// For an array of integers - nums
        ///A pair(i, j) is called cool if nums[i] == nums[j] and i<j
        ///Print the number of cool pairs
        ///Example 1
        ///Input: nums = [1,2,3,1,1,3]
        ///Output: 4
        ///Explanation: There are 4 cool pairs (0,3), (0,4), (3,4), (2,5)
        ///Example 3:
        ///Input: nums = [1, 2, 3]
        ///Output: 0
        ///Constraints: time complexity should be O(n).
        /// </summary>
        private static void CoolPairs(int[] nums)
        {
            try
            {
                //write code here.
                Dictionary<int, int> aDictionary = new Dictionary<int, int>();
                // Instantiate a dictionary aDictionary that holds integer values
                for (int ctr = 0; ctr < nums.Length; ++ctr)
                {
                    // iterate through the counter for all the elements in the integer array nums
                    if (aDictionary.ContainsKey(nums[ctr]))
                    {
                        // a conditional loop statement, if the dictionary contains the key in the nums array for the counter value
                        ++aDictionary[nums[ctr]];
                        // append this to the nums counter index value of the dictionary
                    }
                    else
                    // an else case: 
                    {
                        aDictionary.Add(nums[ctr], 0); // Add the counter value of nums array with 0
                    }
                }
                int result = 0; // store 0 in an integer variable result
                foreach (KeyValuePair<int, int> aKeyValuePair in aDictionary)
                {
                    // the sum of cool pairs for each value is 1, 2, 3 to value
                    result += aKeyValuePair.Value * (aKeyValuePair.Value + 1) / 2;
                }
                Console.WriteLine(result); // print the output result
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 4:
        /// <summary>
        /// Given integer target and an array of integers, print indices of the two numbers such that they add up to the target.
        ///You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can print the answer in any order
        ///Example 1:
        ///Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        ///Output: Because nums[0] + nums[1] == 9, we print [0, 1].
        ///Example 2:
        ///Input: nums = [3,2,4], target = 6
        ///Output: [1,2]
        ///Example 3:
        ///Input: nums = [3,3], target = 6
        ///Output: [0,1]
        ///Constraints: Time complexity should be O(n)
        /// </summary>
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                //write code here.
                //write code here.
                int first = -1; // store the position of the first number here
                int second = -1; // store the position of the second number here
                Dictionary<int, int> aDictionary = new Dictionary<int, int>();
                // initialize a dictionary to store the integer values 
                for (int ctr = 0; ctr < nums.Length; ++ctr)
                {
                    // loop through all the elements in the nums array
                    if (aDictionary.ContainsKey(nums[ctr]))
                    {
                        first = aDictionary[nums[ctr]]; // first number contains the value of the dictionary which is the nums array element with ctr as the index
                        second = ctr; // second number is just the counter value
                        break;
                    }
                    else
                    {
                        aDictionary.Add(target - nums[ctr], ctr);
                    }// add the difference of target value and element in the nums array with ctr as the value.
                }
                Console.WriteLine("[" + first + "," + second + "]"); // output contains square brackets and the first number, second number followed by the closing parenthesis

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 5:
        /// <summary>
        /// Given a string s and an integer array indices of the same length.
        ///The string s will be shuffled such that the character at the ith position moves to indices[i] in the shuffled string.
        ///Print the shuffled string.
        ///Example 1
        ///Input: s = "korfsucy", indices = [6,4,3,2,1,0,5,7]
        ///Output: "usfrocky"
        ///Explanation: As shown in the assignment document, "K" should be at index 6, "O" should be at index 4 and so on. "korfsucy" becomes "usfrocky"
        ///Example 2:
        ///Input: s = "USF", indices = [0,1,2]
        ///Output: "USF"
        ///Explanation: After shuffling, each character remains in its position.
        ///Example 3:
        ///Input: s = "ockry", indices = [1, 2, 3, 0, 4]
        ///Output: "rocky"
        /// </summary>
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //write code here.
                char[] anArray = new char[indices.Length]; // initialize a character array
                for (int ctr = 0; ctr < indices.Length; ++ctr)
                {
                    // loop through th elements of the indices array
                    anArray[indices[ctr]] = s[ctr];
                }// append the string s to the indices array which has ctr as the index
                for (int ctr = 0; ctr < indices.Length; ++ctr)
                {
                    Console.Write(anArray[ctr]); // print the array element which has ctr as the index
                }
                Console.WriteLine();

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 6
        /// <summary>
        /// Determine whether two give strings s1 and s2, are isomorphic.
        ///Two strings are isomorphic if the characters in s1 can be replaced to get s2.
        ///All occurrences of a character must be replaced with another character while preserving the order of characters.
        ///No two characters may map to the same character but a character may map to itself.
        ///Example 1:
        ///Input:s1 = "bulls" s2 = "sunny"
        ///Output : True
        ///Explanation: 'b' can be replaced with 's' and similarly 'u' with 'u', 'l' with 'n' and 's' with 'y'.
        ///Example 2:
        ///Input: s1 = "usf" s2 = "add"
        ///Output : False
        ///Explanation: 'u' can be replaced with 'a', but 's' and 'f' should be replaced with 'd' to produce s2, which is not possible. So False.
        ///Example 3:
        ///Input : s1 = "ab" s2 = "aa"
        ///Output: False
        /// </summary>
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                //write code here.
                Dictionary<char, int> aDictionaryA = new Dictionary<char, int>();
                Dictionary<char, int> aDictionaryB = new Dictionary<char, int>();
                List<int> aListA = new List<int>(); // initalize empty integer lists A and B
                List<int> aListB = new List<int>(); 

                // generate frequency dictionary
                for (int ctr = 0; ctr < s1.Length; ++ctr)
                {// use a for loop to iterate through the elements of the s1 string array
                    if (aDictionaryA.ContainsKey(s1[ctr]))
                    {
                        ++aDictionaryA[s1[ctr]];
                    }
                    else // if the dicitonary contains key in the s1 string array, add that to the dictionary
                    {
                        aDictionaryA.Add(s1[ctr], 1); // else add that along with 1 
                    }
                }
                for (int ctr = 0; ctr < s2.Length; ++ctr)
                {
                    if (aDictionaryB.ContainsKey(s2[ctr]))
                    { // if the dictionary B contains key of the string s2 array
                        ++aDictionaryB[s2[ctr]];
                    } // increment the dictionary B value with the counter index value of the string s2
                    else
                    {
                        aDictionaryB.Add(s2[ctr], 1);
                    } // Dictionary B is to be added to the string s2 with ctr as the index
                }

                // place dictionary values into a list
                foreach (KeyValuePair<char, int> aKeyValuePair in aDictionaryA)
                {
                    aListA.Add(aKeyValuePair.Value); // add the dictionary key-value pair for the list A
                }
                foreach (KeyValuePair<char, int> aKeyValuePair in aDictionaryB)
                {
                    aListB.Add(aKeyValuePair.Value); // add the dictionary ky-value pair for the list B
                }

                // sort lists
                aListA.Sort();
                aListB.Sort();

                // it is isomorphic if lists are equal, not isomorphic otherwise
                bool result = true; // store the result in a boolean type variable result set to true 

                if (aListA.Count != aListB.Count) // if the count in list A is not equal to the count in the list B
                {
                    result = false; 
                    return result; // return the result
                }
                for (int ctr = 0; ctr < aListA.Count; ++ctr)
                {
                    // iterate through the list A with count values and increment the ctr value
                    if (aListA[ctr] != aListB[ctr])
                    { // if list A's counter index value is not equal to list B's counter index value
                        result = false;
                        break;
                    }
                }
                return result; // return the final result
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation:
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                //write code here.
                // initialize a dictionary List with integer 
                Dictionary<int, List<int>> aDictionary = new Dictionary<int, List<int>>();
                // loop through the elements in the items array
                for (int ctr = 0; ctr < items.GetLength(0); ++ctr)
                {
                    // if a dictionary contains key in the items array 
                    if (aDictionary.ContainsKey(items[ctr, 0]))
                    {
                        // instantiate a list with the counter value of the dictionary
                        List<int> aList = aDictionary[items[ctr, 0]];
                        aList.Add(items[ctr, 1]); // add 1 and the counter to the list
                        aDictionary[items[ctr, 0]] = aList; // add 0 and the counter to the List 
                    }
                    else
                    {
                        List<int> aList = new List<int>(); // create a new list
                        aList.Add(items[ctr, 1]);// add 1 to the items array
                        aDictionary.Add(items[ctr, 0], aList);
                    }
                }

                // sort ID
                var aSortedDictionary = from aKeyValuePair in aDictionary
                                        orderby aKeyValuePair.Key ascending
                                        select aKeyValuePair;

                Console.Write("[");
                int comma = 0;
                foreach (KeyValuePair<int, List<int>> aKeyValuePair in aSortedDictionary)
                {
                    ++comma;
                    List<int> aList = aKeyValuePair.Value;
                    aList.Sort(); // sort the dictonary elements
                    aList.Reverse(); // from ascending make it decending
                    int average = 0; // declare an integer variable average and initialize it to 0
                    int count = 0; // declare an integer variable count to zero
                    for (int ctr = 0; ctr < aList.Count; ++ctr)
                    {
                        ++count; 
                        average += aList[ctr]; // average is added to the list containing ctr as the index
                        if (count == 5) // after 5 elememts, stop
                        {
                            break;
                        }
                    }
                    average /= count; // average = average divided by the count value
                    Console.Write("[" + aKeyValuePair.Key + "," + average + "]");
                    if (comma < aDictionary.Count)
                    {
                        Console.Write(","); // to separate the elements by "," 
                    }
                }
                Console.WriteLine("]"); // close the square bracket

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 8
        /// <summary>
        /// Write algorithm to determine if a number n is happy.
        ///A happy number is a number defined by the following process:
        ///• Starting with any positive integer, replace the number by the sum of the squares of its digits.
        ///• Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
        ///• Those numbers for which this process ends in 1 are happy.
        ///Return true if n is a happy number, and false if not.
        ///Example 1:
        ///Input: n = 19
        ///Output: true
        ///Explanation:
        ///12 + 92 = 82
        ///82 + 22 = 68
        ///62 + 82 = 100
        ///12 + 02 + 02 = 1
        ///Example 2:
        ///Input: n = 2
        ///Output: false
        ///Constraints:
        ///1 <= n <= 231 - 1
        /// </summary>
        private static bool HappyNumber(int n)
        {
            try
            {
                //write code here.
                bool isHappy = false; // declare a boolean type variable and set it to false
                List<int> aList = new List<int>(); // create an empty list
                while (true) // while the condition is set to be true
                {
                    if (n == 1) // if the n value is equal to 1
                    {
                        isHappy = true;
                        break; // assign bool variable to true
                    }
                    if (aList.Contains(n)) // if the list contains n
                    {
                        isHappy = false; // assign bool variable to false
                        break;
                    }
                    else
                    {
                        aList.Add(n);
                    }
                    string aString = n.ToString(); // initialize a new string
                    int sum = 0;
                    for (int ctr = 0; ctr < aString.Length; ++ctr)
                    { // loop through all the elements in the array 
                        int number = Convert.ToInt32(aString[ctr].ToString());
                        sum += number * number; // sum = sum + number ^2
                    }
                    n = sum;
                }
                return isHappy; // return the bool variable value
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 9
        /// <summary>
        /// Professor Manish is planning to invest in stocks. He has the data of the price of a stock for the next n days.  
        /// Tell him the maximum profit he can earn from the given stock prices.Choose a single day to buy a stock and choose another day in the future to sell the stock for a profit
        /// If you cannot achieve any profit return 0.
        /// Example 1:
        /// Input: prices = [7,1,5,3,6,4]
        /// Output: 5
        /// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
        /// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
        /// Example 2:
        /// Input: prices = [7,6,4,3,1]
        /// Output: 0
        ///Explanation: In this case, no transactions are done and the max profit = 0.
        ///Try to solve it in O(n) time complexity.
        /// </summary>
        private static int Stocks(int[] prices)
        {
            try
            {
                //write code here.
                int[] min = new int[prices.Length];// store min in an integer array
                int[] max = new int[prices.Length]; // store max in an integer array
                int result = int.MaxValue; // result is nothing but the maximum value
                for (int ctr = 0; ctr < prices.Length; ++ctr)
                { // iterate through the prices array with ounter value set to 0 
                    if (prices[ctr] < result)
                    { // if the prices array with counter value is lesser than result
                        result = prices[ctr]; // append result to the counter value of the prices array
                    }
                    min[ctr] = result; // else the result will be equal to the ctr value in the min array
                }
                result = int.MinValue; // result is now appended to the minimum value
                for (int ctr = prices.Length - 1; ctr >= 0; --ctr)
                { 
                    // iterate through all the elements until the last but one element of the prices array and decrement ctr value
                    if (prices[ctr] > result) // conditional if looping to be done if the ctr index value of the prices is less than the result
                    {
                        result = prices[ctr]; // result becomes equal to the ctr index value of the prices array
                    }
                    max[ctr] = result; // result is then appended to the max array element which has the ctr as the index
                }
                result = int.MinValue; // now the result is equal to the Minimum value. 
                for (int ctr = 0; ctr < prices.Length; ++ctr)
                {
                    // iterate through all the elements of the prices array
                    int temp = max[ctr] - min[ctr]; // store the difference of the max and min value in the integer variable temp
                    if (temp > result) // if condition: temp is greater than the result
                    {
                        result = temp; // result is appended to temp
                    }
                }
                if (result < 0) // if the result is less than 0, 
                {
                    return 0; // just return 0
                }
                return result; // finally return the desired result
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 10
        /// <summary>
        /// Professor Clinton is climbing the stairs in the Muma College of Business. He generally takes one or two steps at a time.
        /// One day he came across an idea and wanted to find the total number of unique ways that he can climb the stairs. Help Professor Clinton.
        /// Print the number of unique ways.
        /// Example 1:
        ///Input: n = 2
        ///Output: 2
        ///Explanation: There are two ways to climb to the top.
        ///1. 1 step + 1 step
        ///2. 2 steps
        ///Example 2:
        ///Input: n = 3
        ///Output: 3
        ///Explanation: There are three ways to climb to the top.
        ///1. 1 step + 1 step + 1 step
        ///2. 1 step + 2 steps
        ///3. 2 steps + 1 step
        ///Hint : Use the concept of Fibonacci series.
        /// </summary>
        private static void Stairs(int steps)
        {
            try
            {
                //write code here.
                int nminus2 = 0; // integer variable is assigned to 0
                int nminus1 = 1; // anohter integer variable is assigned to 1
                int ctr = 0;// a thrid integer variable is assigned to 0
                int n; // initialize an integer n
                while (true) // looping while condition is set to be true
                {
                    ++ctr; // increment the counte value
                    n = nminus2 + nminus1; // n value is set to first integer variable intialized to 0 added to the second integer variable set to 1
                    if (ctr == steps) // if the counter value is equal to the steps
                    {
                        break; // break the if condition
                    }
                    nminus2 = nminus1; // the first integer variable is equal to the second one
                    nminus1 = n; // the second integer variable is equal to the n value
                }
                Console.WriteLine(n); // print the n
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
