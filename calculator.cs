using System;

namespace chelgrave_challenge
{

	class room
	{
		//given values
		public double room_perimeter_in_metres;
		public double wall_height_in_metres ;
		public int number_of_doors;
		public int number_of_double_windows;
		//to be calculated
		public int roll_count;
		public decimal total_price;
		
		public room(double room_perimeter, double wall_height, int doors, int double_windows)
		{
			room_perimeter_in_metres=room_perimeter;
			wall_height_in_metres=wall_height;
			number_of_doors=doors;
			number_of_double_windows=double_windows;
		}
		
		public void roll_counter_and_pricer(double paper_length, string paper_type, decimal roll_price)
		{
			
			double paper_area;
			
			if (paper_type=="standard")
			{
				paper_area=2.7870912;
			}
			else
			{
				paper_area=2.0438669;
			}

			roll_count = System.Convert.ToInt32((room_perimeter_in_metres*paper_length)/paper_area)-((number_of_doors/2)+number_of_double_windows);
			
			total_price = roll_price*roll_count;
		}
	}
	
	class wallpaper
	{
		//given values
		public double length_of_repeats;
		public decimal price_per_roll;
		public string type_of_wallpaper;
		//to be calculated
		public double length_of_paper;
		
		public wallpaper(double repeat_length, decimal roll_price, string wallpaper_type)
		{
			length_of_repeats=repeat_length;
			price_per_roll=roll_price;
			type_of_wallpaper=wallpaper_type;
		}
		
		public void paper_length_finder(double wall_high)
		{
			length_of_paper = (((wall_high/length_of_repeats)+1)*length_of_repeats);
		}
	}


    class Program
    {
        static void Main(string[] args)
        {

            //initialize the objects
			room room_calculate = new room(0.0, 0.0, 0, 0);
			wallpaper wallpaper_calculate = new wallpaper(0.0, 0.0m, " ");

            //clean the console
            System.Console.Clear();

            //introduction
            System.Console.WriteLine("Welcome to the wallpaper calculator.");
            System.Console.WriteLine("This program takes relevant wallpaper inputs and outputs a total price and roll count necessary to complete a job.");
            System.Console.WriteLine("Please enter the relevant values below.");
            System.Console.WriteLine(" ");

            //get the relevant values from the user for the first time
			for (int first_time_data=1; first_time_data<8;first_time_data++)
			{
				menu_select(first_time_data, room_calculate, wallpaper_calculate);
			}


            //calculate, then print the values inputted and the resultant answer
            //repeat untill the user exits the console
            System.Console.Clear();
            var user_selection = " ";
            int user_selection_int;

            do
            {
                
                System.Console.Clear();
                print_result(room_calculate, wallpaper_calculate);

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
					menu_select(user_selection_int, room_calculate, wallpaper_calculate);
				}

            } while (user_selection!="exit");

        }
    
    
    
    
    
    
    
    
    
    
    
    
    
