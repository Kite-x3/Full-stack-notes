import { useState, useEffect } from 'react'
import { Note } from '../../types/note'
import { Task } from '../task/Task'
import { fetchNotes } from '../../services/notes'
import classes from './TaskList.module.css'
import axios from 'axios'

export const TaskList = () => {
  const [notes, setNotes] = useState<Note[]>([])
  const [loading, setLoading] = useState(true)
  const [error, setError] = useState<string | null>(null)

  useEffect(() => {
    const fetchData = async () => {
      try {
        const notes = await fetchNotes()

        setNotes(notes)
      } catch (error) {
        setError(
          error instanceof Error
            ? error.message
            : axios.isAxiosError(error)
            ? error.message
            : 'неизвестная ошибка'
        )
      }
      setLoading(false)
    }
    fetchData()
  }, [])

  if (loading) {
    return <div className={classes.Error}>Loading...</div>
  }

  if (error) {
    return <div className={classes.Error}>Error: {error}</div>
  }

  return (
    <section className={classes.TaskList}>
      {notes.map((note, index) => (
        <Task key={index} title={note.title} text={note.text} />
      ))}
    </section>
  )
}
