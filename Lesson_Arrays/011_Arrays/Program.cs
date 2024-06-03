namespace _011_Arrays
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create a 10x10 grid for the sea battle game
            char[,] grid = new char[10, 10];

            // Initialize the grid with empty spaces
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    grid[row, col] = ' ';
                }
            }

            // Place ships on the grid
            PlaceShip(grid, 4); // Place a battleship (length 4)
            PlaceShip(grid, 3); // Place a cruiser (length 3)
            PlaceShip(grid, 3); // Place another cruiser (length 3)
            PlaceShip(grid, 2); // Place a destroyer (length 2)
            PlaceShip(grid, 2); // Place another destroyer (length 2)
            PlaceShip(grid, 2); // Place another destroyer (length 2)
            PlaceShip(grid, 1); // Place a submarine (length 1)
            PlaceShip(grid, 1); // Place another submarine (length 1)
            PlaceShip(grid, 1); // Place another submarine (length 1)
            PlaceShip(grid, 1); // Place another submarine (length 1)

            // Print the grid
            PrintGrid(grid);
        }

        static void PlaceShip(char[,] grid, int length)
        {
            Random random = new Random();

            // Generate random coordinates for the ship
            int row = random.Next(10);
            int col = random.Next(10);

            // Generate a random direction for the ship (0: horizontal, 1: vertical)
            int direction = random.Next(2);

            // Check if the ship can be placed in the chosen direction
            bool canPlaceShip = true;
            if (direction == 0)
            {
                if (col + length > 10)
                {
                    canPlaceShip = false;
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (grid[row, col + i] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (row + length > 10)
                {
                    canPlaceShip = false;
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (grid[row + i, col] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                }
            }

            // Check if the ship is near another ship
            if (canPlaceShip)
            {
                if (direction == 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (row > 0 && grid[row - 1, col + i] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                        if (row < 9 && grid[row + 1, col + i] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        if (col > 0 && grid[row + i, col - 1] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                        if (col < 9 && grid[row + i, col + 1] != ' ')
                        {
                            canPlaceShip = false;
                            break;
                        }
                    }
                }
            }

            // Place the ship on the grid if possible
            if (canPlaceShip)
            {
                if (direction == 0)
                {
                    for (int i = 0; i < length; i++)
                    {
                        grid[row, col + i] = 'S';
                    }
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        grid[row + i, col] = 'S';
                    }
                }
            }
            else
            {
                // Retry placing the ship
                PlaceShip(grid, length);
            }
        }

        static void PrintGrid(char[,] grid)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int row = 0; row < 10; row++)
            {
                Console.Write(row + " ");
                for (int col = 0; col < 10; col++)
                {
                    Console.Write(grid[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


