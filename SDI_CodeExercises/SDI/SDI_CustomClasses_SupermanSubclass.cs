using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI
{
    class Superman
    {
        /*
        Mark Mckinney
        24 June 2018
        SDI Section 01 
        Custom Class Assignment
        Class for Superman game
        */

        //Member variables
        int mSetRounds;
        int mCurrentHP;
        int mMinHP;
        int mMaxHP;

        //Constructor function
        public Superman(int _SetRounds, int _CurrentHP, int _MaxHP, int _MinHP) {
            mSetRounds = _SetRounds;
            mCurrentHP = _CurrentHP;
            mMaxHP = _MaxHP;
            mMinHP = _MinHP;
        }

        public Superman(int _CurrentHP, int _MaxHP, int _MinHP) {
            mCurrentHP = _CurrentHP;
            mMaxHP = _MaxHP;
            mMinHP = _MinHP;
        }

        //Getters
        public int GetSetRounds() {
            return mSetRounds;
        }
        public int GetCurrentHP() {
            return mCurrentHP;
        }
        public int GetMaxHP() {
            return mMaxHP;
        }
        public int GetMinHP() {
            return mMinHP;
        }

        //Setters
        public void SetRounds(int _SetRounds) {
            this.mSetRounds = _SetRounds;
        }
        public void SetCurrentHP(int _CurrentHP) {
            this.mCurrentHP = _CurrentHP;
        }
        public void SetMaxHP(int _IncreaseHP) {
            this.mMaxHP = _IncreaseHP;
        }
        public void SetMinHP(int _DecreaseHP) {
            this.mMinHP = _DecreaseHP;
        }


        //Increase function
        public int TotalHpIncrease(int _CurrentHP, int _IncreaseHP) {
            int totalHpIcrease = _CurrentHP + _IncreaseHP;
            return totalHpIcrease;
        }

        //Decrease function
        public int TotalHpDecrease(int _CurrentHP, int _DecreaseHP) {
            int totalHpDecrease = _CurrentHP - _DecreaseHP;
            return totalHpDecrease;
        }

        //Set Rounds Function
        public int SetRoundsFunc(int _Rounds) {
            Console.Write(" Enter the number of round you would like to play: ");
            string hitPtString = Console.ReadLine();
            int numRounds;
            while (!int.TryParse(hitPtString, out numRounds) && !(numRounds < 0)) {
                Console.Write(" Opps! Please enter a whole number: ");
                hitPtString = Console.ReadLine();
                int.TryParse(hitPtString, out numRounds);
            }
            return numRounds;
        }

        //Health status bar
        public string Bar(int GetCurrentHP) {
            string meterBar = "";
            if ((GetCurrentHP > 0) && (GetCurrentHP <= 5))        { meterBar = "█                    "; }
            else if ((GetCurrentHP > 5) && (GetCurrentHP <= 10))  { meterBar = "██                   "; }
            else if ((GetCurrentHP > 10) && (GetCurrentHP <= 15)) { meterBar = "███                  "; }
            else if ((GetCurrentHP > 15) && (GetCurrentHP <= 20)) { meterBar = "████                 "; }
            else if ((GetCurrentHP > 20) && (GetCurrentHP <= 25)) { meterBar = "█████                "; }
            else if ((GetCurrentHP > 25) && (GetCurrentHP <= 30)) { meterBar = "██████               "; }
            else if ((GetCurrentHP > 30) && (GetCurrentHP <= 35)) { meterBar = "███████              "; }
            else if ((GetCurrentHP > 35) && (GetCurrentHP <= 40)) { meterBar = "████████             "; }
            else if ((GetCurrentHP > 40) && (GetCurrentHP <= 45)) { meterBar = "█████████            "; }
            else if ((GetCurrentHP > 45) && (GetCurrentHP <= 50)) { meterBar = "██████████           "; }
            else if ((GetCurrentHP > 50) && (GetCurrentHP <= 55)) { meterBar = "███████████          "; }
            else if ((GetCurrentHP > 55) && (GetCurrentHP <= 60)) { meterBar = "████████████         "; }
            else if ((GetCurrentHP > 60) && (GetCurrentHP <= 65)) { meterBar = "█████████████        "; }
            else if ((GetCurrentHP > 65) && (GetCurrentHP <= 70)) { meterBar = "██████████████       "; }
            else if ((GetCurrentHP > 70) && (GetCurrentHP <= 75)) { meterBar = "███████████████      "; }
            else if ((GetCurrentHP > 75) && (GetCurrentHP <= 80)) { meterBar = "████████████████     "; }
            else if ((GetCurrentHP > 80) && (GetCurrentHP <= 85)) { meterBar = "█████████████████    "; }
            else if ((GetCurrentHP > 85) && (GetCurrentHP <= 90)) { meterBar = "██████████████████   "; }
            else if ((GetCurrentHP > 90) && (GetCurrentHP <= 95)) { meterBar = "███████████████████  "; }
            else if ((GetCurrentHP > 95) && (GetCurrentHP < 100)) { meterBar = "████████████████████ "; }
            else if (GetCurrentHP == 100)                         { meterBar = "█████████████████████"; }
            return meterBar;
        }
    }
}