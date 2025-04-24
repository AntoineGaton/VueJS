<script setup>
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
</script>

<template>
  <div class="app-container">
    <div class="left-section">
      <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="125" height="125" />

      <div class="wrapper">
        <HelloWorld msg="Welcome to the User Manager Application" />

        <nav>
          <RouterLink to="/users">Users</RouterLink>
          <RouterLink to="/create-user">Create User</RouterLink>
        </nav>
      </div>
    </div>

    <div class="vertical-divider">
      <div class="pulse-line-vertical"></div>
    </div>

    <div class="right-section">
      <RouterView />
    </div>
  </div>
</template>

<style>
#app {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  width: 100%;
}

.app-container {
  display: flex;
  justify-content: center;
  align-items: center;
  gap: 2rem;
  padding: 2rem;
}

.left-section,
.right-section {
  flex: 1;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}

.vertical-divider {
  position: relative;
  width: 2px;
  height: 400px;
  overflow: hidden;
}

.pulse-line-vertical {
  position: absolute;
  width: 100%;
  height: 100%;
  background: #42b883;
  box-shadow:
    0 0 10px #42b883,
    0 0 20px #42b883,
    0 0 30px #42b883;
  animation: neonPulse 2s ease-in-out infinite;
}

@keyframes neonPulse {
  0% {
    opacity: 0.7;
  }
  50% {
    opacity: 1;
    box-shadow:
      0 0 15px #42b883,
      0 0 25px #42b883,
      0 0 35px #42b883;
  }
  100% {
    opacity: 0.7;
  }
}

.logo {
  display: block;
  margin: 0 auto 2rem;
}

nav {
  width: auto;
  font-size: 12px;
  text-align: center;
  margin-top: 2rem;
  display: flex;
  gap: 1rem;
  display: flex;
  justify-content: center;
}

nav a.router-link-exact-active {
  color: var(--color-text);
  font-weight: bold;
}

nav a {
  display: inline-block;
  padding: 0.5rem 1rem;
  border-radius: 4px;
  text-decoration: none;
  transition: background-color 0.2s;
}

nav a:hover {
  background-color: var(--color-background-soft);
}

@media (max-width: 768px) {
  .app-container {
    flex-direction: column;
    align-items: center;
    min-height: auto;
  }

  .vertical-divider {
    width: 80%;
    height: 2px;
    margin: 1rem 0;
  }

  .pulse-line-vertical {
    background: #42b883;
    box-shadow:
      0 0 10px #42b883,
      0 0 20px #42b883,
      0 0 30px #42b883;
    animation: neonPulse 2s ease-in-out infinite;
  }
}
</style>
