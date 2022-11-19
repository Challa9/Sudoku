namespace Sudoku{
    class Program{

        static string print_board(string[] num){            
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
            return "this is returng";
        }

        static void case_check(string[] aviable_slots, string input, string answer){

            switch (input) 
            {
                case "11":
                    aviable_slots[0] = answer;
                    print_board(aviable_slots);
                    break;
                case "12":
                    aviable_slots[1] = answer;
                    print_board(aviable_slots);
                    break;
                case "13":
                    aviable_slots[2] = answer;
                    print_board(aviable_slots);
                    break;
                case "15":
                    aviable_slots[3] = answer;
                    print_board(aviable_slots);
                    break;
                case "16":
                    aviable_slots[4] = answer;
                    print_board(aviable_slots);
                    break;
                case "19":
                    aviable_slots[5] = answer;
                    print_board(aviable_slots);
                    break;
                
                case "24":
                    aviable_slots[6] = answer;
                    print_board(aviable_slots);
                    break;
                case "29":
                    aviable_slots[7] = answer;
                    print_board(aviable_slots);
                    break;
                case "31":
                    aviable_slots[8] = answer;
                    print_board(aviable_slots);
                    break;
                case "39":
                    aviable_slots[9] = answer;
                    print_board(aviable_slots);
                    break;
                case "42":
                    aviable_slots[10] = answer;
                    print_board(aviable_slots);
                    break;
                case "44":
                    aviable_slots[11] = answer;
                    print_board(aviable_slots);
                    break;
                case "45":
                    aviable_slots[12] = answer;
                    print_board(aviable_slots);
                    break;
                case "47":
                    aviable_slots[13] = answer;
                    print_board(aviable_slots);
                    break;
                case "48":
                    aviable_slots[14] = answer;
                    print_board(aviable_slots);
                    break;
                case "51":
                    aviable_slots[15] = answer;
                    print_board(aviable_slots);
                    break;
                case "54":
                    aviable_slots[16] = answer;
                    print_board(aviable_slots);
                    break;
                case "55":
                    aviable_slots[17] = answer;
                    print_board(aviable_slots);
                    break;
                case "56":
                    aviable_slots[18] = answer;
                    print_board(aviable_slots);
                    break;
                case "58":
                    aviable_slots[19] = answer;
                    print_board(aviable_slots);
                    break;
                case "61":
                    aviable_slots[20] = answer;
                    print_board(aviable_slots);
                    break;
                case "62":
                    aviable_slots[21] = answer;
                    print_board(aviable_slots);
                    break;
                case "63":
                    aviable_slots[22] = answer;
                    print_board(aviable_slots);
                    break;
                case "65":
                    aviable_slots[23] = answer;
                    print_board(aviable_slots);
                    break;
                case "66":
                    aviable_slots[24] = answer;
                    print_board(aviable_slots);
                    break;
                case "68":
                    aviable_slots[25] = answer;
                    print_board(aviable_slots);
                    break;
                case "69":
                    aviable_slots[26] = answer;
                    print_board(aviable_slots);
                    break;
                case "71":
                    aviable_slots[27] = answer;
                    print_board(aviable_slots);
                    break;
                case "72":
                    aviable_slots[28] = answer;
                    print_board(aviable_slots);
                    break;
                case "73":
                    aviable_slots[29] = answer;
                    print_board(aviable_slots);
                    break;
                case "74":
                    aviable_slots[30] = answer;
                    print_board(aviable_slots);
                    break;
                case "78":
                    aviable_slots[31] = answer;
                    print_board(aviable_slots);
                    break;
                case "79":
                    aviable_slots[32] = answer;
                    print_board(aviable_slots);
                    break;
                case "81":
                    aviable_slots[33] = answer;
                    print_board(aviable_slots);
                    break;
                case "83":
                    aviable_slots[34] = answer;
                    print_board(aviable_slots);
                    break;
                case "84":
                    aviable_slots[35] = answer;
                    print_board(aviable_slots);
                    break;
                case "85":
                    aviable_slots[36] = answer;
                    print_board(aviable_slots);
                    break;
                case "86":
                    aviable_slots[37] = answer;
                    print_board(aviable_slots);
                    break;
                case "87":
                    aviable_slots[38] = answer;
                    print_board(aviable_slots);
                    break;
                case "88":
                    aviable_slots[39] = answer;
                    print_board(aviable_slots);
                    break;
                case "92":
                    aviable_slots[40] = answer;
                    print_board(aviable_slots);
                    break;
                case "96":
                    aviable_slots[41] = answer;
                    
                    print_board(aviable_slots);
                    break;
                case "97":
                    aviable_slots[42] = answer;
                    print_board(aviable_slots);
                    break;
                case "98":
                    aviable_slots[43] = answer;
                    print_board(aviable_slots);
                    break;
                case "99":
                    aviable_slots[44] = answer;
                    print_board(aviable_slots);
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
                                int new_answer = Convert.ToInt32(answer);
                                if(new_answer > 9 || new_answer < 1){
                                    Console.WriteLine("Bad answer, can't be bigger than 9 or less than 1");
                                }
                                else{
                                    ask_for_answer = false;
                                    case_check(aviable_slots, input, answer);
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
