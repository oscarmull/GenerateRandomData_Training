using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracture.Randomizers
{
    public class Text
    {
        public string GenerateRandomParagraph() {
            return Faker.Lorem.Paragraph();
        }
        public string GenerateRandomSentence()
        {
            return Faker.Lorem.Sentence();
        }
        public List<String> GenerateRandomParagraphs(int numberOfParagraphs)
        {
            var paragraphs = Faker.Lorem.Paragraphs(numberOfParagraphs);
            var list = new List<String>();
            foreach (var paragraph in paragraphs)
            {
                list.Add(paragraph);
            }
            return list;
        }
        public string GenerateRamdonWord(){
            return Faker.Lorem.GetFirstWord();
        }
        public List<String> GenerateRandomWords(int numberOfWords)
        {
            var words = Faker.Lorem.Words(numberOfWords);
            var list = new List<String>();
            foreach (var word in words)
            {
                list.Add(word);
            }
            return list;
        }
        public string GenerateRandomString(int length){
            return Faker.StringFaker.Alpha(length);
        }
    }
}
