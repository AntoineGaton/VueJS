# 🎨 User Manager Frontend

A modern Vue 3 application built with Vite, showcasing a clean and responsive user interface for managing users. This frontend application communicates with a .NET Core Web API backend.

## 🚀 Features

- **Modern Vue 3 Architecture**

  - Composition API
  - Single File Components (SFC)
  - Reactive State Management
  - TypeScript Support

- **Routing & Navigation**

  - Vue Router for client-side routing
  - Dynamic route parameters
  - Programmatic navigation
  - Route guards and navigation hooks

- **API Integration**

  - Axios for HTTP requests
  - Centralized API service layer
  - Error handling and response interceptors
  - Clean separation of concerns

- **UI/UX Features**
  - Responsive design
  - Modern animations
  - Clean and intuitive navigation
  - Loading states and error handling

## 🛠️ Tech Stack

- [Vue 3](https://vuejs.org/) - Progressive JavaScript Framework
- [Vite](https://vitejs.dev/) - Next Generation Frontend Tooling
- [Vue Router](https://router.vuejs.org/) - Official Router for Vue.js
- [Axios](https://axios-http.com/) - Promise-based HTTP client
- [ESLint](https://eslint.org/) - Pluggable JavaScript linter
- [Prettier](https://prettier.io/) - Code formatter

## 📁 Project Structure

```
user-manager-frontend/
├── src/
│   ├── assets/         # Static assets (images, styles)
│   ├── components/     # Reusable Vue components
│   ├── views/          # Page components
│   ├── services/       # API service layer
│   ├── router/         # Vue Router configuration
│   ├── App.vue         # Root component
│   └── main.js         # Application entry point
├── public/             # Public static assets
└── package.json        # Project dependencies
```

## 🚀 Getting Started

### Prerequisites

- Node.js (v16 or higher)
- npm or yarn

### Installation

1. Clone the repository
2. Install dependencies:

```sh
npm install
```

### Development

Start the development server:

```sh
npm run dev
```

The application will be available at `http://localhost:5173`

### Production Build

Create a production build:

```sh
npm run build
```

The build output will be in the `dist` directory.

## 🧪 Testing

Run the linter:

```sh
npm run lint
```

## 🔧 Configuration

### Environment Variables

Create a `.env` file in the root directory:

```env
VITE_API_BASE_URL=http://localhost:5000
```

### Vite Configuration

See [vite.config.js](vite.config.js) for build and development server configuration.

## 📚 Key Components

### API Service Layer

The application uses a centralized service layer for API calls:

```javascript
// services/userService.js
export const getUsers = async () => {
  try {
    const response = await api.get('/Users')
    return response.data
  } catch (error) {
    console.error('Error fetching users:', error)
    throw error
  }
}
```

### Routing

Routes are defined in `router/index.js`:

```javascript
const routes = [
  {
    path: '/users',
    name: 'users',
    component: HomeView,
  },
  {
    path: '/create-user',
    name: 'create-user',
    component: CreateUserView,
  },
]
```

## 🎨 UI Components

The application features several reusable components:

- Navigation bar
- User list
- User form
- Loading spinner
- Error messages

## 🔐 Security

- CORS configuration for API communication
- Input validation
- Error handling
- Secure HTTP requests

## 📱 Responsive Design

The application is fully responsive and works on:

- Desktop
- Tablet
- Mobile devices

## 🛠️ Development Tools

- [VSCode](https://code.visualstudio.com/) - Recommended IDE
- [Volar](https://marketplace.visualstudio.com/items?itemName=Vue.volar) - Vue 3 extension
- [Vue DevTools](https://devtools.vuejs.org/) - Browser extension for debugging

## 📝 Best Practices

- Component-based architecture
- Single Responsibility Principle
- DRY (Don't Repeat Yourself)
- Clean and maintainable code
- Proper error handling
- Responsive design principles
