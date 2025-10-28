# 🏋️‍♂️ Salalah Fitness Club — Member and Class Management

## 📘 Repository Description
This repository contains a **C# console-based system** for managing members, trainers, and fitness classes at Salalah Fitness Club.  
It demonstrates **Object-Oriented Programming (OOP)** concepts such as inheritance, encapsulation, lists, and real-world application modeling.

The system allows:
- Adding members and trainers  
- Creating fitness classes  
- Assigning trainers to classes  
- Registering members into classes  
- Viewing class details (trainer & enrolled members)  
- Calculating membership costs depending on membership type  

---

## 📚 Table of Contents
- [Objective & Story](#-objective--story)
- [OOP Breakdown](#-oop-breakdown)
- [Classes & Relationships Diagram](#-classes--relationships-diagram)
- [Concepts Covered](#-concepts-covered)
- [Author](#-author)

---

## 🎯 Objective & Story
Design and implement a simple console-based system that helps Salalah Fitness Club manage members, trainers, and classes using **OOP principles** only.

**Requirements:**
- Add members and trainers  
- Create fitness classes  
- Assign a trainer to a class  
- Register members into classes  
- View class details  
- Calculate membership cost based on membership type  

---

## 🧩 OOP Breakdown

```csharp
// Base class
class Person
{
    int Id;
    string FullName;
    int Age;
    void DisplayInfo();
}

// Member inherits Person
class Member : Person
{
    MemberType MembershipType;
    List<FitnessClass> RegisteredClasses;
    void RegisterToClass(FitnessClass fitnessClass);
    void ShowRegisteredClasses();
}

// Trainer inherits Person
class Trainer : Person
{
    string Specialization;
    List<FitnessClass> AssignedClasses;
    void AssignToClass(FitnessClass fitnessClass);
    void ShowAssignedClasses();
}

// FitnessClass
class FitnessClass
{
    string ClassName;
    string Schedule;
    Trainer Trainer;
    List<Member> EnrolledMembers;
    void AddMember(Member member);
    void ShowClassDetails();
}

// FitnessCenter
class FitnessCenter
{
    List<Member> Members;
    List<Trainer> Trainers;
    List<FitnessClass> Classes;
    void AddMember();
    void AddTrainer();
    void CreateClass();
    void AssignTrainerToClass();
    void RegisterMemberToClass();
    void ShowAllClasses();
}


🧠 Concepts Covered
✅ Object-Oriented Programming (OOP)
✅ Classes & Objects
✅ Inheritance & Encapsulation
✅ Lists / Arrays for data management
✅ Methods for operations on objects
✅ Real-world application modeling


