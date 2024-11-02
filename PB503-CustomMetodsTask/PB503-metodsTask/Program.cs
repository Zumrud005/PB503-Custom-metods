using System.ComponentModel.Design;
using System.Text;

namespace PB503_metodsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ValidatePassword(string password) - methodunuz olur, parameter olaraq qebul etdiyi stringin uzunlugu minimum 8, 
            //böyük hərflə başlamalı, tərkibində minimum 1 rəqəm olmalı və minimum 1 karakter(hərf və ya rəqəm olmayan: misal?, !, @) 
            //olmalıdır.Bu hallar ödənirsə true, ödənmirsə false qaytarmalıdır.

            //string password =Console.ReadLine();
            // Console.WriteLine(ValidatePassword(password));



            //String`in Substring(),  methodunu custom şəkildə yazmaq.
            // string word = "Zumrud Mustafazada";
            //Console.WriteLine(SubstringCustom(ref word, 2));
            //Console.WriteLine(SubstringCustom(ref word,0,5));



            //String`in Replace(),  methodunu custom şəkildə yazmaq.
            //string word = "salam necesen,salam  yaxsiyam";
            //ReplaceCustom(ref word, "salam", "hello");
            //Console.WriteLine(word);

            //String'in Trim() metodunu custom sekilde yazmaq

            //string word = "       Zumrud Mustafzada          ";
            //Console.WriteLine($"evvelki ifade:{word}");
            //Console.WriteLine($"sonraki ifade:{TrimCustom(ref word)}");

            
        }



        static bool ValidatePassword(string password)
        {

            if (password.Length >= 8)
            {

                if (char.IsUpper(password[0]))
                {
                    for (int i = 1; i < password.Length; i++)
                    {
                        if (char.IsDigit(password[i]))
                        {
                            for (int j = 1; j < password.Length; j++)
                            {
                                if (!char.IsLetterOrDigit(password[j]))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }

            }
            return false;

        }


        static string SubstringCustom(ref string word, int startIndex)
        {
            string result = "";

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("zehmet olmasa sozu duzgun qeyd edin");
                return "";
            }
            if (startIndex < 0 || startIndex > word.Length)
            {
                Console.WriteLine("indeksler duzgun deyil");
                return "";
            }
            for (int i = startIndex; i < word.Length; i++)
            {
                result += word[i];
            }
            return result;
        }


        static string SubstringCustom(ref string word, int startIndex, int endIndex)
        {
            string result = "";
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("zehmet olmasa sozu duzgun qeyd edin");
                return "";
            }
            if (startIndex < 0 || endIndex >= word.Length )
            {
                Console.WriteLine("indeksler duzgun deyil");
                return "";
            }
            for (int i = startIndex; i < startIndex+endIndex; i++)
            {
                result += word[i];
            }

            return result;
        }



        static string ReplaceCustom(ref string word, string oldWord, string newWord)
        {
            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(oldWord))
                return word;

            string result = "";
            int i = 0;

            while (i < word.Length)
            {

                if (i <= word.Length - oldWord.Length && word.Substring(i, oldWord.Length) == oldWord)
                {
                    result += newWord;
                    i += oldWord.Length;
                }
                else
                {
                    result += word[i];
                    i++;
                }
            }

            word = result;
            return word;
        }



        static string TrimCustom(ref string word)
        {
            string updateWord = "";
            int firstIndex = 0;
            int lastIndex = 0;  
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    firstIndex = i;
                  
                    break;
                }
            }
            for (int k= word.Length-1; k >=0; k--)
            {
                if (word[k]!=' ')
                {
                    lastIndex = k;
                    
                    break;
                }
            }
            for (int j = firstIndex; j <= lastIndex; j++)
            {
                updateWord += word[j];
            }
            return updateWord;
        }









    }
}




    

