// main.js - Entry point of the Vue.js application
// This file initializes the Vue application and sets up global configurations

// Import global styles
import './assets/main.css'

// Import Vue core functions and components
import { createApp } from 'vue' // Vue 3's createApp function
import App from './App.vue' // Root component
import router from './router' // Vue Router configuration

// Create the Vue application instance
// This is the starting point of your Vue application
const app = createApp(App)

// Use Vue Router for client-side navigation
// This enables the routing functionality throughout the app
app.use(router)

// Mount the application to the DOM element with id="app"
// This is where your Vue application will be rendered
app.mount('#app')
