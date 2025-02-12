import { api, handleAxiosError } from '../api/apiClient'

export const fetchNotes = async () => {
  try {
    var response = await api.get('/Notes')

    return response.data
  } catch (error) {
    handleAxiosError(error)
    throw error
  }
}
