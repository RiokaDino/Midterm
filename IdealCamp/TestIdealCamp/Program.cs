enum Menu {
    RegisterIdeaCamp = 1,
    ExhibitorStatistics,
    Login
}
enum Register {
    RegisterNewCollegian = 1,
    RegisterNewStudent,
    RegisterNewTeacher,
}
enum Menu2 {
    RegisterIdeaCamp = 1,
    ShowAllCollegian,
    ShowAllStudent,
    ShowAllTeacher,
    Logout
}

class Program {

    static PersonList personList;

    static void Main(string[] args) {
        PreparePersonListWhenProgramIsLoad();
        PrintMenuScreen();
    }

    static void PrintMenuScreen() {
        Console.Clear();

        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PrintListMenu() {
        Console.WriteLine("Welcome to Idea Camp 2022");
        Console.WriteLine("***************************************************");
        Console.WriteLine("Status not Sign in");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Register for Idea Camp 2022");
        Console.WriteLine("2.Exhibitor statistics");
        Console.WriteLine("3.Sign in");
        Console.WriteLine("***************************************************");
    }

    static void InputMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        Menu menu = (Menu)(int.Parse(Console.ReadLine()));

        PresentMenu(menu);
    }

    static void PresentMenu(Menu menu) {
        switch (menu) {
            case Menu.RegisterIdeaCamp:
                PrintListRegisterMenu(); 
                break;
            case Menu.ExhibitorStatistics:
                ExhibitorStatistics(); 
                break;
            case Menu.Login:
                Login();
                break;
            default:
                break;
        }
    }
    static void ExhibitorStatistics() {
        Console.WriteLine("  Show Statistics ");
        Console.WriteLine("****************************");
        Program.personList.FetchPersonList();
        Console.Write("");
        Console.ReadLine();

        BackToMainMenu();
    }
     static void Login() {
        Console.Clear();
        Console.WriteLine("  Login ");
        Console.WriteLine("****************************");
        InputEmail();
        InputPassword();

        BackToMainMenu2();
    }
    static string InputEmail() {
        Console.Write("Email : ");
        return Console.ReadLine();
    }
    static string InputPassword() {
        Console.Write("Password : ");
        return Console.ReadLine();
    }
    static void PrintListMenu2() {
        Console.WriteLine("Welcome to Idea Camp 2022");
        Console.WriteLine("***************************************************");
        Console.WriteLine("Status Sign in");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Register Idea Camp 2022");
        Console.WriteLine("2.Show All Collegian");
        Console.WriteLine("3.Show All Student");
        Console.WriteLine("4.Show All Teacher");
        Console.WriteLine("5.Logout");
        Console.WriteLine("***************************************************");
        InputMenuFromKeyboard2();
    }

    static void InputMenuFromKeyboard2() {
        Console.Write("Please input Menu:");
        Menu2 menu2 = (Menu2)(int.Parse(Console.ReadLine()));

        PresentMenu2(menu2);
    }

    static void PresentMenu2(Menu2 menu2) {
        switch (menu2) {
            case Menu2.RegisterIdeaCamp:
                PrintListRegisterMenu(); 
                break;
            case Menu2.ShowAllCollegian:
                ShowAllCollegian(); 
                break;
            case Menu2.ShowAllStudent:
                ShowAllStudent();
                break;
            case Menu2.ShowAllTeacher:
                ShowAllTeacher();
                break;
            case Menu2.Logout:
                PrintListMenu();
                break;
            default:
                break;
        }
    }
    static void BackToMainMenu2() {
        Console.Clear();
        PrintListMenu2();
        InputMenuFromKeyboard2();
    }
    static void ShowAllCollegian() {
        Console.WriteLine("  Show All Collegian ");
        Console.WriteLine("****************************");
        Program.personList.FetchCollegianList();
        Console.Write("");
        Console.ReadLine();

        BackToMainMenu();
    }
    static void ShowAllStudent() {
        Console.WriteLine("  Show All Student ");
        Console.WriteLine("****************************");
        Program.personList.FetchStudentList();
        Console.Write("");
        Console.ReadLine();

        BackToMainMenu();
    }
    static void ShowAllTeacher() {
        Console.WriteLine("  Show All Teacher ");
        Console.WriteLine("****************************");
        Program.personList.FetchTeacherList();
        Console.Write("");
        Console.ReadLine();

        BackToMainMenu();
    }

    static void PrintListRegisterMenu() {
        Console.Clear();
        Console.WriteLine("Welcome to Idea Camp 2022");
        Console.WriteLine("***************************************************");
        Console.WriteLine("Status not Sign in");
        Console.WriteLine("***************************************************");
        Console.WriteLine("1.Collegion");
        Console.WriteLine("2.Student");
        Console.WriteLine("3.Teacher");
        Console.WriteLine("***************************************************");
        InputRegisterMenuFromKeyboard();
    }

