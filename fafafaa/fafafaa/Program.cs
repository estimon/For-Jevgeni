using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fafafaa
{
    class Program
    {
        static void Main(string[] args)
        {
            #region boyyyyyyyyy
            //var cars = new List<string> { "BMW", "Lada", "Mercedes", "Ferrari", "Opel", "Saab" };



            //for(int index = 0; index < cars.Count; index++)
            //{
            //    Console.WriteLine(cars[index]);
            //}


            
            var humans1 = new List<Human>
            {
               new Human(){Name = "Kalle", Age = 20 },
               new Human(){Name = "Talle", Age = 20 },
               new Human(){Name = "Palle", Age = 20 },
               new Human(){Name = "Dalle", Age = 23 },
               new Human(){Name = "Jälle", Age = 24 },
           };

            



            // Küsime kelle vanus on üle 20 

            //var query = (from element in humans1
            //             orderby element.Age  ascending
            //             where element.Age > 20
            //             select element).ToList();

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age);
            //}

            //var human1 = new Human();
            //human1.Name = "Andrus";
            //human1.Age = 1;
            //humans1.Add(human1);


            //while (true)
            //{
            //    var humanadd = new Human();
            //    Console.WriteLine("Sisestage nimi");
            //    humanadd.Name = Console.ReadLine();
            //    Console.WriteLine("Sisestage vanus");
            //    humanadd.Age = int.Parse(Console.ReadLine());
            //    humans1.Add(humanadd);


            //    foreach (var item in humans1)
            //    {
            //        Console.WriteLine(item.Name + " " + item.Age);
            //    }

            //    Console.WriteLine("You want sum???(yes/no)");
            //    Console.ReadLine();



            //}
                        #endregion
                        #region ayy

            //Dictionary
            //var openWith = new Dictionary<string, string>();

            //            //key    //value
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("jpg", "pain t.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //try
            //{
            //    openWith.Add("txt", "word.exe");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine(" An element with key txt already exists");
            //}

            //Console.WriteLine("For key = rtf, value = " + openWith["rtf"]);



            //try
            //{
            //    Console.WriteLine("For key = tif, value = {0}", openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("key = \"tif\", is not found");

            //}

            //string value = "";

            //if (openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("Key = \"tif\", value = {0}", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key =\"tif\" is not found");
            //}
            //if (openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hyperterm.exe");
            //    Console.WriteLine("Value added for key ht: {0}", openWith["ht"]);
            //}


            ////Küsime võtame ja väärtused kasutame foreach tsüklis
            //foreach(KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            //}

            ////Võtame väärtused

            //Dictionary<string, string>.ValueCollection valueCollection = openWith.Values;

            //foreach (var item in valueCollection)
            //{
            //    Console.WriteLine("Value = {0}", item);
            //}


            ////Küsime võtmed

            //Dictionary<string, string>.KeyCollection keyCollection = openWith.Keys;


            //foreach (var item in keyCollection)
            //{
            //    Console.WriteLine("Key = {0}", item);
            //}

            ////Kustutame võtame/väärtused

            //openWith.Remove("rtf");
            //if (!openWith.ContainsKey("rtf"))
            //{
            //    Console.WriteLine("Key \"rtf\" is not found");
            //}

                        #endregion
                        #region Queue - first in first out
            //// Loome queue(järjekorra)
            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");


            ////Küsime elemendi järjekorrast 
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //// Võtame välja esimese elemendi
            //Console.WriteLine("Dequeueing: {0}", numbers.Dequeue());

            ////Piilume järgmist elementi

            //Console.WriteLine("Peek at next item to dequeue: {0}", numbers.Peek());

            ////Võtame välja järgmise 
            //Console.WriteLine("Dequeueing: {0}", numbers.Dequeue());


            ////Teeme koopia järjekorrast

            //Queue<string> queuecopy = new Queue<string>(numbers.ToArray());
            //Console.WriteLine("\n Contents of the first copy");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);
            //foreach (var item in array2)
            //{

            //}


            //Queue<string> queuecopy2 = new Queue<string>(array2);
            //Console.WriteLine("\n Contents of the second copy, With duplicates and nulls");
            //foreach (var number in queuecopy)
            //{
            //    Console.WriteLine(number);
            //}


            //Console.WriteLine("\n queueCopy contains 'four' = {0}", queuecopy.Contains("four"));
            ////tühjendamine järjekorras 

            //queuecopy.Clear();
            //Console.WriteLine("\n queue Count is: {0}", queuecopy.Count());



                        #endregion
                        #region Stack - last in last out

            //Stack < string > numbers = new Stack<string>();

            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);

            //}

            //Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}", numbers.Peek());
            //Console.WriteLine("Popping ' {0}'", numbers.Pop());

            #endregion


            #region LINQ

            int[] numbers1 = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var a = numbers1.ElementAt(1);
            var b = numbers1.FirstOrDefault();
            var c = numbers1.Take(3).ToList();
            var d = numbers1.Average();

            var e = numbers1.Max();
            var f = numbers1.Min();
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(f);
            //foreach (var item in c)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine("ElementAt " + a);
            Console.WriteLine("FirstOrDefault " + b);
            Console.WriteLine("Take 3 " + c);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Avrage " + d);
            Console.WriteLine("Max " + e );
            Console.WriteLine("Min " + f);

            var g = humans1.Where(x => x.Name == "Kalle").FirstOrDefault().Name;
            var h = humans1.Where(x => x.Age == 20).ToList();
            var i = humans1.Where(x => x.Name.Contains("a")).ToList();
            var j = humans1.Where(x => x.Name.StartsWith("m")).ToList();
            foreach (var item in h)
            {
                Console.WriteLine(item.Name + " " +item.Age);
            }
            Console.WriteLine(g);
            Console.WriteLine(h);

            Console.WriteLine("Constains a");
            foreach (var item in i)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }




            //var a = numbers1.Contains(7);
            //var b = false;


            //foreach (var item in numbers1)
            //{
            //    if (item == 6)
            //        b = true;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //var evennumQuery = (from num in numbers1
            //                    where (num % 2) == 0
            //                    select num).ToList();




            #endregion


            Console.ReadLine();

        }
    }
}