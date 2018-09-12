using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Hashing
{
    public class HashingProblems
    {
        /// <summary>
        /// There is a class consisting of 'N' students . There can be many students with the same name.
        /// Now, you have to print the names of the students followed by there frequency as shown in the sample explanation given below.
        /// Output the names in the lexicographical order.
        /// </summary>
        public static int FrequencyofStudents(string[] studentsNameList, string nameToSearch)
        {
            Dictionary<string, int> dictNames = new Dictionary<string, int>();
            
            for (int i = 0; i < studentsNameList.Length; i++)
            {
                if (dictNames.ContainsKey(studentsNameList[i]))
                {
                    dictNames[studentsNameList[i]]++;
                }
                else
                {
                    dictNames.Add(studentsNameList[i], 1);
                }
            }

            if (dictNames.ContainsKey(nameToSearch))
                return dictNames[nameToSearch]; ;
            return -1;
        }

        /// <summary>
        /// Daksh has 'N' boxes of cricket balls and each box has certain number of cricket balls (non-zero) in it. The boxes are numbered from 1 to N.
        /// Now, Daksh has to go for practicing to cricket ground to compete in the upcoming fest URJA.Daksh wants to carry exactly K number of 
        /// cricket balls to ground and he can carry only 2 boxes.Can you tell him the number of ways in which he can select 2 boxes such that 
        /// total number of cricket balls in them is K.
        /// </summary>
        public static int CricketBalls(int n, int[] arr)
        {
            Hashtable ht = new Hashtable();
            for(int i=0;i<arr.Length;i++)
            {
                ht.Add(i, arr[i]);
            }
            return 1;
        }
    }
}
