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

### Classes Needed

#### **Person (Base Class)**
- Fields: `Id`, `FullName`, `Age`  
- Method: `DisplayInfo()`

#### **Member (Inherits from Person)**
- Fields: `MembershipType` (Enum: Monthly, Quarterly, Yearly)  
- Property: `List<FitnessClass> RegisteredClasses`  
- Methods:  
  - `RegisterToClass(FitnessClass fitnessClass)`  
  - `ShowRegisteredClasses()`

#### **Trainer (Inherits from Person)**
- Field: `Specialization` (e.g., "Cardio", "Yoga")  
- Property: `List<FitnessClass> AssignedClasses`  
- Methods:  
  - `AssignToClass(FitnessClass fitnessClass)`  
  - `ShowAssignedClasses()`

#### **FitnessClass**
- Fields: `ClassName`, `Schedule`, `Trainer`, `List<Member> EnrolledMembers`  
- Methods:  
  - `AddMember(Member member)`  
  - `ShowClassDetails()`

#### **FitnessCenter**
- Holds lists:  
  - `List<Member> Members`  
  - `List<Trainer> Trainers`  
  - `List<FitnessClass> Classes`  
- Methods:  
  - `AddMember()`  
  - `AddTrainer()`  
  - `CreateClass()`  
  - `AssignTrainerToClass()`  
  - `RegisterMemberToClass()`  
  - `ShowAllClasses()`  

---

## 🗂️ Classes & Relationships Diagram
