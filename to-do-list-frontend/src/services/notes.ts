import { api, handleAxiosError } from '../api/apiClient'

export const fetchNotes = async () => {
  try {
    var response = await api.get('/Note')

    return response.data
  } catch (error) {
    handleAxiosError(error)
    throw error
  }
}
