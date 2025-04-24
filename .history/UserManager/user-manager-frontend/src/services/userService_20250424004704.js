// services/userService.js - API Service Layer
// This file contains functions for interacting with the User API
// Uses Axios for HTTP requests (configured in api.js)

import api from './api'

/**
 * Fetches all users from the API
 * @returns {Promise<Array>} Array of user objects
 * @throws {Error} If the API request fails
 */
export const getUsers = async () => {
  try {
    const response = await api.get('/Users')
    return response.data
  } catch (error) {
    console.error('Error fetching users:', error)
    throw error
  }
}

/**
 * Fetches a single user by ID
 * @param {number} id - The ID of the user to fetch
 * @returns {Promise<Object>} User object
 * @throws {Error} If the API request fails
 */
export const getUserById = async (id) => {
  try {
    const response = await api.get(`/Users/${id}`)
    return response.data
  } catch (error) {
    console.error('Error fetching user by id:', error)
    throw error
  }
}

/**
 * Creates a new user
 * @param {Object} user - The user object to create
 * @returns {Promise<Object>} The created user object
 * @throws {Error} If the API request fails
 */
export const createUser = async (user) => {
  try {
    const response = await api.post('/Users', user)
    return response.data
  } catch (error) {
    console.error('Error creating user:', error)
    throw error
  }
}

/**
 * Updates an existing user
 * @param {number} id - The ID of the user to update
 * @param {Object} user - The updated user data
 * @returns {Promise<Object>} The updated user object
 * @throws {Error} If the API request fails
 */
export const updateUser = async (id, user) => {
  try {
    const response = await api.put(`/Users/${id}`, user)
    return response.data
  } catch (error) {
    console.error('Error updating user:', error)
    throw error
  }
}

/**
 * Deletes a user
 * @param {number} id - The ID of the user to delete
 * @returns {Promise<void>}
 * @throws {Error} If the API request fails
 */
export const deleteUser = async (id) => {
  try {
    const response = await api.delete(`/Users/${id}`)
    return response.data
  } catch (error) {
    console.error('Error deleting user:', error)
    throw error
  }
}
