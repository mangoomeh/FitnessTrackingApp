# 🏋️‍♂️ Fitness Tracker MVC App

A lightweight fitness tracking web application built with C# using the ASP.NET MVC framework. This app allows users to log workouts, track progress, and visualize their activity history — all with a simple and intuitive interface.

## 🚀 Features

- Log and view workout sessions
- Track exercise types, duration, and notes
- Responsive and clean Razor views
- Secure API integration for data handling
- SQLite-backed persistence
- MVC architecture with conventional routing
- Dynamic delete confirmation (JavaScript-enhanced UI)

## 🛠 Technologies Used

| Tech           | Description                                    |
|----------------|------------------------------------------------|
| ASP.NET MVC    | Main framework for structuring the application |
| C#             | Backend logic and controllers                  |
| Razor Views    | Server-side rendering of user interface        |
| SQLite         | Lightweight database for storing workout data  |
| JavaScript     | Enhancing UI with interactive behaviors        |
| Bootstrap      | Optional styling for responsive design         |

## 🧱 Architecture Overview

- **Model**: Workout records, fitness data objects
- **View**: Razor templates with Tag Helpers
- **Controller**: Handles HTTP requests (GET/POST/DELETE)
- **Routing**: Convention-based routing mapped to controllers/actions
- **Database**: Integrated with SQLite for local persistence