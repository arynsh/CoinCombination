using System;
using System.Collections.Generic;

namespace Coin.Method
{
    public class CoinCombination
    {
        public int  UserInput { get; set;}
        public Dictionary <int, string> CoinDictionary ;

        public CoinCombination(int userInput)
        {
            UserInput = userInput;
            CoinDictionary = new Dictionary<int, string>(){ {25, "quarter"}, {10, "dime"}, {5, "nickle"}, {1, "penny"}  };
        }
        

        public string ChangeCounter()
        {
            Dictionary<int, string>.KeyCollection keyColl = CoinDictionary.Keys;
            List<string> coinList = new List<string>();
            int UserInputCopy = UserInput;

                foreach (int key in keyColl)
                {
                    while (UserInputCopy >= key)
                    {
                        if (UserInputCopy/key > 1)
                        {
                            if(CoinDictionary[key] == "penny")
                            {
                            coinList.Add((UserInputCopy/key).ToString()+" " + "pennies");
                            }
                            else
                            { 
                            coinList.Add((UserInputCopy/key).ToString()+" "+ CoinDictionary[key] + "s");
                            }
                        }
                        else
                        {
                            coinList.Add((UserInputCopy/key).ToString()+" "+ CoinDictionary[key]);                                               
                        }
                    UserInputCopy = UserInputCopy % key;
                    }
                }
            return string.Join(", ",coinList);
        }

        public string ChangeCounterCombo()
        {
            int[] keyColl = new int[] {1,5,10,25};
            int[,] solution = new int[keyColl.Length+1, UserInput+1];


            for(int i = 0; i < keyColl.Length; i++) {
                solution[i, 0] = 1;
            }

            for (int i =1; i <= UserInput; i++) {
                solution[0, i] = 0;
            }

            for (int i =1; i <= keyColl.Length; i++) {
                for (int j = 1; j <= UserInput; j++) {
                    if (keyColl[i-1] <= j) {
                        solution[i, j] = solution[i-1, j] + solution[i, j-keyColl[i-1]];
                    }
                    else{
                        solution[i, j] = solution[i-1, j];
                    }
                }
            }
            // for (int i =0; i< solution.GetLength(0); i++) {
            //     for (int j = 0; j < solution.GetLength(1); j++) {
            //         Console.WriteLine($"[{i}, {j}]" +  solution[i, j]);
            //     }
            // }
            return solution[4, UserInput].ToString();

        }

    }  
}