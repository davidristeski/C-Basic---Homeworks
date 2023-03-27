//Class - 09 (handling errors) exercise - MOVIE APP

using Domains.Classes;
using Domains.Enums;
using System.Linq.Expressions;


//Instanced two cinemas 1)Cineplex and 2)Milenium
Cinema Cineplex = new Cinema
{
    Name = "Cineplex",
    Halls = 5,
    ListOfMovies = new List<Movie>()
    {
        new Movie("Shawshank Redemtpion", Domains.Enums.GenreEnum.Drama, 5, 65),
        new Movie("Kill Bill", Domains.Enums.GenreEnum.Action, 3, 45),
        new Movie("Kill Bill 2", Domains.Enums.GenreEnum.Action, 3, 55),
        new Movie("Mission Impossible 2", Domains.Enums.GenreEnum.Action, 4, 40),
        new Movie("Narnia", Domains.Enums.GenreEnum.SciFi, 3, 55),
        new Movie("Final Destination", Domains.Enums.GenreEnum.Horror,2,55),
        new Movie("Terminator", GenreEnum.Action, 3, 55),
        new Movie("Terminator 2", GenreEnum.Action, 3, 65)
    }

};
Cinema Milenium = new Cinema
{
    Name = "Milenium",
    Halls = 1,
    ListOfMovies = new List<Movie>()
    {
        new Movie("Makedonska krvava svadba", Domains.Enums.GenreEnum.Drama, 3, 5),
        new Movie("Avengers", Domains.Enums.GenreEnum.Action, 3, 45),
        new Movie("Space Jam", Domains.Enums.GenreEnum.Action, 3, 55),
        new Movie("Parasite", Domains.Enums.GenreEnum.Action, 4, 40),
        new Movie("The Godfather", GenreEnum.Drama, 5, 85),
        new Movie("Batman Begins", GenreEnum.Action, 5, 65),
        new Movie("The Exorcist", GenreEnum.Horror, 4, 50),
        new Movie("Matrix", GenreEnum.SciFi, 5, 65)
    }

};


// User Interface to choose a cinema
Console.WriteLine("Hello, please choose a cinema: 1)Cineplex or 2)Milenium");
string UserInputCinema = Console.ReadLine();


//Choosing between the two cinemas and proceeding with the method written below SelectionOfCinema()
try {
    if (UserInputCinema != "1" && UserInputCinema != "2")
    {
        throw new Exception("Wrong input, please try again. Choose 1 or 2");
    }
    else{
        switch (UserInputCinema)
        {
            case "1":
                SelectionOfCinema(Cineplex);
                break;
            case "2":
                SelectionOfCinema(Milenium);
                break;
            default: throw new Exception("Wrong input added. Add 1 or 2.");

        }
    }
   
}
catch(Exception ex)
{
    Console.WriteLine("Custom exception happend " + ex.Message); 
}
finally
 {  
}


// Method for the user to choose an option 1)See all movies or 2)See movies by genre
void SelectionOfCinema(Cinema cinema)
{
    try { 
    Console.WriteLine($"Welcome to {cinema.Name}");
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. See all movies");
    Console.WriteLine("2. See movies by genre");
    
    string userInputAction = Console.ReadLine();

        switch (userInputAction)
        {
            case "1":
                Console.WriteLine("All movies list:");
                for (int i = 0; i < cinema.ListOfMovies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {cinema.ListOfMovies[i].Title}");
                }
                break;
            case "2":
                Console.WriteLine("Choose a genre:");
                Console.WriteLine("1. Comedy");
                Console.WriteLine("2. Horror");
                Console.WriteLine("3. Action");
                Console.WriteLine("4. Drama");
                Console.WriteLine("5. Sci-Fi");

                int genreIndexInput = Convert.ToInt32(Console.ReadLine()) - 1;

                GenreEnum inputIndexGenre = (GenreEnum)genreIndexInput;

                for (int i = 0; i < cinema.ListOfMovies.Count; i++) {
                    if (inputIndexGenre == cinema.ListOfMovies[i].Genre)
                    {
                        Console.WriteLine(cinema.ListOfMovies[i].Title);
                    }
                    else
                    {
                        Console.WriteLine($"There are no movies in {inputIndexGenre}");
                        break;
                    }
                    
                }
                break;
                
            default: throw new Exception("Wrong input added. Add 1 or 2."); }



    }
    catch(Exception ex) { Console.WriteLine(ex.Message); }
}



