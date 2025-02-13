import classes from './TaskAddForm.module.css'

const handleSubmit = (e: React.FormEvent) => {
  e.preventDefault()
}

export const TaskAddForm = () => {
  return (
    <form className={classes.TaskAddForm} onSubmit={handleSubmit}>
      <h2>Добавление новой заметки</h2>
      <div className={classes.Field}>
        <label htmlFor='Title'>Заголовок</label>
        <input type='text' placeholder='Заголовок' id='Title' name='Title' />
      </div>
      <div className={classes.Field}>
        <label htmlFor='Text'>Текст</label>
        <input type='text' placeholder='Текст' id='Text' name='Text' />
      </div>
      <button>Добавить</button>
    </form>
  )
}
