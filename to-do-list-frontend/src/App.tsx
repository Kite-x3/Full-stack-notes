import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
import { TaskList } from './components/taskList/TaskList'

function App() {
  return (
    <Router>
      <Routes>
        <Route path='/' element={<TaskList />}></Route>
      </Routes>
    </Router>
  )
}

export default App
