using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordProcessor
{
    public class TextHelper
    {

        #region Matn va harflar turkumini aniqlovchi funksiyalar

        public static string DIGITS = "0123456789";

        public static string LATIN_VOWELS = "aAuUoOeEiI";
        public static string LATIN_CONSONANTS = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVxXyYzZ";
        public static string LATIN_ALL = LATIN_VOWELS + LATIN_CONSONANTS;

        public static string CYRILLIC_VOWELS = "аАеЕёЁиИоОуУэЭўЎюЮяЯ";
        public static string CYRILLIC_CONSONANTS = "бБвВгГдДжЖзЗйЙкКлЛмМнНпПрРсСтТфФхХцЦчЧшШҳҲғҒқҚ";
        public static string CYRILLIC_ALL = CYRILLIC_VOWELS + CYRILLIC_CONSONANTS;

        public static string APOSTROPH_VARIANTS = "‘'`ʹʻʼʽˊˋ‘‘’";

        // Berilgan belgi kirilcha unli harfmi?
        public static bool IsVowelCyr(string ch)
        {

            return (CYRILLIC_VOWELS.Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi lotincha unli harfmi?
        public static bool IsVowelLat(string ch)
        {

            return (LATIN_VOWELS.Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi kirilcha undosh harfmi?
        public static bool IsConsonantCyr(string ch)
        {

            return (CYRILLIC_CONSONANTS.Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi lotincha undosh harfmi?
        public static bool IsConsonantLat(string ch)
        {

            return (LATIN_CONSONANTS.Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi apostrof shaklidami?
        public static bool IsApostroph(string ch)
        {

            return (APOSTROPH_VARIANTS.Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi kirilcha va katta harfmi?
        public static bool IsUcaseCyr(string ch)
        {

            return (CYRILLIC_ALL.ToUpper().Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi lotincha katta harfmi?
        public static bool IsUcaseLat(string ch)
        {

            return (LATIN_ALL.ToUpper().Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi kirilcha kichik harfmi?
        public static bool IsLcaseCyr(string ch)
        {

            return (CYRILLIC_ALL.ToLower().Contains(ch) && ch.Length > 0);

        }

        // Berilgan belgi lotincha kichik harfmi?
        public static bool IsLcaseLat(string ch)
        {

            return (LATIN_ALL.ToLower().Contains(ch) && ch.Length > 0);

        }

        // Berilgan matnga qarab kiril yoki lotindaligini aniqlash
        public static bool GetConvertDirection(string text)
        {

            int count = 0;

            // Har bir belgi kiril harfida bo'lsa sanagich 1 taga oshiriladi,
            // aks holda 1 taga kamaytiriladi. Natijada agar so'zda kiril harflar ko'p
            // bo'lsa sanagich qiymati 0 dan katta bo'ladi
            for (int i = 0; i < text.Length; i++)
            {

                if (IsLcaseCyr(text.Substring(i, 1).ToLower())) count++; else count--;

            }

            return (count > 0);

        }

        // Berilgan begli raqammi?
        public static bool IsDigit(string ch)
        {
            return DIGITS.Contains(ch) && ch.Length > 0;
        }

        // Berilgan belgi lotin harfimi?
        public static bool IsLatin(string ch)
        {
            return LATIN_ALL.Contains(ch) && ch.Length > 0;
        }

        // Berilgan belgi kirill harfimi?
        public static bool IsCyrillic(string ch)
        {
            return CYRILLIC_ALL.Contains(ch) && ch.Length > 0;
        }


        #endregion

        #region Transliteratsiya funksiyalari

        private static string apostroph1 = "‘";

        private static string[,] c2l = new string[,]
        {
            { "а", "a"  }, { "б", "b"  }, { "в", "v"  }, { "г", "g"  },
            { "д", "d"  }, { "ж", "j"  }, { "з", "z"  }, { "и", "i"  },
            { "й", "y"  }, { "к", "k"  }, { "л", "l"  }, { "м", "m"  },
            { "н", "n"  }, { "о", "o"  }, { "п", "p"  }, { "р", "r"  },
            { "с", "s"  }, { "т", "t"  }, { "у", "u"  }, { "ф", "f"  },
            { "х", "x"  }, { "ҳ", "h"  }, { "қ", "q"  }, { "э", "e"  },
            { "ё", "yo" }, { "ш", "sh" }, { "ч", "ch" }, { "ю", "yu" },
            { "я", "ya" }, { "ғ", "g‘"  }, { "ў", "o‘" }
        };

        // Berilgan matnni kirilldan lotinga o'girish
        public static string CyrToLat(string word)
        {

            int index = 0;
            int length = word.Length;
            string ch, prevch, nextch, resch, result = "";

            // qoidalar bo'yicha
            while (index < length)
            {

                ch = word.Substring(index, 1);

                prevch = (index > 0) ? word.Substring(index - 1, 1) : "";
                nextch = (index + 1) < length ? word.Substring(index + 1, 1) : "";
                resch = "";

                for (int i = 0; i < c2l.Length; i++)
                    if (c2l[i, 0].Equals(ch)) resch = c2l[i, 1];

                // agar harf o'tkazishlar jadvalida bo'lmasa
                if (resch.Length == 0)
                {

                    if (ch.Equals("е", StringComparison.CurrentCultureIgnoreCase))

                        // so'z boshida yoki unlidan keyin kelsa "ye", aks holda "e"
                        if (index == 0 || IsVowelCyr(prevch)) resch = "ye"; else resch = "e";

                    else if (ch.Equals("ц", StringComparison.CurrentCultureIgnoreCase))

                        // so'z boshi yoki ohirida kelsa, "s"
                        if (index == 0 || index == length - 1) resch = "s";

                        // so'z o'rtasida undoshdan keyin kelsa, "ts"
                        else if (index > 0 && IsConsonantCyr(prevch)) resch = "s";

                        // qolgan hamma holda ham "ts"
                        else resch = "ts";

                    else if (ch == "ъ" || ch == "Ъ")

                        // ў dan keyin kelsa, ""
                        if (prevch.ToLower() != "ў") resch = apostroph1; else resch = "";

                    else if ((ch == "ь" || ch == "Ь"))

                        // каньон, миньон => kanyon, minyon
                        if (IsConsonantCyr(prevch) && IsVowelCyr(nextch)) resch = "y"; else resch = "";

                    else

                        resch = ch;

                }

                // harf registrini to'g'rilash
                // Шанба=>Shanba (SHanba emas), АЁҚШ=>AYOQSH, МиЯ=>MiYa, ЯйЛоВ=>YayLoV
                if (IsUcaseCyr(ch)) resch = resch.ToUpper(); else resch = resch.ToLower();
                if (IsLcaseCyr(nextch) && resch.Length > 1 && index < length - 1) resch = resch.Substring(0, 1) + resch.Substring(1, 1).ToLower();
                if (IsUcaseCyr(nextch) && resch.Length > 1 && IsLcaseCyr(prevch)) resch = resch.Substring(0, 1) + resch.Substring(1, 1).ToLower();

                result = result + resch;

                index++;

            }

            return result;

        }


        private static string[,] l2c = new string[,]
        {
            { "a", "а"  }, { "b", "б"  }, { "c", "с"  }, { "d", "д"  },
            { "e", "е"  }, { "f", "ф"  }, { "g", "г"  }, { "h", "ҳ"  },
            { "i", "и"  }, { "j", "ж"  }, { "k", "к"  }, { "l", "л"  },
            { "m", "м"  }, { "n", "н"  }, { "o", "о"  }, { "p", "п"  },
            { "q", "қ"  }, { "r", "р"  }, { "s", "с"  }, { "t", "т"  },
            { "u", "у"  }, { "v", "в"  }, { "x", "х"  }, { "y", "й"  },
            { "z", "з"  }, { "ш", "sh" }, { "ч", "ch" }, { "ю", "yu" },
            { "я", "ya" }, { "ғ", "g‘"  }, { "ў", "o‘" }
        };

        // Berilgan matnni lotindan kirillga o'girish
        public static string LatToCyr(string word)
        {

            int index = 0;
            int length = word.Length;
            string ch, prevch, nextch, resch, result = "";
            string nextnextch;

            // qoidalar bo'yicha 
            while (index < length)
            {

                ch = word.Substring(index, 1);
                resch = "";
                prevch = (index > 0) ? word.Substring(index - 1, 1) : "";
                nextch = (index + 1 < length) ? word.Substring(index + 1, 1) : "";
                nextnextch = (index + 2 < length) ? word.Substring(index + 2, 1) : "";

                if (ch.ToLower() == "c" && nextch.ToLower() == "h")
                {
                    resch = "ч"; index++;
                }
                else if (ch.ToLower() == "t" && nextch.ToLower() == "s" && index == length - 1)
                {
                    resch = "ц"; index++;
                }
                else if (ch.ToLower() == "o" && IsApostroph(nextch))
                {
                    resch = "ў"; index++;
                }
                else if (ch.ToLower() == "e" && IsVowelLat(prevch)) resch = "э";

                else if (ch.ToLower() == "y" && nextch.ToLower() == "e") { resch = "е"; index++; }

                else if (ch.ToLower() == "y" && nextch.ToLower() == "o")

                    if (IsApostroph(nextnextch)) { resch = "йў"; index += 2; }
                    else { resch = "ё"; index++; }

                else if (ch.ToLower() == "y" && nextch.ToLower() == "a") { resch = "я"; index++; }

                else if (ch.ToLower() == "y" && nextch.ToLower() == "u") { resch = "ю"; index++; }

                else if (ch.ToLower() == "s" && nextch.ToLower() == "h") { resch = "ш"; index++; }

                else if (ch.ToLower() == "e" && index == 0) resch = "э";

                else if (ch.ToLower() == "g" && IsApostroph(nextch)) { resch = "ғ"; index++; }

                else if (IsApostroph(ch))

                    if (IsUcaseLat(prevch) || IsUcaseLat(nextch)) resch = "Ъ"; else resch = "ъ";

                else
                {

                    for (int i = 0; i < c2l.Length / 2; i++)
                        if (l2c[i, 0].Equals(ch)) resch = l2c[i, 1];

                    if (resch.Length == 0) resch = ch;

                }

                // harf registrini to'g'rilash
                if (IsUcaseLat(ch)) resch = resch.ToUpper(); else resch = resch.ToLower();
                if (IsLcaseLat(nextch) && resch.Length > 1 && index < length - 1) resch = resch.Substring(0, 1) + resch.Substring(1, 1).ToLower();
                if (IsUcaseLat(nextch) && resch.Length > 1 && IsLcaseLat(prevch)) resch = resch.Substring(0, 1) + resch.Substring(1, 1).ToLower();

                result = result + resch;

                index++;

            }

            return result;

        }

        #endregion

    }
}