    static void InputRegisterMenuFromKeyboard() {
        Console.Write("Please input Menu:");
        Register register = (Register)(int.Parse(Console.ReadLine()));

        PresentRegister(register);
    }

    static void PresentRegister(Register register) {
        switch (register) {
            case Register.RegisterNewCollegian:
                ShowInputRegistrationNewCollegianScreen();
                break;
            case Register.RegisterNewStudent:
                ShowInputRegistrationNewStudentScreen();
                break;
            case Register.RegisterNewTeacher:
                ShowInputRegistrationNewTeacherScreen();
                break;
            default:
                break;
        }
    }

    static void ShowInputRegistrationNewTeacherScreen() {
        PrintHeaderRegistrationTeacher();
        Console.Write("Input Total new Teacher : ");
        int totalNewTeacher = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewTeacher;i++) {
            Console.Clear();
            Teacher teacher = new Teacher(InputNamePrefix(),
                                      InputName(),
                                      InputSurname(),
                                      InputPositioncollege(),
                                      InputAge(),
                                      InputAllergic(),
                                      InputReligion(),
                                      InputCar());
            Program.personList.AddNewPerson(teacher);
        }

        BackToMainMenu(); 

    }

    static string InputNamePrefix() {
        Console.Write("Name prefix (Mr./ Mrs./ Miss) : ");
        return Console.ReadLine();
    }

    static string InputName() {
        Console.Write("Name : ");
        return Console.ReadLine();
    }

    static string InputSurname() {
        Console.Write("Surname : ");
        return Console.ReadLine();
    }
    static string InputAge() {
        Console.Write("Age : ");
        return Console.ReadLine();
    }

    static string InputAllergic() {
        Console.Write("Allergic (If not put -) : ");
        return Console.ReadLine();
    }

    static string InputReligion() {
        Console.Write("Religion (buddhism/ christianity/ islam/ Other) : ");
        return Console.ReadLine();
    }
    static string InputPositioncollege() {
        Console.Write("Positioncollege (dean/ head of department/ full-time teacher) : ");
        return Console.ReadLine();
    }
    static string InputCar() {
        Console.Write("Car (If there is, please enter the vehicle registration./ If not put -): ");
        return Console.ReadLine();
    }


    static void ShowInputRegistrationNewStudentScreen() {
        PrintHeaderRegisterStudent();
        Console.Write("Input Total new Student : ");
        int totalNewStudent = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewStudent;i++) {
            Console.Clear();
            Student student = new Student(InputNamePrefix(),
                                      InputName(),
                                      InputSurname(),
                                      InputLevelofeducation(),
                                      InputAge(),
                                      InputAllergic(),
                                      InputReligion(),
                                      InputSchool());
            Program.personList.AddNewPerson(student);
        }

        BackToMainMenu(); 

    }
    static string InputLevelofeducation() {
        Console.Write("Level of education (Secondary school year 4/ 5/ 6): ");
        return Console.ReadLine();
    }
    static string InputSchool() {
        Console.Write("School : ");
        return Console.ReadLine();
    }
    static void ShowInputRegistrationNewCollegianScreen() {
        PrintHeaderRegistrationNewsCollegian();
        Console.Write("Input Total new Collegian : ");
        int totalNewCollegian = int.Parse(Console.ReadLine());
        for(int i=0;i < totalNewCollegian;i++) {
            Console.Clear();
            Collegian collegian = new Collegian(InputNamePrefix(),
                                      InputName(),
                                      InputSurname(),
                                      InputCollegianID(),
                                      InputAge(),
                                      InputAllergic(),
                                      InputReligion());
            Program.personList.AddNewPerson(collegian);
        }

        BackToMainMenu();

    }
    static string InputCollegianID() {
        Console.Write("CollegianID : ");
        return Console.ReadLine();
    }
    static void PrintHeaderRegistrationNewsCollegian() {
        Console.WriteLine("Register New Collegian");
        Console.WriteLine("*********************");
    }
    static void PrintHeaderRegisterStudent() {
        Console.WriteLine("Register New Student");
        Console.WriteLine("*********************");
    }
    static void PrintHeaderRegistrationTeacher() {
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("*********************");
    }

    static void BackToMainMenu() {
        Console.Clear();
        PrintListMenu();
        InputMenuFromKeyboard();
    }

    static void PreparePersonListWhenProgramIsLoad() {
        Program.personList = new PersonList();
    }

}
