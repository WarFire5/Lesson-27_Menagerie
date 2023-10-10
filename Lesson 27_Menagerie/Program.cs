﻿using Lesson_27_Menagerie.Classes;

Console.WriteLine("Зверинец");
Console.WriteLine();

ElephantAnimal elephant = new ElephantAnimal("Матильда", 15, 20, 100);
//bool satiety = elephant.EatingPortionOfFeed("Сено", 5);
//Console.WriteLine(satiety);
elephant.Is();
elephant.LivesIn();
elephant.DoIt();
elephant.EatingPortionOfFeed("Сено", 5);
elephant.MakeASound();
elephant.EatingPortionOfFeed("Торт", 5);
elephant.CheckPredator("Сено");
//Console.WriteLine(elephant.IsPredator);
//bool check = elephant.CheckPredator();
//Console.WriteLine(elephant.CheckPredator());
elephant.EatingPortionOfFeed("Сено", 5);
elephant.Playing();
elephant.PlayingWithRelatives();
elephant.EatingPortionOfFeed("Сено", 5);
//Console.WriteLine(elephant.SatietyCheck());
Console.WriteLine();

PenguinAnimal penguin = new PenguinAnimal("Петя", 3, 5, 10);
//bool satiety = penguin.EatingPortionOfFeed("Рыба", 1);
//Console.WriteLine(satiety);
penguin.Is();
penguin.LivesIn();
penguin.DoIt();
penguin.EatingPortionOfFeed("Рыба", 1);
penguin.MakeASound();
penguin.EatingPortionOfFeed("Хлеб", 1);
penguin.CheckPredator("Рыба");
penguin.EatingPortionOfFeed("Рыба", 1);
penguin.Playing();
penguin.PlayingWithRelatives();
penguin.EatingPortionOfFeed("Рыба", 1);
//Console.WriteLine(penguin.SatietyCheck());
Console.WriteLine();

TigerAnimal tiger = new TigerAnimal("Симба", 15, 10, 50);
//bool satiety = tiger.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(satiety);
tiger.Is();
tiger.LivesIn();
tiger.DoIt();
tiger.EatingPortionOfFeed("Мясо", 5);
tiger.MakeASound();
tiger.EatingPortionOfFeed("Трава", 5);
tiger.CheckPredator("Мясо");
tiger.EatingPortionOfFeed("Мясо", 5);
tiger.Playing();
tiger.PlayingWithRelatives();
tiger.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(tiger.SatietyCheck());
Console.WriteLine();

FrogAnimal frog = new FrogAnimal("Кваша", 6, 3, 5);
//bool satiety = frog.EatingPortionOfFeed("Насекомые", 2);
//Console.WriteLine(satiety);
frog.Is();
frog.LivesIn();
frog.DoIt(); 
frog.EatingPortionOfFeed("Насекомые", 2);
frog.MakeASound();
frog.EatingPortionOfFeed("Сыр", 2);
frog.CheckPredator("Насекомые");
frog.EatingPortionOfFeed("Насекомые", 2);
frog.Playing();
frog.PlayingWithRelatives();
frog.EatingPortionOfFeed("Насекомые", 2);
//Console.WriteLine(tiger.SatietyCheck());
Console.WriteLine();

FishAnimal fish = new FishAnimal("Нимо", 3, 1, 1);
//bool satiety = fish.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(satiety);
fish.Is();
fish.LivesIn();
fish.DoIt(); 
fish.EatingPortionOfFeed("Планктон", 1);
fish.MakeASound();
fish.EatingPortionOfFeed("Сахар", 1);
fish.CheckPredator("Планктон");
fish.EatingPortionOfFeed("Планктон", 1);
fish.Playing();
fish.PlayingWithRelatives();
fish.EatingPortionOfFeed("Планктон", 1);
//Console.WriteLine(fish.SatietyCheck());
Console.WriteLine();

OrangutanAnimal orangutan = new OrangutanAnimal("Губач", 9, 15, 25);
//bool satiety = orangutan.EatingPortionOfFeed("Мясо", 5);
//Console.WriteLine(satiety);
orangutan.Is();
orangutan.LivesIn();
orangutan.DoIt(); 
orangutan.EatingPortionOfFeed("Фрукты", 3);
orangutan.MakeASound();
orangutan.EatingPortionOfFeed("Чипсы", 3);
orangutan.CheckPredator("Фрукты");
orangutan.EatingPortionOfFeed("Фрукты", 3);
orangutan.Playing();
orangutan.PlayingWithRelatives();
orangutan.EatingPortionOfFeed("Фрукты", 3);
//Console.WriteLine(orangutan.SatietyCheck());
Console.WriteLine();

Console.ReadLine();