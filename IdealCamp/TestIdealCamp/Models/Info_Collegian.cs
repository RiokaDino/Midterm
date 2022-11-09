public class Collegian: Person {
    private string collegianID;

    public Collegian(string nameprefix, string name, string surname, string collegianID, string age, string allergy, string religion)
    : base(nameprefix, name, surname, age, allergy, religion) {
        this.collegianID = collegianID;
    }
}