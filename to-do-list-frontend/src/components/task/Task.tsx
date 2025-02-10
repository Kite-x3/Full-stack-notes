import classes from './Task.module.css'

export const Task = ({ title, text }: { title: string; text: string }) => {
  return (
    <div className={classes.Note}>
      <h2>{title}</h2>
      <p>{text}</p>
    </div>
  )
}
