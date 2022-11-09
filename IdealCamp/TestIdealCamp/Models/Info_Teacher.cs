public class Teacher: Person {
    private string positioncollege;
    private string car;

    public Teacher(string nameprefix, string name, string surname, string age, string positioncollege, string allergy, string religion, string car)
    : base(nameprefix, name, surname, age, allergy, religion) {
        this.positioncollege = positioncollege;
        this.car = car;
    }
}