namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 1
            /*int[] myNum = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var evenNumbers = myNum.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");

            foreach ( var evenNumber in evenNumbers )
            {
                Console.WriteLine(evenNumber);
            }

            Console.WriteLine("\n");*/


            // test 2
            /*int[] numbers = { 1, -2, 3, -4, -5, 6, -7, -8, 9, 10,-11, 12, 13, 14, 15 };

            var positiveNumbers = numbers.Where(x => x > 0 && x < 12).ToList();

            Console.WriteLine("\nThe numbers within the range of 1 to 11 are : \n");

            foreach (var positiveNumber in positiveNumbers)
            {
                Console.WriteLine(positiveNumber);
            }
            Console.WriteLine("\n");*/


            // test 3
            /*int[] myNums = { 6, 5, 8, 9, 10, 16, 19 };
            var squaredNums = myNums.Where(x => x < 10)
                                .Select(x => new { Number = x, Square = x * x })
                                .ToList();
            foreach (var pair in squaredNums)
            {
                Console.WriteLine($"{pair.Number} => {pair.Square}");
            }

            Console.WriteLine("\n");*/


            // test 4
            /*int[] nums = { 1, 2, 5, 4, 5, 6, 7, 6, 8, };
            var groupedResult = from x in nums
                                group x by x into y
                                select y;

            foreach (var num in groupedResult)
            {
                Console.WriteLine("Number " + num.Key + " appears " + num.Count() + " times.");
            }

            Console.WriteLine("\n");*/


            // test 5
            /*string fruit = "apple";
            var frequencyChars = from x in fruit
                                group x by x into y
                                select y;
            foreach(var frequency in frequencyChars)
            {
                Console.WriteLine("Character " + frequency.Key + ": " + frequency.Count() + " times.");
            }

            Console.WriteLine("\n");*/


            // test 6
            /*string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Friday", "Saturday", "Sunday" };

            foreach (var day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("\n");*/


            // test 7
            /*int[] arr = { 5, 1, 9, 2, 3, 3, 5};

            var displayedNums = from x in arr
                                group x by x into y
                                select y;


            foreach (var displayedNum in displayedNums)
            {
                int number = displayedNum.Key;
                int frequency = displayedNum.Count();
                int multiplication = number * frequency;
                Console.WriteLine(displayedNum.Key + " " + multiplication + " " + displayedNum.Count());
            }

            Console.WriteLine("\n");*/


            // test 8
            /*string[] cities = { "ROME", "NAIROBI", "AMSTERDAM", "CALIFORNI", "LONDON", "ZURICH", "NEW DEHLI" };
            var popularCities = cities.Where(x => x.StartsWith("A") && x.EndsWith("M")).ToList();

            foreach (var city in popularCities)
            {
                Console.WriteLine(city);
            }
            Console.WriteLine("\n");*/


            // test 9
            /*int i = 0;
            List<int> nr = new List<int>();
            nr.Add(55);
            nr.Add(200);
            nr.Add(740);
            nr.Add(76);
            nr.Add(230);
            nr.Add(482);
            nr.Add(95);


            foreach (var everyNumbers in nr)
            {
                Console.WriteLine(everyNumbers);
            }
            Console.WriteLine("\n");

            var myNrs = nr.Where(x => x > 80).ToList();
            foreach(var myNr in myNrs)
            {
                Console.WriteLine(myNr);
            }
            Console.WriteLine("\n");*/


            // test 10
            /*Console.WriteLine("Input the number of members on the List: ");
            int numberOfMembers = int.Parse(Console.ReadLine());
            List<int> memberList = new List<int>();

            for (int i = 0; i < numberOfMembers; i++)
            {
                Console.WriteLine($"Member {i} : ");
                int member = int.Parse(Console.ReadLine());
                memberList.Add(member);
            }

            Console.WriteLine("Input the value above which you want to display the members of the List: ");
            int aboveValue = int.Parse(Console.ReadLine());

            List<int> numbersAboveValue = memberList.FindAll(member => member > aboveValue);

            Console.WriteLine(aboveValue);
            foreach (int number in numbersAboveValue)
            {
                Console.WriteLine(number);
            }*/


            // Test 11

            /*List<int> nums = new List<int>(); 
            nums.Add(5);
            nums.Add(7);
            nums.Add(13);
            nums.Add(24);
            nums.Add(6);
            nums.Add(9);
            nums.Add(8);
            nums.Add(7);

            Console.WriteLine("The members of the list are : ");

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");

            var sortedNums = nums.OrderByDescending(x => x).Take(3);

            foreach (int i in sortedNums)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");*/


            //Test 12
            /*string sentence = "This IS a STRING";

            string[] words = sentence.Split(new char[] { ' ' });

            foreach (string word in words)
            {
                if (IsUpperCase(word))
                {
                    Console.WriteLine(word);
                }
            }
            
            static bool IsUpperCase(string s)
            {
                foreach (char c in s)
                {
                    if (char.IsLower(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("\n");*/


            //Test 13
            /*Console.WriteLine("Input number of strings to store in the array: ");
            int n = int.Parse(Console.ReadLine());

            string[] stringArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}]: ");
                stringArray[i] = Console.ReadLine();
            }

            string result = string.Join(", ", stringArray);
            Console.WriteLine(result);
            Console.WriteLine("\n");*/

            //Test 14

            /*List<Student> students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Fidan", GradePoint = 980});
            students.Add(new Student() { Id = 2, Name = "Ayshan", GradePoint = 780});
            students.Add(new Student() { Id = 1, Name = "Gunay", GradePoint = 830 });
            students.Add(new Student() { Id = 1, Name = "Afag", GradePoint = 950 });
            students.Add(new Student() { Id = 1, Name = "Jeyhun", GradePoint = 630 });

            Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find : ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= students.Count)
            {
                List<Student> listedStudents = students
                    .OrderByDescending(x => x.GradePoint)
                    .Take(n)
                    .ToList();

                Console.WriteLine($"Top {n} maximum grade points achieved by the students:");
                foreach (Student student in listedStudents)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Achieved Grade Point: {student.GradePoint}");
                }
            }
            else
            {
                Console.WriteLine($"There are not enough students");
            }*/


            // test 16
            /*string[] s = Directory.GetFiles(@"c:\A");
            
            var avg = s.Select(file => new FileInfo(file).Length).Average();
            avg = Math.Round(avg / 10, 1);
            Console.WriteLine("The Average file size is {0} MB", avg);*/

            // test 17, 18, 19, 20
            /*List<char> letters = new List<char>();
            letters.Add('c');
            letters.Add('a');
            letters.Add('d');
            letters.Add('b');

            Console.WriteLine("Original list : ");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //test 17
            /*var lettersToRemove = letters.Find(c => c == 'a');
            letters.Remove(lettersToRemove);

            Console.WriteLine("Renewed list");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //test 18
            /*var lettersToRemove = letters.Where(c => c != 'a').ToList();
            letters = lettersToRemove;

            Console.WriteLine("Renewed list");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //test 19
            /*letters.RemoveAll(c => c == 'a');
            
            Console.WriteLine("Renewed list: ");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //test 20
            /*letters.RemoveAt(3);

            Console.WriteLine("Renewed list: ");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //test 21
            /*letters.RemoveRange(2, 2);
            Console.WriteLine("Renewed list: ");
            foreach (char c in letters)
            {
                Console.WriteLine(c);
            }*/


            //Test 22
            /*Console.WriteLine("Input number of strings to store in the array: ");
            int n = int.Parse(Console.ReadLine());

            string[] stringArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element[{i}]: ");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("Input the minimum length of the item you want to find : ");
            int k = int.Parse(Console.ReadLine());

            var stringToFind = stringArray.Where(x => x.Length >= k).ToList();
            foreach (var item in stringToFind)
            {
                Console.WriteLine(item);
            }*/



            //Test 28
            /*string[] cities =
            {
               "CALIFORNIA", "ROME","LONDON","ABU DHABI", "NAIROBI","NEW DELHI","AMSTERDAM", "PARIS", "ZURICH"
            };

            List<string> sortedcities = cities.OrderBy(x => x.Length).ThenBy(x => x).ToList();
            foreach (string c in sortedcities)
            {
                Console.WriteLine(c);
            }*/

            // Test 23
            /*List<char> letterList = new List<char> { 'X' };
            List<int> numberList = new List<int> { 1, 2, 3, 4 };

            var productList = from letter in letterList 
                              from number in numberList
                              select new { letterList = letter, numberList = number};

            foreach (var item in productList)
            {
                Console.WriteLine($"{{ letterList = {item.letterList}, numberList = {item.numberList} }}");
            };*/

            //Test 24
            /*List<char> letterList = new List<char> { 'X', 'Y' };
            List<int> numberList = new List<int> { 1, 2, 3 };
            List<string> colourList = new List<string> { "Green", "Orange" };

            var productList = from letter in letterList
                              from number in numberList
                              from colour in colourList
                              select new { letterList = letter, numberList = number, colourList = colour };

            foreach (var item in productList)
            {
                Console.WriteLine($"{{ letterList = {item.letterList}, numberList = {item.numberList}, colourList = {item.colourList} }}");
            };*/

            // Test 29

            /*List<string> list = new List<string> { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI"};

            int groupSize = 2;


            for(int i = 0;  i < list.Count; i += groupSize)
            {
                var group = list.Skip(i).Take(groupSize);
                Console.WriteLine("Group of cities : ");
                Console.WriteLine(string.Join("; ", group));
            }*/

            // Test 30
            /*List<int> numbers = new List<int> { 10, 5, 8, 2, 10, 3, 5, 8 };
            List<int> distinctNumbers = numbers.Distinct().ToList();
            distinctNumbers.Sort();

            Console.WriteLine("Distinct elements in ascending order:");

            foreach (int number in distinctNumbers)
            {
                Console.WriteLine(number);
            }*/

        }

        //Test 14
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int GradePoint { get; set; }
        }
    }

}