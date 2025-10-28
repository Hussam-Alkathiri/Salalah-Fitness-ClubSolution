using Salalah_Fitness_Club.Models.Enums;
using Salalah_Fitness_Club.Models.Fito;
using Salalah_Fitness_Club.Models.Users;

namespace Salalah_Fitness_Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessCenter center = new FitnessCenter();

            Trainer t1 = new Trainer(0, "Hussam", Gender.Male, 24, "Cardio");
            Trainer t2 = new Trainer(1, "Ali", Gender.Female, 28, "Yoga");
            center.AddTrainer(t1);
            center.AddTrainer(t2);

            Member m1 = new Member(0, "Fahad", Gender.Male, 22, MemberType.Monthly);
            Member m2 = new Member(1, "Omar", Gender.Male, 25, MemberType.Yearly);
            center.AddMember(m1);
            center.AddMember(m2);

            FitnessClass c1 = new FitnessClass("Morning Yoga", "8 AM");
            FitnessClass c2 = new FitnessClass("Evening Cardio", "6 PM");
            center.CreateClass(c1);
            center.CreateClass(c2);

            center.AssignTrainerToClass(1, 0);
            center.AssignTrainerToClass(0, 1);

            center.RegisterMemberToClass(0, 0);
            center.RegisterMemberToClass(1, 1);
            center.RegisterMemberToClass(0, 1);

            center.ShowAllClasses();
        }
    }
}
