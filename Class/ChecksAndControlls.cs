using Inlämning1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämning1.Class
{
    class ChecksAndControlls : IChecksAndControlls
    {
        public bool CheckIfStringIsEmpty(string Word)
        {
           var result = String.IsNullOrWhiteSpace(Word);
            if (result)
            {
                result = false;

            }
            else
            {
                result = true;
            }

           return result;
        }

        public string UppercaseFirstLetter(string Word)
        {
            string result = Word;

            if (CheckIfStringIsEmpty(Word))
            {
                 result = char.ToUpper(Word[0]) + Word.Substring(1);

            }

            return result;

        }
    }
}
