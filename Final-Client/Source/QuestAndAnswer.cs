using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project
{
    public class QuestAndAnswer
    {
        // Properties
        public string Question{get;set;}
        public string OptionA { get;set;}
        public string OptionB { get;set;}
        public string OptionC { get;set;}
        public string OptionD { get;set;}
        public string Answer { get;set;}

        // Contrustor
        public QuestAndAnswer()
        {

        }
        public QuestAndAnswer(string question, string optionA, string optionB, string optionC, string optionD, string answer)
        {
            Question = question;
            OptionA = optionA;
            OptionB = optionB;
            OptionC = optionC;
            OptionD = optionD;
            Answer = answer;
        }
        public static QuestAndAnswer GetObjectFromBytes(byte[] data)
        {
            QuestAndAnswer result = new QuestAndAnswer();
            using (MemoryStream m = new MemoryStream(data))
            {
                using (BinaryReader reader = new BinaryReader(m))
                {
                    result.Question = reader.ReadString();
                    result.OptionA = reader.ReadString();
                    result.OptionB = reader.ReadString();
                    result.OptionC = reader.ReadString();
                    result.OptionD = reader.ReadString();
                    result.Answer = reader.ReadString();
                }
            }
            return result;
        }
        public byte[] ToBytesArray()
        {
            using (MemoryStream m = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(m))
                {
                    writer.Write(Question);
                    writer.Write(OptionA);
                    writer.Write(OptionB);
                    writer.Write(OptionC);
                    writer.Write(OptionD);
                    writer.Write(Answer);
                    writer.Flush();
                }
                m.FlushAsync();
                return m.ToArray();
            }
        }
    }
}
