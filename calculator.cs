using System;

namespace chelgrave_challenge
{

    class Program
    {
        static void Main(string[] args)
        {

            //room detail variables   	
            double room_perimeter_in_metres;
            double wall_height_in_metres;
            int number_of_doors;
            int number_of_double_windows;
            double length_of_repeats;
            double price_per_roll;
            string room_perimeter_in_metres_string;
            string wall_height_in_metres_string;
            string number_of_doors_string;
            string number_of_double_windows_string;
            string length_of_repeats_string;
            string price_per_roll_string;
            string wallpaper_type;

            //testing variables
            bool answer_test;

            //wallpaper variables
            string[] wallpaper_types = { "Standard", "European" };
            string[] formula_resultants;

            //clean the console
            System.Console.Clear();

            //introduction
            System.Console.WriteLine("Welcome to the wallpaper calculator.");
            System.Console.WriteLine("This program takes relevant wallpaper inputs and outputs a total price and roll count necessary to complete a job.");
            System.Console.WriteLine("Please enter the relevant values below.");
            System.Console.WriteLine(" ");

            //get the relevant values from the user for the first time
            System.Console.Write("1: What is the Room Perimeter (metres): ");
            room_perimeter_in_metres_string = System.Console.ReadLine();
            answer_test = double.TryParse(room_perimeter_in_metres_string, out room_perimeter_in_metres);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {room_perimeter_in_metres_string} - you must enter a number");
                    System.Console.Write("1: What is the Room Perimeter (metres): ");
                    room_perimeter_in_metres_string = System.Console.ReadLine();
                    answer_test = double.TryParse(room_perimeter_in_metres_string, out room_perimeter_in_metres);

                } while (answer_test==false);
            }

