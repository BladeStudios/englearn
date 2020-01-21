﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZTP
{
    public partial class GameWindow : Form
    {
        private int selectedLevel;
        private int selectedMode;

        public GameWindow()
        {
            InitializeComponent();
            Game game = new Game(selectedLevel, selectedMode);
            game.setState(1); //ustawienie przy ktorym pytaniu jestesmy
        }

        //GETTERY I SETTERY

        public int getSelectedLevel()
        {
            return this.selectedLevel;
        }

        public void setSelectedLevel(int selectedLevel)
        {
            this.selectedLevel = selectedLevel;
        }

        public int getSelectedMode()
        {
            return this.selectedMode;
        }

        public void setSelectedMode(int selectedMode)
        {
            this.selectedMode = selectedMode;
        }

        public void createButtons(int selectedMode) // tworzy odpowiednia ilosc i ulozenie buttonow zaleznie od wybranego trybu
        {

        }
    }
}
