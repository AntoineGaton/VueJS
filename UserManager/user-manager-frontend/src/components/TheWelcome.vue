<script>
import { getUsers, deleteUser } from '../services/userService'

export default {
  data() {
    return {
      users: [],
    }
  },
  async created() {
    try {
      this.users = await getUsers()
      console.log('Fetched users:', this.users) // Add logging to debug
    } catch (error) {
      console.error('Error fetching users:', error)
    }
  },
  methods: {
    async handleDelete(id) {
      if (confirm('Are you sure you want to delete this user?')) {
        try {
          await deleteUser(id)
          this.users = this.users.filter((user) => user.id !== id)
        } catch (error) {
          console.error('Error deleting user:', error)
        }
      }
    },
  },
}
</script>

<template>
  <div class="users-container">
    <h2 style="text-align: center; font-size: 2rem; font-weight: bold">User List</h2>
    <div class="users-list">
      <ul v-if="users.length">
        <template v-for="(user, index) in users" :key="user.id">
          <li class="user-item">
            <div class="user-info">
              <p>Name: {{ user.username }}</p>
              <p>Email: {{ user.email }}</p>
              <p v-if="user.isActive">isActive: <span style="color: green">Active</span></p>
              <p v-else>isActive: <span style="color: red">Inactive</span></p>
            </div>
            <div class="user-actions">
              <RouterLink :to="'/update-user/' + user.id" class="edit-link">Edit</RouterLink>
              <button @click="handleDelete(user.id)" class="delete-btn">Delete</button>
            </div>
          </li>
          <div v-if="index < users.length - 1" class="animated-divider">
            <div class="pulse-line"></div>
          </div>
        </template>
      </ul>
      <p v-else>No users found</p>
    </div>
  </div>
</template>

<style scoped>
.users-container {
  max-width: 800px;
  margin: 0 auto;
  padding: 1rem;
}

.users-list {
  margin-top: 1rem;
}

.user-item {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem;
  margin-bottom: 0.5rem;
  gap: 1rem;
}

.user-info {
  flex: 1;
  padding-right: 1rem;
}

.vertical-divider {
  position: relative;
  width: 2px;
  align-self: stretch;
  overflow: hidden;
}

.pulse-line-vertical {
  position: absolute;
  width: 100%;
  height: 100%;
  background: linear-gradient(180deg, transparent, #42b883, transparent);
  animation: pulseVertical 2s ease-in-out infinite;
}

.user-actions {
  display: flex;
  gap: 1rem;
  padding-left: 1rem;
  min-width: 140px;
}

.edit-link {
  color: var(--color-text);
  text-decoration: none;
  padding: 0.25rem 0.5rem;
  border-radius: 4px;
  background-color: #4caf50;
  color: white;
}

.edit-link:hover {
  background-color: #45a049;
}

.delete-btn {
  background-color: #ff4444;
  color: white;
  border: none;
  padding: 0.25rem 0.5rem;
  border-radius: 4px;
  cursor: pointer;
}

.delete-btn:hover {
  background-color: #cc0000;
}

h2 {
  color: var(--color-heading);
  font-size: 1.5rem;
  margin-bottom: 1rem;
}

ul {
  list-style: none;
  padding: 0;
  margin: 0;
}

.animated-divider {
  position: relative;
  height: 2px;
  margin: 0.5rem 0;
  overflow: hidden;
}

.pulse-line {
  position: absolute;
  width: 100%;
  height: 100%;
  background: linear-gradient(90deg, transparent, #42b883, transparent);
  animation: pulseHorizontal 2s ease-in-out infinite;
}

@keyframes pulseHorizontal {
  0% {
    opacity: 0.3;
    transform: translateX(-100%);
  }
  50% {
    opacity: 1;
  }
  100% {
    opacity: 0.3;
    transform: translateX(100%);
  }
}

@keyframes pulseVertical {
  0% {
    opacity: 0.3;
    transform: translateY(-100%);
  }
  50% {
    opacity: 1;
  }
  100% {
    opacity: 0.3;
    transform: translateY(100%);
  }
}
</style>
