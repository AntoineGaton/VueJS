import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import CreateUserView from '../views/CreateUserView.vue'
import UpdateUserView from '../views/UpdateUserView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      redirect: '/users',
    },
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
    {
      path: '/update-user/:id',
      name: 'update-user',
      component: UpdateUserView,
      props: true,
    },
  ],
})

export default router
