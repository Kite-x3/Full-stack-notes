import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
import { TasksPage } from './pages/TasksPage'

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<TasksPage />}></Route>
      </Routes>
    </Router>
  )
}

export default App