            System.Console.Write("2: What is the Wall Height (metres): ");
            wall_height_in_metres_string = System.Console.ReadLine();
            answer_test = double.TryParse(wall_height_in_metres_string, out wall_height_in_metres);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {wall_height_in_metres_string} - you must enter a number");
                    System.Console.Write("2: What is the Wall Height (metres): ");
                    wall_height_in_metres_string = System.Console.ReadLine();
                    answer_test = double.TryParse(wall_height_in_metres_string, out wall_height_in_metres);

                } while (answer_test==false);
            }

            System.Console.Write("3: How many Doors are Installed: ");
            number_of_doors_string = System.Console.ReadLine();
            answer_test = int.TryParse(number_of_doors_string, out number_of_doors);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {number_of_doors_string} - you must enter a number (no decimals)");
                    System.Console.Write("3: How many Doors are Installed: ");
                    number_of_doors_string = System.Console.ReadLine();
                    answer_test = int.TryParse(number_of_doors_string, out number_of_doors);

                } while (answer_test==false);
            }

            System.Console.Write("4: How many Double Windows are Installed: ");
            number_of_double_windows_string = System.Console.ReadLine();
            answer_test = int.TryParse(number_of_double_windows_string, out number_of_double_windows);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {number_of_double_windows_string} - you must enter a number (no decimals)");
                    System.Console.Write("4: How many Double Windows are Installed: ");
                    number_of_double_windows_string = System.Console.ReadLine();
                    answer_test = int.TryParse(number_of_double_windows_string, out number_of_double_windows);

                } while (answer_test==false);
            }

            System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres): ");
            length_of_repeats_string = System.Console.ReadLine();
            answer_test = double.TryParse(length_of_repeats_string, out length_of_repeats);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {length_of_repeats_string} - you must enter a number");
                    System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres) ");
                    length_of_repeats_string = System.Console.ReadLine();
                    answer_test = double.TryParse(length_of_repeats_string, out length_of_repeats);

                } while (answer_test==false);
            }

            System.Console.Write("6: What is the Price Per Roll (dollars): ");
            price_per_roll_string = System.Console.ReadLine();
            answer_test = double.TryParse(price_per_roll_string, out price_per_roll);
            if (answer_test==false)
            {
                do
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {price_per_roll_string} - you must enter a number");
                    System.Console.Write("6: What is the Price Per Roll (dollars): ");
                    price_per_roll_string = System.Console.ReadLine();
                    answer_test = double.TryParse(price_per_roll_string, out price_per_roll);

                } while (answer_test==false);
            }

            System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
            wallpaper_type = System.Console.ReadLine();
            if ((wallpaper_type != "european") & (wallpaper_type != "standard"))
            {
                do 
                {
                    System.Console.WriteLine($"Incorrect answer - you selected {wallpaper_type} - you must select either the european or standard");
                    System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
                    wallpaper_type = System.Console.ReadLine();
                }
                while ((wallpaper_type != "european") & (wallpaper_type != "standard"));
            }



            //calculate, then print the values inputted and the resultant answer
            //repeat untill the user exits the console
            System.Console.Clear();
            var user_selection = " ";
            int user_selection_int;

            do
            {
                
                System.Console.Clear();
                formula_resultants = formulas(room_perimeter_in_metres, wall_height_in_metres, number_of_doors, number_of_double_windows, length_of_repeats, price_per_roll, wallpaper_type);
                print_result(room_perimeter_in_metres, wall_height_in_metres, number_of_doors, number_of_double_windows, length_of_repeats, price_per_roll, wallpaper_type, formula_resultants);

                System.Console.WriteLine("If you want to change any of your user defined values, enter the number corresponding to that selection below.");
                System.Console.WriteLine("Otherwise, type 'exit' to leave the program.");
                System.Console.Write("User Selection: ");
                user_selection = System.Console.ReadLine();

                //run the selector
                if (user_selection=="exit" )
                {
                   break; 
                }
                else if (int.TryParse(user_selection, out user_selection_int))
                {
                    if (System.Convert.ToInt32(user_selection)<8 & System.Convert.ToInt32(user_selection)>0 )
                    {
                        switch (System.Convert.ToInt32(user_selection))
                        {

                            case 1:
                                System.Console.Write("1: What is the Room Perimeter (metres): ");
                                room_perimeter_in_metres_string = System.Console.ReadLine();
                                answer_test = double.TryParse(room_perimeter_in_metres_string, out room_perimeter_in_metres);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {room_perimeter_in_metres_string} - you must enter a number");
                                        System.Console.Write("1: What is the Room Perimeter (metres): ");
                                        room_perimeter_in_metres_string = System.Console.ReadLine();
                                        answer_test = double.TryParse(room_perimeter_in_metres_string, out room_perimeter_in_metres);

                                    } while (answer_test==false);
                                }
                                break;

                            case 2:
                                System.Console.Write("2: What is the Wall Height (metres): ");
                                wall_height_in_metres_string = System.Console.ReadLine();
                                answer_test = double.TryParse(wall_height_in_metres_string, out wall_height_in_metres);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {wall_height_in_metres_string} - you must enter a number");
                                        System.Console.Write("2: What is the Wall Height (metres): ");
                                        wall_height_in_metres_string = System.Console.ReadLine();
                                        answer_test = double.TryParse(wall_height_in_metres_string, out wall_height_in_metres);

                                    } while (answer_test==false);
                                }
                                break;

                            case 3:
                                System.Console.Write("3: How many Doors are Installed: ");
                                number_of_doors_string = System.Console.ReadLine();
                                answer_test = int.TryParse(number_of_doors_string, out number_of_doors);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {number_of_doors_string} - you must enter a number (no decimals)");
                                        System.Console.Write("3: How many Doors are Installed: ");
                                        number_of_doors_string = System.Console.ReadLine();
                                        answer_test = int.TryParse(number_of_doors_string, out number_of_doors);

                                    } while (answer_test==false);
                                }
                                break;

                            case 4:
                                System.Console.Write("4: How many Double Windows are Installed: ");
                                number_of_double_windows_string = System.Console.ReadLine();
                                answer_test = int.TryParse(number_of_double_windows_string, out number_of_double_windows);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {number_of_double_windows_string} - you must enter a number (no decimals)");
                                        System.Console.Write("4: How many Double Windows are Installed: ");
                                        number_of_double_windows_string = System.Console.ReadLine();
                                        answer_test = int.TryParse(number_of_double_windows_string, out number_of_double_windows);

                                    } while (answer_test==false);
                                }
                                break;

                            case 5:
                                System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres): ");
                                length_of_repeats_string = System.Console.ReadLine();
                                answer_test = double.TryParse(length_of_repeats_string, out length_of_repeats);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {length_of_repeats_string} - you must enter a number");
                                        System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres): ");
                                        length_of_repeats_string = System.Console.ReadLine();
                                        answer_test = double.TryParse(length_of_repeats_string, out length_of_repeats);

                                    } while (answer_test==false);
                                }
                                break;

                            case 6:
                                System.Console.Write("6: What is the Price Per Roll (dollars): ");
                                price_per_roll_string = System.Console.ReadLine();
                                answer_test = double.TryParse(price_per_roll_string, out price_per_roll);
                                if (answer_test==false)
                                {
                                    do
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {price_per_roll_string} - you must enter a number");
                                        System.Console.Write("6: What is the Price Per Roll (dollars): ");
                                        price_per_roll_string = System.Console.ReadLine();
                                        answer_test = double.TryParse(price_per_roll_string, out price_per_roll);

                                    } while (answer_test==false);
                                }
                                break;

                            case 7:
                                System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
                                wallpaper_type = System.Console.ReadLine();
                                if ((wallpaper_type != "european") & (wallpaper_type != "standard"))
                                {
                                    do 
                                    {
                                        System.Console.WriteLine($"Incorrect answer - you selected {wallpaper_type} - you must select either the european or standard");
                                        System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
                                        wallpaper_type = System.Console.ReadLine();
                                    }
                                    while ((wallpaper_type != "european") & (wallpaper_type != "standard"));
                                }
                                break;
                        }
                    }
                    
                }
            } while (user_selection!="exit");

        }
    
        //calculate the values needed
        static string[] formulas(double room_perimeter, double wall_height, int door_number, int double_window_number, double repeat_length, double roll_price, string wallpaper_type)
        {
            double paper_area;

            if (wallpaper_type=="standard")
            {
                paper_area=2.7870912;
            }
            else
            {
                paper_area=2.0438669;
            }

            double length_of_paper = ((wall_height/repeat_length)+1)*repeat_length;
            int roll_count = System.Convert.ToInt32((room_perimeter*length_of_paper)/paper_area)-((door_number/2)+double_window_number);
            double total_price = roll_count*roll_price;

            return new string[] {System.Convert.ToString(length_of_paper), System.Convert.ToString(roll_count), System.Convert.ToString(total_price)};
            
        }


        //print all the necessary details
        static void print_result(double room_perimeter, double wall_height, int door_number, int double_window_number, double repeat_length, double roll_price, string type_of_wallpaper, string[] formula_results)
        {
            //user selected values
            System.Console.WriteLine("Your Current Selections:");
            System.Console.WriteLine($"1: Room Perimeter In Metres: {room_perimeter}");
            System.Console.WriteLine($"2: Wall Height In Metres: {wall_height}");
            System.Console.WriteLine($"3: Number Of Doors: {door_number}");
            System.Console.WriteLine($"4: Number Of Double Windows: {double_window_number}");		
            System.Console.WriteLine($"5: Length of the Wallpaper Pattern (metres): {repeat_length}");
            System.Console.WriteLine($"6: Price Per Roll (dollars): {roll_price}");
            System.Console.WriteLine($"7: Wallpaper Type: {type_of_wallpaper}");
            System.Console.WriteLine(" ");
            
            //calculated results
            System.Console.WriteLine("Resultant Values:");
            System.Console.WriteLine($"The Length of Paper (metres): {formula_results[0]}");
            System.Console.WriteLine($"Roll Count: {formula_results[1]}");
            System.Console.WriteLine($"Total Price (dollars): {formula_results[2]}");
            System.Console.WriteLine(" ");

        }
    }
}

