using System.Collections.Generic;

namespace CTCI.Ch_03_Stacks_and_Queues.Task_06_Dogs_and_Cats
{
    public enum AnimalKind
    {
        Dog,
        Cat
    }

    public class Animal
    {
        public Animal(AnimalKind kind, int age)
        {
            Kind = kind;
            Age = age;
        }

        public AnimalKind Kind { get; }
        public int Age { get; }
    }

    public class DogsAndCats
    {
        // oldest first
        private readonly LinkedList<Animal> _dogs = new();
        private readonly LinkedList<Animal> _cats = new();

        public void Enqueue(Animal animal)
        {
            var list = animal.Kind == AnimalKind.Dog
                ? _dogs
                : _cats;
            var node = list.First;

            while (node != null && node.Value.Age > animal.Age)
            {
                node = node.Next;
            }

            if (node != null)
            {
                list.AddBefore(node, animal);
            }
            else
            {
                list.AddLast(animal);
            }
        }

        public Animal DequeueDog()
        {
            var oldestDog = _dogs.First?.Value;

            if (oldestDog != null)
            {
                _dogs.RemoveFirst();
            }

            return oldestDog;
        }

        public Animal DequeueCat()
        {
            var oldestCat = _cats.First?.Value;

            if (oldestCat != null)
            {
                _cats.RemoveFirst();
            }

            return oldestCat;
        }

        public Animal DequeueAny()
        {
            var oldestDog = _dogs.First;
            var oldestCat = _cats.First;

            if (oldestDog == null)
            {
                _dogs.RemoveFirst();
                return oldestCat.Value;
            }

            if (oldestCat == null)
            {
                _cats.RemoveFirst();
                return oldestDog.Value;
            }

            if (oldestDog.Value.Age > oldestCat.Value.Age)
            {
                _dogs.RemoveFirst();
                return oldestDog.Value;
            }

            _cats.RemoveFirst();
            return oldestCat.Value;
        }
    }
}