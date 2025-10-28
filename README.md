# 🏋️‍♂️ Salalah Fitness Club — Member and Class Management

## 📚 Table of Contents
- [Project Link](https://github.com/Hussam-Alkathiri/Salalah-Fitness-ClubSolution/tree/master/Salalah%20Fitness%20Club)
- [Objective](#-objective)
- [Story & Requirements](#-story--requirements)
- [OOP Breakdown](#-oop-breakdown)
- [Author](#-author)

---

## 🎯 Objective
Design and implement a simple console-based system that helps Salalah Fitness Club manage members, trainers, and classes using **OOP principles** only.

---

## 📖 Story & Requirements
The fitness club wants a basic system where they can:  
- Add members and trainers  
- Create fitness classes  
- Assign a trainer to a class  
- Register members into classes  
- View class details (which trainer and which members)  
- Calculate membership cost depending on membership type  

---

## 🧩 OOP Breakdown

### Classes Needed

#### 1️⃣ Person (Base Class)
**Fields:**  
- Id  
- FullName  
- Age  

**Methods:**  
- DisplayInfo()  

---

#### 2️⃣ Member (Inherits from Person)
**Extra Fields:**  
- MembershipType (enum: Monthly, Quarterly, Yearly)  

**Properties:**  
- List<FitnessClass> RegisteredClasses  

**Methods:**  
- RegisterToClass(FitnessClass fitnessClass)  
- ShowRegisteredClasses()  

---

#### 3️⃣ Trainer (Inherits from Person)
**Fields:**  
- Specialization (e.g., "Cardio", "Yoga")  

**Properties:**  
- List<FitnessClass> AssignedClasses  

**Methods:**  
- AssignToClass(FitnessClass fitnessClass)  
- ShowAssignedClasses()  

---

#### 4️⃣ FitnessClass
**Fields:**  
- ClassName  
- Schedule  
- Trainer  
- List<Member> EnrolledMembers  

**Methods:**  
- AddMember(Member member)  
- ShowClassDetails()  

---

#### 5️⃣ FitnessCenter
**Holds Lists:**  
- List<Member> Members  
- List<Trainer> Trainers  
- List<FitnessClass> Classes  

**Methods:**  
- AddMember()  
- AddTrainer()  
- CreateClass()  
- AssignTrainerToClass()  
- RegisterMemberToClass()  
- ShowAllClasses()  

---

## 👨‍💻 Author
**Hussam Salim Al-Kathiri**  
📍 Salalah, Oman  
🔗 [LinkedIn Profile](https://www.linkedin.com/in/hussam-alkathiri)
