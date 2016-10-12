using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogList
{
    class Runtime
    {
        public void TheDogs()
        {
            //Dog dog1 = new Dog
            //{
            //    Name = "Snobben",
            //    Age = 5,
            //    Breed = "Beagle"
            //};

            //Dog dog2 = new Dog
            //{
            //    Name = "Lassie",
            //    Age = 3,
            //    Breed = "Collie"
            //};

            //Dog dog3 = new Dog
            //{
            //    Name = "Bingo",
            //    Age = 15,
            //    Breed = "Labrador"
            //};

            //Dog dog4 = new Dog
            //{
            //    Name = "Bella",
            //    Age = 12,
            //    Breed = "Labradoodle"
            //};

            //Console.WriteLine("Name: {0} Age: {1} Breed: {2}", dog1.Name, dog1.Age, dog1.Breed);
            //Console.WriteLine("Name: {0} Age: {1} Breed: {2}", dog2.Name, dog2.Age, dog2.Breed);
            //Console.WriteLine("Name: {0} Age: {1} Breed: {2}", dog3.Name, dog3.Age, dog3.Breed);
            //Console.WriteLine("Name: {0} Age: {1} Breed: {2}", dog4.Name, dog4.Age, dog4.Breed);
            //Console.ReadLine();

            List<Dog> dogs = new List<Dog>()
            {
                new Dog {Name = "Snobben", Age = 5,  Breed = "Beagle"},
                new Dog {Name = "Lassie ", Age = 3,  Breed = "Collie"},
                new Dog {Name = "Bingo  ", Age = 15, Breed = "Labrador"},
                new Dog {Name = "Bella  ", Age = 12, Breed = "Labradoodle"},
            };



            foreach (var dog in dogs)
            {
                Console.WriteLine("Name: {0} Age: {1} Breed: {2}", dog.Name, dog.Age, dog.Breed);
            }

            Console.ReadLine();
        }
    }
}
