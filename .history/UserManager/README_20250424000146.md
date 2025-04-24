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
- CORS enabled for cross-origin frontend communication

---

## 📦 Features

- 🔄 Full CRUD functionality
- 🧩 Entity Framework Code-First with **Migrations**
- 🔐 Clean RESTful API structure
- ✅ Connected frontend + backend with real-time data updates
- 📚 Clean project architecture and modular design

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

## 📸 Screenshots

> 💡 Add screenshots of your landing page, user list, and form views here!

---

## 🧪 How to Run

### Backend (.NET API)

```bash
cd UserManagerAPI
dotnet ef database update
dotnet run
```

### Frontend (Vue)

```bash
cd user-manager-frontend
npm install
npm run dev
```

---

## ✨ What I Practiced and Learned

- Structuring a full-stack application using MVC and REST principles
- Setting up and managing a local database with EF Core + SQLite
- Building reusable Vue components and consuming APIs with Axios
- Managing routes and state in a Vue SPA
- Real-world practices in project modularity, CORS, and cross-stack communication

---

## 💼 Built for

This project was created as part of my preparation for a **Software Developer interview with SBS CyberSecurity**, showcasing my comfort with both frontend and backend tools commonly used in modern enterprise applications.

---

## 📧 Contact

**Antoine Gaton**
[Portfolio Website](https://www.antoinegaton.com) • [LinkedIn](https://www.linkedin.com/in/antoine-gaton/) • [GitHub](https://github.com/AntoineGaton)