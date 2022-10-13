﻿namespace MorseSharp
{
    /// <summary>
    /// Defines all morse characters.
    /// </summary>
    internal static class MorseCharacters
    {
        /// <summary>
        /// Defines all morse characters in english language.
        /// </summary>
        /// <returns><see cref="System.Collections.Generic.Dictionary{TKey, TValue}"></see> of morse characters./></returns>
        public static Dictionary<char, string> GetMorseCharactersEnglish()
        {
            return new Dictionary<char, string>()
            {
                //Alphabets
                { 'A', "._" },
                { 'B', "_..." },
                { 'C', "_._." },
                { 'D', "_.."},
                { 'E', "." },
                { 'F', ".._." },
                { 'G', "__." },
                { 'H', "...." },
                { 'I', ".." },
                { 'J', ".___" },
                { 'K', "_._" },
                { 'L', "._.." },
                { 'M', "__" },
                { 'N', "_." },
                { 'O', "___" },
                { 'P', ".__." },
                { 'Q', "__._" },
                { 'R', "._." },
                { 'S', "..." },
                { 'T', "_" },
                { 'U', ".._" },
                { 'V', "..._" },
                { 'W', ".__"},
                { 'X', "_.._" },
                { 'Y', "_.__" },
                { 'Z', "__.." },
                //Numerics
                { '1', ".____" },
                { '2', "..__" },
                { '3', "...__" },
                { '4', "...._" },
                { '5', "....." },
                { '6', "_...." },
                { '7', "__..." },
                { '8', "___.." },
                { '9', "____." },
                { '0', "_____" },
                //Space
                {' ', "/" },
                //Punctuation
                {'.',"._._._" },
                {',',"__..__" },
                {'?',"..__.." },
                {';',"_._._." },
                {':',"___..." },
                {'/',"_.._."},
                {'\'',".____." },
                {'\"',"._.._." },
                //Special Characters
                {'_',"..__._"},
                {'+',"._._." },
                {'-',"_...._" },
                {'*',"_.._" },
                {'=',"_..._" },
                {')',"_.__._" },
                {'(',"_.__." }
        };
        }

        /// <summary>
        /// Defines all morse characters in kurdish language.
        /// </summary>
        /// <returns><see cref="System.Collections.Generic.Dictionary{TKey, TValue}"></see> of morse characters./></returns>
        public static Dictionary<char, string> GetMorseCharactersKurdish()
        {
            return new Dictionary<char, string>()
            {
                //Alphabets
                {'ا',"._" },
                {'ب',"_..." },
                {'پ',".__." },
                {'ت',"_" },
                {'ج',".___" },
                {'چ',"___." },
                {'ح',"...." },
                {'خ',"_.._" },
                {'د',"_.." },
                {'ر',"_._" },
                {'ڕ',"._." },
                {'ز',"__.." },
                {'ژ',"__." },
                {'س',"..." },
                {'ش',"____" },
                {'ع',"___" },
                {'غ',"..__" },
                {'ف',".._." },
                {'ڤ',".._.." },
                {'ق',"...___" },
                {'ک',"_...." },
                {'گ',"__._" },
                {'ل',"._.." },
                {'ڵ',"..._" },
                {'م',"__" },
                {'ن',"_." },
                {'ه',"_._." },
                {'ە',"." },
                {'و',".__" },
                {'ۆ',"._._" },
                {'ی',".." },
                {'ێ',".._" },
                {'ئ',".._.." },

                //Numbers
                {'١',".____" },
                {'٢',"..___" },
                {'٣',"...__" },
                {'٤',"...._" },
                {'٥',"....." },
                {'٦',"_...." },
                {'٧',"__..." },
                {'٨',"___.." },
                {'٩',"____." },
                {'٠',"_____" },
                //Space
                {' ', "/" },
                //Punctuation
                {'.',"._._._." },
                {'،',"__..__" },
                {'؟',"..__.." },
                {':',"___..." },
                {'_',"_...._" },
                {'/',"_.._." },
                {'\'',".____." },
                {'\"',"._.._." },
                {'؛',"_._._." },
                //Special Characters
                {'-',"..__._" },
                {'+',"._._." },
                {'*',"_.._" },
                {'٪',"___.._" },
                {'=',"_..._" },
                {')',"_.__._" },
                {'(',"_.__." },

        };
        }
    }
}