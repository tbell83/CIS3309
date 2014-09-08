using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_class{
    public class Game{
        private int turn_count;
        private int target;
        private int status;
        private int[] record = new int [] {0,0};

/// <summary>
/// Create a new Game object with fresh set of 10 turns and a randomly generated target number.
/// </summary>
        public Game(){
            turn_count = 10;
            target = generateTarget();
        }

        public void newGame(){
            turn_count = 10;
            target = generateTarget();
        }

/// <summary>
/// Allows a turn to be taken in the number guessing game.  Returns 0 for win/correct, 1 for too high, 2 for too low, 3 for a loss, 4 for invalid input
/// </summary>
/// <param name="guess">Input int between 0 and 101.</param>
/// <returns>0,1,2,3</returns>
        public int takeTurn(int guess){
            if (validate(guess)){
                if (guess == target){
                    status = 0;
                    record[0] = record[0] + 1;
                }else if (turn_count == 1){
                    status = 3;
                    record[1] = record[1] + 1;
                }else if (guess > target){
                    status = 1;
                }else if (guess < target){
                    status = 2;
                }
                turn_count--;
            }else{
                status = 4;
            }
            return status;
        }

/// <summary>
/// Get the record of wins and losses for the current session.  Returns an array [<WINS>,<LOSSES>].
/// </summary>
/// <returns></returns>
        public int[] getRecord(){
            return record;
        }

/// <summary>
/// Returns the number of turns left before the game is lost.
/// </summary>
/// <returns></returns>
        public int getTurn(){
            return turn_count;
        }

        private bool validate(int guess){
            bool state;
            if (guess > 0 && guess <= 100){
                state = true;
            }else{
                state = false;
            }
            return state;
        }

        private int generateTarget(){
            Random rand = new Random();
            int number = rand.Next(1,100);
 ///           string ouput = "\n The number is:" + number + "\n";
 ///           Console.Write(ouput);
            return number;
        }
    }
}
