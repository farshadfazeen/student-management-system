# 🎓 Student Management System

A Windows-based Student Management System developed in **C# using Windows Forms and SQL Server** for the fictional **NexusPoint Academy** scenario.

The application provides a centralized interface for managing students, courses, course enrolments, and academic grades while demonstrating database connectivity, CRUD operations, event-driven programming, object-oriented concepts, validation, debugging, and structured application development.

---

## 🖥️ Application Preview

<table>
  <tr>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/31574484-8095-40e2-850e-04d8d93119aa" />
    </td>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/f4afd070-dfed-4625-8363-afef7252a802" />
    </td>
  </tr>
  <tr>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/9d562ee1-c6c0-49ae-b3d6-0340795926ea" />
    </td>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/78562ad0-de09-4ebf-aeee-b7e92a6728b8" />
    </td>
  </tr>
  <tr>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/1da93a4e-dd89-4ad3-80e3-e3638fd1dbd4" />
    </td>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/7bce5b76-8e9e-487a-bd8b-6d79d379a5c6" />
    </td>
  </tr>
  <tr>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/e89ce73c-cf77-4640-87f4-06cbb1d72d29" />
    </td>
    <td width="50%">
      <img width="100%" alt="Student Management System Preview" src="https://github.com/user-attachments/assets/bbd91807-ad02-44ed-a2d0-e4d3e2cdb840" />
    </td>
  </tr>
</table>

---

## 📌 Project Overview

NexusPoint Academy is an institution offering technology-related courses to students. The goal of this project was to develop a desktop application that could simplify the academy's day-to-day student administration.

The system provides separate modules for managing:

- Student information
- Available courses
- Student course enrolments
- Academic grades
- User authentication
- Navigation between the different areas of the application

The application was developed as part of a **Higher National Diploma in Computing – Programming project** and focuses on translating algorithms and system requirements into a functional Windows application.

---

## ✨ Main Features

### 👨‍🎓 Student Management

Users can:

- Add new students
- View registered students
- Search students using Student ID
- Update student information
- Delete student records
- Clear entered information

Student records include:

- Student ID
- Full Name
- Date of Birth
- Email Address
- Phone Number

---

### 📚 Course Management

The Course Management module allows users to:

- Add new courses
- View available courses
- Search by Course ID
- Update course information
- Delete courses
- Clear form data

Each course contains:

- Course ID
- Course Name
- Duration in weeks
- Course Fee

---

### 📝 Enrolment Management

The system supports course enrolment and allows a student to be associated with multiple courses.

Users can:

- Create new enrolments
- Select one or more courses
- View existing enrolments
- Search enrolments
- Update enrolment information
- Delete enrolments
- View available students
- View available courses

Enrolment information includes:

- Enrollment ID
- Student ID
- Course ID
- Enrollment Date

The application uses iteration to process multiple selected courses when a student is enrolled in more than one course.

---

### 🏆 Grading System

The Grades module allows academic results to be recorded against student enrolments.

Supported grade classifications include:

- Distinction
- Second Upper
- Second Lower
- Pass
- Resit

Users can:

- Add grades
- View all grades
- Search grades by Enrollment ID
- Update grades
- Delete grades
- View related courses
- View enrolment information

---

### 🔐 Login & Navigation

The application includes a simple authentication screen before users can access the management modules.

After successful login, the Main Menu provides navigation to:

- Student Management
- Course Management
- Enrollment Management
- Grades System

---

## 🔑 Demo Login

The application uses demonstration credentials for the academic project.

```text
Username: admin
Password: 123
```

> These are demonstration credentials only. The login implementation is intentionally simple and is not intended to represent production-level authentication.

---

## 🗄️ Database Design

The application uses **Microsoft SQL Server** to store and manage its data.

The main application uses four core tables:

| Table | Purpose |
|---|---|
| `Students` | Stores student information |
| `Courses` | Stores available course information |
| `Enrollments` | Links students with their selected courses |
| `Grades` | Stores grades associated with enrolments and courses |

The database design uses identifiers and relationships to maintain connections between students, courses, enrolments, and grades.

A composite-key approach was used where necessary to support students being associated with multiple courses without creating conflicting records.

---

## ⚙️ CRUD Operations

The application demonstrates full CRUD functionality throughout the major management modules.

| Operation | Description |
|---|---|
| **Create** | Add students, courses, enrolments, and grades |
| **Read** | Display stored records using DataGridView |
| **Update** | Modify existing records |
| **Delete** | Remove selected records |
| **Search** | Retrieve specific information using IDs |

SQL commands such as `INSERT`, `SELECT`, `UPDATE`, and `DELETE` are executed from the C# application to interact with the database.

---

## 🧰 Technologies Used

| Technology | Usage |
|---|---|
| **C#** | Main programming language |
| **Windows Forms** | Desktop graphical user interface |
| **.NET Framework 4.8** | Application framework |
| **Microsoft SQL Server** | Relational database |
| **SQL** | Database querying and CRUD operations |
| **Visual Studio 2022** | Application development and debugging |
| **SQL Server Management Studio (SSMS)** | Database creation and management |

---

## 🧠 Programming Concepts Demonstrated

The project applies several programming concepts, including:

### Object-Oriented Programming

The application is divided into separate forms/classes, with each part responsible for a particular area of the system.

Examples include:

```text
Login
MainMenu
StudentManagement
CourseManagement
EnrollManagement
GradesSystem
```

This separation helps keep the application modular and easier to understand.

