import { NavLink } from 'react-router-dom'
import { Logo } from '../Logo/Logo'
import classes from './Header.module.css'

export const Header = () => {
  return (
    <header className={classes.Header}>
      <Logo className={classes.Logo} />
      <div className={classes.Navigation}>
        <NavLink to='/'>Главная</NavLink>
        <NavLink to='/'>Рекомендации</NavLink>
      </div>
      <div>Profile pic</div>
    </header>
  )
}