    	static void menu_select(int selector, room room_example, wallpaper wallpaper_example)
    	{
    		
	        string room_perimeter_in_metres_string;
            string wall_height_in_metres_string;
            string number_of_doors_string;
            string number_of_double_windows_string;
            string length_of_repeats_string;
            string price_per_roll_string;
            
    		bool answer_test;
    		
    		if (selector==1)
    		{

		        System.Console.Write("1: What is the Room Perimeter (metres): ");
		        room_perimeter_in_metres_string = System.Console.ReadLine();
		        answer_test = double.TryParse(room_perimeter_in_metres_string, out room_example.room_perimeter_in_metres);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {room_perimeter_in_metres_string} - you must enter a number");
		                System.Console.Write("1: What is the Room Perimeter (metres): ");
		                room_perimeter_in_metres_string = System.Console.ReadLine();
		                answer_test = double.TryParse(room_perimeter_in_metres_string, out room_example.room_perimeter_in_metres);

		            } while (answer_test==false);
		        }

			}
			else if (selector==2)
			{	

		        System.Console.Write("2: What is the Wall Height (metres): ");
		        wall_height_in_metres_string = System.Console.ReadLine();
		        answer_test = double.TryParse(wall_height_in_metres_string, out room_example.wall_height_in_metres);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {wall_height_in_metres_string} - you must enter a number");
		                System.Console.Write("2: What is the Wall Height (metres): ");
		                wall_height_in_metres_string = System.Console.ReadLine();
		                answer_test = double.TryParse(wall_height_in_metres_string, out room_example.wall_height_in_metres);

		            } while (answer_test==false);
		        }

			}
			else if (selector==3)
			{	

		        System.Console.Write("3: How many Doors are Installed: ");
		        number_of_doors_string = System.Console.ReadLine();
		        answer_test = int.TryParse(number_of_doors_string, out room_example.number_of_doors);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {number_of_doors_string} - you must enter a number (no decimals)");
		                System.Console.Write("3: How many Doors are Installed: ");
		                number_of_doors_string = System.Console.ReadLine();
		                answer_test = int.TryParse(number_of_doors_string, out room_example.number_of_doors);

		            } while (answer_test==false);
		        }

			}
			else if (selector==4)
			{	

		        System.Console.Write("4: How many Double Windows are Installed: ");
		        number_of_double_windows_string = System.Console.ReadLine();
		        answer_test = int.TryParse(number_of_double_windows_string, out room_example.number_of_double_windows);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {number_of_double_windows_string} - you must enter a number (no decimals)");
		                System.Console.Write("4: How many Double Windows are Installed: ");
		                number_of_double_windows_string = System.Console.ReadLine();
		                answer_test = int.TryParse(number_of_double_windows_string, out room_example.number_of_double_windows);

		            } while (answer_test==false);
		        }

			}
			else if (selector==5)
			{	

		        System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres): ");
		        length_of_repeats_string = System.Console.ReadLine();
		        answer_test = double.TryParse(length_of_repeats_string, out wallpaper_example.length_of_repeats);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {length_of_repeats_string} - you must enter a number");
		                System.Console.Write("5: What is the Length of the Wallpaper Pattern (metres) ");
		                length_of_repeats_string = System.Console.ReadLine();
		                answer_test = double.TryParse(length_of_repeats_string, out wallpaper_example.length_of_repeats);

		            } while (answer_test==false);
		        }

			}
			else if (selector==6)
			{	

		        System.Console.Write("6: What is the Price Per Roll (dollars): ");
		        price_per_roll_string = System.Console.ReadLine();
		        answer_test = decimal.TryParse(price_per_roll_string, out wallpaper_example.price_per_roll);
		        if (answer_test==false)
		        {
		            do
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {price_per_roll_string} - you must enter a number");
		                System.Console.Write("6: What is the Price Per Roll (dollars): ");
		                price_per_roll_string = System.Console.ReadLine();
		                answer_test = decimal.TryParse(price_per_roll_string, out wallpaper_example.price_per_roll);

		            } while (answer_test==false);
		        }

			}
			else if (selector==7)
			{	

		        System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
		        wallpaper_example.type_of_wallpaper = System.Console.ReadLine();
		        if ((wallpaper_example.type_of_wallpaper != "european") & (wallpaper_example.type_of_wallpaper != "standard"))
		        {
		            do 
		            {
		                System.Console.WriteLine($"Incorrect answer - you selected {wallpaper_example.type_of_wallpaper} - you must select either the european or standard");
		                System.Console.Write("7: What Type of Wallpaper are you Using (european or standard): ");
		                wallpaper_example.type_of_wallpaper = System.Console.ReadLine();
		            }
		            while ((wallpaper_example.type_of_wallpaper != "european") & (wallpaper_example.type_of_wallpaper != "standard"));
		        }

			}
			else
			{
				System.Console.Write("Incorrect choice - you need to select a number between 1 and 7 (inclusive)");	
            }
    	}
    	
    	








        //print all the necessary details
        static void print_result(room room_example, wallpaper wallpaper_example)
        {
        
        	//complete the calculations
        	wallpaper_example.paper_length_finder(room_example.wall_height_in_metres);
        	room_example.roll_counter_and_pricer(wallpaper_example.length_of_paper,wallpaper_example.type_of_wallpaper,wallpaper_example.price_per_roll);
        	
            //user selected values
            System.Console.WriteLine("Your Current Selections:");
            System.Console.WriteLine($"1: Room Perimeter In Metres: {room_example.room_perimeter_in_metres}");
            System.Console.WriteLine($"2: Wall Height In Metres: {room_example.wall_height_in_metres}");
            System.Console.WriteLine($"3: Number Of Doors: {room_example.number_of_doors}");
            System.Console.WriteLine($"4: Number Of Double Windows: {room_example.number_of_double_windows}");		
            System.Console.WriteLine($"5: Length of the Wallpaper Pattern (metres): {wallpaper_example.length_of_repeats}");
            System.Console.WriteLine($"6: Price Per Roll (dollars): {wallpaper_example.price_per_roll}");
            System.Console.WriteLine($"7: Wallpaper Type: {wallpaper_example.type_of_wallpaper}");
            System.Console.WriteLine(" ");
            
            //calculated results
            System.Console.WriteLine("Resultant Values:");
            System.Console.WriteLine($"The Length of Paper (metres): {wallpaper_example.length_of_paper}");
            System.Console.WriteLine($"Roll Count: {room_example.roll_count}");
            System.Console.WriteLine($"Total Price (dollars): {room_example.total_price}");
            System.Console.WriteLine(" ");

        }
    }
}

