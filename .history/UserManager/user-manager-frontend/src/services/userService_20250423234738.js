import api from './api'

// This is used to get all users
export const getUsers = async () => {
  try {
    const response = await api.get('/Users')
    return response.data
  } catch (error) {
    console.error('Error fetching users:', error)
    throw error
  }
}

// This is used to get a user by id
export const getUserById = async (id) => {
  try {
    const response = await api.get(`/Users/${id}`)
    return response.data
  } catch (error) {
    console.error('Error fetching user by id:', error)
    throw error
  }
}

// This is used to create a user
export const createUser = async (user) => {
  try {
    const response = await api.post('/Users', user)
    return response.data
  } catch (error) {
    console.error('Error creating user:', error)
    throw error
  }
}

// This is used to update a user
export const updateUser = async (id, user) => {
  try {
    const response = await api.put(`/Users/${id}`, user)
    return response.data
  } catch (error) {
    console.error('Error updating user:', error)
    throw error
  }
}

// This is used to delete a user
export const deleteUser = async (id) => {
  try {
    const response = await api.delete(`/Users/${id}`)
    return response.data
  } catch (error) {
    console.error('Error deleting user:', error)
    throw error
  }
}
