using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataBaseDAL
    {
        public readonly VocabularyModel _ctx = new VocabularyModel();
        public int? GetUserIdByCredential(Credential credential)
        {
            var cred = _ctx.Credentials.Where(x => x.Email == credential.Email && x.Password == credential.Password)
                                       .SingleOrDefault();
            if(cred != null)
            {
                return cred.Id;
            }
            return null;   
        }
        public bool IsEmailAddressFree(string email)
        {
            return _ctx.Credentials.Any(x => x.Email == email);
        }
        public bool AddCredential(Credential credential) ///////////////////////////////// xml serialize
        {
            string projectPath =
                Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, @"..\..\VocabularyServer\bin\Debug"));
            int countBefore = _ctx.Credentials.Count();
            _ctx.Credentials.Add(credential);
            _ctx.Dictionaries.Add(new Dictionary
            {
                Name = "Animals",
                Credential = credential
            });
            _ctx.SaveChanges();
            var dictionary = _ctx.Dictionaries.Where(x => x.Name == "Animals" && x.Credential.Id == credential.Id).SingleOrDefault();
            _ctx.Words.AddRange(
                new List<Word>
                {
                    new Word
                    {
                        WordEng = "cat",
                        Transcription = "|kæt|",
                        Translation = "кіт",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\cat.jpg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\cat.mp3")
                    },
                    new Word
                    {
                        WordEng = "dog",
                        Transcription = "|dɔːɡ|",
                        Translation = "пес",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\dog.jpg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\dog.mp3")
                    },
                    new Word
                    {
                        WordEng = "bear",
                        Transcription = "|ber|",
                        Translation = "ведмідь",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\bear.jpeg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\bear.mp3")
                    },
                    new Word
                    {
                        WordEng = "penguin",
                        Transcription = "|ˈpeŋɡwɪn|",
                        Translation = "пінгвін",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\penguin.png"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\penguin.mp3")
                    },
                    new Word
                    {
                        WordEng = "parrot",
                        Transcription = "|ˈpærət|",
                        Translation = "папуга",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\parrot.png"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\parrot.mp3")
                    },
                    new Word
                    {
                        WordEng = "donkey",
                        Transcription = "|ˈdɔːŋki|",
                        Translation = "осел",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\donkey.jpg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\donkey.mp3")
                    },
                    new Word
                    {
                        WordEng = "rat",
                        Transcription = "|ræt|",
                        Translation = "пацюк",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\rat.png"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\rat.mp3")
                    },
                    new Word
                    {
                        WordEng = "mosquito",
                        Transcription = "|məˈskiːtoʊ|",
                        Translation = "комар",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\mosquito.jpg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\mosquito.mp3")
                    },
                    new Word
                    {
                        WordEng = "fox",
                        Transcription = "|fɑːks|",
                        Translation = "лисиця",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\fox.png"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\fox.mp3")
                    },
                    new Word
                    {
                        WordEng = "ratel",
                        Transcription = "|ˈreɪt(ə)l|",
                        Translation = "медоїд",
                        Dictionary = dictionary,
                        Image = File.ReadAllBytes($"{path}\\Image\\ratel.jpg"),
                        Sound = File.ReadAllBytes($"{path}\\Sound\\ratel.mp3")
                    }
                }
             );
            _ctx.SaveChanges();
            int countAfter = _ctx.Credentials.Count();
            return countAfter > countBefore;
        }
        public bool AddDictionary(Dictionary dictionary)
        {
            int countBefore = _ctx.Dictionaries.Count();
            _ctx.Dictionaries.Add(dictionary);
            _ctx.SaveChanges();
            int countAfter = _ctx.Dictionaries.Count();
            return countAfter > countBefore;
        }
    }
}
