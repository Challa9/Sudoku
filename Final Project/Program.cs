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

        static void case_check(string[] aviable_slots, string input, string answer, string[] correct_answers, string[] input_slots){

            
            int input_count = 0;
            foreach(string i in input_slots){

                if(i == input){
                    if(answer == "help"){
                        aviable_slots[input_count] = correct_answers[input_count];
                        print_board(aviable_slots);
                    }
                    else{                     
                        aviable_slots[input_count] = answer;
                        print_board(aviable_slots);
                    }
                }
                input_count++;
            }
        }

        static void check(string[] aviable_slots, string[] correct_answers, string[] input_slots){
            
            int answer_count = 0;
            int count = 0;
            foreach(string i in aviable_slots){
                if(i != correct_answers[answer_count] && i != "*"){
                    Console.WriteLine(input_slots[answer_count] + " is incorrect");
                }
                else{
                    if(count < 1){
                        Console.WriteLine("so far so good, keep it up!");
                    }
                }
                count++;
                answer_count++;
                
            }
        }

        static void solve(string[] aviable_slots, string[] correct_answers, bool run ){
            int counting = 0;
            foreach(string i in aviable_slots){
                aviable_slots[counting] = correct_answers[counting];
            }
            print_board(aviable_slots);
            Environment.Exit(0);
        }
        static void Main(string[] args){
            
            string[] aviable_slots = {"*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*"}; 
            string[] correct_answers = {"3", "9", "8", "7", "1", "2", "8", "3", "5", "6", "3", "2", "6", "5", "1", "7", "1", "4", "8", "3", "6", "1", "9", "5", "7", "4", "8", "1", "4", "3", "9", "6", "5", "9", "7", "5", "1", "6", "3", "2", "5", "4", "8", "9", "1"};
            string[] input_slots = {"11", "12", "13", "15", "16", "19", "24", "29", "31", "39", "42", "44", "45", "47", "48", "51", "54", "55", "56", "58", "61", "62", "63", "65", "66", "68", "69", "71", "72", "73", "74", "78", "79", "81", "83", "84", "85", "86", "87", "88", "92", "96", "97", "98", "99"};
            
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
                        if(input == "check"){
                            check(aviable_slots, correct_answers, input_slots);
                        }
                        else if(input == "solve"){
                            solve(correct_answers, correct_answers, run);
                        }
                        else{
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
                                        case_check(aviable_slots, input, answer, correct_answers, input_slots);
                                        ask_for_answer = false;
                                        help_count += 1;
                                        Console.Write("Helps left: ");
                                        Console.Write(5 - help_count);
                                        Console.WriteLine();
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
                                                case_check(aviable_slots, input, answer, correct_answers, input_slots);
                                            }
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
