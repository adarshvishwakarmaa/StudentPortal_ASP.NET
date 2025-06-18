# Student Portal – ASP.NET Core MVC CRUD Application

This is a basic ASP.NET Core MVC project named **Student Portal**. It performs complete **CRUD operations (Create, Read, Update, Delete)** using **Entity Framework Core** with a **single model (Student)**.

---

## 📚 Features

- Display list of students (Index)
- Add a new student (Create)
- Edit student details (Edit)
- View student details (Details)
- Delete a student (Delete)

---

## 💡 Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server (or localdb)
- Razor Views
- Bootstrap (optional for UI styling)

---

## 🧩 Model – `Student.cs`

```csharp
public class Student
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    public string Phone { get; set; }

    public bool IsPresent { get; set; }
}
