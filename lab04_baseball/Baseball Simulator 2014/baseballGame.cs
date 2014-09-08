using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Baseball_Simulator_2014 {
    class baseballGame {
        Queue<int> bases = new Queue<int>(3);
        int[,] score = new int[2,9];
        string teamA, teamB;
        Random seed = new Random();
        public baseballGame() {
        }

        public int[,] Game(){
            for (int inning = 1;inning <= 9;inning++){
                for (int frame = 1;frame <= 2;frame++){
                    score[frame-1,inning-1] = Frame();
                }
                ///Console.WriteLine("New Inning");
            }
            return score;
        }

        private int Frame() {
            ///Console.WriteLine("Teams Switch");
            clearBases();
            int score = 0;
            int outs = 3;
            while(outs != 0){
                int hit = atBat();
                if (hit == 0) {
                    outs--;
                    ///Console.WriteLine("Outs remaining: " + outs.ToString());
                }
                score += running(hit);
            }
            return score;
        }

        private int atBat(){
            ///Console.WriteLine("New Batter");
            Random random = new Random(seed.Next());
            int number = random.Next(100);
            ///Console.WriteLine(number);
            if(number >= 1 && number <= 60){
                ///Console.WriteLine("You're Out!");
                return 0;
            }else if(number >= 61 && number <= 70){
                ///Console.WriteLine("Single");
                return 1;
            }else if(number >= 71 && number <= 80){
                ///Console.WriteLine("Double");
                return 2;
            }else if(number >= 81 && number <= 90){
                ///Console.WriteLine("Triple");
                return 3;
            }else{
                ///Console.WriteLine("Home Run");
                return 4;
            }
        }

        private int running(int run){
            int runs = 0;
            for (int i = 0; i < run; i++){
                if (bases.Dequeue() == 1){
                    runs++;
                    ///Console.WriteLine("Runner Scores!");
                }

                if (i == 0){
                    bases.Enqueue(1);
                }else{
                    bases.Enqueue(0);
                }
            }
            return runs;
        }

        private void clearBases() {
            bases.Clear();
            for (int i = 1; i <= 3; i++) {
                bases.Enqueue(0);
            } 
        }
    }
}