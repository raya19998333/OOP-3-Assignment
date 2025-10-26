<h1 align="center">💼 OOP-3 Assignment — MakeenSalalah Repository</h1>

<p align="center">
  <img src="https://img.shields.io/badge/Language-C%23-blue?style=for-the-badge" alt="C#">
  <img src="https://img.shields.io/badge/Status-Completed-success?style=for-the-badge" alt="Status">
  <img src="https://img.shields.io/badge/Concepts-OOP%20Advanced-lightgrey?style=for-the-badge" alt="OOP">
  <img src="https://img.shields.io/badge/Author-Raya_Al_Amri-blueviolet?style=for-the-badge" alt="Author">
</p>

---

## 🗂️ Table of Contents
- [📋 Assignment Rules](#-assignment-rules)
- [🎫 Assignment 1 — Ticket Booking System](#-assignment-1--ticket-booking-system)
- [💻 Assignment 2 — Online Course Enrollment System](#-assignment-2--online-course-enrollment-system)
- [🏠 Assignment 3 — Smart Home Control Center](#-assignment-3--smart-home-control-center)
- [📚 Assignment 4 — Library System with Book Status Tracking](#-assignment-4--library-system-with-book-status-tracking)
- [📝 Assignment 5 — Task Tracker Application](#-assignment-5--task-tracker-application)
- [👩🏻‍💻 Author](#-author)

---

## 📋 Assignment Rules
> ⚠️ Please read before starting the assignments.

| # | Rule |
|---|------|
| 1️⃣ | 🔍 **SEARCH IS ALLOWED** |
| 2️⃣ | 🚫 **Copy-paste code without explanation = rejected** → for each rejected problem, solve **5 extra applications** |
| 3️⃣ | ❌ **USING CHATGPT IS NOT ALLOWED** |
| 4️⃣ | 💻 **Submit your C# code on GitHub** |
| 5️⃣ | 🧠 **THINK — USE PEN AND PAPER** before coding |

---

## ✅ Completion Status
All assignments in this repository are **Completed** and tested successfully.  
<img src="https://img.shields.io/badge/Completion-100%25-green?style=for-the-badge" alt="Completed">

---

## 🎫 Assignment 1 — Ticket Booking System  
**Concepts Used:** Enum, Indexer, Class, Encapsulation

📚 **Description:**  
Create a class `Ticket` with:
- EventName  
- SeatNumber  
- TicketType (Enum: Regular, VIP, Backstage)

Create a class `TicketSystem` that stores multiple `Ticket` objects in an array or list.

🧩 **Requirements:**
- Use an indexer to access tickets by seat number (e.g., `system["A12"]`)  
- Add method to count how many tickets are of each type  
- Demonstrate usage with at least 5 tickets and access them using the indexer

---

## 💻 Assignment 2 — Online Course Enrollment System  
**Concepts Used:** Enum, Indexer, List, OOP, Polymorphism

📚 **Description:**  
Create an enum `Level`: Beginner, Intermediate, Advanced  

Base class `Course`:
- Name, Instructor, Level  

Derived classes:
- `VideoCourse` → Duration in hours  
- `LiveSession` → DateTime Schedule  

Create a class `CourseCatalog` using an indexer to access courses by level:
- `catalog[Level.Beginner]` → returns all beginner-level courses

📘 Demonstrate adding courses and print details by level.

---

## 🏠 Assignment 3 — Smart Home Control Center  
**Concepts Used:** Interface, Indexer, Enum, Encapsulation

📚 **Description:**  
Create an enum `DeviceType`: Light, Fan, AC, Heater  

Interface `ISmartDevice`:
- `TurnOn()`  
- `TurnOff()`  
- `ShowStatus()`

Implement classes for each device type.  
Create a class `SmartHome` containing devices indexed by `DeviceType`:
- `home[DeviceType.Light]` → returns the Light object

📘 Demonstrate:
- Turning devices on/off using the indexer  
- Printing device status

---

## 📚 Assignment 4 — Library System with Book Status Tracking  
**Concepts Used:** Enum, Indexer, Class, List, OOP

📚 **Description:**  
Create an enum `BookStatus`: Available, CheckedOut, Reserved  

Class `Book`:
- Title, Author, Status (enum)  

Class `Library`:
- List of books  
- Indexer: `library["Book Title"]` → returns the `Book` object

🧩 **Methods:**
- `ChangeStatus(title, status)`  
- `ShowBooksByStatus(BookStatus status)`  

📘 Demonstrate:
- Adding at least 5 books  
- Accessing by title using the indexer  
- Filtering books by status

---

## 📝 Assignment 5 — Task Tracker Application  
**Concepts Used:** Enum, Indexer, Encapsulation, Collections

📚 **Description:**  
Create an enum `TaskPriority`: Low, Medium, High  

Class `Task`:
- Title, Description, Priority, IsCompleted  

Class `TaskList`:
- Internal list of tasks  
- Indexer to return all tasks of a specific priority (e.g., `list[TaskPriority.High]`)

🧩 **Methods:**
- `AddTask(Task)`  
- `MarkComplete(string taskTitle)`  
- `ShowAll()`  

📘 Demonstrate:
- Adding tasks  
- Using the indexer to list tasks by priority  
- Marking tasks as complete and showing results

---

## 👩🏻‍💻 Author
**Raya Al Amri**  
🎓 *Information Systems Graduate*  
💡 Passionate about OOP design, clean code, and modular systems  
📍 *University of Technology and Applied Sciences — Salalah*

---

<p align="center">
  <b>✨ “Organize your objects, master your code, and build real-world systems with OOP.” ✨</b>
</p>
