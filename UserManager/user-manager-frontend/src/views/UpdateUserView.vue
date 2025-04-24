<script>
import { getUserById, updateUser } from '../services/userService'

export default {
  data() {
    return {
      user: {
        id: null,
        username: '',
        email: '',
        isActive: true,
      },
    }
  },
  async created() {
    const userId = this.$route.params.id
    try {
      this.user = await getUserById(userId)
    } catch (error) {
      console.error('Error fetching user:', error)
    }
  },
  methods: {
    async handleSubmit() {
      try {
        await updateUser(this.user.id, this.user)
        this.$router.push('/users')
      } catch (error) {
        console.error('Error updating user:', error)
      }
    },
  },
}
</script>

<template>
  <div class="form-container">
    <h2>Update User</h2>
    <form @submit.prevent="handleSubmit" class="user-form">
      <div class="form-group">
        <label for="username">Username</label>
        <input type="text" id="username" v-model="user.username" required class="form-input" />
      </div>
      <div class="form-group">
        <label for="email">Email</label>
        <input type="email" id="email" v-model="user.email" required class="form-input" />
      </div>
      <div class="form-group">
        <label>
          <input type="checkbox" v-model="user.isActive" />
          Active
        </label>
      </div>
      <button type="submit" class="submit-btn">Update User</button>
    </form>
  </div>
</template>

<style scoped>
.form-container {
  max-width: 500px;
  margin: 0 auto;
  padding: 2rem;
}

.user-form {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}

.form-group {
  display: flex;
  flex-direction: column;
  gap: 0.5rem;
}

.form-input {
  padding: 0.5rem;
  border: 1px solid var(--color-border);
  border-radius: 4px;
}

.submit-btn {
  background-color: var(--color-text);
  color: white;
  padding: 0.5rem 1rem;
  border: none;
  border-radius: 4px;
  cursor: pointer;
  margin-top: 1rem;
}

.submit-btn:hover {
  opacity: 0.9;
}
</style>
