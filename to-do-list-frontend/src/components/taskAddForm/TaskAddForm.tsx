import classes from './TaskAddForm.module.css'

const handleSubmit = (e: React.FormEvent) => {
  e.preventDefault()
}

export const TaskAddForm = () => {
  return (
    <form className={classes.TaskAddForm} onSubmit={handleSubmit}>
      <div className={classes.Field}>
        <label htmlFor='Title'>Title</label>
        <input type='text' placeholder='Title' id='Title' name='Title' />
      </div>
      <div className={classes.Field}>
        <label htmlFor='Text'>Text</label>
        <input type='text' placeholder='Text' id='Text' name='Text' />
      </div>
      <button>Add</button>
    </form>
  )
}
