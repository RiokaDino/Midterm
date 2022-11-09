using System.Collections.Generic;
using System;
class PersonList {
    private List<Person> personList;

    public PersonList() {
        this.personList = new List<Person>();
    }

    public void AddNewPerson(Person person) {
        this.personList.Add(person);
    }

    public void FetchPersonList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Collegian) {
                Console.WriteLine("Name {0} \n Type: Collegian ", person.GetName());
            } else if (person is Student) {
                Console.WriteLine("Name {0} \n Type: Student ", person.GetName());
            } else if (person is Teacher) {
                Console.WriteLine("Name {0} \n Type: Teacher ", person.GetName());
            }
        }
    }
    public void FetchCollegianList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Collegian) {
                Console.WriteLine("Name {0} {1} {2}", person.GetNamePrefix(), person.GetName(), person.GetSurname());
            }
        }
    }
    public void FetchStudentList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Student) {
                Console.WriteLine("Name {0} {1} {2}", person.GetNamePrefix(), person.GetName(), person.GetSurname());
            }
        }
    }
    public void FetchTeacherList() {
        Console.WriteLine("List Person");
        Console.WriteLine("************");

        foreach(Person person in this.personList) {
            if (person is Teacher) {
                Console.WriteLine("Name {0} {1} {2}", person.GetNamePrefix(), person.GetName(), person.GetSurname());
            }
        }
    }
}