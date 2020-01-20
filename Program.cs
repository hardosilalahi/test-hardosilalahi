using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace test_hardosilalahi
{
    class Program
    {
        static void Main(string[] args)
        {
            // NumberOne.hello("hardo");

            // DateTime birthday = new DateTime(1997,06,24);
            // NumberTwo.ulangTahun(birthday);

            // NumberThree.CountString("Hello World");

            // NumberFive.IsEven(6);
            // NumberFive.IsOdd(6);

            // NumberSix.Grade(85);

            // NumberSeven.CelsiusToFahrenheit(0);
            // NumberSeven.FahrenheitToCelsius(50);
            // NumberSeven.CelsiusToKelvin(100);
            // NumberSeven.KelvinToCelsius(375);
            // NumberSeven.KelvinToFahrenheit(375);
            // NumberSeven.FahrenheitToKelvin(12);

            // NumberEight.IsLeapYear(2020);
            // NumberEight.IsLeapYear(2019);

            // var jakarta = Tuple.Create("Jakarta", 7);
            // var bali = Tuple.Create("Bali", 8);
            // var london = Tuple.Create("London", 0);
            // var cairo = Tuple.Create("Cairo", 2);
            // var denver = Tuple.Create("Denver", -6);
            // var chicago = Tuple.Create("Chicago", -5);

            // NumberNine.TimezoneDiff(jakarta, london);
            // NumberNine.TimezoneDiff(cairo, chicago);
            // NumberNine.TimezoneDiff(cairo, bali);
            // NumberNine.TimezoneDiff(denver, jakarta);

            // NumberTen.sum(1, 6);
            // NumberTen.multiply(2, 6);
            // NumberTen.substract(6, 2);
            // NumberTen.divide(6, 2);]

            // NumberEleven.SumArgs();

            // NumberTwelve.ConvertToUpper("hello world");
            // NumberTwelve.ConvertToUpper("welcome to the world");

            // NumberThirteen.CountWords("Lorem ipsum dolor sit amet");
            
            // NumberFourteen.IsPalindrome("ipsum");
            // NumberFourteen.IsPalindrome("malam");
            // NumberFourteen.IsPalindrome("tidur");
            // NumberFourteen.IsPalindrome("kasur rusak");
            // NumberFourteen.IsPalindrome("ibu ratna antar ubi");
            
            // NumberFifteen.Mirror("--vv");
            // NumberFifteen.Mirror("..ww");

            // string[] fruits = {
            //     "Jeruk",
            //     "Apel",
            //     "Anggur",
            //     "Pepaya",
            //     "Pisang",
            //     "Kiwi",
            //     "Markisa",
            // };

            // NumberSixteen.IndexFinder(fruits, "Jeruk");
            // NumberSixteen.IndexFinder(fruits, "Pepaya");
            // NumberSixteen.IndexFinder(fruits, "Markisa");
            // NumberSixteen.IndexFinder(fruits, "Pisang");

            // NumberSeventeen.FooBarBaz();

            // int[] numbers = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 54};
            // NumberEighteen.FindMax(numbers);
            // NumberEighteen.FindMin(numbers);
            // NumberEighteen.FindAverage(numbers);
            
            // int[] points = {2, 4, 54, 12, -65, 19, 40, 92, 88, 330, -4, 45};
            // NumberNineteen.ArraySort(points);

            // NumberTwenty item = new NumberTwenty();
            // item.name = "Indomie Goreng";
            // item.price = 3500;
            // item.onSale = false; // If true the price will drop 20%
            // Console.WriteLine(item.print());

            // We have some word collection ...
            var censoredWords = new List<string>(){"imperdiet","dolor","duo"};

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            NumberFour.Censorship(censoredWords, paragraph);

            
            // No. 11
            // int sum = 0;
            // for(int i = 0; i < args.Length; i++){
            //     sum += Convert.ToInt32(args[i]);
            // }
            // Console.WriteLine(sum);

            
        }

        class NumberOne{
            // 01.md
            public static void hello(string name){
            Console.WriteLine($"Hello, my name is {name}.");
            }
            //
        }
        class NumberTwo{
            // 02.md
            public static void ulangTahun(DateTime birthday){
            DateTime today = DateTime.Today;
            DateTime next = birthday.AddYears(today.Year - birthday.Year);

            if (next < today)
            {
                next = next.AddYears(1);
            }   
            int remaining = (next - today).Days;
            Console.WriteLine($"{remaining} days remaining to my next birthday.");
            }
            //
        }
        class NumberThree{
            // 03.md
            public static void CountString(string kata){
                Console.WriteLine($"'{kata}' have {kata.Length} characters");
            }
        }

        class NumberFour{
            // 04.md
            public static void Censorship(List<string> censored, string paragraph){
                var replace = "";
                for(int i = 0; i < censored.Count; i++){
                    replace = paragraph.Replace(censored[i], "*");
                }
                Console.WriteLine(replace);
            }
        }

        class NumberFive{
            public static void IsOdd(int number){
                if(number % 2 == 0){
                    Console.WriteLine(false);
                }
                else{
                    Console.WriteLine(true);
                }
            }
            public static void IsEven(int number){
                if(number % 2 == 0){
                    Console.WriteLine(true);
                }
                else{
                    Console.WriteLine(false);
                }
            }
        }

        class NumberSix{
            public static void Grade(int score){
                if(score >= 90){
                    Console.WriteLine("A");
                }
                else if(score >= 80 && score <= 89){
                    Console.WriteLine("B");
                }
                else if(score >= 70 && score <= 79){
                    Console.WriteLine("C");
                }
                else if(score >= 60 && score <= 69){
                    Console.WriteLine("D");
                }
                else if(score <= 59){
                    Console.WriteLine("E");
                }
                else{
                    Console.WriteLine("Error, try again.");
                }
            }
        }

        class NumberSeven{
            public static void CelsiusToFahrenheit(int celsius){
                var result = ((celsius * 9) / 5) + 32;
                Console.WriteLine(result);
            }
            public static void FahrenheitToCelsius(int fahrenheit){
                var result = ((fahrenheit - 32) * 5) / 9;
                Console.WriteLine(result);
            }
            public static void CelsiusToKelvin(int celsius){
                var result = celsius + 273.15;
                Console.WriteLine(result);
            }
            public static void KelvinToCelsius(int kelvin){
                var result = kelvin - 273.15;
                Console.WriteLine(result);
            }
            public static void KelvinToFahrenheit(int kelvin){
                var result = (((kelvin - 273.15) * 9) / 5) + 32;
                Console.WriteLine(result);
            }
            public static void FahrenheitToKelvin(int fahrenheit){
                var result = (((fahrenheit + 459.67) * 5) / 9);
                Console.WriteLine(result);
            }
        }
        class NumberEight{
            public static void IsLeapYear(int year){
                if(year % 4 == 0 && year % 100 == 0 && year % 400 == 0){
                    Console.WriteLine(true);
                }
                else if(year % 4 == 0 && year % 100 == 0 && year % 400 != 0){
                    Console.WriteLine(false);
                }
                else if(year % 4 == 0 && year % 100 != 0){
                    Console.WriteLine(true);
                }
                else if(year % 4 != 0){
                    Console.WriteLine(false);
                }
                else{
                    Console.WriteLine("Error input, try again");
                }
            }
        }
        class NumberNine{
            public static void TimezoneDiff(Tuple<string, int> regionA, Tuple<string, int> regionB){
                if(regionA.Item2 > regionB.Item2){
                    var differences = regionA.Item2 - regionB.Item2;
                    Console.WriteLine($"{regionA.Item1} {differences} hours ahead of {regionB.Item1}");
                }
                else if( regionA.Item2 < regionB.Item2){
                    var differences = regionB.Item2 - regionA.Item2;
                    Console.WriteLine($"{regionA.Item1} {differences} hours behind of {regionB.Item1}");
                }
            }
        }

        class NumberTen{
            public static void sum(int num1, int num2){
                Console.WriteLine(num1 + num2);
            }
            public static void substract(int num1, int num2){
                Console.WriteLine(num1 - num2);
            }
            public static void multiply(int num1, int num2){
                Console.WriteLine(num1 * num2);
            }
            public static void divide(int num1, int num2){
                Console.WriteLine(Convert.ToDouble(num1 / num2));
            }
        }
        class NumberEleven{
            // tidak disimpan dalam class, melainkan isi methodnya dimasukkan ke dalam Main()
            // code dibawah adalah snippet yang bisa dimasukkan langsung ke dalam main()
            //     int sum = 0;
            //     for(int i = 0; i < args.Length; i++){
            //         sum += Convert.ToInt32(args[i]);
            //     }
            //     Console.WriteLine(sum);
            // }
        }
        class NumberTwelve{
            public static void ConvertToUpper(string sentence){
                Console.WriteLine(sentence.ToUpper());
            }
        }

        class NumberThirteen{
            public static void CountWords(string txt){
                string[] words = txt.Split(' ');
                Console.WriteLine(words.Length);
            }
        }

        class NumberFourteen{
            public static void IsPalindrome(string txt){
                Console.WriteLine(txt.SequenceEqual(txt.Reverse()));
            }
        }

        class NumberFifteen{
            public static void Mirror(string txt){
                char[] arrayChar = txt.ToCharArray();
                Array.Reverse(arrayChar);
                string mirrorred = new string(arrayChar);
                Console.WriteLine(txt+mirrorred);
            }
        }

        class NumberSixteen{
            public static void IndexFinder(string[] arrayString, string word){
                Console.WriteLine(Array.IndexOf(arrayString, word));
            }
        }

        class NumberSeventeen{
            public static void FooBarBaz(){
                for(int i = 0; i <= 1000; i++){
                    if(i % 5 == 0){
                        if(i % 20 == 0){
                            if(i % 100 == 0){
                                Console.WriteLine(i+". "+"Baz");
                            }
                            else{
                                Console.WriteLine(i+". "+"Bar");
                            }
                        }
                        else{
                            Console.WriteLine(i+". "+"Foo");
                        }
                    }
                    else{
                        Console.WriteLine(i+".");
                    }
                }
            }
        }
        class NumberEighteen{
            public static void FindMax(int[] arrayNumber){
                Console.WriteLine(arrayNumber.Max());
            }
            public static void FindMin(int[] arrayNumber){
                Console.WriteLine(arrayNumber.Min());
            }
            public static void FindAverage(int[] arrayNumber){
                Console.WriteLine(arrayNumber.Average());
            }
        }
        class NumberNineteen{
            public static void ArraySort(int[] arrayNumber){
                Array.Sort(arrayNumber);
                for(int i = 0; i < arrayNumber.Length; i++){
                    Console.WriteLine(arrayNumber[i]);
                }
            }
        }

        class NumberTwenty{
            public string name{get; set;}
            public double price{get; set;}
            public bool onSale{get; set;}

            public string print(){
                if(onSale == true){
                    price = price - (price * 0.2);
                    return $"{name} ({price})";
                }
                else{
                    price = price;
                    return $"{name} ({price})"; 
                }
            }
        }
    }
}
