# 🧑‍💻 User Manager App

A full-stack CRUD application built to showcase and practice my skills in **Vue 3**, **Axios**, and **ASP.NET Core Web API** with **Entity Framework Core** and **SQLite**.

---

## 🚀 Overview

The User Manager App is a full-stack application that allows users to:

- View a list of all users
- Add new users
- Edit existing user details
- Delete users

This app demonstrates a complete understanding of modern frontend development using Vue.js and backend API development using .NET Core, with secure and scalable database interactions using EF Core and SQLite.

---

## 🧱 Tech Stack

### 🔹 Frontend

- [Vue 3](https://vuejs.org/) with Composition API
- [Vue Router](https://router.vuejs.org/) for client-side navigation
- [Axios](https://axios-http.com/) for HTTP requests
- [Prettier](https://prettier.io/) + [ESLint](https://eslint.org/) for code consistency

### 🔹 Backend

- [.NET 6 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/)
- [SQLite](https://www.sqlite.org/index.html) for local database
- [Swagger/OpenAPI](https://swagger.io/) for API documentation and testing
- CORS enabled for cross-origin frontend communication

---

## 📦 Features

- 🔄 Full CRUD functionality
- 🧩 Entity Framework Code-First with **Migrations**
- 🔐 Clean RESTful API structure
- ✅ Connected frontend + backend with real-time data updates
- 📚 Clean project architecture and modular design
- 📝 Interactive API documentation with Swagger UI
- 🧪 API testing capabilities through Swagger interface

---

## 📂 Folder Structure

```
user-manager-app/
│
├── UserManagerAPI/                  # .NET Core backend
│   ├── Controllers/                 # API routes
│   ├── Data/                        # DbContext
│   ├── Models/                      # User model
│   ├── Migrations/                  # EF Core migrations
│
└── user-manager-frontend/          # Vue 3 frontend
    ├── components/                 # Reusable UI components
    ├── views/                      # Pages (UserList, Create, Edit)
    ├── services/                   # Axios API layer
    ├── router/                     # SPA routing
```

---

## 🧪 How to Run

### Backend (.NET API)

1. Navigate to the backend directory:

```bash
cd UserManagerAPI
```

2. Update the database with the latest migrations:

```bash
dotnet ef database update
```

3. Run the API:

```bash
dotnet run
```

4. Access Swagger UI:

- Open your browser and navigate to `https://localhost:5001/swagger` or `http://localhost:5000/swagger`
- The Swagger UI provides interactive documentation and testing capabilities for all API endpoints
- You can test each endpoint directly from the Swagger interface

### Frontend (Vue)

1. Navigate to the frontend directory:

```bash
cd user-manager-frontend
```

2. Install dependencies:

```bash
npm install
```

3. Start the development server:

```bash
npm run dev
```

4. Access the application:

- Open your browser and navigate to `http://localhost:5173` (or the URL shown in your terminal)

---

## 🔍 API Testing with Swagger

The application includes Swagger UI for easy API testing and documentation:

1. After starting the backend server, visit the Swagger UI at `https://localhost:5001/swagger`
2. You'll see a list of all available API endpoints
3. Click on any endpoint to expand its details
4. Use the "Try it out" button to test the endpoint
5. Fill in the required parameters and click "Execute"
6. View the response and status code

Example API endpoints available in Swagger:

- GET /api/Users - List all users
- POST /api/Users - Create a new user
- GET /api/Users/{id} - Get a specific user
- PUT /api/Users/{id} - Update a user
- DELETE /api/Users/{id} - Delete a user

---

## 📚 Educational Guide: Understanding the Codebase

This section explains the architecture and flow of the application, making it easier for students to understand MVC, APIs, databases, .NET, and Entity Framework concepts.

### 🏗️ Architecture Overview

The application follows a three-tier architecture:

1. **Presentation Layer (Frontend - Vue.js)**

   - Handles user interface and user interactions
   - Communicates with the backend through HTTP requests
   - Uses Vue 3's Composition API for reactive state management
   - Implements client-side routing with Vue Router

2. **Application Layer (Backend - .NET Web API)**

   - Implements the RESTful API endpoints
   - Handles business logic and data validation
   - Uses Controllers to process HTTP requests
   - Implements the MVC (Model-View-Controller) pattern

3. **Data Layer (Entity Framework + SQLite)**
   - Manages database operations
   - Uses Entity Framework Core for ORM (Object-Relational Mapping)
   - Implements database migrations for schema changes
   - Handles data persistence and retrieval

### 🔄 Data Flow

1. **Frontend to Backend Communication**

   ```
   Vue Component → Axios Service → .NET Controller → Database
   ```

   - Vue components make HTTP requests using Axios
   - Requests are sent to specific API endpoints
   - Controllers process these requests
   - Entity Framework handles database operations

2. **Backend to Frontend Communication**
   ```
   Database → Entity Framework → Controller → Axios → Vue Component
   ```
   - Database returns data through Entity Framework
   - Controllers format the data
   - Data is sent back to the frontend
   - Vue components update the UI reactively

### 📦 Key Components Explained

#### 1. Models (Data Structure)

```csharp
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    // Other properties
}
```

- Define the structure of your data
- Represent database tables
- Used by Entity Framework for database operations

#### 2. Controllers (Request Handling)

```csharp
[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }
}
```

- Handle HTTP requests (GET, POST, PUT, DELETE)
- Process business logic
- Return appropriate HTTP responses

#### 3. DbContext (Database Operations)

```csharp
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
}
```

- Manages database connections
- Provides access to database tables
- Handles CRUD operations

#### 4. Frontend Components (Vue.js)

```vue
<template>
  <div>
    <h1>User List</h1>
    <ul>
      <li v-for="user in users" :key="user.id">
        {{ user.name }}
      </li>
    </ul>
  </div>
</template>

<script setup>
import { ref, onMounted } from "vue";
import axios from "axios";

const users = ref([]);

onMounted(async () => {
  const response = await axios.get("/api/users");
  users.value = response.data;
});
</script>
```

- Display data to users
- Handle user interactions
- Make API requests
- Update UI reactively

### 🛠️ Entity Framework Core Concepts

1. **Migrations**

   - Track changes to your database schema
   - Create and update database tables
   - Maintain database version control

2. **LINQ Queries**

   - Write database queries using C# syntax
   - Filter, sort, and transform data
   - Example: `_context.Users.Where(u => u.Age > 18).ToList()`

3. **Relationships**
   - Define relationships between entities
   - One-to-many, many-to-many relationships
   - Automatic foreign key handling

### 🔐 Security Considerations

1. **CORS (Cross-Origin Resource Sharing)**

   - Configured in `Program.cs`
   - Allows frontend to communicate with backend
   - Specifies allowed origins and methods

2. **Data Validation**
   - Input validation in controllers
   - Model validation using data annotations
   - Error handling and proper HTTP responses

### 📝 Learning Resources

- [Vue 3 Documentation](https://vuejs.org/guide/introduction.html)
- [.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [REST API Best Practices](https://restfulapi.net/)
- [MVC Pattern Explanation](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview)

---

## ✨ What I Achieved

- Built a complete full-stack application with Vue 3 frontend and .NET Core backend
- Implemented a clean RESTful API architecture
- Set up Entity Framework Core with SQLite for data persistence
- Created a user-friendly frontend with Vue 3 and Composition API
- Integrated Swagger for API documentation and testing
- Implemented proper CORS configuration for frontend-backend communication
- Developed a modular and maintainable codebase
- Successfully implemented all CRUD operations
- Created a responsive and intuitive user interface

---

## 💼 Built for

This project was created as part of my preparation for a **Software Developer interview with SBS CyberSecurity**, showcasing my comfort with both frontend and backend tools commonly used in modern enterprise applications.

---

## 📧 Contact

**Antoine Gaton**
[Portfolio Website](https://www.antoinegaton.com) • [LinkedIn](https://www.linkedin.com/in/antoine-gaton/) • [GitHub](https://github.com/AntoineGaton)
