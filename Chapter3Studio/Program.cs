using System;

namespace Chapter3Studio
{
    class Program
    {
        public static void Main(string[] args)
        {
            string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] lipsum = loremIpsum.ToCharArray();
            Console.WriteLine(lipsum.Length);
            var loremIpsumCharCount = CharacterCount.CharacterTypeCount(lipsum);
            Console.WriteLine(loremIpsumCharCount.Count);
        }
    }
}
