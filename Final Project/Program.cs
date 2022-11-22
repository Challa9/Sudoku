
namespace Sudoku{
    class Program{

        static void print_board(string[] num){            
            Console.WriteLine("    1 2 3   4 5 6   7 8 9  ");
            Console.WriteLine("  ╔═══════╦═══════╦═══════╗");
            Console.WriteLine("1 ║ "+num[0]+" "+num[1]+" "+num[2]+" ║ 6 "+num[3]+" "+num[4]+" ║ 4 5 "+num[5]+" ║");
            Console.WriteLine("2 ║ 4 6 1 ║ "+num[6]+" 2 5 ║ 9 7 "+num[7]+" ║");
            Console.WriteLine("3 ║ "+num[8]+" 7 2 ║ 4 9 3 ║ 1 8 "+num[9]+" ║");
            Console.WriteLine("  ╠═══════╬═══════╬═══════╣");
            Console.WriteLine("4 ║ 8 "+num[10]+" 4 ║ "+num[11]+" "+num[12]+" 9 ║ "+num[13]+" "+num[14]+" 7 ║");
            Console.WriteLine("5 ║ "+num[15]+" 2 5 ║ "+num[16]+" "+num[17]+" "+num[18]+" ║ 6 "+num[19]+" 9 ║");
            Console.WriteLine("6 ║ "+num[20]+" "+num[21]+" "+num[22]+" ║ 3 "+num[23]+" "+num[24]+" ║ 2 "+num[25]+" "+num[26]+" ║");
            Console.WriteLine("  ╠═══════╬═══════╬═══════╣");
            Console.WriteLine("7 ║ "+num[27]+" "+num[28]+" "+num[29]+" ║ "+num[30]+" 8 2 ║ 7 "+num[31]+" "+num[32]+" ║");
            Console.WriteLine("8 ║ "+num[33]+" 8 "+num[34]+" ║ "+num[35]+" "+num[36]+" "+num[37]+" ║ "+num[38]+" "+num[39]+" 4 ║");
            Console.WriteLine("9 ║ 2 "+num[40]+" 6 ║ 7 3 "+num[41]+" ║ "+num[42]+" "+num[43]+" "+num[44]+" ║");
            Console.WriteLine("  ╚═══════╩═══════╩═══════╝");
            
        }

