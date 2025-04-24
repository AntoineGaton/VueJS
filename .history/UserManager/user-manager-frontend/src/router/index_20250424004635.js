// router/index.js - Vue Router configuration
// This file defines the routes and navigation structure of the application

import { createRouter, createWebHistory } from 'vue-router'
// Import view components for each route
import HomeView from '../views/HomeView.vue'
import CreateUserView from '../views/CreateUserView.vue'
import UpdateUserView from '../views/UpdateUserView.vue'

// Create the router instance
// createWebHistory enables HTML5 History mode for clean URLs
const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  // Define the application routes
  routes: [
    {
      path: '/',
      redirect: '/users', // Redirect root path to users list
    },
    {
      path: '/users',
      name: 'users', // Named route for programmatic navigation
      component: HomeView, // Component to render for this route
    },
    {
      path: '/create-user',
      name: 'create-user',
      component: CreateUserView,
    },
    {
      path: '/update-user/:id', // Dynamic route with parameter
      name: 'update-user',
      component: UpdateUserView,
      props: true, // Enable passing route params as props
    },
  ],
})

// Export the router instance
export default router
