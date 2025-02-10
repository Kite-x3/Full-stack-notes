import axios from 'axios'

export const api = axios.create({
  baseURL: 'https://localhost:7012',
  timeout: 5000,
})

export const handleAxiosError = (error: any) => {
  if (axios.isAxiosError(error)) {
    if (error.response) {
      console.error(
        `Ошибка API: ${error.response.status} - ${error.response.data}`
      )
    } else if (error.request) {
      console.error('Ошибка сети: сервер не отвечает.')
    } else {
      console.error('Неизвестная ошибка:', error.message)
    }
  } else {
    console.error('Непредвиденная ошибка:', error)
  }
}
