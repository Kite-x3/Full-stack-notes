import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
import { TasksPage } from './pages/TasksPage'
import { Header } from './components/header/Header'

function App() {
  return (
    <Router>
      <Header />
      <Routes>
        <Route path='/' element={<TasksPage />}></Route>
      </Routes>
    </Router>
  )
}

export default App