        static void case_check(string[] aviable_slots, string input, string answer, string[] correct_answers){

            
            foreach(string i in aviable_slots){
                Console.WriteLine(i);
            }

            
            switch (input) 
            {
                case "11":
                    if(answer == "help"){
                        aviable_slots[0] = correct_answers[0];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[0] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "12":
                    if(answer == "help"){
                        aviable_slots[1] = correct_answers[1];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[1] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "13":
                    if(answer == "help"){
                        aviable_slots[2] = correct_answers[2];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[2] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "15":
                    if(answer == "help"){
                        aviable_slots[3] = correct_answers[3];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[3] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "16":
                    if(answer == "help"){
                        aviable_slots[4] = correct_answers[4];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[4] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "19":
                    if(answer == "help"){
                        aviable_slots[5] = correct_answers[5];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[5] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                
                case "24":
                    if(answer == "help"){
                        aviable_slots[6] = correct_answers[6];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[6] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "29":
                    if(answer == "help"){
                        aviable_slots[7] = correct_answers[7];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[7] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "31":
                    if(answer == "help"){
                        aviable_slots[8] = correct_answers[8];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[8] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "39":
                    if(answer == "help"){
                        aviable_slots[9] = correct_answers[9];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[9] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "42":
                    if(answer == "help"){
                        aviable_slots[10] = correct_answers[10];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[10] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "44":
                    if(answer == "help"){
                        aviable_slots[11] = correct_answers[11];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[11] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "45":
                    if(answer == "help"){
                        aviable_slots[12] = correct_answers[12];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[12] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "47":
                    if(answer == "help"){
                        aviable_slots[13] = correct_answers[13];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[13] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "48":
                    if(answer == "help"){
                        aviable_slots[14] = correct_answers[14];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[14] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "51":
                    if(answer == "help"){
                        aviable_slots[15] = correct_answers[15];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[15] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "54":
                    if(answer == "help"){
                        aviable_slots[16] = correct_answers[16];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[16] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "55":
                    if(answer == "help"){
                        aviable_slots[17] = correct_answers[17];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[17] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "56":
                    if(answer == "help"){
                        aviable_slots[18] = correct_answers[18];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[18] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "58":
                    if(answer == "help"){
                        aviable_slots[19] = correct_answers[19];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[19] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "61":
                    if(answer == "help"){
                        aviable_slots[20] = correct_answers[20];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[0] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "62":
                    if(answer == "help"){
                        aviable_slots[21] = correct_answers[21];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[21] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "63":
                    if(answer == "help"){
                        aviable_slots[22] = correct_answers[22];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[22] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "65":
                    if(answer == "help"){
                        aviable_slots[23] = correct_answers[23];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[23] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "66":
                    if(answer == "help"){
                        aviable_slots[24] = correct_answers[24];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[24] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "68":
                    if(answer == "help"){
                        aviable_slots[25] = correct_answers[25];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[25] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "69":
                    if(answer == "help"){
                        aviable_slots[26] = correct_answers[26];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[26] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "71":
                    if(answer == "help"){
                        aviable_slots[27] = correct_answers[27];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[27] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "72":
                    if(answer == "help"){
                        aviable_slots[28] = correct_answers[28];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[28] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "73":
                    if(answer == "help"){
                        aviable_slots[29] = correct_answers[29];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[29] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "74":
                    if(answer == "help"){
                        aviable_slots[30] = correct_answers[30];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[30] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "78":
                    if(answer == "help"){
                        aviable_slots[31] = correct_answers[31];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[31] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "79":
                    if(answer == "help"){
                        aviable_slots[32] = correct_answers[32];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[32] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "81":
                    if(answer == "help"){
                        aviable_slots[33] = correct_answers[33];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[33] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "83":
                    if(answer == "help"){
                        aviable_slots[34] = correct_answers[34];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[34] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "84":
                    if(answer == "help"){
                        aviable_slots[35] = correct_answers[35];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[35] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "85":
                    if(answer == "help"){
                        aviable_slots[36] = correct_answers[36];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[36] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "86":
                    if(answer == "help"){
                        aviable_slots[37] = correct_answers[37];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[37] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "87":
                    if(answer == "help"){
                        aviable_slots[38] = correct_answers[38];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[38] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "88":
                    if(answer == "help"){
                        aviable_slots[39] = correct_answers[39];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[39] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "92":
                    if(answer == "help"){
                        aviable_slots[40] = correct_answers[40];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[40] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "96":
                    if(answer == "help"){
                        aviable_slots[41] = correct_answers[41];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[41] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "97":
                    if(answer == "help"){
                        aviable_slots[42] = correct_answers[42];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[42] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "98":
                    if(answer == "help"){
                        aviable_slots[43] = correct_answers[43];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[43] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                case "99":
                    if(answer == "help"){
                        aviable_slots[44] = correct_answers[44];
                        print_board(aviable_slots);
                    }
                    else{
                        aviable_slots[44] = answer;
                        print_board(aviable_slots);
                    }
                    break;
                
                
                default:
                    Console.WriteLine("oops, something went wrong");
                    break;
            }
        }
        static void Main(string[] args){
            
            string[] aviable_slots = {"*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*"}; 
            string[] correct_answers = {"3", "9", "8", "7", "1", "2", "8", "3", "5", "6", "3", "2", "6", "5", "1", "7", "1", "4", "8", "3", "6", "1", "9", "5", "7", "4", "8", "1", "4", "3", "9", "6", "5", "9", "7", "5", "1", "6", "3", "2", "5", "4", "8", "9", "1"};
            print_board(aviable_slots);

            bool run = true;
            int help_count = 0;
            while(run){
                try{
                    bool ask_for_pick = true;
                    while(ask_for_pick){
                        #nullable disable
                        Console.Write("Pick a row and colum: ");
                        string input = Console.ReadLine();
                        int new_input = Convert.ToInt32(input);
                        if(new_input > 99 || new_input < 11){
                            Console.Write("Bad, answer, pick a 9x9 row and column");
                            Console.WriteLine();
                        }
                        else if(input == "14" || input == "17" || input == "18" || input == "21" || input == "22" || input == "23" || input == "25" || input == "26" || input == "27" || input == "28" || input == "32" || input == "33" || input == "34" || input == "35" || input == "36" || input == "37" || input == "38" || input == "41" || input == "43" || input == "46" || input == "49" || input == "52" || input == "53" || input == "59" || input == "64" || input == "67" || input == "75" || input == "77" || input == "82" || input == "89" || input == "91" || input == "93" || input == "94" || input == "95"){
                            Console.Write("Bad answer, pick a different row or column");
                            Console.WriteLine();
                        }
                        
                        else{
                            ask_for_pick = false;
                            bool ask_for_answer = true; 
                            while(ask_for_answer){
                                Console.Write("Answer: ");
                                string answer = Console.ReadLine();

                                if(answer == "help" && help_count < 5){
                                    case_check(aviable_slots, input, answer, correct_answers);
                                    ask_for_answer = false;
                                    help_count += 1;
                                    Console.WriteLine(help_count );
                                }
                                else{
                                    
                                    if(help_count >= 5 && answer == "help"){
                                        Console.WriteLine("You ran out of help!");
                                    }
                                    else{
                                        int new_answer = Convert.ToInt32(answer);
                                        if(new_answer > 9 || new_answer < 1){
                                            Console.WriteLine("Bad answer, can't be bigger than 9 or less than 1");
                                        }
                                        else{
                                            ask_for_answer = false;
                                            case_check(aviable_slots, input, answer, correct_answers);
                                        }
                                    }

                                    
                                }


                               
                            }
                            
                        }
                    }
                    
                }
                
                catch{
                    Console.WriteLine("Bad Input, try again");
                    
                    
                }

                int correct_answer_count = 0;
                
                for(int i = 0; i < 45; i++){
                    if(aviable_slots[i] == correct_answers[i]){
                        correct_answer_count += 1;
                    }
                    if(correct_answer_count == 45){
                        Console.WriteLine("CONGRATS, YOU COMPLETED THE PUZZLE");
                        run = false;
                    }
                }
                    
                
            }
        }
    }
}