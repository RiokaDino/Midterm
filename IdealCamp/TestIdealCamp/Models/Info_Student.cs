public class Student: Person {
    private string levelofeducation;
    private string school;

    public Student(string nameprefix, string name, string surname, string age, string levelofeducation, string allergy, string religion, string school)
    : base(nameprefix, name, surname, age, allergy, religion) {
        this.levelofeducation = levelofeducation;
        this.school = school;
    }
    public string Getlevelofeducation() {
        return this.levelofeducation;
    }
}