using System;
using System.Collections;
using System.Collections.Generic;

namespace Semester_2_Laboratory_4
{
    class Program
    {
        abstract class KitchenAppliance
        {
            public abstract void WashTheDishes();
            public abstract void PlaceOnTheKitchen();
            public abstract void ChangeThePlaceInTheKitchen(ref List<string> freSpeaceInTheKitchen);
        }

        class Microwave : KitchenAppliance
        {
            public Microwave(double weight)
            {
                this.Weight = weight;
            }

            public Microwave(double weight, bool isTurnedOn, bool isDirty, string placeOnTheKitchen)
            {
                this.Weight = weight;
                this.IsTurnedOn = isTurnedOn;
                this.IsDirty = isDirty;
                this.placeOnTheKitchen = placeOnTheKitchen;
            }

            public void TurnOn()
            {
                if (isTurnedOn == false)
                {
                    Console.WriteLine("The microwave is turned on");
                    isTurnedOn = true;
                }
                else
                    Console.WriteLine("The microwave is already on");
            }
            public override void WashTheDishes()
            {
                if (isDirty == true)
                {
                    Console.WriteLine("Wash the microwave");
                    isDirty = false;
                }
                else
                    Console.WriteLine("The microwave is already clean");
            }

            public override void PlaceOnTheKitchen()
            {
                Console.WriteLine($"Place on the kitchen: {placeOnTheKitchen}, weight: {weight}");
            }

            public override void ChangeThePlaceInTheKitchen(ref List<string> freeSpeaceInTheKitchen)
            {
                Console.WriteLine("Fre speace in the kitchen:");
                foreach (var element in freeSpeaceInTheKitchen)
                {
                    Console.WriteLine(element);
                }

            Repeat:
                Console.WriteLine("Enter new place in the kitchen:");
                string choice = Console.ReadLine();
                if (freeSpeaceInTheKitchen.Contains(choice.ToLower()))
                {
                    freeSpeaceInTheKitchen.Add(this.placeOnTheKitchen.ToLower());
                    this.placeOnTheKitchen = choice.ToLower();
                    freeSpeaceInTheKitchen.Remove(choice.ToLower());
                }
                else
                    goto Repeat;
            }

            public bool IsTurnedOn
            {
                get { return isTurnedOn; }
                set { isTurnedOn = value; }
            }

            public bool IsDirty
            {
                get { return isDirty; }
                set { isDirty = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { if (value > 0) weight = value; }
            }

            public string placeOnTheKitchen
            {
                get { return _placeOnTheKitchen; }
                set { _placeOnTheKitchen = value; }
            }

            private bool isTurnedOn;
            private bool isDirty;
            private double weight;
            private string _placeOnTheKitchen;
        }

        class Dishes : KitchenAppliance
        {
            public Dishes(double weight)
            {
                this.Weight = weight;
            }

            public Dishes(double weight, bool isDirty, string placeOnTheKitchen)
            {
                this.Weight = weight;
                this.IsDirty = isDirty;
                this.placeOnTheKitchen = placeOnTheKitchen;
            }

            public override void WashTheDishes()
            {
                if (isDirty == true)
                {
                    Console.WriteLine("Wash the dishes");
                    isDirty = false;
                }
                else
                    Console.WriteLine("The dishes are already clean");
            }

            public override void PlaceOnTheKitchen()
            {
                Console.WriteLine($"Place on the kitchen: {placeOnTheKitchen}, weight: {weight}");
            }

            public override void ChangeThePlaceInTheKitchen(ref List<string> freeSpeaceInTheKitchen)
            {
                Console.WriteLine("Fre speace in the kitchen:");
                foreach (var element in freeSpeaceInTheKitchen)
                {
                    Console.WriteLine(element);
                }

            Repeat:
                Console.WriteLine("Enter new place in the kitchen:");
                string choice = Console.ReadLine();
                if (freeSpeaceInTheKitchen.Contains(choice.ToLower()))
                {
                    freeSpeaceInTheKitchen.Add(this.placeOnTheKitchen.ToLower());
                    this.placeOnTheKitchen = choice.ToLower();
                    freeSpeaceInTheKitchen.Remove(choice.ToLower());
                }
                else
                    goto Repeat;
            }

            public bool IsDirty
            {
                get { return isDirty; }
                set { isDirty = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { if (value > 0) weight = value; }
            }

            public string placeOnTheKitchen
            {
                get { return _placeOnTheKitchen; }
                set { _placeOnTheKitchen = value; }
            }

            private bool isDirty;
            private double weight;
            private string _placeOnTheKitchen;
        }

