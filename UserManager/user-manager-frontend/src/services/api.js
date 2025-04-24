import axios from 'axios'

// This is used to make requests to the backend
const api = axios.create({
  baseURL: 'http://localhost:5279/api',
})

export default api
