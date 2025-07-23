using UnityEngine;
using SimpleJSON;
using System.Collections.Generic;
using System.IO;
using System;

namespace wordleUnity
{
    public static class WordUtilities
    {
        public static string GetTodaysWord(int startYear)
        {
            string path = Application.persistentDataPath + "/wordList.json";
            JSONNode words = JSON.Parse(File.ReadAllText(path));
            int i = GetCurrentDayIndex(startYear);

            return words["wordList"][i];
        }


        public static void ShowStats()
        {
            string path = Application.persistentDataPath + "/wordList.json";
            JSONNode words = JSON.Parse(File.ReadAllText(path));
            Debug.Log("Words in list: " + words["wordList"].Count);
        }


        public static bool IsInDictionary(string playerWord)
        {
            bool isIn = false;

            string path = Application.persistentDataPath + "/wordList.json";
            JSONNode words = JSON.Parse(File.ReadAllText(path));

            for (int i = 0; i < words["wordList"].Count; i++)
            {
                if(words["wordList"][i] == playerWord)
                {
                    isIn = true;
                    break;
                }
            }
            
            return isIn;
        }


        public static int GetCurrentDayIndex(int startYear)
        {
            DateTime now = DateTime.Now; //Today
            int todayIndex = now.DayOfYear;

            //Tally days in prior years since (and including) start year
            int priorDaysTotal = 0;
            for (int theYear = startYear; theYear < now.Year; theYear++)
            {
                priorDaysTotal += new DateTime(theYear, 12, 31).DayOfYear;
            }

            return (todayIndex + priorDaysTotal);
        }


        public static void MakeNewList(TextAsset theList)
        {
            List<string> randWords = new List<string>();
            List<string> words = new List<string>();

            JSONNode wordList = JSONNode.Parse(theList.text);

            for (int i = 0; i < wordList["wordList"].Count; i++)
            {
                words.Add(wordList["wordList"][i]);
            }

            while (words.Count > 0)
            {
                int i = UnityEngine.Random.Range(0, words.Count - 1);
                string w = words[i];
                words.RemoveAt(i);
                randWords.Add(w);
            }

            JSONObject newList = new JSONObject();
            newList.Add("wordList", randWords);
            string path = Application.persistentDataPath + "/wordList.json";
            File.WriteAllText(path, newList.ToString());
        }
  


        public static void ShowSs()
        {
            string path = Application.persistentDataPath + "/wordList.json";
            JSONNode words = JSON.Parse(File.ReadAllText(path));

            for (int i = 0; i < words["wordList"].Count; i++)
            {
                string s = (string)words["wordList"][i];
                if (s.EndsWith("s"))
                {
                    Debug.Log(s);
                }
            }
        }
    }
}
