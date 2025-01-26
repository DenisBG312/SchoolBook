# 📚 SchoolBook: School Management System 

**🌐 A modern and comprehensive school management system designed for efficient management of academic, administrative, and student activities.**

---

### ✨ 1. Introduction

SchoolBook is a robust, user-friendly school management system designed to facilitate the administration of schools. With features for managing students, teachers, classes, assignments, exams, and attendance, it ensures smooth academic operations.

---

### 🌐 3. System Architecture

The application uses a layered architecture:
- 💪 **Backend-Framework**: ASP.NET Core (.NET 8)
- 🔨 **Entity Framework**:	Database management and ORM
- 🔢 **Database**: MSSQL Server
- 🔒 **Authentication**: ASP.NET Identity
- 📊 **Web API**: ASP.NET Core Web API

---

### 🔢 4. Database Diagram

![Database Diagram](https://github.com/DenisBG312/SchoolBook/blob/master/Project-Images/image.png)

---

### ⚙️ 5. Setup Instructions

#### Prerequisites
- 💻 .NET 8 SDK
- 🔐 MSSQL Serve
#### Steps
1. Clone the repository:
   ```bash
   git clone https://github.com/DenisBG312/schoolbook.git
   cd schoolbook
   ```

2. Configure the database connection in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Your-Database-Connection-String"
   }
   ```

3. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Open the application at `http://localhost:5000`.

---

### 🔧 6. Usage Guide

#### 🔒 Authentication
- **Admin**: Default admin credentials can be configured in the seed data.
- **Teacher/Student**: Accounts must be created by the admin.

#### 🎡 Key Actions
1. **📘 Admin Panel**: Manage users, classes, subjects, and assignments.
2. **👨‍🎓 Teacher Panel**: Create assignments, track attendance, and grade submissions.
3. **📚 Student Panel**: View assignments, submit work, and check grades.

---

### ✉️ 9. License

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

### 📧 10. Contact

For queries or support, contact:

- 📧 **Email**: denis.tsranski@gmail.com

