import React from 'react'
import { Link } from 'react-router-dom'
import logo from '../assets/possible-logo-removebg-preview.png'

const Navbar = () => {
  return (
    <div className='navbar'>
      <Link to="/">
        <img src={logo} alt="Go to Home Page" className="logo"/>
      </Link>

      <ul>
        <Link to="/login">
        <button class="buttonNavbar" role="button">Login</button>
        </Link>
        <Link to="/register">
        <button class="buttonNavbar" role="button">Register</button>
        </Link>
      </ul>
    </div>
  )
}

export default Navbar
