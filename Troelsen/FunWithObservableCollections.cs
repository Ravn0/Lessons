using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Troelsen
{
    public enum NotifyCollectionChangedAction
    {
        Add = 0,
        Remove = 1,
        Replace = 2,
        Move = 3,
        Reset = 4,
    }
    public static class FunWithObservableCollections
    {
        public static void UseObservableCollection()
        {
            // Сделать коллекцию наблюдаемой и добавить в нее несколько объектов Person.
            ObservableCollection<Person> people = new ObservableCollection<Person>()
            {
                new Person{ FirstName = "Peter", LastName = "Murphy", Age = 52 },
                new Person{ FirstName = "Kevin", LastName = "Key", Age = 48 },
            };
            // Привязаться к событию CollectionChanged.
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person { FirstName = "Aleksey", LastName = "Plakhtiev", Age = 23 });
            people.Remove(people[1]);
            people.Remove(people[1]);
        }
        static void people_CollectionChanged(object sender,
        System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Выяснить действие, которое привело к генерации события.
            Console.WriteLine("Action for this event: {0}", e.Action);
            // Было что-то удалено,
            if (e.Action ==
            System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the OLD items:"); // старые элементы
                foreach (Person p in e.OldItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
            // Было что-то добавлено.
            if (e.Action ==
            System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Теперь вывести новые элементы, которые были вставлены.
                Console.WriteLine("Here are the NEW items:"); // новые элементы
                foreach (Person p in e.NewItems)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
