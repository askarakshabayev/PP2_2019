﻿using System;
using System.Collections.Generic;
using System.IO;
namespace Example3
{
    public class Wall:GameObject
    {
        enum GameLevel
        {
            First,
            Second,
            Third
        }

        GameLevel gameLevel = GameLevel.First;


        public Wall(char sign, ConsoleColor color):base(0, 0, sign, color)
        {
            body = new List<Point>();
        }

        public void Level(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string s = "";
            int y = 0;
            while ((s = sr.ReadLine()) != null)
            {
                for (int x = 0; x < s.Length; x++)
                    if (s[x] == '*')
                        body.Add(new Point(x, y));
                y++;
            }
            sr.Close();
        }
        public void LoadLevel()
        {
            body = new List<Point>();
            if (gameLevel == GameLevel.First)
            {
                Level("level1.txt");
            }
            if (gameLevel == GameLevel.Second)
            {
                Level("level2.txt");
            }
            if (gameLevel == GameLevel.Third)
            {
                Level("level3.txt");
            }
        }
        public void NextLevel()
        {
            if (gameLevel == GameLevel.First)
                gameLevel = GameLevel.Second;
            else if (gameLevel == GameLevel.Second)
                gameLevel = GameLevel.Third;
            LoadLevel();
        }
    }
}
