﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;

namespace DAL
{
    internal class CustomInitializer<T> : DropCreateDatabaseIfModelChanges<VocabularyModel>
    {
        protected override void Seed(VocabularyModel _ctx)
        {
            string projectPath =
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            //string currentDir = Environment.CurrentDirectory;
            //DirectoryInfo directory = new DirectoryInfo(
            //Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + localPath)));
            var path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.RelativeSearchPath, @"..\..\VocabularyServer\bin\Debug"));
            Credential cred1 = new Credential
            {
                Email = "nhy66@mail.ru",
                Password = "5984ljkfh"
            };
            _ctx.Credentials.Add(cred1);

            Dictionary dict1 = new Dictionary
            {
                Name = "Animal",
                Credential = cred1
            };
            _ctx.Dictionaries.Add(dict1);

            _ctx.Words.AddRange(new List<Word>()
            {
                new Word
                {
                    WordEng = "cat",
                    Transcription = "|kæt|",
                    Translation = "кіт",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\cat.jpg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\cat.mp3")
                },
                new Word
                {
                    WordEng = "dog",
                    Transcription = "|dɔːɡ|",
                    Translation = "пес",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\dog.jpg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\dog.mp3")
                },
                new Word
                {
                    WordEng = "bear",
                    Transcription = "|ber|",
                    Translation = "ведмідь",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\bear.jpeg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\bear.mp3")
                },
                new Word
                {
                    WordEng = "penguin",
                    Transcription = "|ˈpeŋɡwɪn|",
                    Translation = "пінгвін",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\penguin.png"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\penguin.mp3")
                },
                new Word
                {
                    WordEng = "parrot",
                    Transcription = "|ˈpærət|",
                    Translation = "папуга",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\parrot.png"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\parrot.mp3")
                },
                new Word
                {
                    WordEng = "donkey",
                    Transcription = "|ˈdɔːŋki|",
                    Translation = "осел",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\donkey.jpg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\donkey.mp3")
                },
                new Word
                {
                    WordEng = "rat",
                    Transcription = "|ræt|",
                    Translation = "пацюк",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\rat.png"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\rat.mp3")
                },
                new Word
                {
                    WordEng = "mosquito",
                    Transcription = "|məˈskiːtoʊ|",
                    Translation = "комар",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\mosquito.jpg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\mosquito.mp3")
                },
                new Word
                {
                    WordEng = "fox",
                    Transcription = "|fɑːks|",
                    Translation = "лисиця",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\fox.png"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\fox.mp3")
                },
                new Word
                {
                    WordEng = "ratel",
                    Transcription = "|ˈreɪt(ə)l|",
                    Translation = "медоїд",
                    Dictionary = dict1,
                    Image = File.ReadAllBytes($"{path}\\Image\\ratel.jpg"),
                    Sound = File.ReadAllBytes($"{path}\\Sound\\ratel.mp3")
                }
            });
            _ctx.SaveChanges();
            base.Seed(_ctx);
        }
    }
}