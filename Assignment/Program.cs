using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment
{
    internal class Program
    {
        public static void NameOfDays(List<string> days)
        {
            Console.WriteLine("Days of Week");
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000);
            }
        }
        public static void AllMonths(List<string> months)
        {
            Console.WriteLine("Months of Year");
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
        }
        public static void DisplayFruits(List<string> fruits)
        {
            Console.WriteLine("Fruits");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
        public static void DisplayMeanings(Dictionary<string, string> meanings)
        {
            Console.WriteLine("Words with Meanings");
            foreach (var meaning in meanings)
            {
                Console.WriteLine(meaning);
            }
        }

        static void Main(string[] args)
        {
            List<string> Fruits = new List<string>()
            { "Apple", "Mango", "WaterMelon", "Gauva", "Banana", "Strawberry", "Kiwi", "Fig", "DragonFruit", "Avocado"};
            List<string> Days = new List<string>()
            { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
            List<string> Months = new List<string>()
            { "January", "Febrary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            Dictionary<string, string> Meanings = new Dictionary<string, string>();
            Meanings.Add("RAM", "Random Access Memory is a type of computer memory that allows data to be accessed" +
                " and manipulated quickly by the CPU.");

            Meanings.Add("ROM", "Read-Only Memory is a type of computer memory that retains data even when the power is turned" +
                " off and is typically used to store essential firmware and software instructions for booting and system" +
                " initialization.");

            Meanings.Add("CD", "(Compact Disc) is an optical storage medium used to store and distribute digital data, such as audio," +
                " video, and computer files.");

            Meanings.Add("DVD", "Digital Versatile Disc is an optical storage medium used to store and distribute digital data, " +
                "including movies, videos, software, and other files. It is similar to a CD but has a higher storage capacity, " +
                "allowing it to hold larger amounts of data. DVDs are widely used for entertainment purposes and data backup.");

            Meanings.Add("CPU", "Central Processing Unit is the main processing component of a computer that performs instructions" +
                " and calculations, acting as the brain of the computer.");

            Console.WriteLine("-----------------Welcome to Learning-------------------");
            var startTime = DateTime.Now;
            NameOfDays(Days);
            var endTime = DateTime.Now;
            Console.WriteLine("Start time: " + startTime + " end time: " + endTime);
            Thread.Sleep(5000);
            var startTime1 = DateTime.Now;
            AllMonths(Months);
            var endTime1 = DateTime.Now;
            Console.WriteLine("Start time: " + startTime1 + " end time: " + endTime1);
            Thread thread1 = new Thread(() => DisplayFruits(Fruits));
            Thread thread2 = new Thread(() => DisplayMeanings(Meanings));
            thread1.Start();
            thread2.Start();
            Console.ReadKey();
        }
    }
}
