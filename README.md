# Student & School Management Web App (.NET MVC)  
 
This is a web-based CRUD application developed during my internship using **ASP.NET MVC (Model-View-Controller)** framework and connected to a **SQL Server (SSMS)** backend. 
The project was built during the first week of the internship and demonstrates a solid understanding of relational database integration, MVC architecture, and user interface implementation in a full-stack .NET environment.

## 🔧 Technologies Used

- **ASP.NET MVC 5**
- **C#**
- **SQL Server Management Studio (SSMS)**
- **Entity Framework (Code First)**
- **Razor Views**
- **Bootstrap (via layout view)**


## 📌 Project Overview

The project models a basic **student and school management system**, with the following key features:

- Two core tables: `Students` and `Schools`
- Each student is associated with a school **(via foreign key relationship)**
- Fully functional **CRUD operations** (Create, Read, Update, Delete) on the Students table
- A static listing of 5 schools in the Schools table
- Seamless dropdown integration in Create/Edit views to select the school for a student
- Structured navigation between modules via the **navbar menu**

---

## 📂 Database Structure

### `Schools` Table

| Column Name  | Type     | Description             |
|--------------|----------|-------------------------|
| SchoolID     | int      | Primary Key             |
| SchoolName   | string   | Name of the school      |

### `Students` Table

| Column Name  | Type     | Description                         |
|--------------|----------|-------------------------------------|
| StudentID    | int      | Primary Key                         |
| Name         | string   | Name of the student                 |
| Age          | int      | Student's age                       |
| Email Id     | int      | Student's email id                  |
| Phone Number | int      | Student's phone number              |
| SchoolID     | int      | Foreign Key referencing `Schools`   |



---



## 🧭 Navigation Flow

- **Home Page**: Central landing page with a menu dropdown and interactive buttons for both pages
- **Menu > Students**: Displays the complete list of students along with their associated school details
- **Menu > Schools**: Lists 5 predefined schools

## 📸 Screenshots



### Home Page with Navigation

![Home Page](screenshots/homepage.png)


### Students Index Page (List View)

![Students Page](screenshots/students_index.png)


### Student Create Page with School Dropdown

![Create Student](screenshots/create_student.png)

---

## ✅ Key Features Implemented

- MVC pattern adherence with clear separation of concerns
- Relational database modeling with foreign key constraint
- Entity Framework integration for DB operations
- Dropdown binding from Schools table
- Server-side validation and clean form UI
- Bootstrap-styled layout for responsiveness


## 📁 Folder Structure Highlights
/MyApp  
├── Controllers  
│ ├── HomeController.cs  
│ └── ItemsController.cs  
├── Data  
│ ├── MyAppContext.cs  
├── Views  
│ ├── Home/  
│ ├── Items/  
│ └── Shared/  
│ └── _Layout.cshtml  
├── appsettings.json  
├── Program.cs  
└── MyApp.sln  

---

## 🛡️ Notes

- Sensitive files such as `web.config` have been excluded from version control via `.gitignore`
- Database connection string uses company credentials and is **not** exposed in this repository


## 📈 Future Improvements (Optional Ideas)

- Add search/filter functionality to the Students list
- Implement pagination for large data sets
- Add authentication for admin access to CRUD operations
- Replace static school list with full CRUD management


## 📬 Contact

Built by **Rakshit Bansal** as part of internship training in .NET technologies. For more details, feel free to connect or reach out.

---