        class Fork : KitchenAppliance
        {
            public Fork(double weight)
            {
                this.Weight = weight;
            }

            public Fork(double weight, bool isDirty, string placeOnTheKitchen)
            {
                this.Weight = weight;
                this.IsDirty = isDirty;
                this.placeOnTheKitchen = placeOnTheKitchen;
            }

            public override void WashTheDishes()
            {
                if (isDirty == true)
                {
                    Console.WriteLine("Wash the fork");
                    isDirty = false;
                }
                else
                    Console.WriteLine("The fork is already clean");
            }

            public override void PlaceOnTheKitchen()
            {
                Console.WriteLine($"Place on the kitchen: {placeOnTheKitchen}, weight: {weight}");
            }

            public override void ChangeThePlaceInTheKitchen(ref List<string> freeSpeaceInTheKitchen)
            {
                Console.WriteLine("Fre speace in the kitchen:");
                foreach (var element in freeSpeaceInTheKitchen)
                {
                    Console.WriteLine(element);
                }

            Repeat:
                Console.WriteLine("Enter new place in the kitchen:");
                string choice = Console.ReadLine();
                if (freeSpeaceInTheKitchen.Contains(choice.ToLower()))
                {
                    freeSpeaceInTheKitchen.Add(this.placeOnTheKitchen.ToLower());
                    this.placeOnTheKitchen = choice.ToLower();
                    freeSpeaceInTheKitchen.Remove(choice.ToLower());
                }
                else
                    goto Repeat;
            }

            public bool IsDirty
            {
                get { return isDirty; }
                set { isDirty = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { if (value > 0) weight = value; }
            }

            public string placeOnTheKitchen
            {
                get { return _placeOnTheKitchen; }
                set { _placeOnTheKitchen = value; }
            }

            private bool isDirty;
            private double weight;
            private string _placeOnTheKitchen;
        }

        class Plate : KitchenAppliance
        {
            public Plate(double weight)
            {
                this.Weight = weight;
            }

            public Plate(double weight, bool isDirty, string placeOnTheKitchen)
            {
                this.Weight = weight;
                this.IsDirty = isDirty;
                this.placeOnTheKitchen = placeOnTheKitchen;
            }

            public override void WashTheDishes()
            {
                if (isDirty == true)
                {
                    Console.WriteLine("Wash the plate");
                    isDirty = false;
                }
                else
                    Console.WriteLine("The plate is already clean");
            }

            public override void PlaceOnTheKitchen()
            {
                Console.WriteLine($"Place on the kitchen: {placeOnTheKitchen}, weight: {weight}");
            }

            public override void ChangeThePlaceInTheKitchen(ref List<string> freeSpeaceInTheKitchen)
            {
                Console.WriteLine("Fre speace in the kitchen:");
                foreach (var element in freeSpeaceInTheKitchen)
                {
                    Console.WriteLine(element);
                }

            Repeat:
                Console.WriteLine("Enter new place in the kitchen:");
                string choice = Console.ReadLine();
                if (freeSpeaceInTheKitchen.Contains(choice.ToLower()))
                {
                    freeSpeaceInTheKitchen.Add(this.placeOnTheKitchen.ToLower());
                    this.placeOnTheKitchen = choice.ToLower();
                    freeSpeaceInTheKitchen.Remove(choice.ToLower());
                }
                else
                    goto Repeat;
            }

            public bool IsDirty
            {
                get { return isDirty; }
                set { isDirty = value; }
            }

            public double Weight
            {
                get { return weight; }
                set { if (value > 0) weight = value; }
            }

            public string placeOnTheKitchen
            {
                get { return _placeOnTheKitchen; }
                set { _placeOnTheKitchen = value; }
            }

            private bool isDirty;
            private double weight;
            private string _placeOnTheKitchen;
        }

        static void Main(string[] args)
        {
            List<string> freSpeaceInTheKitchen = new List<string> {
            "Table", "Table top"
            };

            List<KitchenAppliance> kitchenAppliances = new List<KitchenAppliance> {
                new Microwave(10, false, false, "Table"),
                new Dishes(2, false, "Table top"),
                new Fork(0.2, false, "Floor"),
                new Plate(0.5, false, "Table"),
            }; 

            foreach (var element in kitchenAppliances)
            {
                element.PlaceOnTheKitchen();
            }
        }
    }
}
