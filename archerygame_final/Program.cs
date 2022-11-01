using System;

namespace archerygame_final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 10,-10 for Ax:");
            int Ax = Convert.ToInt32(Console.ReadLine());

            if ((Ax + 11) > 21 || 1 > (Ax + 11))
            {
                Console.WriteLine("Tekrar deneyin");
                return;
            }

            Console.WriteLine("Enter number between 10,-10 for Ay:");
            int Ay = Convert.ToInt32(Console.ReadLine());

            if ((Ay + 11) > 21 || 1 > (Ay + 11))
            {
                Console.WriteLine("Tekrar deneyin");
                return;
            }


            Console.WriteLine("This is coordinates belong to player A. " + (Ax) + "," + (Ay));

            //  Creates random coordinates for B and C
            Random random = new Random();
            int Bx = random.Next(-10, 11);
            int By = random.Next(-10, 11);
            int Cx = random.Next(-10, 11);
            int Cy = random.Next(-10, 11);

            //  Calculates the distances of characters to each other
            double distanceAB = (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By);
            double distanceAC = (Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy);
            double distanceBC = (Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy);

            //  Recreates random coordinates for B and C if 2 characters are in the same coordinates
            //  It checks 4 times
            if (distanceAB - distanceAC == 0 || distanceAB - distanceBC == 0 || distanceAC - distanceBC == 0)
            {
                //  Recreates coordinates of B and C if there are identical distances
                Bx = random.Next(-10, 11);
                By = random.Next(-10, 11);
                Cx = random.Next(-10, 11);
                Cy = random.Next(-10, 11);
                distanceAB = (Ax - Bx) * (Ax - Bx) * (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) * (Ay - By) * (Ay - By);
                distanceAC = (Ax - Cx) * (Ax - Cx) * (Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy) * (Ay - Cy) * (Ay - Cy);
                distanceBC = (Bx - Cx) * (Bx - Cx) * (Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy) * (By - Cy) * (By - Cy);
                if (distanceAB - distanceAC == 0 || distanceAB - distanceBC == 0 || distanceAC - distanceBC == 0)
                {
                    Bx = random.Next(-10, 11);
                    By = random.Next(-10, 11);
                    Cx = random.Next(-10, 11);
                    Cy = random.Next(-10, 11);
                    distanceAB = (Ax - Bx) * (Ax - Bx) * (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) * (Ay - By) * (Ay - By);
                    distanceAC = (Ax - Cx) * (Ax - Cx) * (Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy) * (Ay - Cy) * (Ay - Cy);
                    distanceBC = (Bx - Cx) * (Bx - Cx) * (Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy) * (By - Cy) * (By - Cy);
                    if (distanceAB - distanceAC == 0 || distanceAB - distanceBC == 0 || distanceAC - distanceBC == 0)
                    {
                        Bx = random.Next(-10, 11);
                        By = random.Next(-10, 11);
                        Cx = random.Next(-10, 11);
                        Cy = random.Next(-10, 11);
                        distanceAB = (Ax - Bx) * (Ax - Bx) * (Ax - Bx) * (Ax - Bx) + (Ay - By) * (Ay - By) * (Ay - By) * (Ay - By);
                        distanceAC = (Ax - Cx) * (Ax - Cx) * (Ax - Cx) * (Ax - Cx) + (Ay - Cy) * (Ay - Cy) * (Ay - Cy) * (Ay - Cy);
                        distanceBC = (Bx - Cx) * (Bx - Cx) * (Bx - Cx) * (Bx - Cx) + (By - Cy) * (By - Cy) * (By - Cy) * (By - Cy);
                        if (distanceAB - distanceAC == 0 || distanceAB - distanceBC == 0 || distanceAC - distanceBC == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Please retry...");
                            Console.WriteLine("Exiting the application...");
                            Console.ResetColor();
                            return;
                        }
                    }
                }









            }

            distanceAB = Math.Sqrt(distanceAB);
            distanceAC = Math.Sqrt(distanceAC);
            distanceBC = Math.Sqrt(distanceBC);

            //setting players health's
            int hA = 0;
            int hB = 0;
            int hC = 0;

            //for giving the random healths we set a new int between (1,8) and for every case we set an if command
            int hChoose = random.Next(2, 8);

            //every if command is down below
            if (hChoose == 2)
            {
                hA = 60;
                hB = 80;
                hC = 100;
            }

            if (hChoose == 3)
            {
                hA = 60;
                hB = 100;
                hC = 80;
            }

            if (hChoose == 4)
            {
                hA = 80;
                hB = 60;
                hC = 100;
            }

            if (hChoose == 5)
            {
                hA = 80;
                hB = 100;
                hC = 60;
            }

            if (hChoose == 6)
            {
                hA = 100;
                hB = 60;
                hC = 80;
            }
            if (hChoose == 7)
            {
                hA = 100;
                hB = 80;
                hC = 60;
            }
            //and of the health possibility

            int set1 = 0;
            int set2 = 1;
            int set3 = 2;

            int setA = 0;
            int setB = 0;
            int setC = 0;


            //for giving random sets we set a new int between (1,8) and for every case we set an if command
            int setChoose = random.Next(2, 8);
            //every if command is down below
            if (setChoose == 2)
            {
                setA = 0;
                setB = 1;
                setC = 2;
            }
            if (setChoose == 3)
            {
                setA = 0;
                setB = 2;
                setC = 1;
            }
            if (setChoose == 4)
            {
                setA = 1;
                setB = 0;
                setC = 2;
            }
            if (setChoose == 5)
            {
                setA = 1;
                setB = 2;
                setC = 0;
            }
            if (setChoose == 6)
            {
                setA = 2;
                setB = 0;
                setC = 1;
            }
            if (setChoose == 7)
            {
                setA = 2;
                setB = 1;
                setC = 0;
            }
            


            //  Writes properties of A, B and C to screen
            Console.Write("\nA: ({0},{1})", Ax, Ay);
            Console.CursorLeft = 13;
            Console.Write("Set " + setA);
            Console.CursorLeft = 21;
            Console.Write("Health:" + hA);

            Console.Write("\nB: ({0},{1})", Bx, By * -1);
            Console.CursorLeft = 13;
            Console.Write("Set " + setB);
            Console.CursorLeft = 21;
            Console.Write("Health:" + hB);

            Console.Write("\nC: ({0},{1})", Cx, Cy * -1);
            Console.CursorLeft = 13;
            Console.Write("Set " + setC);
            Console.CursorLeft = 21;
            Console.Write("Health:" + hC + "\n\n");

            int middleLineY = Console.CursorTop;

            //  Writes coordinate system to console
            Console.WriteLine("   +─────────────────────^─────────────────────+");
            Console.WriteLine(" 10│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  9│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  8│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  7│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  6│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  5│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  4│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  3│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  2│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  1│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("  0│─────────────────────+─────────────────────>");
            Console.WriteLine(" -1│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -2│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -3│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -4│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -5│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -6│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -7│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -8│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine(" -9│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("-10│ · · · · · · · · · · │ · · · · · · · · · · │");
            Console.WriteLine("   +───────────────────────────────────────────+");
            Console.WriteLine("    10 9 8 7 6 5 4 3 2 1 0 1 2 3 4 5 6 7 8 9 10");

            //  Sets current cursor position to variables
            var lastLineX = Console.CursorLeft;
            var lastLineY = Console.CursorTop;

            //  Writes A, B and C to coordinate system
            Console.SetCursorPosition(((Ax + 11) * 2) + 3, (Ay*-1) + 11 + middleLineY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A");
            Console.ResetColor();

            Console.SetCursorPosition(((Bx + 11) * 2) + 3, By + 11 + middleLineY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("B");
            Console.ResetColor();

            Console.SetCursorPosition(((Cx + 11) * 2) + 3, Cy + 11 + middleLineY);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("C");
            Console.ResetColor();

            //  Places cursor to old position
            Console.SetCursorPosition(lastLineX, lastLineY);

            //Assign the player of Round1
            double chosendistance = 0;
            int setP1;
            int setP2;
            int healthP1;
            int healthP2;
            //int scoreP1;
            //int scoreP2;
            char char1;
            char char2;
            char1 = 'A';
            char2 = 'B';
            int score = 0;
            int score2 = 0;
            char winner;
            char defeat;

            int manhattanAB = Math.Abs(Ax - Bx) + Math.Abs(Ay - By);
            int manhattanAC = Math.Abs(Ax - Cx) + Math.Abs(Ay - Cy);
            int manhattanBC = Math.Abs(Bx - Cx) + Math.Abs(By - Cy);

            if (distanceAB < distanceAC && distanceAB < distanceBC)
            {
                chosendistance = distanceAB;

                Console.WriteLine("Round 1 : A-B");
                char1 = 'A';
                char2 = 'B';
                setP1 = setA;
                setP2 = setB;
                healthP1 = hA;
                healthP2 = hB;


                if ((setP1 - setP2) == 1)
                {
                    score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
                    Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
                    Console.WriteLine("C: Non-fighter        Health:" + (hC) + "           Score:0");

                    if (distanceAC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAC <= 15)
                    {
                        Console.WriteLine("Round 2 : A-C");
                        score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAC * 10) + (100 - (hC - 25)));
                        Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
                        Console.WriteLine("C: Survivor           Health:" + (hC - 25) + "           Score:" + (score2));

                        if (score < score2)
                        {
                            Console.WriteLine("C has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));


                    }
                }


                if ((setP1 - setP2) == -1)
                {
                    score = ((manhattanAB * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Defeated           Health:0" + "           Score:0");
                    Console.WriteLine("B: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));
                    Console.WriteLine("C: Non-fighter        Health:" + (hC) + "           Score:0");

                    if (distanceBC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceBC <= 15)
                    {
                        Console.WriteLine("Round 2 : B-C");
                        score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanBC * 10) + (100 - (hC - 25)));
                        Console.WriteLine("A: Defeated           Health:0           Score:0");
                        Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("C: Survivor           Health:" + (hC - 25) + "           Score:" + (score2));


                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("C has the maximum score " + ((score2)));

                    }
                }


                if ((setP1 - setP2) == -2)
                {
                    score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
                    Console.WriteLine("B: Defeated           Health:0" + "           Score:");
                    Console.WriteLine("C: Non-fighter        Health:" + (hC) + "           Score:0");

                    if (distanceAC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAC <= 15)
                    {
                        Console.WriteLine("Round 2 : A-C");
                        score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAC * 10) + (100 - (hC - 25)));

                        Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Defeated           Health:0" + "           Score:0");
                        Console.WriteLine("C: Survivor           Health:" + (hC - 25) + "           Score:" + (score2));

                        if (score < score2)
                        {
                            Console.WriteLine("C has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));

                    }
                }

                if ((setP1 - setP2) == 2)
                {
                    score = ((manhattanAB * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Defeated           Health:0" + "           Score:0");
                    Console.WriteLine("B: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));
                    Console.WriteLine("C: Non-fighter        Health:" + (hC) + "           Score:0");

                    if (distanceBC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceBC <= 15)
                    {
                        Console.WriteLine("Round 2 : B-C");
                        score = ((manhattanAB * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanBC * 10) + (100 - (hC - 25)));
                        Console.WriteLine("A: Defeated           Health:0           Score:0");
                        Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("C: Survivor           Health:" + (hC - 25) + "           Score:" + (score2));


                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("C has the maximum score " + ((score2)));

                    }
                }


            }



            if (distanceAC < distanceAB && distanceAC < distanceBC)
            {
                chosendistance = distanceAC;
                Console.WriteLine("Round 1 : A-C");
                char1 = 'A';
                char2 = 'C';
                setP1 = setA;
                setP2 = setC;
                healthP1 = hA;
                healthP2 = hC;

                if ((setP1 - setP2) == 1)
                {
                    score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
                    Console.WriteLine("B: Non-fighter        Health:" + (hB) + "           Score:0");
                    Console.WriteLine("C: Defeated           Health:0           Score:0");

                    if (distanceAB > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAB <= 15)
                    {
                        Console.WriteLine("Round 2 : A-B");
                        score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAB * 10) + (100 - (hB - 25)));

                        Console.WriteLine("A: Defeat            Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Survivor           Health:" + (hB - 25) + "           Score:" + (score2));
                        Console.WriteLine("C: Defeated           Health:0           Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));

                    }
                }



                if ((setP1 - setP2) == -1)
                {
                    score = ((manhattanAC * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Defeated           Health:0           Score:0");
                    Console.WriteLine("B: Non-fighter        Health:" + hB + "           Score:0");
                    Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));

                    if (distanceBC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceBC <= 15)
                    {
                        Console.WriteLine("Round 2 : B-C");
                        score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanBC * 10) + (100 - (hB - 25)));
                        Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Survivor           Health:" + (hB - 25) + "           Score:" + (score2));
                        Console.WriteLine("C: Defeated           Health:0           Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));

                    }
                }



                if ((setP1 - setP2) == -2)
                {
                    score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Survivor           Health:" + (healthP1 - 25) + "           Score:" + (score));
                    Console.WriteLine("B: Non-fighter        Health:" + hB + "           Score:0");
                    Console.WriteLine("C: Defeated           Health:0           Score:0");

                    if (distanceAB > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAB <= 15)
                    {
                        Console.WriteLine("Round 2 : A-B");
                        score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAB * 10) + (100 - (hB - 25)));
                        Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Survivor           Health:" + (hB - 25) + "           Score:" + (score2));
                        Console.WriteLine("C: Defeated           Health:0           Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));
                    }
                }

                if ((setP1 - setP2) == 2)
                {
                    score = ((manhattanAC * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Defeated           Health:0           Score:0");
                    Console.WriteLine("B: Non-fighter        Health:" + hB + "           Score:0");
                    Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + (score));

                    if (distanceBC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceBC <= 15)
                    {
                        Console.WriteLine("Round 2 : B-C");
                        score = ((manhattanAC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanBC * 10) + (100 - (hB - 25)));
                        Console.WriteLine("A: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("B: Survivor           Health:" + (hB - 25) + "           Score:" + (score2));
                        Console.WriteLine("C: Defeated           Health:0           Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("B has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("A has the maximum score " + ((score)));

                    }
                }

            }


            if (distanceBC < distanceAB && distanceBC < distanceAC)
            {
                chosendistance = distanceBC;
                Console.WriteLine("Round 1 : B-C");
                char1 = 'B';
                char2 = 'C';
                setP1 = setB;
                setP2 = setC;
                healthP1 = hB;
                healthP2 = hC;

                if ((setP1 - setP2) == 1)
                {
                    score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Non-fighter        Health:" + (hA) + "           Score:0");
                    Console.WriteLine("B: Survivor           Health:" + (healthP1 - 25) + "           Score:" + score);
                    Console.WriteLine("C: Defeated           Health:0           Score:0");

                    if (distanceAB > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAB <= 15)
                    {
                        Console.WriteLine("Round 2 : A-B");
                        score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAB * 10) + (100 - (hA - 25)));

                        Console.WriteLine("A: Survivor           Health:" + (hA - 25) + "           Score:" + (score2));
                        Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("C: Defeated           Health:0           Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("A has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("B has the maximum score " + ((score)));

                    }
                }

                if ((setP1 - setP2) == -1)
                {
                    score = ((manhattanBC * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Non-fighter        Health:" + (hA) + "           Score:0");
                    Console.WriteLine("B: Defeated           Health:0           Score:0");
                    Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + score);

                    if (distanceAC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAC <= 15)
                    {
                        Console.WriteLine("Round 2 : A-C");
                        score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAC * 10) + (100 - (hA - 25)));

                        Console.WriteLine("A: Survivor           Health:" + (hA - 25) + "           Score:" + (score2));
                        Console.WriteLine("B: Defeated           Health:0           Score:0");
                        Console.WriteLine("C: Defeat             Health:0" + "           Score:" + (score));

                        if (score < score2)
                        {
                            Console.WriteLine("A has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("C has the maximum score " + ((score)));

                    }
                }

                if ((setP1 - setP2) == -2)
                {
                    score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                    Console.WriteLine("A: Non-fighter        Health:" + hA + "           Score:0");
                    Console.WriteLine("B: Survivor           Health:" + (healthP1 - 25) + "           Score:" + score);
                    Console.WriteLine("C: Defeated           Health:0           Score:0");

                    if (distanceAB > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAB <= 15)
                    {
                        Console.WriteLine("Round 2 : A-B");
                        score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAB * 10) + (100 - (hA - 25)));
                        Console.WriteLine("A: Survivor           Health:" + (hA - 25) + "            Score:" + (score2));
                        Console.WriteLine("B: Defeat             Health:0" + "           Score:" + (score));
                        Console.WriteLine("C: Defeated           Health:0            Score:0");

                        if (score < score2)
                        {
                            Console.WriteLine("A has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("B has the maximum score " + ((score)));


                    }
                }

                if ((setP1 - setP2) == 2)
                {
                    score = ((manhattanBC * 10) + (100 - (healthP2 - 25)));
                    Console.WriteLine("A: Non-fighter        Health:" + (hA) + "           Score:0");
                    Console.WriteLine("B: Defeated           Health:0           Score:0");
                    Console.WriteLine("C: Survivor           Health:" + (healthP2 - 25) + "           Score:" + score);

                    if (distanceAC > 15)
                    {
                        Console.WriteLine("The distance between players not suitable for round 2");
                    }


                    if (distanceAC <= 15)
                    {
                        Console.WriteLine("Round 2 : A-C");
                        score = ((manhattanBC * 10) + (100 - (healthP1 - 25)));
                        score2 = ((manhattanAC * 10) + (100 - (hA - 25)));

                        Console.WriteLine("A: Survivor           Health:" + (hA - 25) + "           Score:" + (score2));
                        Console.WriteLine("B: Defeated           Health:0           Score:0");
                        Console.WriteLine("C: Defeat             Health:0" + "           Score:" + (score));

                        if (score < score2)
                        {
                            Console.WriteLine("A has the maximum score " + ((score2)));

                        }
                        else if (score == score2)
                        {
                            Console.WriteLine("A an C are have maximum score.");
                        }
                        else
                            Console.WriteLine("C has the maximum score " + ((score)));

                    }
                }
            }

            chosendistance = Convert.ToInt32(chosendistance);
            //Console.ReadKey();
            lastLineY = Console.CursorTop;


            //  Updates colors of the players according to the states of them
            if (hA == 0)
            {
                Console.SetCursorPosition(((Ax + 11) * 2) + 3, Ay + 11 + middleLineY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("A");
                Console.ResetColor();
            }
            if (hB == 0)
            {
                Console.SetCursorPosition(((Bx + 11) * 2) + 3, By + 11 + middleLineY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("B");
                Console.ResetColor();
            }
            if (hC == 0)
            {
                Console.SetCursorPosition(((Cx + 11) * 2) + 3, Cy + 11 + middleLineY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("C");
                Console.ResetColor();
            }

            Console.CursorTop = lastLineY;

        }
    }
}
