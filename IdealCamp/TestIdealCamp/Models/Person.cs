public abstract class Person {
    private string nameprefix;
    private string name;
    private string surname;
    private string age;
    private string allergy;
    private string religion;


    public Person(string nameprefix, string name, string surname, string age, string allergy, string religion) {
        this.nameprefix = nameprefix;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.allergy = allergy;
        this.religion = religion;
    }

    public string GetNamePrefix() {
        return this.nameprefix;
    }

    public string GetName() {
        return this.name;
    }

    public string GetSurname() {
        return this.surname;
    }

    public string GetAge() {
        return this.age;
    }

    public string GetAllergy() {
        return this.allergy;
    }
    
    public string GetReligion() {
        return this.religion;
    }

}