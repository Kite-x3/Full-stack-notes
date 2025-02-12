import { TaskAddForm } from '../components/taskAddForm/TaskAddForm'
import { TaskList } from '../components/taskList/TaskList'

import classes from './TasksPage.module.css'

export const TasksPage = () => {
  return (
    <div className={classes.TasksPage}>
      <TaskAddForm></TaskAddForm>
      <TaskList></TaskList>
    </div>
  )
}
