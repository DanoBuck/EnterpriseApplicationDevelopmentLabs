using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate string EncryptMyCipher(string plainText);

namespace Delegates.Classes
{
    public class CaesarCipher
    {
        public static string EncryptSimple1Step(string encryption)
        {
            char[] caesarArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string result = "";
            char characterToReplace;
            int characterPosition = 0;

            for (int i = 0; i < encryption.Length; i++)
            {
                for(int j = 0; j < caesarArray.Length; j++)
                {
                    if(encryption[i] == caesarArray[j])
                    {
                        if(j > caesarArray.Length - 1)
                        {
                            j = 0;
                            characterPosition = 0;
                        }
                        characterPosition = j;
                    }
                }
                characterToReplace = encryption[i];

                // We want to keep our spaces in this cipher
                if (characterToReplace == ' ')
                {
                    result += characterToReplace;
                }
                else {
                    characterToReplace = caesarArray[characterPosition + 1];
                    result += characterToReplace;
                }
            }
            return result;
        }

        public static string ReverseEncryption(string encryption)
        {
            string result = "";

            for(int i = encryption.Length-1; i >= 0; i--)
            {
                result += encryption[i];
            }
            return result.ToString();
        }

        //EncryptMyCipher encrpyt;

        //encrypt = new EncryptMyCipher("To Bbe Encrypted");

        //encrypyt = new EncryptMyCipher("");
    }
}