### Event-Driven Programming

Windows Forms controls such as buttons trigger C# event handlers.

Examples include:

```text
Login button clicked
Insert button clicked
Search button clicked
Update button clicked
Delete button clicked
```

Each event performs a specific action based on user interaction.

### Procedural Logic

Individual methods follow step-by-step procedures for operations such as:

```text
Receive input
→ Validate data
→ Connect to database
→ Execute SQL command
→ Display result
```

---

## 🔄 Application Flow

```text
Login
  │
  ▼
Main Menu
  │
  ├──► Student Management
  │
  ├──► Course Management
  │
  ├──► Enrollment Management
  │
  └──► Grades System
```

Each management module provides access to its relevant database operations and allows the user to return to the Main Menu.

---

## 🛡️ Error Handling & Validation

The application includes basic validation and exception handling to improve reliability.

Examples include:

- Login credential validation
- Missing-field checks
- Course ID validation
- Student ID searches
- Database operation error handling
- `try-catch` blocks around selected SQL operations
- User feedback through message boxes

Exception handling helps prevent database or input errors from immediately terminating the application.

---

## 🧪 Testing

The system was tested primarily through **manual functional testing** and **black-box testing**.

Testing focused on:

- Valid and invalid login attempts
- Navigation between forms
- Adding student records
- Searching student records
- Updating records
- Deleting records
- Creating courses
- Multiple-course enrolment
- Recording grades
- Updating grades
- Input validation
- Clear buttons
- Database consistency

### Example Test Cases

| Test | Expected Result |
|---|---|
| Login using valid credentials | Main Menu opens |
| Login using invalid credentials | Error message displayed |
| Insert a complete student record | Student is saved and displayed |
| Search using an existing Student ID | Matching student is displayed |
| Update student information | Existing record is updated |
| Delete a student | Student is removed |
| Insert a course | Course is stored and displayed |
| Enrol a student into multiple courses | All selected enrolments are saved |
| Add a grade | Grade is stored and displayed |
| Update a grade | Grade record is updated |

The academic test scope focused on application functionality rather than performance, load, or advanced security testing.

---

## 🐞 Debugging & Code Quality

During development, Visual Studio debugging tools were used to investigate application behaviour and identify errors.

This included:

- Breakpoints
- Variable inspection
- Step-by-step execution
- Output/Debug windows
- Exception inspection
- Call Stack analysis

The project also applies basic coding standards such as:

- Meaningful variable and method names
- PascalCase and camelCase naming conventions
- Short and focused methods
- Code comments where useful
- Consistent indentation
- Exception handling
- Modular form organization

---

## 💡 Development Challenges

Some of the main challenges encountered while developing the application included:

### Handling Date Inputs

Dates entered through text fields needed a consistent format before being stored in SQL Server.

### Multiple Course Enrolments

The enrolment module needed to process more than one selected course.

A `foreach` loop was used to iterate through selected courses and process each enrolment.

### Grade Representation

Grades were represented as readable text values such as `Distinction` and `Pass` rather than numeric codes, making the stored data and user interface easier to understand.

### Database Relationships

Supporting multiple-course enrolment required careful handling of identifiers and database relationships to avoid duplicate or conflicting records.

### Runtime Errors

Database operations and invalid input could create runtime exceptions, so error handling was added using `try-catch` blocks.

---

## 🚀 Running the Project

### Requirements

To run the original application locally, you will need:

- Windows
- Visual Studio with C# desktop development support
- .NET Framework 4.8
- Microsoft SQL Server
- SQL Server Management Studio

### General Setup

1. Clone the repository:

```bash
git clone https://github.com/farshadfazeen/student-management-system.git
```

2. Open the solution/project in Visual Studio.

3. Configure a local SQL Server database for the application.

4. Update the application's database connection settings if required for your environment.

5. Build the application.

6. Run the Windows Forms project.

7. Log in using the demo credentials:

```text
Username: admin
Password: 123
```

> Database/server configuration may need to be adjusted because the original project was developed using a local SQL Server environment.

---

## ⚠️ Project Scope

This project was developed as an academic Windows desktop application and demonstrates the fundamental implementation of a database-driven management system.

The authentication mechanism uses simple demonstration credentials and should not be considered production-ready security.

Potential future improvements could include:

- Database-backed user authentication
- Password hashing
- User roles and permissions
- Improved input validation
- More secure database configuration
- Advanced reporting
- Automated testing
- Modernized interface design
- Deployment packaging
- Additional student progress and reporting features

---

## 🎯 What I Learned

This project helped strengthen practical experience in:

- C# application development
- Windows Forms
- SQL Server integration
- CRUD operations
- Database relationships
- Event-driven programming
- Object-oriented application structure
- Algorithm design
- Input validation
- Exception handling
- Debugging
- Application testing
- Converting system requirements into working software

---

## 🎓 Academic Context

This project was developed for the **Programming** unit of a **Higher National Diploma in Computing**.

The project scenario required the development of a Windows-based Student Management System for **NexusPoint Academy**, covering algorithm design, programming paradigms, implementation using an IDE, debugging, and coding standards.

---

## 👤 Developer

**M Farshad**

Software Developer  
Colombo, Sri Lanka

GitHub: [@farshadfazeen](https://github.com/farshadfazeen)

---

## 📄 Note

This repository is maintained as part of my software development portfolio and demonstrates my academic and practical experience with C#, Windows Forms, SQL, database-driven applications, and structured software development.
